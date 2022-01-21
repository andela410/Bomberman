using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Bomberman
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SoundPlayer player = new SoundPlayer(Properties.Resources.Black_Betty);
            player.PlayLooping();
            //Application.Run(new Form1());
            Application.Run(new Menu());
        }
    }
}
