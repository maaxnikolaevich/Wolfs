using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolfs
{
   public class Isle
    {
        Transform transform;
        Image sprite;
        public int sizeX;
        public int sizeY;

        public Isle(PointF pos)
        {
            sprite= Properties.Resources.area;
            sizeX = 600;
            sizeY = 600;
            transform = new Transform(pos, new Size(sizeX, sizeY));
        }

        public void DrawSprite(Graphics g)
        {
            g.DrawImage(sprite,transform.pos.X, transform.pos.Y, transform.size.Width, transform.size.Height);
        }
    }
}
