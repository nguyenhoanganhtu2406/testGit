using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;
using System.Linq;

namespace _4201104148_DB4O
{
    class Database
    {
        public static string DbFileName { get; set; }
        public static IObjectContainer DB
        {
            get { return Db4oEmbedded.OpenFile(DbFileName); }
        }
        public static List<Employee> GetEmployees()
        {
            List<Employee> result = new List<Employee>();
            IObjectContainer db = Db4oEmbedded.OpenFile(DbFileName);
            IEnumerable<Employee> query = from Employee emp in db select emp;
            result = query.ToList();
            db.Close();
            return result;
        }
        public static void Add(Employee emp)
        {
            IObjectContainer db = Db4oEmbedded.OpenFile(DbFileName);
            db.Store(emp);
            db.Close();
        }
        public static List<Company> GetCompanies()
        {
            List<Company> result = new List<Company>();
            IObjectContainer db = Db4oEmbedded.OpenFile(DbFileName);
            IEnumerable<Company> comps = from Company comp in db select comp;
            var query = comps.Where(p => p.)
            db.Close();
        }
    }
}
