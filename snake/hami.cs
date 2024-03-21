using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class hami : PictureBox
    {
        public static int Méret = 20;

        public hami()
        {
            Width = hami.Méret;
            Height = hami.Méret;
            BackColor = Color.Cyan;
        }
    }
}
