namespace RentalSystem.Models;

public class Laptop : Equipment
{
    private int _gpu;
    private int _ram;
    public int GPU
    {
        get { return _gpu; }
        set
        {
            if ( value < 0 || value > 32)
            {
                throw new ArgumentOutOfRangeException(paramName: nameof(GPU), message: "GPU must be between 0 and 32");
            }
            
            _gpu = value;
        }
    }

    public int RAM
    {
        get { return _ram; }
        set
        {
            if ( value < 0 || value > 32)
            {
                throw new ArgumentOutOfRangeException(paramName: nameof(RAM), message: "GPU must be between 0 and 32");
            }
            
            _ram = value;
        }
    }

    public Laptop(string name, bool isAvailable, decimal price, int gpu, int ram) : base(name, isAvailable, price)
    {
        GPU = gpu;
        RAM = ram;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, GPU: {GPU}, RAM: {RAM}";
    }
}