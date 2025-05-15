using System.ComponentModel.DataAnnotations;

namespace BookNest.Models;

public class Book
{
    public int BookID {get; set;}

    public string Title {get; set;} = string.Empty;
    public string Author {get; set;} = string.Empty;
    public string Description {get; set;} = string.Empty;
    public string ImageURL {get; set;} = string.Empty;
    public List<Review> Reviews {get; set;} = default!;
    [DataType(DataType.Currency)]
    public decimal Price {get; set;}

}