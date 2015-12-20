using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Lonely_Wolf.Models.Items
{
    interface ITemporary:IItem
    {
        void Update(GameTime gameTime);
         bool IsFinished { get; }
    }
}
