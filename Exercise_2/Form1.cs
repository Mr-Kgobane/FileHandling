using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Exercise_2
{
    public partial class Form1 : Form
    {
        List<string> detail = new List<string>();
        BindingSource data = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            data.DataSource = detail;
            lstDisplay.DataSource = data;
        }

        FileHandler handle = new FileHandler();
        private void btnAdd2List_Click(object sender, EventArgs e)
        {
            Employee p = new Employee(txtName.Text, txtSurname.Text, txtJob.Text);
            detail.Add(p.Display());
            data.ResetBindings(false);
        }

        private void btnSave2File_Click(object sender, EventArgs e)
        {
            handle.write(detail);
        }

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            lstDisplay.DataSource = handle.read();
        }
    }
}
