using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace image_move_date
{
    public class MessageEventArgs : EventArgs
    {
        public String Message { get; set; }
    }

    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            SetupWindow();
        }

        private void SetupWindow()
        {
            txtPhotoPathDstBase.Text = Config.PhotoPathDstBase;
        }

        private void OnResultAppend(object sender, MessageEventArgs e)
        {
            txtResult.AppendText(String.Format("{0}\n", e.Message));
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            String dstdir = txtPhotoPathDst.Text;
            if(String.IsNullOrEmpty(dstdir) == true)
            {
                MessageBox.Show("移動先ディレクトリを指定してください");
                return;
            }

            String srcdir = txtPhotoPathSrc.Text;
            if (String.IsNullOrEmpty(srcdir) == true)
            {
                MessageBox.Show("移動元ディレクトリを指定してください");
                return;
            }

            ImageMove(srcdir, dstdir);
        }

        private void ImageMove(String srcdir, String dstdir)
        {
            Directory.CreateDirectory(dstdir);
            MessageEventArgs e = new MessageEventArgs();

            string[] files = Directory.GetFiles(srcdir, "*.*");
            foreach (String srcfilepath in files)
            {
                String srcfilename = Path.GetFileName(srcfilepath);
                String dstfilepath = Path.Combine(dstdir, srcfilename);
                File.Move(srcfilepath, dstfilepath);
                e.Message = String.Format("{0} => {1}", srcfilepath, dstfilepath);
                OnResultAppend(this, e);
            }
            e.Message = String.Format("... done");
            OnResultAppend(this, e);
        }

        private void txtPhotoPathDstBase_TextChanged(object sender, EventArgs e)
        {
            Config.PhotoPathDstBase = txtPhotoPathDstBase.Text;
        }

        private void txtPhotoPathSrc_TextChanged(object sender, EventArgs e)
        {
            String srcdir = txtPhotoPathSrc.Text;
            String dstdirbase = txtPhotoPathDstBase.Text;

            if (Directory.Exists(srcdir) == false)
            {
                MessageBox.Show("ディレクトリを指定してください");
                return;
            }

            DirectoryInfo di = new DirectoryInfo(srcdir);
            DateTime ctime = di.CreationTime;
            String date = ctime.ToString(@"yyyy\\MM\\dd");
            String dstdir = Path.Combine(dstdirbase, date);
            Console.WriteLine(dstdir);
            txtPhotoPathDst.Text = dstdir;
        }

        private void txtPhotoPathSrc_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtPhotoPathSrc_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            txtPhotoPathSrc.Text = files[0];
        }

        private void txtPhotoPathDstBase_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtPhotoPathDstBase_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            txtPhotoPathDstBase.Text = files[0];
        }
    }
}
