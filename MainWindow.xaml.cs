using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Text.RegularExpressions;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LIBRARY
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        System.Windows.Threading.DispatcherTimer timer2 = new System.Windows.Threading.DispatcherTimer();
        void timer2_a(object sender, EventArgs e)
        {
            progressBar.Value += 10;
            if (progressBar.Value == 100)
            {
                timer2.Stop();
                new Window1().ShowDialog();
                this.Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer2.Interval = TimeSpan.FromMilliseconds(1000);
            timer2.Tick += new EventHandler(timer2_a);
            timer2.Start();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            timer2.Interval = TimeSpan.FromMilliseconds(1000);
            timer2.Tick += new EventHandler(timer2_a);
            timer2.Start();
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Label_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }
    }







    class Mojudi
    {
        public static bool card(string card)
        {
            // split digit and convert to int
            int[] digits = new int[card.Length];

            for (int i = 0; i < (int)card.Length; i++)
            {
                digits[i] = int.Parse(card[i].ToString());
            }

            /// calc sum of 0,2,4,6,... digits
            int sumodd = 0;
            for (int i = (int)card.Length - 1; i > 0; i -= 2)
            {


                sumodd += digits[i];
            }

            ////add sum of 1,3,5,7,... to last sum
            for (int i = (int)card.Length - 2; i >= 0; i -= 2)
            {

                // check bigger than 10
                if (2 * digits[i] >= 10)
                {
                    sumodd += 2 * digits[i] / 10 + 2 * digits[i] % 10;
                }
                else
                {
                    sumodd += 2 * digits[i];

                }

            }



            //check a multiple of 10
            if (sumodd % 10 == 0)
            {
                return true;

            }

            else
            {
                return false;
            }
        }



        public static bool datecard(string date_m, string date_d)
        {
            //calc now date time

            var now_date = DateTime.Now;


            //convert datecard_string to timestamp 
            var card_date = new DateTime(DateTime.Now.Year, int.Parse(date_m), int.Parse(date_d));


            //remin 3 month check
            if (Math.Abs((card_date - now_date).Days) < 90)
            {
                return false;

            }
            return true;

        }

        public static bool cvvv(string cvv)
        {
            // 3 or 4 digit
            foreach (var m in Regex.Matches(cvv, "^[0-9]{3,4}"))
            {

                if (m.ToString().Equals(cvv))
                {

                    return true;
                }
            }


            return false;


        }

        public static bool password(string password)
        {
            // contain atleast 1 A-Z and with lenth 8 ta 32 char
            foreach (var m in Regex.Matches(password, "^(?=.*[A-Z])[a-zA-Z]{8,32}"))
            {


                if (m.ToString().Equals(password))
                {

                    return true;
                }
            }


            return false;

        }



        public bool validity(string ShomareKart, string cvv, int enghezaYear, int EnghezaDay)
        {

            return true;
        }




        public bool AfzayeshMojudiBank(string ShomareKart, string cvv, int enghezaYear, int EnghezaDay, int mizaneafzayesh)
        {
            //Afzayesh Mojudi Bank Tavasot Modir

            //EtebarSanji
            if (card((ShomareKart).ToString()) == true && cvvv(cvv) == true && datecard(enghezaYear.ToString(), EnghezaDay.ToString()) == true)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlDataReader reader;
                String sql = "Select * from Manager";
                SqlCommand command = new SqlCommand(sql, con);
                reader = command.ExecuteReader();
                reader.Read(); int mojudifeli = Convert.ToInt32(reader.GetString(2));
                mojudifeli += mizaneafzayesh;
                String query = "Update Admin set balance='" + mojudifeli + "'where name=admin";
                command = new SqlCommand(query, con);
                adapter.UpdateCommand = new SqlCommand(query, con);
                adapter.UpdateCommand.ExecuteNonQuery();
                con.Close();
                return true;
            }
            return false;
        }

        public string mojudiBank()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            String query = "Select * from Manager";
            SqlDataReader read;
            SqlCommand cm = new SqlCommand(query, con);
            read = cm.ExecuteReader();
            while (read.Read())
            {
                if ("admin" == read.GetString(0))
                {
                    return read.GetString(2);
                }
            }
            return 120.ToString();


        }

        public double mojudiMember(string name)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
            String query = "Select * from Member";
            SqlDataReader read;
            SqlCommand cm = new SqlCommand(query, con);
            read = cm.ExecuteReader();
            while (read.Read())
            {
                if (name == read.GetString(0))
                {
                    return Convert.ToDouble(read.GetString(3));
                }
            }
            return 120;


        }

        public double MojudiKarmand(string name)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
            String query = "Select * from Admin";
            SqlDataReader read;
            SqlCommand cm = new SqlCommand(query, con);
            read = cm.ExecuteReader();
            while (read.Read())
            {
                if (name == read.GetString(0))
                {
                    return Convert.ToDouble(read.GetString(3));
                }
            }
            return 120;
        }

        public void PardakhtHoghugh()
        {
            //Hoghugh Dadan Modir Be karmand
            int sum = 0;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlDataReader dataReader;
            String sql = "Select * from  Admin";
            SqlCommand command = new SqlCommand(sql, con);     //sum hoghugh
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                sum += Convert.ToInt32(dataReader.GetValue(2).ToString());
            }

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
            sql = "Select name,password,balance from Manager";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            dataReader.Read();
            int Mojudi = Convert.ToInt32(dataReader.GetValue(2).ToString());
            if (Mojudi > sum)
            {
                Mojudi -= sum;
                String query = "Update Manager set balance='" + Mojudi + "'where name=admin ";
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
                    sql = "Update Admin set balance='" + i + "' where name='" + dataReader.GetValue(0).ToString();
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
            if (card((ShomareKart).ToString()) == true && cvvv(cvv) == true && datecard(enghezaYear.ToString(), EnghezaDay.ToString()) == true)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
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
                            String sql = "Update Member set balance='" + mojudi + "'where name='" + Name;
                            SqlCommand cm = new SqlCommand(sql, con);
                            SqlDataAdapter adapter = new SqlDataAdapter();
                            adapter.UpdateCommand = new SqlCommand(sql, con);
                            adapter.UpdateCommand.ExecuteNonQuery();
                            cm.Dispose();
                            con.Close();
                            return true;
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

        public bool AfzayeshMojudiMember(string Name, string ShomareKart, string cvv, int enghezaYear, int EnghezaDay, int meghdar)
        {
            if (card((ShomareKart).ToString()) == true && cvvv(cvv) == true && datecard(enghezaYear.ToString(), EnghezaDay.ToString()) == true)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
                String query = "Select * from Member";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if ((reader.GetString(0)) == Name)
                    {
                        int mojudi = reader.GetInt32(4);
                        mojudi += meghdar;
                        String sql = "Update Member set balance='" + mojudi + "'where name='" + Name;
                        SqlCommand cm = new SqlCommand(sql, con);
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.UpdateCommand = new SqlCommand(sql, con);
                        adapter.UpdateCommand.ExecuteNonQuery();
                        cm.Dispose();
                        con.Close();
                        return true;
                    }
                    else
                    {
                        return false;
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

            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
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
                    String D = "Update Book set number='" + F + "'where name='" + Name;
                    cm = new SqlCommand(D, sqlcon);
                    SqlDataAdapter Ad = new SqlDataAdapter();
                    Ad.UpdateCommand = new SqlCommand(D, sqlcon);
                    Ad.UpdateCommand.ExecuteNonQuery();
                    cm.Dispose(); Ad.Dispose(); sqlcon.Close();
                }
            }
            cm.Dispose(); read.Close();
            //age nabud
            if (flag == 0)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "Insert into Book (name , author , number , genre) values ('" + Name + "','" + nevisande + "','" + 1 + "','" + genre + "')";
                SqlCommand command = new SqlCommand(sql, sqlcon);
                adapter.InsertCommand = new SqlCommand(sql, sqlcon);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose(); sqlcon.Close();

            }

        }




        public void Amanat(string Nameketab, string NameF)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
            String sql = "Insert into Borrowed (namef , author , Book , genre,DateBorrowed) values ('" + Nameketab + "','" + nevisande + "','" + 1 + "','" + genre + NameF + "','" + DateTime.Now + "')";
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(sql, sqlcon);
            adapter.InsertCommand = new SqlCommand(sql, sqlcon);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose(); sqlcon.Close();
        }
    }




    class Sabtenam     //Hazfo Ezafe
    {
        public static bool phone(string phone)
        {
            /// start with 09 and 9 digit past
            foreach (var m in Regex.Matches(phone, "^09[0-9]{9}"))
            {


                if (m.ToString().Equals(phone))
                {

                    return true;
                }
            }


            return false;
        }
        //email
        public static bool email(string email)
        {
            // 1 ta 32 char from 0-9A-Za-z_- and then @ and then 1 ta 8 char  from 0-9A-Za-z and then . and then 1ta 3 char from a-zA-Z

            foreach (var m in Regex.Matches(email, @"^([0-9A-Za-z_-]){1,32}@([0-9A-Za-z]){1,8}\.[a-zA-Z]{1,3}"))
            {


                if (m.ToString().Equals(email))
                {

                    return true;
                }
            }


            return false;
        }


        //name
        public static bool namee(string name)
        {
            // 3 ta 32 char from A-Za-z 

            foreach (var m in Regex.Matches(name, "^[a-zA-Z]{3,32}"))
            {


                if (m.ToString().Equals(name))
                {

                    return true;
                }
            }


            return false;

        }


        string name, ramz, Shomare, Email; int mojudi;
        public void SabtManager(string nam, string Ramz)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            Console.WriteLine(name + "mohammmad " + ramz);
            string query = "Insert into Manager (name,password,balance) values('" + nam + "','" + Ramz + "','" + 0 + "')";
            SqlDataAdapter adap = new SqlDataAdapter();
            SqlCommand cm = new SqlCommand(query, con);
            try
            {
                adap.InsertCommand = new SqlCommand(query, con);
                adap.InsertCommand.ExecuteNonQuery();
                cm.Dispose(); con.Close();
            }
            catch
            {

            }


        }
        public void Sabtnamkarbar(string n, string r, string s, string E)
        {
            name = n; ramz = r; Shomare = s; Email = E;
            /////if EtebarSanji = True =>  
            //
            if (namee(n) == true && phone(s) == true && email(E) == true)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into User (name,password,phone,email,balance,subscription) values('" + name + "','" + ramz + "','" + Shomare + "','" + Email + "','" + mojudi + "','" + DateTime.Now + "')", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }


        public void SabteAdmin(string n, string r, float Hoghuugh)
        {
            name = n; ramz = r; float Hoghugh = Hoghuugh, Kifpul = 0;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Admin (name,password,Hoghugh,balance) values('" + name + "','" + ramz + "','" + Hoghugh + "','" + Kifpul + "')", con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void HazfAdmin(string Nam)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter();
            String query = "Delete Admin where name=" + Nam;
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

            SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
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

            SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
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
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
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
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
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
