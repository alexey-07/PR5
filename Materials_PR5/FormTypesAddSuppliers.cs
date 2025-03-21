using Materials_PR5.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Materials_PR5
{
    public partial class FormTypesAddSuppliers : Form
    {
        string msgError = "Поле не может быть пустым";
        private DbMaterialsContext? db;

        public FormTypesAddSuppliers()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new DbMaterialsContext();
            this.db.SupplierTypes.Load();
            List<SupplierType> typeSupplier = this.db.SupplierTypes.Local.OrderBy(o => o.TypeSupplier).ToList();
            comboBoxTypes.DataSource = typeSupplier;
            comboBoxTypes.DisplayMember = "TypeSupplier";
            comboBoxTypes.ValueMember = "id";

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                errorProvider.SetError(textBoxName, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                errorProvider.SetError(textBoxName, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxInn_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxInn.Text))
            {
                errorProvider.SetError(textBoxInn, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxInn_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxInn.Text))
            {
                errorProvider.SetError(textBoxInn, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void checkBoxActive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
