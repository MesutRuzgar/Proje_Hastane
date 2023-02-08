using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class frmHastaDetay : Form
    {
        public frmHastaDetay()
        {
            InitializeComponent();
        }

        //global e tc atayıp girişten maskedboxtan tc yi buraya atadık ekrana yansıttık.
        public string tc;
        private void frmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTcNo.Text = tc;
        }
    }
}
