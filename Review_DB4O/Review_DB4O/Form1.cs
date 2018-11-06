using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Review_DB4O
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database.DbFileName = "pilotdb.yap";
            dgvPilot.DataSource = Database.GetList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Pilot newPilot = new Pilot(txtName.Text, int.Parse(txtPoints.Text));
            Database.Add(newPilot);
            dgvPilot.DataSource = Database.GetList();
        }
    }
}
