using Domain.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_3.forms
{
    public partial class Cactivofijo : Form
    {
        public Cactivofijo()
        {
            InitializeComponent();
        }

        private void Cactivofijo_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Enum.GetValues(typeof(TipoActivo)).Cast<object>().ToArray());
            comboBox2.Items.AddRange(Enum.GetValues(typeof(TipoDepreciacion)).Cast<object>().ToArray());
        }
    }
}
