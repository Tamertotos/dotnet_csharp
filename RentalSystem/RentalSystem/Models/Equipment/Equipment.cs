namespace RentalSystem.Models;

public abstract class Equipment
{
    private static int _nextId = 1;
    private string _name;
    private decimal _price;
    
    public int Id { get; }
    public bool IsAvailable { get; set; }
    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(message: "Equipment name cannot be null.", paramName: nameof(value));
            }
            
            
            _name = char.ToUpper(value[0]) +  value.Substring(1).ToLower();
        }
    }

    public decimal Price
    {
        get { return _price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(paramName: nameof(value),message: "Price cannot be negative.");
            }
            _price = value; 
        }
    }
    
    public Equipment(string name, bool isAvailable, decimal price)
    {
        Price = price;
        IsAvailable = isAvailable;
        Name = name;
        Id = _nextId++;
    }

    public override string ToString()
    {
        return $"Name: {Name}, IsAvailable: {IsAvailable}, Price: {Price}";
    }
}