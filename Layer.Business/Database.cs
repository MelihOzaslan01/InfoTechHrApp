using Layers.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Business
{
    internal static class Database
    {
        public static DbInfoTechHrAppEntities Connection = new DbInfoTechHrAppEntities();
    }
}
