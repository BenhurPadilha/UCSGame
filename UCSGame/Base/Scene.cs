using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCSGame.Base
{
    internal abstract class Scene
    {
        public World World;

        public Camera Camera;

        public int Top = 1;

        public Scene()
        {
            World = new World(25, 100);
            World.Fill();

            Camera = new Camera();
        }

        public void Add(string text)
        {
            World.Add(Top, 1, text);

            Top++;
        }

        public string RequestUserOption()
        {
            Console.WriteLine("O que você faz?");

            string option = Console.ReadLine();

            return option;
        }

        public void Move(Scene scene)
        {
            scene.Show();

            string option = RequestUserOption();
            Scene s = scene.Options(option);

            scene.Move(s);
        }

        public abstract Scene Options(string option);

        public void Show()
        {
            Camera.Draw(World);
        }
    }
}
