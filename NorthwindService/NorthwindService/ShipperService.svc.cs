using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace NorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShipperService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ShipperService.svc or ShipperService.svc.cs at the Solution Explorer and start debugging.
    public class ShipperService : IShipperService
    {

        public Shipper GetShipperByID(int id)
        {
            var theShipper = new Shipper();
            var connectionString = ConfigurationManager.ConnectionStrings["NORTHWND"].ConnectionString;
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var sqlShipperCommand = new SqlCommand("SELECT * FROM Shippers WHERE ShipperID = @id", conn);
                sqlShipperCommand.Parameters.AddWithValue("@id", id);

                using (var reader = sqlShipperCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        theShipper.ShipperID = (int)reader["ShipperID"];
                        theShipper.CompanyName = reader["CompanyName"].ToString();
                        theShipper.Phone = reader["Phone"].ToString(); 
                    }
                }
                conn.Close();
            }
            return theShipper;
        }

        public void SaveShipper(int id, string companyName, string phone)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["NORTHWND"].ConnectionString;
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var saveCmd =
                    new SqlCommand(
                        "UPDATE Shippers SET CompanyName = @companyName, Phone = @phone WHERE ShipperID = @id", conn);
                saveCmd.Parameters.AddWithValue("@id", id);
                saveCmd.Parameters.AddWithValue("@companyName", companyName);
                saveCmd.Parameters.AddWithValue("@phone", phone);

                saveCmd.ExecuteNonQuery();
            }
        }
    }
}