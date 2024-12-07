﻿using OneIoT.Framework.Graphics.Drawable;
using OneIoT.Framework.Graphics.VisualElements;

namespace OneIoT.Framework.Graphics.Shapes;


public class Triangle : VisualElement
{
    public Triangle()
    {
        base.Anchors = Anchors.MiddleCenter;
        base.Size = new Size() { Width = 100, Height = 100 };
    }
    
    public Triangle(IVisualElement parent)
    {
        base.Parent = parent;
        base.Anchors = Anchors.MiddleCenter;
        base.Size = new Size() { Width = 100, Height = 100 };
    }
    
    public Triangle(Anchors createAnchor, Size size)
    {
        base.Anchors = createAnchor;
        base.Size = size;
    }
}