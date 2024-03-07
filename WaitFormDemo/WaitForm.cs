using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaitFormDemo
{
    public partial class WaitForm : Form
    {
        public Label LblMessages = new Label();
        public WaitForm()
        {
            InitializeComponent();

            LblMessages.Location = new Point(12, 82);
            LblMessages.Name = "LblMessages";
            LblMessages.Size = new Size(339, 60);
            LblMessages.TabIndex = 1;
            LblMessages.TextAlign = ContentAlignment.MiddleCenter;

        }
    }
}
