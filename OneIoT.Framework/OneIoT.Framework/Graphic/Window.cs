using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace OneIoT.Framework.Graphic
{
    public class Window : GameWindow
    {
        public Window(int width, int height, string title) : base(GameWindowSettings.Default, 
            new NativeWindowSettings() { Size = (width, height), Title = title })
        {
            
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
        }
    }
    
    
    
}


