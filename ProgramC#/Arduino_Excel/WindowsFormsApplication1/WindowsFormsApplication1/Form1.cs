using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        string wartosc, wartosc2;
       
        public Form1()
        {
            InitializeComponent();
            textBoxPomiarPierwszy.Text = "-";
            textBoxPomiarDrugi.Text = "-";
        }
        public static string strPolacz = "server=localhost;user=root;database=mydb;DefaultTableCacheAge=30;charset=utf8";

        private void buttonStartPomiar_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            buttonStartPomiar.Enabled = false;
            buttonStopPomiar.Enabled = true;
           
        }

        private void buttonStopPomiar_Click(object sender, EventArgs e)
        {
           
            serialPort1.Close();
            buttonStartPomiar.Enabled = true;
            buttonStopPomiar.Enabled = false;
            buttonStartZapisPomiarPierwszy.Enabled = true;
            buttonStartZapisPomiarDrugi.Enabled = true;
            textBoxPomiarPierwszy.Text = "-";
            textBoxPomiarDrugi.Text = "-";
                }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            serialPort1.Close();
            MySqlConnection polaczenie = new MySqlConnection();
            polaczenie = new MySqlConnection(strPolacz);
            polaczenie.Close();
        }
        private void wyswietl_dane_z_com(object sender, EventArgs e)
        {
            textBoxPomiarPierwszy.Text = wartosc;
            textBoxPomiarDrugi.Text = wartosc2 +" C";

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            string DataFromArduino = serialPort1.ReadLine().ToString();
            String[] dataSensor1Sensor2 = DataFromArduino.Split(',');
            wartosc = dataSensor1Sensor2[0];
            wartosc2 = dataSensor1Sensor2[1];

            if (buttonStartZapisPomiarPierwszy.Enabled == false)
            {

                DateTime time = DateTime.Now;
                string format = "yyyy-MM-dd HH:mm:ss";
                MySqlConnection polaczenie = new MySqlConnection();
                polaczenie = new MySqlConnection(strPolacz);
                MySqlCommand command = polaczenie.CreateCommand();
                command.CommandText = "INSERT INTO Pomiar(Wartosc,Czas,Servo_idServo) VALUES(" + "'" + wartosc + "','" + time.ToString(format) + "',1)";
                polaczenie.Open();
                command.ExecuteNonQuery();

            }
            
            if (buttonStartZapisPomiarDrugi.Enabled == false)
            {

                DateTime time = DateTime.Now;              // Use current time
                string format = "yyyy-MM-dd HH:mm:ss";
                MySqlConnection polaczenie = new MySqlConnection();
                polaczenie = new MySqlConnection(strPolacz);
                MySqlCommand command = polaczenie.CreateCommand();
                command.CommandText = "INSERT INTO Pomiar(Wartosc,Czas,Servo_idServo) VALUES(" + "'" + wartosc2 + "','" + time.ToString(format) + "',2)";
                polaczenie.Open();
                command.ExecuteNonQuery();
            }

            this.Invoke(new EventHandler(wyswietl_dane_z_com));
        }

     

        private void buttonStopZapisPomiarPierwszy_Click(object sender, EventArgs e)
        {
            buttonStartZapisPomiarPierwszy.Enabled = true;
            MySqlConnection polaczenie = new MySqlConnection();
            polaczenie = new MySqlConnection(strPolacz);
            polaczenie.Close();
        
        }


        private void buttonStopZapisPomiarDrugi_Click(object sender, EventArgs e)
        {
            buttonStartZapisPomiarDrugi.Enabled = true;
            MySqlConnection polaczenie = new MySqlConnection();
            polaczenie = new MySqlConnection(strPolacz);
            polaczenie.Close();
        }

        private void buttonStartZapisPomiarPierwszy_Click(object sender, EventArgs e)
        {
            buttonStartZapisPomiarPierwszy.Enabled = false;
        }

        private void buttonStartZapisPomiarDrugi_Click(object sender, EventArgs e)
        {
            buttonStartZapisPomiarDrugi.Enabled = false;
        }

  
    }
}
