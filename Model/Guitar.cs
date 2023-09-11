using System;

public class Guitar
{
    public string SerialNumber { get; set; }
    public double Price { get; set; }
    public GuitarSpecs Specs { get; set; }

    public Guitar(string serialNumber, double price, GuitarSpecs specs)
    {
        SerialNumber = serialNumber;
        Price = price;
        Specs = specs;
    }

    public GuitarSpecs GetSpecs()
    {
        return Specs;
    }
}
