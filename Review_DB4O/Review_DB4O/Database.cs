using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db4objects.Db4o;
using System.Linq;
using Db4objects.Db4o.Linq;

namespace Review_DB4O
{
    class Database
    {
        public static string DbFileName { get; set; }
        public static List<Pilot> GetList()
        {
            IObjectContainer db = Db4oEmbedded.OpenFile(DbFileName);
            IEnumerable<Pilot> query = from Pilot p in db select p;
            List<Pilot> result = query.ToList();
            db.Close();
            return result;
        }
        public static void Add(Pilot p)
        {
            IObjectContainer db = Db4oEmbedded.OpenFile(DbFileName);
            db.Store(p);
            db.Close();
        }
    }
}
