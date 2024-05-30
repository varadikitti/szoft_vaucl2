using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_VAUCL2
{
    internal class LikeButton : Label
    {
        int darab = 0;
        public LikeButton()
        {
            AutoSize = true;
            BackColor = Color.Gray;
            Text = "☆☆☆☆☆";
            MouseClick += LikeButton_MouseClick;         
        }

        private void LikeButton_MouseClick(object? sender, MouseEventArgs e)
        {
            darab++;
            if (darab == 1) { Text = "★☆☆☆☆"; }
            if (darab == 2) { Text = "★★☆☆☆"; }
            if (darab == 3) { Text = "★★★☆☆"; }
            if (darab == 4) { Text = "★★★★☆"; }
            if (darab == 5) { Text = "★★★★★"; }
            //if (darab == 6) { Visible = false; }       
            if (darab == 6) 
            { 
                Text = "☆☆☆☆☆";
                //Text += "★"; 
                darab = 0;
            }       
        }
    }
}
