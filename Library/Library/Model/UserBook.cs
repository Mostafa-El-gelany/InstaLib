using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class UserBook
    {
        public int ID { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        
        [ForeignKey("book")]
        public long BookId {  get; set; }
        
        public DateTime DateOfBorrowing { get; set; }
        public bool IsReturned {  get; set; }
        public UserBook() 
        {
            DateOfBorrowing = DateTime.Now;
            IsReturned = false;
        }
        
        public virtual Book book { get; set; }
       
        public virtual User User { get; set; }
        public override string ToString()
        {
            return "username is " + User.Username + " book name is " + book.Title;
        }

    }
}
