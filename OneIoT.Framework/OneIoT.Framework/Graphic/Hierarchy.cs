namespace OneIoT.Framework.Graphic;

public class Hierarchy
{
    public IVisual? Parent { get; set; }
    public List<IVisual>? Children { get; set; }

    public Hierarchy(IVisual? parent, List<IVisual>? children)
    {
        Parent = parent;
        Children = children;
    }

    public Hierarchy()
    {
        
    }
    
    public void AddChild()
    {
        
    }
}

public class HierarchyParent
{
    
}

public class HierarchyChild
{
    
}