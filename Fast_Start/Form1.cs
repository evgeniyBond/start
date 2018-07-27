using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Start
{
    public partial class Form1 : Form
    {
        string conString = @"Data Source=DEXP\MISQLEXPRESS;Initial Catalog=sportsmen;Integrated Security = true";
        SqlConnection connection;

        Pad cl = new Pad();
        Sportsmen spmn = new Sportsmen("Иван", "Иванов", 185, 75, "левая", 1.02f, 0.12f, 1, 760);

        const double g = 9.8;  // ускорение свободного падения
        int n1, n3;   // номер таблицы 

        public Form1()
        {
            InitializeComponent();
            tabControl1.SelectedIndex = 0;
            Connect_db();
            SelectData_Sportsmen();  // Данные спортсмена вывести на экран
            SelectData_Pad();   // Данные параметров колодок вывести на экран
        }

        public void Connect_db()
        {
            connection = new SqlConnection(conString);
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Соединение с базой данных не установлено", e.Message);
                return;
            }
            finally
            {
                MessageBox.Show("Подключение к БД . . .", "Попытка соединиться с базой данных");

            }
        }

        public void SelectData_Sportsmen()
        {
            //connection.Open();
            string sql = "SELECT * FROM sportsmen_data";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[7]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();

            }

            reader.Close();
            connection.Close();
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        public void SelectData_Pad()
        {

            connection.Open();
            string sql1 = "SELECT alfa1,dist_pad FROM sportsmen_data";
            SqlCommand command1 = new SqlCommand(sql1, connection);
            SqlDataReader reader1 = command1.ExecuteReader();
            List<string[]> data1 = new List<string[]>();
            while (reader1.Read())
            {
                data1.Add(new string[2]);
                data1[data1.Count - 1][0] = reader1[0].ToString();
                data1[data1.Count - 1][1] = reader1[1].ToString();               
            }

            reader1.Close();
            connection.Close();
            foreach (string[] s1 in data1)
                dataGridView3.Rows.Add(s1);
        }

        // Заполнить поля значениями из конструктора
        public void Print_data()
        {
            // Данные спортсмена           
            txbRost.Text = spmn.height_man.ToString();        // рост
            //txbVes.Text = spmn.weight.ToString();           // вес
            if (spmn.supporting_leg == "левая")               // опорная нога
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

            // Данные колодки           
            txbBetweenPlastin.Text = (cl.distanse).ToString();            
        }



        private void btnOpen_Click(object sender, EventArgs e)
        {
            Sportsmen.Items.Add(spmn.name + " " + spmn.surname);  // Имя и Фамилия в списке
            Print_data();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Sportsmen.Items.Add(textBox1.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Sportsmen.Items.RemoveAt(Sportsmen.SelectedIndex);
        }

        

        // Методы для вычисления 

        // 1 Начальная скорость
        public string start_speed(double k11, double k22, double k33)
        {
            double k1 = (((double)1.0 / 70) * k11) - 2.0;
            double k2 = (((double)1.0 / 70) * k22) - 0.5;
            double k3 = (((double)1.0 / 60) * k33) - 12.0;

            double V_0 = ((1 + (k1 - k2 + k3)) / 3) * Convert.ToDouble(Math.Sqrt(10));
            return Convert.ToString(Math.Round(V_0,3));
        }

        //2 синус двойного аргумента 
        public string Sin2a(double V_0, double S)
        {
            double v0 = V_0;             
            double sin2a = (v0 * v0) / (g * S);            

            string alfa1 = sin2a.ToString();
            double alf = Convert.ToDouble(alfa1);
            string a = Convert.ToString((Math.Asin(alf) * 180 / Math.PI) / 2);

            return Convert.ToString(Math.Round(Convert.ToDouble(a),0));
        }

        //3 Время отрыва ноги от колодки 
        public string time(double S, double V_0,  double sin2a)
        {
            double t;            
                t = Convert.ToDouble(S / (V_0 * (Math.Sqrt(Math.Abs(0.5 - (Math.Sqrt(Math.Abs(1 - (sin2a * sin2a))) / 2))))));                          
               return Convert.ToString(Math.Round(t, 3));
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            for (int i = 0; (i < dataGridView1.Rows.Count - 1) && (i < dataGridView3.Rows.Count - 1); i++)
            {
                string sql = "INSERT INTO sportsmen_data(name, surname, hight, distance, time, speed, pressure, alfa1, dist_pad) VALUES (@name, @surname, @hight, @distance, @time, @speed, @pressure, @alfa1, @dist_pad)";
                SqlCommand cmd_SQL = new SqlCommand(sql, connection);

                cmd_SQL.Parameters.Add(new SqlParameter ("@name", dataGridView1.Rows[i].Cells[0].Value));
                cmd_SQL.Parameters.Add(new SqlParameter("@surname", dataGridView1.Rows[i].Cells[1].Value));
                cmd_SQL.Parameters.Add(new SqlParameter("@hight", dataGridView1.Rows[i].Cells[2].Value));
                cmd_SQL.Parameters.Add(new SqlParameter("@distance", dataGridView1.Rows[i].Cells[3].Value));
                cmd_SQL.Parameters.Add(new SqlParameter("@time", dataGridView1.Rows[i].Cells[4].Value));
                cmd_SQL.Parameters.Add(new SqlParameter("@speed", dataGridView1.Rows[i].Cells[5].Value));
                cmd_SQL.Parameters.Add(new SqlParameter("@pressure", dataGridView1.Rows[i].Cells[6].Value));

                cmd_SQL.Parameters.Add(new SqlParameter("@alfa1", dataGridView3.Rows[i].Cells[0].Value));                
                cmd_SQL.Parameters.Add(new SqlParameter("@dist_pad", dataGridView3.Rows[i].Cells[1].Value));

                try
                {
                    connection.Open();
                    int n = cmd_SQL.ExecuteNonQuery();
                    label4.Text += String.Format("Добавлено {0} записей", n);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnMatMod_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

            n1 = dataGridView1.Rows.Add();           

            
            dataGridView1.Rows[n1].Cells[0].Value = spmn.name;
            dataGridView1.Rows[n1].Cells[1].Value = spmn.surname;
            dataGridView1.Rows[n1].Cells[2].Value = txbRost.Text;
            dataGridView1.Rows[n1].Cells[3].Value = txbDist_m.Text;
            
            dataGridView1.Rows[n1].Cells[6].Value = txbpres.Text;
            

            n3 = dataGridView3.Rows.Add();
                     
            dataGridView3.Rows[n3].Cells[1].Value = txbBetweenPlastin.Text;  // Расстояние между колодками

            dataGridView1.Rows[n1].Cells[5].Value = start_speed(Convert.ToDouble(dataGridView1.Rows[n1].Cells[2].Value), Convert.ToDouble(dataGridView3.Rows[n3].Cells[1].Value), Convert.ToDouble(dataGridView1.Rows[n1].Cells[6].Value));  // скорость
            dataGridView3.Rows[n3].Cells[0].Value = Sin2a(Convert.ToDouble(dataGridView1.Rows[n1].Cells[5].Value), Convert.ToDouble(dataGridView1.Rows[n1].Cells[3].Value));     // Угол наклона  
            dataGridView1.Rows[n1].Cells[4].Value = time(Convert.ToDouble(dataGridView1.Rows[n1].Cells[3].Value), Convert.ToDouble(dataGridView1.Rows[n1].Cells[5].Value), Convert.ToDouble(dataGridView3.Rows[n3].Cells[0].Value));  // время
        }

    }
}
