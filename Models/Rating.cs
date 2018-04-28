using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SportsStore.Models {

    public class Rating {
     
        public long RatingId { get; set; }
        public int Stars { get; set; }
        public Product Product { get; set; }
    }
}