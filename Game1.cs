using Microsoft.Xna.Framework;
using Nez;

namespace NewProject
{
    public class Game1 : Core
    {
        public Game1() {}

        protected override void Initialize()
        {
            base.Initialize();

            scene = Scene.createWithDefaultRenderer(clearColor: Color.MonoGameOrange);
        }
    }
}
