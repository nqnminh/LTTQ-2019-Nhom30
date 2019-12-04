using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMain.Class.Nam
{
    public class Connect_Hoadon
    {
        private static Connect_Hoadon instance;

        public static Connect_Hoadon Instance
        {
            get { return Connect_Hoadon.instance; }
            set { Connect_Hoadon.instance = value; }
        }
    }
}
