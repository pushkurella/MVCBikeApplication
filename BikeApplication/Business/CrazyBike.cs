using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataAccess;

namespace Business
{
    public class CrazyBike
    {

        public static List<VehicleInformation> GetVehicleData()
        {
            VehicleInformation vehicleInfo = new VehicleInformation();
            var vehicleInfoList = new List<VehicleInformation>();
            DataSet dsGetVehiclesReport = new DataSet();

            //2nd Assignment
            dsGetVehiclesReport = DACrazyBike.GetVehicleInfoUsingDBWithConfig();

            if (dsGetVehiclesReport.Tables.Count > 0)
            {
                vehicleInfoList = dsGetVehiclesReport.Tables[0].AsEnumerable().Select(m => new VehicleInformation
                {
                    ModelName = Convert.ToString(m["ModelName"]),
                    ModelYear = Convert.ToString(m["ModelYear"]),
                    Price = Convert.ToString(m["Price"]),

                }).ToList();

            }

            //Build the Business Logic here based on the requirements from the client

            return vehicleInfoList;

        }


    }

}