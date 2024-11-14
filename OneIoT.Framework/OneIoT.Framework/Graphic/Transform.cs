using System.Numerics;

namespace OneIoT.Framework.Graphic;

public class Transform
{
    public Vector3 Position { get; set; }

    public Quaternion Rotation {get; set;}
    public Dimension? Dimension { get; set; }

    public Transform()
    {
        Position = new Vector3(0, 0, 0);
        Rotation = new Quaternion(0f, 0f, 0f, 0f);
        Dimension = new Dimension(0, 0);
    }
    public Transform(Vector3 position, Quaternion rotation, Dimension? dimension = null)
    {
        Position = position;
        Rotation = rotation;
        Dimension = dimension;
    }
    
    public virtual Vector3 GetPosition()
    {
        return new Vector3(Position.X, Position.Y, Position.Z);
    }
}

public class Scale
{
    public float ScaleX { get; set; }
    public float ScaleY { get; set; }
    
}

public class Dimension
{
    public float Width { get; set; }
    public float Height { get; set; }

    public Dimension(float width, float height)
    {
        Width = width;
        Height = height;
    }

    public Dimension()
    {
        
    }
}

