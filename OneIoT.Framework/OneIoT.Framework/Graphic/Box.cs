namespace OneIoT.Framework.Graphic;

public class Box : Shape, IVisual
{
    public Transform Transform { get; set; }
    public Color Color { get; set; }

    public Box(Window parent, Transform? transform = null) : base(parent, transform)
    {
        
    }
    
}