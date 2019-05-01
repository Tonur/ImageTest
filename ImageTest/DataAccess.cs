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
        public static byte[] GetPhoto(int caseNr)
        {
            if (!DoesPhotoExist(caseNr))
            {
                return default(byte[]);
            }

            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "SELECT dataOfFile FROM files WHERE caseNr = @caseNr";
                    command.Parameters.AddWithValue("@caseNr", caseNr);
                    command.Connection = connection;
                    connection.Open();
                    return (byte[])command.ExecuteScalar();
                }
            }
        }

        internal static void UploadPhoto(int caseID, string fileName, string extention, byte[] photo)
        {

            string[] fileNames =  fileName.Split('.');

            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO files VALUES (@caseNr, @nameOfFile, @extOfFile, @dataOfFile)";
                    command.Parameters.AddWithValue("@caseNr", caseID);
                    command.Parameters.AddWithValue("@nameOfFile", fileNames[0]);
                    command.Parameters.AddWithValue("@extOfFile", extention);
                    command.Parameters.Add(GetImageSqlParameter("@dataOfFile", photo));
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

        private static bool DoesPhotoExist(int caseNr)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "IF EXISTS(SELECT * FROM files WHERE caseNr = @caseNr) BEGIN SELECT 1 END ELSE SELECT 0";
                    command.Parameters.AddWithValue("@caseNr", caseNr);
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
