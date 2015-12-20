
using Microsoft.Xna.Framework.Graphics;

namespace Lonely_Wolf.Models.Items
{
    interface IItem
    {
        void Draw(SpriteBatch spriteBatch);
        bool IsAvalable { get; }
    }
}
