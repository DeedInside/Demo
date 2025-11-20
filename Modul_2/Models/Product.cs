namespace Modul_2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public NameProduct Name { get; set; }
        /// <summary>
        /// единица измерения
        /// </summary>
        public UnitProduct Unit { get; set; }
        public double Price { get; set; } = 0.0;
        /// <summary>
        /// поставщик
        /// </summary>
        public Supplier Supplier { get; set; }
        /// <summary>
        /// Производитель
        /// </summary>
        public Manufacturer Manufacturer { get; set; }
        public СategoryProduct Сategory { get; set; }
        public int Discount { get; set; } = 0;
        public int Count { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        public string ImagePath { get; set; } = @"../Images/Dafaults/picture.png";
        public override string ToString()
        {
            return $"{Id} - {Name} - {Price}";
        }
    }
}
