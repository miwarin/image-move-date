using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_move_date
{
    class Program : ApplicationContext
    {
        private MainWindow _MainWindow;

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Program program = new Program();
            Application.Run(program);
        }

        public Program()
        {
            this._MainWindow = new MainWindow();
            this._MainWindow.FormClosed += new FormClosedEventHandler(OnFormClosed);
            this._MainWindow.Show();
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
