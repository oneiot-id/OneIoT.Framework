﻿    using OneIoT.Framework.Events;
    using OpenTK.Mathematics;

    namespace OneIoT.Framework.Graphics.VisualElements;

    public class VisualElement : IVisualElement, IEvents
    {

        public VisualElement(IVisualElement parent)
        {
            Parent = parent;
            CenterPoint = parent.CenterPoint;
            Anchor = Anchors.MiddleCenter;
            Size = new Size() { Width = 100, Height = 100 };
        }
        
        public VisualElement()
        {
            
        }
        
        protected Vector2 PositionOffset;
        
        public string Name { get; set; } = null;
        
        public virtual IVisualElement? Parent { get; set; } = null;

        public virtual Children Children { get; set; } = new Children();
    
        public virtual Transform Transform { get; set; } = new Transform();

        public virtual Size Size { get; set; } = new Size();

        public virtual VisualElementColor Color { get; set; } = new VisualElementColor();
        
        public virtual Anchors Anchor { get; set; }
        
        public Anchors Origin { get; set; }

        public virtual Vector2 CenterPoint { get; set; } = new Vector2(0, 0);

        public bool Visible { get; set; } = true;
    
        public virtual void AddChild(IVisualElement element)
        {
            element.Parent = this;
            Children.AddChildren(element);
        }

        public virtual Vector2[] Points { get; set; }
            
        public delegate void MouseEvent(Func<object> e);

        private event MouseEvent? ClickEvent;
        private event MouseEvent? HoverEvent;

        // private bool _isClickEventRegistered = false;
        
        public void RegisterMouseCallback<T>(MouseEvent? e) where T : MouseClickEvent
        {
            
            if (ClickEvent != null && !ClickEvent.HasSingleTarget)
            {
                ClickEvent += e;
                // _isClickEventRegistered = true;
            }
        }

        private void TriggerEvent(Func<object> e)
        {
            ClickEvent?.Invoke(e);
        }

        private bool _isClicked = false;
        
        public void OnClick()
        {
            if (!_isClicked)
            {
                _isClicked = true;
                
                Func<object> e = () =>
                {
                    return null;
                };
                
                TriggerEvent(e);
                
            }
        }

        public void OnClickExit()
        {
            _isClicked = false;
        }

        public void OnMouseExit()
        {
            _isClicked = false;
        }

        protected virtual void CalculateAnchor()
        {
            var halfW = Size.Width / 2f;
            var halfH = Size.Height / 2f;
            
            switch (Anchor)
            {
                case Anchors.TopLeft:
                    PositionOffset.X += halfW;
                    PositionOffset.Y += halfH;
                    break;
                case Anchors.TopCenter:
                    PositionOffset.Y += halfH;
                    break;
                case Anchors.TopRight:
                    PositionOffset.X -= halfW;
                    PositionOffset.Y += halfH;
                    break;
                case Anchors.MiddleLeft:
                    PositionOffset.X += halfW;
                    break;
                case Anchors.MiddleCenter:
                    break;
                case Anchors.MiddleRight:
                    PositionOffset.X -= halfW;
                    break;
                case Anchors.BottomLeft:
                    PositionOffset.X += halfW;
                    PositionOffset.Y -= halfH;
                    break;
                case Anchors.BottomCenter:
                    PositionOffset.Y -= halfH;
                    break;
                case Anchors.BottomRight:
                    PositionOffset.X -= halfW;
                    PositionOffset.Y -= halfH;
                    break;
            }
        }

        protected virtual void CalculateTranslation(Transform transform)
        {
            PositionOffset.X += transform.Position.X;
            PositionOffset.Y += transform.Position.Y;
        }

        protected virtual void CalculateScaling(Transform transform)
        {
            Size.Width = Size.Width *  transform.Scale;
            Size.Height = Size.Height * transform.Scale;
        }
    }