using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.Data;


namespace Layer.Business.System    //namespacesimizi anasa spaceden ayirdik
{
    public class SysDepartment
    {
        static DbInfoTechHrAppEntities Contex = new DbInfoTechHrAppEntities();

        public bool AddDepartment(string DepartmentName)
        {
            bool Result = false;
            SysDepartman DepartmanBilgisi = new SysDepartman();
            DepartmanBilgisi.DepartmanAdi = DepartmentName;
            Contex.SysDepartman.Add(DepartmanBilgisi);
            Contex.SaveChanges();
            return Result;
        }
    }


    public class SysSection
    {

    }

    public class SysScholl
    {


    }
}
