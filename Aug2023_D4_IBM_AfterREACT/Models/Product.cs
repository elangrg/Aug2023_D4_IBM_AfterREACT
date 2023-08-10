namespace Aug2023_D4_IBM_AfterREACT.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }


        public override string ToString()
        {
            return $"ProductID={this.ProductID}|Product Name={this.ProductName}|Category={this.Category}";

        }

    }
}
