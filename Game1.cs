using Microsoft.Xna.Framework;
using Nez;

namespace MonoGameNez
{
    public class Game1 : Core
    {
        protected override void Initialize()
        {
            base.Initialize();

            scene = Scene.createWithDefaultRenderer(clearColor: Color.MonoGameOrange);
        }
    }
}
