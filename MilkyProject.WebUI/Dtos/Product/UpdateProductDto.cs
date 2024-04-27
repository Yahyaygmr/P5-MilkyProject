namespace MilkyProject.WebUI.Dtos.Product
{
    public class UpdateProductDto
    {
        public int productId { get; set; }
        public string name { get; set; }
        public decimal oldPrice { get; set; }
        public decimal newPrice { get; set; }
        public string imageUrl { get; set; }
        public bool status { get; set; }
    }
}
