
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DACrazyBike
    {

        //Get the demographics from database but get the connection string details from web.Config file
        public static DataSet GetVehicleInfoUsingDBWithConfig()
        {
            SqlConnection cnn;
            string sql = null;
            SqlCommand command;
            SqlDataReader dataReader;

            DataTable dt = new DataTable();
            DataSet dsGetVehicleInfoReport = new DataSet();

            var cs = ConfigurationManager.ConnectionStrings["CrazyBikeConnection_DEV"].ConnectionString;
            cnn = new SqlConnection(cs);
            sql = "Select * from Vehicle_Info";

            //Open the connection
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            dt.Load(dataReader);
            dsGetVehicleInfoReport.Tables.Add(dt);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            return dsGetVehicleInfoReport;
        }

    }
}

