
using Microsoft.EntityFrameworkCore;

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
        }
    }
}
