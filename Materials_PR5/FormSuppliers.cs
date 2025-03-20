using Materials_PR5.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Materials_PR5
{
    public partial class FormSuppliers : Form
    {
        private DbMaterialsContext db;

        public FormSuppliers()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.db = new DbMaterialsContext();
            this.db.Suppliers.Load();
            dataGridViewSuppliers.DataSource = db.Suppliers.Local.OrderBy(o => o.IdSupplierType).ToList();
            dataGridViewSuppliers.Columns["SupplierType"].Visible = false;
            dataGridViewSuppliers.Columns["SuppliersMaterials"].Visible = false;

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            db?.Dispose();
            db = null;
        }

        private void ButtonTypeAdd_Click(object sender, EventArgs e)
        {
            FormTypesAddSuppliers formTypesAdd = new FormTypesAddSuppliers();
            DialogResult result = formTypesAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            //if (formTypesAdd.textBoxTypes.Text == String.Empty)
            //    MessageBox.Show("Поле не может быть пустым!");

            Supplier supplier = new Supplier();
            //supplier.NameSupplier = formTypesAdd.textBox.Text;

            db.Suppliers.Add(supplier);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен!");
            dataGridViewSuppliers.DataSource = db.Suppliers.Local.OrderBy(o => o.IdSupplierType).ToList();
        }
        }
    }

