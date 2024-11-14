namespace OneIoT.Framework.Graphic;

public class VisualElement : IVisual
{
    public virtual Transform Transform { get; set; }
    public VisualElement(Transform transform)
    {
        Transform = transform;
    }

}