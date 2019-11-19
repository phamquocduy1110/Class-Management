using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class CreateClassForm : Form
    {
        private ClassManagement Business;
        public CreateClassForm()
        {
            InitializeComponent();
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text;
            var description = this.txtDescription.Text;
            this.Business.AddClass(name, description);
            MessageBox.Show("Add new class successfully. ");
            this.Close();
        }
    }
}
