using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace Oring
{
    class Connection
    {
        public async void ConnectionEQ(ModbusConnection MC, string status)
        {
            ModbusClient _modbus = new ModbusClient();
            _modbus.IPAddress = MC.IPaddress;
            _modbus.Port = MC.Port;
            Task taskConnection = new Task(() =>
            {
                try
                {
                    _modbus.Connect();
                }
                catch (Exception ex)
                {
                    status = "false";
                    MessageBox.Show(ex.ToString());
                }
            });
            taskConnection.Start();
            await taskConnection;
            if (_modbus.Connected)
            {
                status = "true";
            }

        }
    }
}
