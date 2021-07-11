using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Navigation;


namespace WpfApp3
{
    class Mojudi
    {
        public bool validity(string ShomareKart, string cvv, int enghezaYear, int EnghezaDay)
        {

            return true;
        }
        public void AfzayeshMojudiBank(string ShomareKart, string cvv, int enghezaYear, int EnghezaDay, int mizaneafzayesh)
        {
            //Afzayesh Mojudi Bank Tavasot Modir

            //EtebarSanji
            if (validity(ShomareKart, cvv, enghezaYear, EnghezaDay) == true)
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB);Initial Catalog=Data;User ID=sa;Password=wintellect");
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlDataReader reader;
                String sql = "Select Mojudi where Name=admin";
                SqlCommand command = new SqlCommand(sql, con);
                reader = command.ExecuteReader();
                reader.Read(); int mojudifeli = Convert.ToInt32(reader.GetValue(0).ToString());
                mojudifeli += mizaneafzayesh;
                String query = "Update Admin set Mojudi='" + mojudifeli + "'where Name=admin ";
                command = new SqlCommand(query, con);
                adapter.UpdateCommand = new SqlCommand(query, con);
                adapter.UpdateCommand.ExecuteNonQuery();
                con.Close();
            }
        }



        public void PardakhtHoghugh()
        {
            //Hoghugh Dadan Modir Be karmand
            int sum = 0;
            SqlConnection con = new SqlConnection("Data Source=(LocalDB);Initial Catalog=Admin;User ID=sa;Password=wintellect");
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlDataReader dataReader;
            String sql = "Select * from  Admin";
            SqlCommand command = new SqlCommand(sql, con);     //sum hoghugh
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                sum += Convert.ToInt32(dataReader.GetValue(2).ToString());
            }

            con = new SqlConnection("Data Source = (LocalDB); Initial Catalog = Manager; User ID = sa; Password = wintellect");
            sql = "Select Name,Ramz,Mojudi from Manager";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            dataReader.Read();
            int Mojudi = Convert.ToInt32(dataReader.GetValue(2).ToString());
            if (Mojudi > sum)
            {
                Mojudi -= sum;
                String query = "Update Manager set Mojudi='" + Mojudi + "'where Name=admin ";
                SqlCommand ccommand = new SqlCommand(query, con);
                adapter.UpdateCommand = new SqlCommand(query, con);             //Kahesh Mojudi Bank
                adapter.UpdateCommand.ExecuteNonQuery();


                query = "Select * from Admin";
                ccommand = new SqlCommand(query, con);
                dataReader = command.ExecuteReader();
                int i;
                while (dataReader.Read())                               //Afzayesh Kif pule Admin
                {
                    i = Convert.ToInt32(dataReader.GetValue(1).ToString()) + Convert.ToInt32(dataReader.GetValue(2).ToString());
                    sql = "Update Admin set Mojudi='" + i + "' where Name='" + dataReader.GetValue(0).ToString();
                }

                con.Close();

            }
            else
            {
                string Error = "Mojudi Bank Kafi nist";
            }



        }


        public bool PardakhtEshterak(string ShomareKart, string cvv, int enghezaYear, int EnghezaDay, string Name)
        {
            if (validity(ShomareKart, cvv, enghezaYear, EnghezaDay) == true)
            {
                SqlConnection con = new SqlConnection("Data Source = (LocalDB); Initial Catalog = Admin; User ID = sa; Password = wintellect");
                String query = "Select * from Member";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if ((reader.GetString(0)) == Name)
                    {
                        int mojudi = reader.GetInt32(4);
                        if (mojudi > 400)
                        {
                            mojudi -= 400;
                            String sql = "Update Member set Mojudi='" + mojudi + "'where Name='" + Name;
                            SqlCommand cm = new SqlCommand(sql, con);
                            SqlDataAdapter adapter = new SqlDataAdapter();
                            adapter.UpdateCommand = new SqlCommand(sql, con);
                            adapter.UpdateCommand.ExecuteNonQuery();
                            cm.Dispose();
                            con.Close();
                            return true;
                            break;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

            }
            return false;
        }
    }

    class Addbook
    {
        string Name, nevisande, genre;
        public void AddBook(string n, string author, string genre1)
        {
            Name = n; nevisande = author; genre = genre1;
            //Check Mojud Budan
            int flag = 0;

            SqlConnection sqlcon = new SqlConnection("Data Source=(LocalDB);Initial Catalog=Book;User ID=sa;Password=wintellect");
            SqlDataReader read;
            String Red = "Select * from Book";
            SqlCommand cm = new SqlCommand(Red, sqlcon);
            read = cm.ExecuteReader();
            while (read.Read())
            {
                if (read.GetString(0) == Name && read.GetString(1) == author && read.GetString(3) == genre)
                {
                    flag = 1;
                    int F = int.Parse(read.GetString(2)) + 1;
                    String D = "Update Book set Tedad='" + F + "'where Name='" + Name;
                    cm = new SqlCommand(D, sqlcon);
                    SqlDataAdapter Ad = new SqlDataAdapter();
                    Ad.UpdateCommand = new SqlCommand(D, sqlcon);
                    Ad.UpdateCommand.ExecuteNonQuery();
                    cm.Dispose(); Ad.Dispose(); sqlcon.Close();
                }
            }
            cm.Dispose(); read.Close();
            if (flag == 0)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "Insert into (LocalDB) (Name , nevisande , Tedad , genre) values ('" + Name + "','" + nevisande + "','" + 1 + "','" + genre + "')";
                SqlCommand command = new SqlCommand(sql, sqlcon);
                adapter.InsertCommand = new SqlCommand(sql, sqlcon);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose(); sqlcon.Close();

            }

        }




        public void Amanat(string Nameketab, string NameF)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=(LocalDB);Initial Catalog=BorrowedBook;User ID=sa;Password=wintellect");
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "Insert into Amanat (Name , nevisande , Tedad , genre,NameFard) values ('" + Nameketab + "','" + nevisande + "','" + 1 + "','" + genre + NameF + "','" + "')";
            SqlCommand command = new SqlCommand(sql, sqlcon);
            adapter.InsertCommand = new SqlCommand(sql, sqlcon);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose(); sqlcon.Close();
        }
    }




    class Sabtenam     //Hazfo Ezafe
    {
        string name, ramz, Shomare, Email; int mojudi; DateTime Zamanesabtenam = DateTime.Now;
        public void SabtManager(string nam, string Ramz)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB);Initial Catalog=Data;User ID=sa;Password=wintellect");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Registration (Name,Ramz,MojudiBank) values('" + name + "','" + ramz + "','" + 0 + "')", con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }
        public void Sabtnamkarbar(string n, string r, string s, string E)
        {
            name = n; ramz = r; Shomare = s; Email = E;
            /////if EtebarSanji = True =>  
            //
            SqlConnection con = new SqlConnection("Data Source=(LocalDB);Initial Catalog=Data;User ID=sa;Password=wintellect");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Registration (Name,Ramz,Shomare,Email,Mojudi,zamansabtnam) values('" + name + "','" + ramz + "','" + Shomare + "','" + Email + "','" + mojudi + "','" + Zamanesabtenam + "')", con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();


        }
        public void HazfKarbar()
        {

        }

        public void SabteAdmin(string n, string r, float Hoghuugh)
        {
            name = n; ramz = r; float Hoghugh = Hoghuugh, Kifpul = 0;
            SqlConnection con = new SqlConnection("Data Source=(LocalDB);Initial Catalog=Data;User ID=sa;Password=wintellect");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Admin (Name,Ramz,Hoghugh,Kif Pul) values('" + name + "','" + ramz + "','" + Hoghugh + "','" + Kifpul + "')", con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void HazfAdmin(string Nam)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB);Initial Catalog=Data;User ID=sa;Password=wintellect");
            con.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter();
            String query = "Delete Admin where Name=" + Nam;
            SqlCommand command = new SqlCommand(query, con);
            dataadapter.DeleteCommand = new SqlCommand(query, con);
            dataadapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose(); con.Close();
        }
    }
    class Login
    {
        string name, ramz;

        public bool LogMember(string n, string r)
        {
            name = n; ramz = r;

            SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost\sqle2012; Initial Catalog=Member; Integrated Security=True;");
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlDataReader read;
                String query = "SELECT * FROM Member";
                SqlCommand Cmd = new SqlCommand(query, sqlCon);
                read = Cmd.ExecuteReader();
                while (read.Read())
                {
                    if (read.GetString(0) == name && read.GetString(1) == r)
                    {
                        Cmd.Dispose();
                        read.Close();

                        sqlCon.Close();
                        return true;
                    }
                }
                Cmd.Dispose();
                read.Close();

                sqlCon.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlCon.Close();
                return false;
            }
        }

        public bool LogAdmin(string n, string r)
        {
            name = n; ramz = r;

            SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost\sqle2012; Initial Catalog=Admin; Integrated Security=True;");
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlDataReader read;
                String query = "SELECT * FROM Admin";
                SqlCommand Cmd = new SqlCommand(query, sqlCon);
                read = Cmd.ExecuteReader();
                while (read.Read())
                {
                    if (read.GetString(0) == name && read.GetString(1) == r)
                    {
                        Cmd.Dispose();
                        read.Close();

                        sqlCon.Close();
                        return true;
                    }
                }
                Cmd.Dispose();
                read.Close();

                sqlCon.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlCon.Close();
                return false;
            }
        }

        public bool LogManager(string n, string r)
        {
            name = n; ramz = r;
            if (name == "admin" && ramz == "Admin123")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

    class Manager
    {
        Mojudi mojudi = new Mojudi();
        public void AfzudaneKarmand(string n, string r, float D)
        {
            Sabtenam sbt = new Sabtenam();
            sbt.SabteAdmin(n, r, D);
        }

        public void HazfeKarmand(string nam)
        {

        }

        public void varizeHoghugh()
        {
            mojudi.PardakhtHoghugh();
        }

        public double MojudiBank()
        {
            SqlConnection con = new SqlConnection("Data Source = (LocalDB); Initial Catalog = Manager; User ID = sa; Password = wintellect");
            String query = "Select * from Manager";
            SqlCommand cm = new SqlCommand(query, con);
            SqlDataReader reader;
            reader = cm.ExecuteReader();
            reader.Read();
            double e = Convert.ToDouble(reader.GetInt32(2));
            reader.Close();
            cm.Dispose();
            con.Close();
            return e;
        }


        public void AfzayeshMojudi(string ShomareKart, string cvv, int enghezaYear, int EnghezaDay, int Meghdar)
        {
            mojudi.AfzayeshMojudiBank(ShomareKart, cvv, enghezaYear, EnghezaDay, Meghdar);
        }


        public void AfzudaneKetab(string n, string author, string genre1)
        {
            int tedad = 1;
        }
    }



    class Admin                 //ADMIN
    {

        public double KifePul(string Name)
        {
            SqlConnection con = new SqlConnection();
            double e = 0;
            String query = "Select * from Admin";
            SqlCommand cm = new SqlCommand(query, con);
            SqlDataReader reader;
            reader = cm.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0) == Name)
                {
                    e = Convert.ToDouble(reader.GetString(3));
                    break;
                }
            }
            reader.Close();
            cm.Dispose();
            con.Close();
            return e;
        }

    }


    class Member   //karaye karbar
    {



        public double KifePul(string Name)
        {
            SqlConnection con = new SqlConnection("Data Source = (LocalDB); Initial Catalog = Manager; User ID = sa; Password = wintellect");
            double e = 0;
            String query = "Select * from Member";
            SqlCommand cm = new SqlCommand(query, con);
            SqlDataReader reader;
            reader = cm.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0) == Name)
                {
                    e = Convert.ToDouble(reader.GetString(4));
                    break;
                }
            }
            reader.Close();
            cm.Dispose();
            con.Close();
            return e;
        }



    }

}


