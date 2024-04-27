using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Context :DbContext
    {
        public Context():base("")
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
