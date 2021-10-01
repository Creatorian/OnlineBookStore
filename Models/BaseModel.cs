using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Models
{
    public class BaseModel
    {
        public BookViewModel BookViewModel { get; set; }
        public CategoryViewModel CategoryViewModel { get; set; }
        public PublisherViewModel PublisherViewModel { get; set; }
        public ShopCartViewModel ShopCartViewModel { get; set; }
    }
}
