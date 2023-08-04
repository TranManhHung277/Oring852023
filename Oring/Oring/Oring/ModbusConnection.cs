using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;
using System.Windows.Forms;


namespace Oring
{
    class ModbusConnection
    {
        string _IPaddress;
        int _port;
        
        public string IPaddress
        {
            get { return _IPaddress; }
            set { _IPaddress = value; }
        }
        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }
        public ModbusConnection(string IPaddress, int Port)
        {
            this.IPaddress = IPaddress;
            this.Port = Port;
        }
        

    }
}
