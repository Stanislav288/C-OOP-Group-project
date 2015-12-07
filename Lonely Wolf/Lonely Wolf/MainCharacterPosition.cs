using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Lonely_Wolf
{
    public static class MainCharacterPosition
    {
        private static Vector2 position = new Vector2(100, 100);

        public static Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

    }
}
