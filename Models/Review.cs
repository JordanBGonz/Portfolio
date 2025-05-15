using System.ComponentModel.DataAnnotations;

namespace BookNest.Models;

public class Review
{
    public int ReviewID {get;set;}

    [Range(1,5)]
     public int Score {get; set; }
     public string ReviewText {get; set;} = string.Empty;

     public int BookID {get; set;}
     public Book? Book {get; set;} = default!;
}