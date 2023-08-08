using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Business.Interfaces
{
    internal interface IDatabaseProcess
    {
        bool CheckDbConnection();
        void CheckDbConnection(bool AutoConnect);
        void DbConnect();
        void DbDisconnect();
    }
}
