namespace MilkyProject.WebUI.Dtos.Product
{
    public class CreateProductDto
    {
            public string name { get; set; }
            public int oldPrice { get; set; }
            public int newPrice { get; set; }
            public string imageUrl { get; set; }
            public bool status { get; set; }
    }
}
