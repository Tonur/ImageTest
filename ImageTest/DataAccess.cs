using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ImageTest
{
    class DataAccess
    {
        public static byte[] GetPhoto(int photoID)
        {
            if (!DoesPhotoExist(photoID))
            {
                return default(byte[]);
            }

            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "SELECT BLOBData FROM BLOBTest WHERE TestID = @photoID";
                    command.Parameters.AddWithValue("@photoID", photoID);
                    command.Connection = connection;
                    connection.Open();
                    return (byte[])command.ExecuteScalar();
                }
            }
        }

        internal static void UploadPhoto(string fileName, byte[] photo)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO BLOBTest (BLOBName, BLOBData) VALUES (@BLOBName, @BLOBData)";
                    command.Parameters.AddWithValue("@BLOBName", fileName);
                    command.Parameters.Add(GetImageSqlParameter("@BLOBData", photo));
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private static SqlParameter GetImageSqlParameter(string parameterName, byte[] photo)
        {
            SqlParameter retval = new SqlParameter(parameterName, System.Data.SqlDbType.Image)
            {
                Value = photo
            };
            return retval;
        }

        private static bool DoesPhotoExist(int photoID)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "IF EXISTS(SELECT * FROM BLOBTest WHERE TestID = @photoID) BEGIN SELECT 1 END ELSE SELECT 0";
                    command.Parameters.AddWithValue("@photoID", photoID);
                    command.Connection = connection;
                    connection.Open();
                    return (int)command.ExecuteScalar() == 1;
                }
            }
        }

        private static SqlConnection GetConnection()
        {
            return new SqlConnection(Properties.Settings.Default.SQLConnection);
        }
    }
}
