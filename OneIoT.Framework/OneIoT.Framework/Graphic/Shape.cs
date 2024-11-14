namespace OneIoT.Framework.Graphic;

public class Shape : IDrawable
{
    public VisualElement Parent;
    private Transform? _transform;

    private float[] _vertices = Array.Empty<float>();
    
    public Shape(Window parent, Transform? transform = null)
    {
        this.Parent = parent;
        this._transform = transform;
    }
    
}