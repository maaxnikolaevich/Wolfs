using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Wolfs
{
    public class Transform
    {
        public PointF pos;
        public Size size;

        public Transform(PointF pos, Size size)
        {
            this.pos = pos;
            this.size = size;
        }


    }
}
