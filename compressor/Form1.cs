using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compressor
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        FirstFollowCompression ffc = new FirstFollowCompression();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ofd.Filter = "PNG|*.png";
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtBrowseFile.Text = ofd.FileName;
            }
        }

        private void btnDestinationFolder_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDestinationFolder.Text = fbd.SelectedPath;
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            //If the destination folder was never selected. It just makes the destination 
            if (txtDestinationFolder.Text.Equals(""))
            {
                string destination = txtBrowseFile.Text.Substring(0,txtBrowseFile.Text.LastIndexOf('\\'));
                txtDestinationFolder.Text = destination;
            }

            byte[] compressed = ffc.compress(txtBrowseFile.Text);
            string[] stringCompressed = compressed.Select(byteValue => byteValue.ToString()).ToArray();
                //.ASCII.GetString(compressed, 0, compressed.Length);

            System.IO.File.WriteAllBytes(txtDestinationFolder.Text + "\\HAHA.txt", compressed);
            System.IO.File.WriteAllLines(txtDestinationFolder.Text + "\\HAHA2.txt", stringCompressed);
            
            MessageBox.Show("Your compression is done");
        }
    }
}
