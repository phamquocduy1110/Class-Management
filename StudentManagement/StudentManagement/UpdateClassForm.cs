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
    public partial class UpdateClassForm : Form
    {
        private int ClassId;
        private ClassManagement Business;
        public UpdateClassForm(int id)
        {
            InitializeComponent();
            this.ClassId = id;
            this.Business = new ClassManagement();
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
            this.Load += UpdateClassForm_Load;
        }

        private void UpdateClassForm_Load(object sender, EventArgs e)
        {
            var oldClass = this.Business.GetClass(this.ClassId);
            this.txtClasssname.Text = oldClass.Name;
            this.txtDescription.Text = oldClass.Description;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtClasssname.Text;
            var description = this.txtDescription.Text;
            this.Business.EditClass(this.ClassId, name, description);
            MessageBox.Show("Update class successfully. ");
        }
    }
}
