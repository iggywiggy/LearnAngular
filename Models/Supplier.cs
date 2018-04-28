using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SportsStore.Models {
    public class Supplier {
        public long SupplierId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}