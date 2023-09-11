using System;

public enum Builder
{
    Fender,
    Gibson,
    Martin,
    Taylor,
    PRS
}

public enum Type
{
    Acoustic,
    Electric
}

public enum BackWood
{
    Mahogany,
    Maple,
    Rosewood,
    Alder
}

public enum TopWood
{
    Spruce,
    Cedar,
    Mahogany,
    Maple
}

public class GuitarSpecs
{
    public Builder GuitarBuilder { get; set; }
    public string Model { get; set; }
    public Type GuitarType { get; set; }
    public BackWood BackWood { get; set; }
    public TopWood TopWood { get; set; }

    public Builder GetBuilder()
    {
        return GuitarBuilder;
    }

    public string GetModel()
    {
        return Model;
    }

    public Type GetType()
    {
        return GuitarType;
    }

    public BackWood GetBackwood()
    {
        return BackWood;
    }

    public TopWood GetTopwood()
    {
        return TopWood;
    }
}
