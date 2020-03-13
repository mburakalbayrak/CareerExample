//using Entities.Concrete;
//using Microsoft.Extensions.Logging;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccess.Concrete.EntitiyFramework.Context
//{
//    public class CareerContextSeed
//    {
//        /// <summary>
//        /// add mock data sql memory
//        /// </summary>
//        /// <param name="dbContext"></param>
//        /// <param name="loggerFactory"></param>
//        /// <param name="retry"></param>
//        /// <returns></returns>
//        public static async Task SeedAsync(CareerContext dbContext, ILoggerFactory loggerFactory, int? retry = 0)
//        {
//            int retryForAvailability = retry.Value;

//            try
//            {
//                // TODO: Only run this if using a real database
//                // dbContext.Database.Migrate();
//                dbContext.Database.EnsureCreated();

//                if (!dbContext.CareerSettings.Any())
//                {
//                    dbContext.CareerSettings.AddRange(GetPreconfiguredCareerSettings());
//                    await dbContext.SaveChangesAsync();
//                }
//            }
//            catch (Exception exception)
//            {
//                if (retryForAvailability < 10)
//                {
//                    retryForAvailability++;
//                    var log = loggerFactory.CreateLogger<CareerContextSeed>();
//                    log.LogError(exception.Message);
//                    await SeedAsync(dbContext, loggerFactory, retryForAvailability);
//                }
//                throw;
//            }
//        }

//        private static IEnumerable<CareerSetting> GetPreconfiguredCareerSettings()
//        {
//            return new List<CareerSetting>()
//            {
//                new CareerSetting() {  Name = "SiteName", Type = "string", IsActive = true, IsDeleted =false , Value ="boyner.com.tr" , ApplicationName = "SERVICE-A", InsertedDate = DateTime.Now },
//                new CareerSetting() {  Name = "IsBasketEnabled", Type = "bool", IsActive = true, IsDeleted =false , Value ="1" , ApplicationName = "SERVICE-B", InsertedDate = DateTime.Now },
//                new CareerSetting() {  Name = "MaxItemCount", Type = "int", IsActive = false, IsDeleted =true , Value ="50" , ApplicationName = "SERVICE-A", InsertedDate = DateTime.Now },
//            };
//        }
//    }
//}
