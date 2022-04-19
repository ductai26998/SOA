using System.ComponentModel.DataAnnotations;

namespace warehouseApp.Mvc.Models
{
    public class Product
    {
        public Product()
        {
            this.ImportDate = DateTime.Now;
            this.Name = string.Empty;
        }

        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ImportDate { get; set; }

        [MaxLength(256)]
        public string Name { get; set; }

        public int Quantity { get; set; }
        public int SoldQuantity { get; set; }
    }
}