using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materials_PR5
{
    public partial class FormTypesAddSuppliers : Form
    {
       /* string msgError = "Поле не может быть пустым";*/
        private object db;

        public FormTypesAddSuppliers()
        {
            InitializeComponent();
        }







        private void TextBoxTypes_TextChanged(object sender, EventArgs e)
        {
            /*if (String.IsNullOrEmpty(comboBoxTypes.Text))
            {
                errorProvider.SetError(comboBoxTypes, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }*/
        }

        private void textBoxTypeName_Validated(object sender, EventArgs e)
        {
            /*if (String.IsNullOrEmpty(comboBoxTypes.Text))
            {
                errorProvider.SetError(comboBoxTypes, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }*/
        }

    /*    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormTypesAddSuppliers form =  new FormTypesAddSuppliers();
          
            var types =  
            short index = -1;
            foreach ( var type in types )
            {
                form.comboBox1.Items.Add(u.TypeSupplier );

            }

        }*/
    }
}
