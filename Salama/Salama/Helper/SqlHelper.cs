using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Salama.Models;
using Salama.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Linq;

namespace Salama.Helper
{
    public static class SqlHelper
    {

        public static async Task<Setup> GetSetupData(IConfiguration _IConfiguration)
        {
            string connectionString = _IConfiguration["AppSettings:DbConnection"].ToString();
            Setup items = new Setup() ;

            using var connection = new SqlConnection(connectionString);

            var query = $@"select * from  SetUpTbl; select * from  SetUpDetailTbl;";

            var command = new SqlCommand(query, connection);

            try
            {
                await connection.OpenAsync();
                command.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();

                da.Fill(ds);

                await connection.CloseAsync();

                items = await GetSetUpList(ds);
                return items;
            }
            catch(Exception ex)
            {
                if (connection.State != ConnectionState.Closed)
                {
                    await connection.CloseAsync();
                }
                return null;
            }

        }

        private static async Task<Setup> GetSetUpList(DataSet ds)
        {
            if (ds.Tables.Count < 2 && ds.Tables.Count !=2) return null;
            else
            {
                Setup setup = new Setup();

                var SetUpList = ds.Tables[0].AsEnumerable().Select(r => new SetUpTbl
                {
                    Name = r.Field<string>("Name"),
                    Id = r.Field<int>("Id"),
                    IsActive = r.Field<bool>("IsActive"),
                }).ToList();

                var SetUpDetailList = ds.Tables[1].AsEnumerable().Select(r => new SetUpDetailTbl
                {
                    Name = r.Field<string>("Name"),
                    Id = r.Field<int>("Id"),
                    SetupId = r.Field<int>("SetupId"),
                    IsActive = r.Field<bool>("IsActive"),
                }).ToList();


                var CarMakeList = SetUpDetailList.Where(x => x.SetupId == (int)SetupEnums.CarMake && x.IsActive == true).Select(
                    carmake => new CarMake
                    {
                        Id = carmake.Id,
                        IsActive = carmake.IsActive,
                        Name = carmake.Name,
                        SetupId = carmake.SetupId
                    }
                    ).ToList();

                setup.CarMakeList.AddRange(CarMakeList);


                var CarModelList = SetUpDetailList.Where(x => x.SetupId == (int)SetupEnums.CarModel && x.IsActive == true).Select(
                    carmake => new CarModel
                    {
                        Id = carmake.Id,
                        IsActive = carmake.IsActive,
                        Name = carmake.Name,
                        SetupId = carmake.SetupId
                    }
                    ).ToList();

                setup.CarModelList.AddRange(CarModelList);


                var CarBodyTypeList = SetUpDetailList.Where(x => x.SetupId == (int)SetupEnums.CarBodyType && x.IsActive == true).Select(
                                         carmake => new CarBodyType
                                         {
                                             Id = carmake.Id,
                                             IsActive = carmake.IsActive,
                                             Name = carmake.Name,
                                             SetupId = carmake.SetupId
                                         }
                                         ).ToList();

                setup.CarBodyTypeList.AddRange(CarBodyTypeList);

                var TrimList = SetUpDetailList.Where(x => x.SetupId == (int)SetupEnums.Trim && x.IsActive == true).Select(
                carmake => new Trim
                {
                    Id = carmake.Id,
                    IsActive = carmake.IsActive,
                    Name = carmake.Name,
                    SetupId = carmake.SetupId
                }
                ).ToList();

                setup.TrimList.AddRange(TrimList);

                return setup;
            }
           
        }
    }
}
