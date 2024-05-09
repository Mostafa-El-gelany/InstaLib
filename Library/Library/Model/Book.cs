using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key,Required]
        // 13 digit number
        [Range(1000000000000, 9999999999999)]
        
        public long ISBN { get; set; }
        public string Title { get; set; }
        public string author {  get; set; }
        public string Publisher {  get; set; }
        [Range(0,1e5,ErrorMessage ="books can't be more than 100000 book")]
        public int quantity { get; set; }
        public virtual ICollection<UserBook> Borrows { get; set; }
        
        public Book()
        {
            quantity = 0;
        }
        

    }
}
