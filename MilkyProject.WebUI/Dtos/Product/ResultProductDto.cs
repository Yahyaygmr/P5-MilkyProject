namespace MilkyProject.WebUI.Dtos.Product
{
    public class ResultProductDto
    {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public decimal OldPrice { get; set; }
            public decimal NewPrice { get; set; }
            public string ImageUrl { get; set; }
            public bool Status { get; set; }

    }
}
