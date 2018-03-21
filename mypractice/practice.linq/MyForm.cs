using MyFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace practice.linq
{
    /// <summary>/// </summary>
    public partial class Form1 : Form
    {
        /// <summary>/// </summary>
        public Form1()
        {
            InitializeComponent();
            this.Font = SystemFonts.MessageBoxFont;
        }
        /// <summary>/// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MinimumSize = Size;
        }
    }
}
