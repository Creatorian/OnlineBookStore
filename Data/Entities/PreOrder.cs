using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Data.Entities
{
    public class PreOrder
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        [StringLength(400)]
        public string BookTitle { get; set; }
        [StringLength(400)]
        public string BookAuthor { get; set; }
        [StringLength(400)]
        public string BookCountry { get; set; }
        [StringLength(400)]
        public string BookPublisher { get; set; }
        [StringLength(400)]
        public string BookCategory { get; set; }
        [StringLength(400)]
        public string BookType { get; set; }
        [StringLength(400)]
        public string BookDimensions { get; set; }
        [StringLength(400)]
        public string BookWeight { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public DateTime RequiredDate { get; set; }
    }
}
