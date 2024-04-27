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
        [Key,Column(Order =1)]
        public string UserId { get; set; }
        [Key,Column(Order =2)]
        public int BookId {  get; set; }
        public DateTime DateOfBorrowing { get; set; }
        public bool IsReturned {  get; set; }
        public UserBook() 
        {
            DateOfBorrowing = DateTime.Now;
            IsReturned = false;
        }
        public Book book { get; set; }
        public User User { get; set; }

    }
}
