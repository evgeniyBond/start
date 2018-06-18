using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel1 = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;


namespace Fast_Start
{
    public partial class StartData : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DEXP\MISQLEXPRESS;Initial Catalog=sportsmen;Integrated Security = true");

        Colodka cl = new Colodka();
        Person person = new Person("Иван", "Иванов", 185, 75, "левая", 1.907, 0.106, 2, 760);

        const double g = 9.8;
        int n, n1, n2;

        public StartData()
        {
            InitializeComponent();
            SelectData_Sportsmen();
           
            SelectData_Pad();
        }

        #region Дата тренировки       
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            // Установка даты, когда происходит тренировка
            label7.Text = "Тренировка состоится: ";
            lblDate.Text = String.Format(dateTimePicker1.Text);
        }

        private void btnTrening_Click_1(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "ddd, dd MMM, yyyy";
            dateTimePicker1.Focus();
            SendKeys.Send("{F4}");
        }

        private void StartData_Load(object sender, EventArgs e)
        {
            label7.Text = "Сегодня:";
            lblDate.Text = String.Format(dateTimePicker1.Text);
            toolTip1.SetToolTip(txbBetweenPlastin, "Введите число от 35 до 105");
            toolTip1.SetToolTip(txbRost, "Введите число от 140 до 210");
            toolTip1.SetToolTip(txbpres, "Введите число от 720 до 780");


        }
        #endregion


        // 1 Начальная скорость
        public string start_speed(double r, double dis, double davlen)
        {
            double kk1 = r;
            double kk2 = dis;
            double kk3 = davlen;

            double k1 = (((double)1.0 / 70) * kk1) - 2.0;
            double k2 = (((double)1.0 / 70) * kk2) - 0.5;
            double k3 = (((double)1.0 / 60) * kk3) - 12.0;

            double V_0 = ((1 + (k1 - k2 + k3)) / 3) * Convert.ToDouble(Math.Sqrt(10));
            return Convert.ToString(V_0);
        }

        //2 синус двойного аргумента 
        public string Sin2a(double V_0)
        {
            double v0 = V_0;
            double temp = g * Convert.ToDouble(txbDist_m.Text);
            double sin2a = v0 * v0 / temp;
            return Convert.ToString(sin2a);
        }

        //3 Время отрыва ноги от колодки 
        public string time(double V_0, double D, double sin2a)
        {
            double v0 = V_0;
            double L = D;
            double alfa = sin2a;
            double t = (double)(L / v0 * (Math.Sqrt(0.5 - (double)(Math.Sqrt(1 - alfa * alfa) / 2))));
            return Convert.ToString(t);
        }

        // Вычисление данных
        private void btnMatMod_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

            n = dataGridView1.Rows.Add();
            //n1 = dataGridView2.Rows.Add();
            n2 = dataGridView3.Rows.Add();
            
            
            dataGridView1.Rows[n].Cells[0].Value = person.name;
            dataGridView1.Rows[n].Cells[1].Value = person.surname;
            dataGridView1.Rows[n].Cells[2].Value = txbRost.Text;
            dataGridView1.Rows[n].Cells[3].Value = txbDist_m.Text;
            dataGridView1.Rows[n].Cells[4].Value = time(Convert.ToDouble(dataGridView1.Rows[n].Cells[5].Value), Convert.ToDouble(txbDist_m.Text), alf);
            dataGridView1.Rows[n].Cells[5].Value = start_speed(Convert.ToDouble(txbRost.Text), Convert.ToDouble(txbBetweenPlastin.Text), Convert.ToDouble(txbpres.Text));
            dataGridView1.Rows[n2].Cells[6].Value = txbpres.Text;
            
            //dataGridView3.Rows[n2].Cells[1].Value = Sin2a(Convert.ToDouble(dataGridView2.Rows[n1].Cells[2].Value));
            double alf = Convert.ToDouble(dataGridView3.Rows[n2].Cells[1].Value);
            dataGridView1.Rows[n2].Cells[8].Value = Convert.ToString((Math.Asin(alf) * 180 / Math.PI) / 2);
            dataGridView1.Rows[n2].Cells[9].Value = txbBetweenPlastin.Text;

            string Sq = Square();
        }

        public void Print_data()
        {
            // Данные спортсмена           
            txbRost.Text = person.height_man.ToString();        // рост
            //txbVes.Text = person.weight.ToString();             // вес
            if (person.supporting_leg == "левая")                // опорная нога
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

            // Данные колодки
            txbLenghCol.Text = cl.lenght.ToString();
            txbWidthCol.Text = cl.width.ToString();
            txbStep.Text = cl.step.ToString();
            txbBetweenPlastin.Text = (cl.distanse).ToString();
            txbAlfa1.Text = cl.alfa1.ToString() + " °";
            txbAlfa2.Text = cl.alfa2.ToString() + " °";
        }
        public string Square()
        {
            // Расчет площади колодки
            double lenght = Convert.ToDouble(txbLenghCol.Text) / 100;
            double width = Convert.ToDouble(txbWidthCol.Text) / 100;
            double Square = lenght * width;
            return Convert.ToString(Square);
        }

        #region 1. Считаем силу        
        // Вес = сила тяжести
        public string weight_and_Ft(double m, double a)
        {
            double F;
            F = m * a;
            return Convert.ToString(F);
        }
        #endregion
        #region 2. Считаем мощность
        public string powerful(double F, double v, double alfa1)
        {
            double N = F * v * Math.Cos(alfa1);

            return Convert.ToString(N);
        }
        #endregion             
        #region 4. Считаем давление
        // Давление
        public string p(double F, double S)
        {
            double p = F / S;
            return Convert.ToString(p);
        }
        #endregion        
        #region 5. Работа
        public string FindWork(double arg1, double arg2)
        {
            // Сила
            double m = arg1;
            double F = m * g;
            double S = arg2;    // дистанция в километрах
            S = S / 1000;
            double A;
            A = F * S;
            return Convert.ToString(A);
        }
        #endregion
        #region 6. Скорость
        //public string Speed(double a)
        //{
        //    double V = V0 + a * t;
        //    return Convert.ToString(V);
        //}
        #endregion

        private void txbRost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double height_man = Convert.ToInt32(txbRost.Text);    // дистанция в километрах

                height_man = height_man / 100;
                txbRost1.Text = height_man.ToString();
            }
            catch (FormatException ex)
            {
                txbRost1.Text = "" + ex.Message;
            }
        }




        private void btnComback_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            Sportsmen.Items.RemoveAt(Sportsmen.SelectedIndex);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Sportsmen.Items.Add(textBox1.Text);
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Sportsmen.Items.Add(person.name + " " + person.surname);  // Имя и Фамилия в списке
            Print_data();
        }

        #region Excel
        public void Add_data_in_Excel()
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = ExcelApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            //Таблица.

            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Тренировки";
            ExcelApp.Columns.ColumnWidth = 22;


            //Selection.Font.Bold = True
            //ActiveWindow.ScrollColumn = 2
            //ActiveWindow.ScrollColumn = 3
            //ActiveWindow.ScrollColumn = 4
            //ActiveWindow.ScrollColumn = 5
            //ActiveWindow.ScrollColumn = 6
            //ActiveWindow.ScrollColumn = 7
            //ActiveWindow.ScrollColumn = 8
            //ActiveWindow.ScrollColumn = 9
            //ActiveWindow.ScrollColumn = 8
            //ActiveWindow.ScrollColumn = 9
            //Columns("O:O").ColumnWidth = 34.14
            //Columns("N:N").ColumnWidth = 30.57
            //Columns("N:N").ColumnWidth = 39
            //Columns("M:M").ColumnWidth = 31.57
            //Columns("L:L").ColumnWidth = 28.86
            //Columns("L:L").ColumnWidth = 40.14
            //Columns("K:K").ColumnWidth = 36
            //Columns("K:K").ColumnWidth = 41.86
            //ActiveWindow.ScrollColumn = 8

            //worksheet.Cells[1, 1] = "Дата тренировки";
            //worksheet.Cells[1, 2] = "Имя";
            //worksheet.Cells[1, 3] = "Фамилия";
            //worksheet.Cells[1, 4] = "Рост";
            //worksheet.Cells[1, 5] = "Вес";
            //worksheet.Cells[1, 6] = "Ускорение";
            //worksheet.Cells[1, 7] = "Сила";
            //worksheet.Cells[1, 8] = "Пройденный путь";
            //worksheet.Cells[1, 9] = "Время";
            //worksheet.Cells[1, 10] = "Скорость";
            //worksheet.Cells[1, 11] = "Давление";
            //worksheet.Cells[1, 12] = "Расстояние от старта до первой колодки";
            //worksheet.Cells[1, 13] = "Расстояние от старта до второй колодки";
            //worksheet.Cells[1, 14] = "Расстояние между колодками";
            //worksheet.Cells[1, 15] = "Угол для первой колодки";
            //worksheet.Cells[1, 16] = "Угол для второй колодки";

            // Таблица 1
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;

            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                }
            }

            //// Таблица 2
            //for (int k = 1; k < dataGridView2.Columns.Count + 1; k++)
            //{
            //    worksheet.Cells[1, k + 5] = dataGridView2.Columns[k - 1].HeaderText;
            //}

            //for (int k = 0; k < dataGridView2.Rows.Count; k++)
            //{
            //    for (int l = 0; l < dataGridView2.Columns.Count; l++)
            //    {
            //        worksheet.Cells[k + 2, l + 6] = dataGridView2.Rows[k].Cells[l].Value.ToString();

            //    }
            //}

            // Таблица 3
            for (int n = 1; n < dataGridView3.Columns.Count + 1; n++)
            {
                worksheet.Cells[1, n + 9] = dataGridView3.Columns[n - 1].HeaderText;
            }

            for (int n = 0; n < dataGridView3.Rows.Count; n++)
            {
                for (int m = 0; m < dataGridView3.Columns.Count; m++)
                {
                    worksheet.Cells[n + 2, m + 10] = dataGridView3.Rows[n].Cells[m].Value.ToString();

                }
            }


            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_data_in_Excel();
        }





        
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO sportsmen_data(name, surname, hight, distance, time, speed, pressure, alfa1, alfa2, wayBetweenPad) 
                  VALUES( '" + dataGridView1.Rows[i].Cells[0].Value + "', '" + dataGridView1.Rows[i].Cells[1].Value + "', '" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "', '" + dataGridView1.Rows[i].Cells[4].Value + "', '" + dataGridView1.Rows[i].Cells[5].Value + "' + '" + dataGridView1.Rows[i].Cells[6].Value + "', '" + dataGridView1.Rows[n2].Cells[7].Value + "', '" + dataGridView1.Rows[n2].Cells[8].Value + "' + '" + dataGridView1.Rows[n2].Cells[9].Value + "')", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

            }           
        }

        public void SelectData_Sportsmen()
        {
            connection.Open();
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

            //connection.Open();
            //string sql1 = "SELECT * FROM pad";
            //SqlCommand command1 = new SqlCommand(sql1, connection);
            //SqlDataReader reader1 = command1.ExecuteReader();
            //List<string[]> data1 = new List<string[]>();
            //while (reader1.Read())
            //{
            //    data1.Add(new string[3]);
            //    data1[data1.Count - 1][0] = reader1[0].ToString();
            //    data1[data1.Count - 1][1] = reader1[1].ToString();
            //    data1[data1.Count - 1][2] = reader1[2].ToString();                
            //}

            //reader1.Close();
            //connection.Close();
            //foreach (string[] s1 in data1)
            //    dataGridView3.Rows.Add(s1);
        }

    }

    
    
}


  

