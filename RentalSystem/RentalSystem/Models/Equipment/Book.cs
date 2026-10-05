namespace RentalSystem.Models;

public class Book : Equipment
{
    private string _author;
    
    public int Page { get; set; }

    public string Author
    {
        get { return _author; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(message: "Author can not be empty", paramName: nameof(value));
            }
            _author = value;
        }
    }

    public Book(string name, bool isAvailable, decimal price, int page, string author):base(name, isAvailable, price)
    {
        Page = page;
        Author = author;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Page: {Page}, Author: {Author}";
    }
}