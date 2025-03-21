using Materials_PR5.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormDeliveryHistory : Form
    {
        private DbMaterialsContext db;

        public FormDeliveryHistory()
        {
            InitializeComponent();
        }

      /*  protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new DbMaterialsContext();
            this.db.SuppliersMaterials.Load();
            dataGridViewSuppliersMaterial.DataSource = db.SuppliersMaterials.Local.OrderByDescending(o=>o.DateOfSupply).ThenBy(o=>o.).ToList();

        }*/
    }
}
