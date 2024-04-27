using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public enum Rule { Manager,IT,Librarian,Customer}
    public class User
    {
        [Key]
       public string Username {  get; set; }
        public string Password {  get; set; }
        public Rule rule {  get; set; }
        public List<UserBook> Borrows { get; set; }
        public User() 
        {

        }


    }
}
