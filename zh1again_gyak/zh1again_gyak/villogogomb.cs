using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh1again_gyak
{
    internal class villogogomb : Button
    {
        public villogogomb()
        {
            MouseEnter += Villogogomb_MouseEnter;
            MouseLeave += Villogogomb_MouseLeave;
            Click += Villogogomb_Click;
        }

        private void Villogogomb_Click(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }

        private void Villogogomb_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.Azure;
        }

        private void Villogogomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.SeaShell;
        }
    }
}
