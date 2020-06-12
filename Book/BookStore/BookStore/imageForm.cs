using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class imageForm : Form
    {
        public imageForm()
        {
            InitializeComponent();
        }

        public bool setImage(byte[] image)
        {
            MemoryStream ms = new MemoryStream(image);
            this.pictureBox.Image = Image.FromStream(ms);
            return true;
        }
    }
}
