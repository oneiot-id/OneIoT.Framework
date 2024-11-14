namespace OneIoT.Framework.Graphic;

public class Color
{
    /// <summary>
    /// Color red in a material, value is from 0 - 1f
    /// </summary>
    public float Red { get; set; }
    /// <summary>
    /// Color green in a material, value is from 0 - 1f
    /// </summary>
    public float Green { get; set; }
    /// <summary>
    /// Color blue in a material, value is from 0 - 1f
    /// </summary>
    public float Blue{ get; set; }
    /// <summary>
    /// Alpha (transparency) in a material, value is from 0 - 1f
    /// </summary>
    public float Alpha { get; set; } = 1f;

    public Color(float red, float green, float blue, float alpha)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }
    public Color(float red, float green, float blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public Color(long hexValue)
    {
        Red = (hexValue & 0xFF0000) / 16711680f;
        Green = (hexValue & 0x00FF00) / 65280f;
        Blue = (hexValue & 0x0000FF) / 255f;
    }
    
    
}