using OpenTK.Windowing.Desktop;

namespace OneIoT.Framework.Graphic
{
    public class Window : GameWindow, IVisual
    {
        // public Transform Transform { get; set; }
        public Transform Transform { get; set; }
        public Color Color { get; set; }
        
        public Window(int width, int height, string title) : base(GameWindowSettings.Default,
            new NativeWindowSettings() { Size = (width, height), Title = title })
        {
            // Transform = new Transform();
            Console.WriteLine(base.Size.X + "," + base.Size.Y);
            Console.WriteLine(this.Size.X + "," + this.Size.Y);
        }


    }
}