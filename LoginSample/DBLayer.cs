using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LoginSample
{
    public class DBLayer
    {
        public int GetUserCountByUserNameAndPassWord(string userName, string passWord)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["xxxx"].ConnectionString;
            SqlParameter param;
            int count = 0;//either 0 or 1. 1 if user exists
            string sqlCmd = "";
            
            sqlCmd = "select count(id)as num from table where username=@un and password=@pw";
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlCmd, conn);
                cmd.CommandType = CommandType.Text;

                param = new SqlParameter("@un", SqlDbType.NVarChar);
                param.Value = userName;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@pw", SqlDbType.NVarChar);
                param.Value = passWord;
                cmd.Parameters.Add(param);

                count = (int)cmd.ExecuteScalar();
                conn.Close();
                return count;
            }
        }

        public void UpdateArlyText(string text)
        {
            SqlParameter param;
            var connectionString = ConfigurationManager.ConnectionStrings["ConnCms"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE TextTable set ArlyText=@text where id=1", conn);
                cmd.CommandType = CommandType.Text;

                //params here
                param = new SqlParameter("@text", SqlDbType.NVarChar);
                param.Value = text;
                cmd.Parameters.Add(param);

                cmd.ExecuteReader();
                conn.Close();
            }
        }

        public string GetArlyText()
        {
            string text = "";
            var connectionString = ConfigurationManager.ConnectionStrings["ConnCms"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT ArlyText from TextTable where id=1", conn);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    text=reader.GetString(0);
                }

                conn.Close();
                return text;
            }
        }
    }
}




//USE[your db]
//GO

///****** Object:  Table [dbo].[TextTable]    Script Date: 06.03.2023 10:20:13 ******/
//SET ANSI_NULLS ON
//GO

//SET QUOTED_IDENTIFIER ON
//GO

//CREATE TABLE [dbo].[TextTable] (

//    [Id][int] NOT NULL,

//    [ArlyText] [nvarchar] (max)NOT NULL,
//	[TrineText][nvarchar] (max)NOT NULL,
//	[ArlyOverskrift][nvarchar] (max)NOT NULL,
//	[TrineOverskrift][nvarchar] (max)NOT NULL,
// CONSTRAINT[PK_TextTable] PRIMARY KEY CLUSTERED 
//(

//    [Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
//GO