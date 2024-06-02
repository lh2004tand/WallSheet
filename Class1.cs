using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAT_WALLSHEET
{
    internal class Class1
    {
        public static int GeTTextHeight(Label lbl)
        {
            using(Graphics g=lbl.CreateGraphics())
            {
                SizeF size =g.MeasureString(lbl.Text,lbl.Font,495);
                return (int)Math.Ceiling(size.Height);
            }
        }
    }
}
