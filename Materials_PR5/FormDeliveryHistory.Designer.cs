namespace Materials_PR5
{
    partial class FormDeliveryHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonAdd = new Button();
            panelFill = new Panel();
            dataGridViewSuppliersMaterial = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliersMaterial).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(buttonAdd);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(800, 77);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.White;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(13, 13);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(200, 51);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewSuppliersMaterial);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 77);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(800, 373);
            panelFill.TabIndex = 7;
            // 
            // dataGridViewSuppliersMaterial
            // 
            dataGridViewSuppliersMaterial.BackgroundColor = Color.White;
            dataGridViewSuppliersMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliersMaterial.Dock = DockStyle.Fill;
            dataGridViewSuppliersMaterial.Location = new Point(10, 10);
            dataGridViewSuppliersMaterial.Name = "dataGridViewSuppliersMaterial";
            dataGridViewSuppliersMaterial.ReadOnly = true;
            dataGridViewSuppliersMaterial.Size = new Size(780, 353);
            dataGridViewSuppliersMaterial.TabIndex = 0;
            // 
            // FormDeliveryHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanel1);
            Name = "FormDeliveryHistory";
            Text = "FormDeliveryHistory";
            flowLayoutPanel1.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliersMaterial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelFill;
        private DataGridView dataGridViewSuppliersMaterial;
        private Button buttonAdd;
    }
}