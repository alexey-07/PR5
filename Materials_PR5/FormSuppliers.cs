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
            /*dataGridViewSuppliers.DataSource = db.Suppliers.Local.OrderBy(o => o.IdSupplierType).ToList();*/
            dataGridViewSuppliers.DataSource = this.db.Suppliers.Include(o => o.SupplierType).
                Select(s=>new {s.Id,s.SupplierType.TypeSupplier,s.NameSupplier,s.Inn,s.IsActive}).OrderBy(o => o.TypeSupplier).ThenBy(o=> o.NameSupplier).ToList();
            /*dataGridViewSuppliers.Columns["SupplierType"].Visible = false;
            dataGridViewSuppliers.Columns["SuppliersMaterials"].Visible = false;*/

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

            var newSupplier = new Supplier
            {
                NameSupplier = formTypesAdd.textBoxName.Text,
                Inn = formTypesAdd.textBoxInn.Text,
                IsActive = formTypesAdd.checkBoxActive.Checked
            };
            SupplierType type = (SupplierType)formTypesAdd.comboBoxTypes.SelectedItem;
            newSupplier.IdSupplierType = type.Id;
            //supplier.NameSupplier = formTypesAdd.textBox.Text;

            db.Suppliers.Add(newSupplier);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен!");
            dataGridViewSuppliers.DataSource = this.db.Suppliers.Include(o => o.SupplierType).Select
            (s => new { s.Id, s.SupplierType.TypeSupplier, s.NameSupplier, s.Inn, s.IsActive }).OrderBy(o => o.TypeSupplier).ThenBy(o => o.NameSupplier).ToList();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            int index = dataGridViewSuppliers.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewSuppliers[0, index].Value.ToString(), out id);
            if (!converted)
                return;
            int ids = (int)id;
            Supplier supplierDel = db.Suppliers.Find(ids);

            db.Suppliers.Remove(supplierDel);

            db.SaveChanges();
            MessageBox.Show("Объект удален");
            dataGridViewSuppliers.DataSource = this.db.Suppliers.Include(o => o.SupplierType).Select
            (s => new { s.Id, s.SupplierType.TypeSupplier, s.NameSupplier, s.Inn, s.IsActive }).OrderBy(o => o.TypeSupplier).ThenBy(o => o.NameSupplier).ToList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count == 0)
                return;

            int index = dataGridViewSuppliers.SelectedRows[0].Index;
            int ids = 0;
            bool converted = Int32.TryParse(dataGridViewSuppliers[0, index].Value.ToString(), out ids);
            if (!converted)
            {
                MessageBox.Show("Ошибка: Неверный ID.");
                return;
            }

            Supplier supplierUp = db.Suppliers.Find(ids);
            if (supplierUp == null)
            {
                MessageBox.Show("Ошибка: Поставщик не найден.");
                return;
            }

            FormTypesAddSuppliers formTypeAdd = new FormTypesAddSuppliers();
            formTypeAdd.comboBoxTypes.SelectedItem = db.SupplierTypes.Find(supplierUp.IdSupplierType);
            formTypeAdd.textBoxName.Text = supplierUp.NameSupplier;
            formTypeAdd.textBoxInn.Text = supplierUp.Inn;
            formTypeAdd.checkBoxActive.Checked = supplierUp.IsActive;

            DialogResult result = formTypeAdd.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            SupplierType type = (SupplierType)formTypeAdd.comboBoxTypes.SelectedItem;
            if (type == null)
            {
                MessageBox.Show("Ошибка: Не выбран тип поставщика.");
                return;
            }

            supplierUp.IdSupplierType = type.Id;
            supplierUp.NameSupplier = formTypeAdd.textBoxName.Text;
            supplierUp.Inn = formTypeAdd.textBoxInn.Text;
            supplierUp.IsActive = formTypeAdd.checkBoxActive.Checked;

            try
            {
                db.SaveChanges();
                MessageBox.Show("Объект обновлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении: {ex.Message}");
            }

            dataGridViewSuppliers.DataSource = this.db.Suppliers.Include(o => o.SupplierType)
                .Select(s => new { s.Id, s.SupplierType.TypeSupplier, s.NameSupplier, s.Inn, s.IsActive })
                .OrderBy(o => o.TypeSupplier)
                .ThenBy(o => o.NameSupplier)
                .ToList();
        }
    }
}

