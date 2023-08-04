using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;


namespace Oring
{
    public partial class Main_Form : Form
    {
        string status;
        ModbusClient _modbus = new ModbusClient();
        public Main_Form()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            status = "false";
            if(status == "false")
            {
                lblConnect.ForeColor = Color.Red;
                lblConnect.BackColor = Color.LightYellow;
            }
            if(status == "true")
            {
                lblConnect.ForeColor = Color.White;
                lblConnect.BackColor = Color.Blue;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                _modbus.IPAddress = Convert.ToString(txtIP.Text);
                _modbus.Port = Convert.ToInt32(txtPort.Text);
            }
            catch { return; }
            ModbusConnection _MC = new ModbusConnection(_modbus.IPAddress, _modbus.Port);
            Connection _connection = new Connection();
            _connection.ConnectionEQ(_MC, status);
      
            //string status = "false";
            //string IP = "";
            //int Port = 0;
            //try
            //{
            //    IP = Convert.ToString(txtIP.Text);
            //    Port = Convert.ToInt32(txtPort.Text);
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.ToString());
            //}

            //ModbusConnection Modbusconnection = new ModbusConnection(IP, Port);

            //Modbusconnection.Connection(status);



        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                _modbus.Disconnect();
            }
            catch(Exception ex)
            {
                return;
            }
        }
    }
}
