using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace db_R6_product
{
    public partial class character : System.Web.UI.Page
    {
        string connectString = "";
        SqlConnection connection = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            connectString = "Data Source=ASUS-LAPTOP\\SQLEXPRESS;Initial Catalog=R6_product;Persist Security Info=True;User ID=r6;Password=r6";
            connection = new SqlConnection(connectString);

            string a = Request.QueryString["id"].ToString();

            if (a == "01")
            {
                String sql_01_1 = "select * from characters where name like 'Flores'";
                String sql_01_2 = "select * from introduction where Intro_name like 'Flores'";
                Image1.ImageUrl = "~/pic/01_flores.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_01_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_01_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "02")
            {
                String sql_02_1 = "select * from characters where name like 'Aruni'";
                String sql_02_2 = "select * from introduction where Intro_name like 'Aruni'";
                Image1.ImageUrl = "~/pic/02_aruni.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_02_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_02_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "03")
            {
                String sql_03_1 = "select * from characters where name like 'Zero'";
                String sql_03_2 = "select * from introduction where Intro_name like 'Zero'";
                Image1.ImageUrl = "~/pic/03_zero.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_03_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_03_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "04")
            {
                String sql_04_1 = "select * from characters where name like 'ace'";
                String sql_04_2 = "select * from introduction where Intro_name like 'ace'";
                Image1.ImageUrl = "~/pic/04_ace.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_04_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_04_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "05")
            {
                String sql_05_1 = "select * from characters where name like 'melusi'";
                String sql_05_2 = "select * from introduction where Intro_name like 'melusi'";
                Image1.ImageUrl = "~/pic/05_melusi.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_05_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_05_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "06")
            {
                String sql_06_1 = "select * from characters where name like 'oryx'";
                String sql_06_2 = "select * from introduction where Intro_name like 'oryx'";
                Image1.ImageUrl = "~/pic/06_oryx.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_06_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_06_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "07")
            {
                String sql_07_1 = "select * from characters where name like 'iana'";
                String sql_07_2 = "select * from introduction where Intro_name like 'iana'";
                Image1.ImageUrl = "~/pic/07_iana.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_07_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_07_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "08")
            {
                String sql_08_1 = "select * from characters where name like 'wamai'";
                String sql_08_2 = "select * from introduction where Intro_name like 'wamai'";
                Image1.ImageUrl = "~/pic/08_wamai.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_08_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_08_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "09")
            {
                String sql_09_1 = "select * from characters where name like 'kali'";
                String sql_09_2 = "select * from introduction where Intro_name like 'kali'";
                Image1.ImageUrl = "~/pic/09_kali.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_09_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_09_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "10")
            {
                String sql_10_1 = "select * from characters where name like 'amaru'";
                String sql_10_2 = "select * from introduction where Intro_name like 'amaru'";
                Image1.ImageUrl = "~/pic/10_amaru.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_10_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_10_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "11")
            {
                String sql_11_1 = "select * from characters where name like 'goyo'";
                String sql_11_2 = "select * from introduction where Intro_name like 'goyo'";
                Image1.ImageUrl = "~/pic/11_goyo.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_11_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_11_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "12")
            {
                String sql_12_1 = "select * from characters where name like 'nokk'";
                String sql_12_2 = "select * from introduction where Intro_name like 'nokk'";
                Image1.ImageUrl = "~/pic/12_nokk.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_12_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_12_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "13")
            {
                String sql_13_1 = "select * from characters where name like 'warden'";
                String sql_13_2 = "select * from introduction where Intro_name like 'warden'";
                Image1.ImageUrl = "~/pic/13_warden.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_13_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_13_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "14")
            {
                String sql_14_1 = "select * from characters where name like 'mozzie'";
                String sql_14_2 = "select * from introduction where Intro_name like 'mozzie'";
                Image1.ImageUrl = "~/pic/14_mozzie.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_14_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_14_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "15")
            {
                String sql_15_1 = "select * from characters where name like 'gridlock'";
                String sql_15_2 = "select * from introduction where Intro_name like 'gridlock'";
                Image1.ImageUrl = "~/pic/15_gridlock.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_15_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_15_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "16")
            {
                String sql_16_1 = "select * from characters where name like 'nomad'";
                String sql_16_2 = "select * from introduction where Intro_name like 'nomad'";
                Image1.ImageUrl = "~/pic/16_nomad.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_16_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_16_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "17")
            {
                String sql_17_1 = "select * from characters where name like 'kaid'";
                String sql_17_2 = "select * from introduction where Intro_name like 'kaid'";
                Image1.ImageUrl = "~/pic/17_kaid.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_17_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_17_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "18")
            {
                String sql_18_1 = "select * from characters where name like 'clash'";
                String sql_18_2 = "select * from introduction where Intro_name like 'clash'";
                Image1.ImageUrl = "~/pic/18_clash.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_18_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_18_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "19")
            {
                String sql_19_1 = "select * from characters where name like 'maverick'";
                String sql_19_2 = "select * from introduction where Intro_name like 'maverick'";
                Image1.ImageUrl = "~/pic/19_maverick.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_19_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_19_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "20")
            {
                String sql_20_1 = "select * from characters where name like 'maestro'";
                String sql_20_2 = "select * from introduction where Intro_name like 'maestro'";
                Image1.ImageUrl = "~/pic/20_maestro.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_20_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_20_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "21")
            {
                String sql_21_1 = "select * from characters where name like 'alibi'";
                String sql_21_2 = "select * from introduction where Intro_name like 'alibi'";
                Image1.ImageUrl = "~/pic/21_alibi.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_21_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_21_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "22")
            {
                String sql_22_1 = "select * from characters where name like 'finka'";
                String sql_22_2 = "select * from introduction where Intro_name like 'finka'";
                Image1.ImageUrl = "~/pic/22_finka.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_22_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_22_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "23")
            {
                String sql_23_1 = "select * from characters where name like 'lion'";
                String sql_23_2 = "select * from introduction where Intro_name like 'lion'";
                Image1.ImageUrl = "~/pic/23_lion.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_23_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_23_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "24")
            {
                String sql_24_1 = "select * from characters where name like 'vigil'";
                String sql_24_2 = "select * from introduction where Intro_name like 'vigil'";
                Image1.ImageUrl = "~/pic/24_vigil.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_24_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_24_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "25")
            {
                String sql_25_1 = "select * from characters where name like 'dokkaebi'";
                String sql_25_2 = "select * from introduction where Intro_name like 'dokkaebi'";
                Image1.ImageUrl = "~/pic/25_dokkaebi.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_25_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_25_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "26")
            {
                String sql_26_1 = "select * from characters where name like 'zofia'";
                String sql_26_2 = "select * from introduction where Intro_name like 'zofia'";
                Image1.ImageUrl = "~/pic/26_zofia.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_26_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_26_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "27")
            {
                String sql_27_1 = "select * from characters where name like 'ela'";
                String sql_27_2 = "select * from introduction where Intro_name like 'ela'";
                Image1.ImageUrl = "~/pic/27_ela.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_27_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_27_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "28")
            {
                String sql_28_1 = "select * from characters where name like 'ying'";
                String sql_28_2 = "select * from introduction where Intro_name like 'ying'";
                Image1.ImageUrl = "~/pic/28_ying.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_28_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_28_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "29")
            {
                String sql_29_1 = "select * from characters where name like 'lesion'";
                String sql_29_2 = "select * from introduction where Intro_name like 'lesion'";
                Image1.ImageUrl = "~/pic/29_lesion.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_29_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_29_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "30")
            {
                String sql_30_1 = "select * from characters where name like 'mira'";
                String sql_30_2 = "select * from introduction where Intro_name like 'mira'";
                Image1.ImageUrl = "~/pic/30_mira.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_30_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_30_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "31")
            {
                String sql_31_1 = "select * from characters where name like 'jackal'";
                String sql_31_2 = "select * from introduction where Intro_name like 'jackal'";
                Image1.ImageUrl = "~/pic/31_jackal.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_31_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_31_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "32")
            {
                String sql_32_1 = "select * from characters where name like 'hibana'";
                String sql_32_2 = "select * from introduction where Intro_name like 'hibana'";
                Image1.ImageUrl = "~/pic/32_hibana.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_32_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_32_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "33")
            {
                String sql_33_1 = "select * from characters where name like 'echo'";
                String sql_33_2 = "select * from introduction where Intro_name like 'echo'";
                Image1.ImageUrl = "~/pic/33_echo.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_33_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_33_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "34")
            {
                String sql_34_1 = "select * from characters where name like 'caveira'";
                String sql_34_2 = "select * from introduction where Intro_name like 'caveira'";
                Image1.ImageUrl = "~/pic/34_caveira.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_34_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_34_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "35")
            {
                String sql_35_1 = "select * from characters where name like 'capitao'";
                String sql_35_2 = "select * from introduction where Intro_name like 'capitao'";
                Image1.ImageUrl = "~/pic/35_capitao.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_35_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_35_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "36")
            {
                String sql_36_1 = "select * from characters where name like 'blackbeard'";
                String sql_36_2 = "select * from introduction where Intro_name like 'blackbeard'";
                Image1.ImageUrl = "~/pic/36_blackbeard.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_36_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_36_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "37")
            {
                String sql_37_1 = "select * from characters where name like 'valkyrie'";
                String sql_37_2 = "select * from introduction where Intro_name like 'valkyrie'";
                Image1.ImageUrl = "~/pic/37_valkyrie.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_37_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_37_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "38")
            {
                String sql_38_1 = "select * from characters where name like 'buck'";
                String sql_38_2 = "select * from introduction where Intro_name like 'buck'";
                Image1.ImageUrl = "~/pic/38_buck.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_38_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_38_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "39")
            {
                String sql_39_1 = "select * from characters where name like 'frost'";
                String sql_39_2 = "select * from introduction where Intro_name like 'frost'";
                Image1.ImageUrl = "~/pic/39_frost.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_39_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_39_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "40")
            {
                String sql_40_1 = "select * from characters where name like 'mute'";
                String sql_40_2 = "select * from introduction where Intro_name like 'mute'";
                Image1.ImageUrl = "~/pic/40_mute.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_40_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_40_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "41")
            {
                String sql_41_1 = "select * from characters where name like 'sledge'";
                String sql_41_2 = "select * from introduction where Intro_name like 'sledge'";
                Image1.ImageUrl = "~/pic/41_sledge.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_41_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_41_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "42")
            {
                String sql_42_1 = "select * from characters where name like 'smoke'";
                String sql_42_2 = "select * from introduction where Intro_name like 'smoke'";
                Image1.ImageUrl = "~/pic/42_smoke.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_42_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_42_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "43")
            {
                String sql_43_1 = "select * from characters where name like 'thatcher'";
                String sql_43_2 = "select * from introduction where Intro_name like 'thatcher'";
                Image1.ImageUrl = "~/pic/43_thatcher.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_43_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_43_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "44")
            {
                String sql_44_1 = "select * from characters where name like 'ash'";
                String sql_44_2 = "select * from introduction where Intro_name like 'ash'";
                Image1.ImageUrl = "~/pic/44_ash.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_44_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_44_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "45")
            {
                String sql_45_1 = "select * from characters where name like 'castle'";
                String sql_45_2 = "select * from introduction where Intro_name like 'castle'";
                Image1.ImageUrl = "~/pic/45_castle.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_45_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_45_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "46")
            {
                String sql_46_1 = "select * from characters where name like 'pulse'";
                String sql_46_2 = "select * from introduction where Intro_name like 'pulse'";
                Image1.ImageUrl = "~/pic/46_pulse.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_46_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_46_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "47")
            {
                String sql_47_1 = "select * from characters where name like 'thermite'";
                String sql_47_2 = "select * from introduction where Intro_name like 'thermite'";
                Image1.ImageUrl = "~/pic/47_thermite.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_47_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_47_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "48")
            {
                String sql_48_1 = "select * from characters where name like 'montagne'";
                String sql_48_2 = "select * from introduction where Intro_name like 'montagne'";
                Image1.ImageUrl = "~/pic/48_montagne.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_48_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_48_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "49")
            {
                String sql_49_1 = "select * from characters where name like 'twitch'";
                String sql_49_2 = "select * from introduction where Intro_name like 'twitch'";
                Image1.ImageUrl = "~/pic/49_twitch.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_49_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_49_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "50")
            {
                String sql_50_1 = "select * from characters where name like 'doc'";
                String sql_50_2 = "select * from introduction where Intro_name like 'doc'";
                Image1.ImageUrl = "~/pic/50_doc.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_50_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_50_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "51")
            {
                String sql_51_1 = "select * from characters where name like 'rook'";
                String sql_51_2 = "select * from introduction where Intro_name like 'rook'";
                Image1.ImageUrl = "~/pic/51_rook.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_51_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_51_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "52")
            {
                String sql_52_1 = "select * from characters where name like 'jager'";
                String sql_52_2 = "select * from introduction where Intro_name like 'jager'";
                Image1.ImageUrl = "~/pic/52_jager.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_52_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_52_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "53")
            {
                String sql_53_1 = "select * from characters where name like 'bandit'";
                String sql_53_2 = "select * from introduction where Intro_name like 'bandit'";
                Image1.ImageUrl = "~/pic/53_bandit.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_53_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_53_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "54")
            {
                String sql_54_1 = "select * from characters where name like 'blitz'";
                String sql_54_2 = "select * from introduction where Intro_name like 'blitz'";
                Image1.ImageUrl = "~/pic/54_blitz.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_54_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_54_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "55")
            {
                String sql_55_1 = "select * from characters where name like 'iq'";
                String sql_55_2 = "select * from introduction where Intro_name like 'iq'";
                Image1.ImageUrl = "~/pic/55_iq.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_55_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_55_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "56")
            {
                String sql_56_1 = "select * from characters where name like 'fuze'";
                String sql_56_2 = "select * from introduction where Intro_name like 'fuze'";
                Image1.ImageUrl = "~/pic/56_fuze.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_56_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_56_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "57")
            {
                String sql_57_1 = "select * from characters where name like 'glaz'";
                String sql_57_2 = "select * from introduction where Intro_name like 'glaz'";
                Image1.ImageUrl = "~/pic/57_glaz.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_57_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_57_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "58")
            {
                String sql_58_1 = "select * from characters where name like 'tachanka'";
                String sql_58_2 = "select * from introduction where Intro_name like 'tachanka'";
                Image1.ImageUrl = "~/pic/58_tachanka.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_58_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_58_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }

            else if (a == "59")
            {
                String sql_59_1 = "select * from characters where name like 'kapkan'";
                String sql_59_2 = "select * from introduction where Intro_name like 'kapkan'";
                Image1.ImageUrl = "~/pic/59_kapkan.png";
                Labe_01.Text = ""; Labe_02.Text = ""; Labe_03.Text = ""; Labe_07.Text = "";
                Labe_04.Text = ""; Labe_05.Text = ""; Labe_06.Text = ""; Labe_08.Text = "";
                try
                {
                    // 01
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql_59_1, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Labe_01.Text += dataReader.GetValue(0); Labe_04.Text += dataReader.GetValue(3);
                        Labe_02.Text += dataReader.GetValue(1); Labe_05.Text += dataReader.GetValue(4);
                        Labe_03.Text += dataReader.GetValue(2); Labe_06.Text += dataReader.GetValue(5);
                    }
                    dataReader.Close(); command.Dispose(); connection.Close();
                    // 02
                    connection.Open();
                    SqlCommand command_2 = new SqlCommand(sql_59_2, connection);
                    SqlDataReader dataReader_2 = command_2.ExecuteReader();
                    while (dataReader_2.Read())
                    {
                        Labe_07.Text += dataReader_2.GetValue(1); Labe_08.Text += dataReader_2.GetValue(2);
                    }
                    dataReader_2.Close(); command_2.Dispose(); connection.Close();
                }
                catch (Exception ex)
                {
                    Labe_01.Text = ex.ToString(); Labe_02.Text = ex.ToString(); Labe_03.Text = ex.ToString(); Labe_04.Text = ex.ToString();
                    Labe_05.Text = ex.ToString(); Labe_06.Text = ex.ToString(); Labe_07.Text = ex.ToString(); Labe_08.Text = ex.ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}