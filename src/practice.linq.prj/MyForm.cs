using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Venediktov.Framework;

namespace practice.linq
{
    /// <summary>/// </summary>
    public partial class MyForm : Form
    {
        /// <summary>/// </summary>
        public MyForm()
        {
            InitializeComponent();
            this.Font = SystemFonts.MessageBoxFont;
            button1.Image = Image.FromFile("..\\..\\..\\image\\1.png");
            
        }
        /// <summary>/// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MinimumSize = Size;
        }
    }
}
