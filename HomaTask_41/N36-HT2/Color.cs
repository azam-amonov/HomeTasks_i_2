namespace HomaTask_41.N36_HT2;

public struct Color
{
    public bool Red { get; set; }
    public bool Blue { get; set; }
    public bool Green { get; set; }

    public Color(bool red, bool blue, bool green)
    {
        Red = red;
        Blue = blue;
        Green = green;
    }
}