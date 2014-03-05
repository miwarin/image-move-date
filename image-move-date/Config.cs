using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace image_move_date
{
    public class Config
    {
        public static String PhotoPathDstBase
        {
            get
            {
                return Properties.Settings.Default.PhotoPathDstBase;
            }
            set
            {
                Properties.Settings.Default.PhotoPathDstBase = value;
                Properties.Settings.Default.Save();
            }
        }
    }
}
