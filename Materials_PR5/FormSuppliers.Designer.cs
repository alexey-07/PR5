namespace Materials_PR5
{
    partial class FormSuppliers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDel = new Button();
            buttonHisSup = new Button();
            panelFill = new Panel();
            dataGridViewSuppliers = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(buttonAdd);
            flowLayoutPanel1.Controls.Add(buttonEdit);
            flowLayoutPanel1.Controls.Add(buttonDel);
            flowLayoutPanel1.Controls.Add(buttonHisSup);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(847, 77);
            flowLayoutPanel1.TabIndex = 5;
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
            buttonAdd.Click += ButtonTypeAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.White;
            buttonEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEdit.Location = new Point(219, 13);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Padding = new Padding(10);
            buttonEdit.Size = new Size(200, 51);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDel
            // 
            buttonDel.BackColor = Color.White;
            buttonDel.Dock = DockStyle.Right;
            buttonDel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDel.Location = new Point(425, 13);
            buttonDel.Name = "buttonDel";
            buttonDel.Padding = new Padding(10);
            buttonDel.Size = new Size(200, 51);
            buttonDel.TabIndex = 2;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonHisSup
            // 
            buttonHisSup.AutoSize = true;
            buttonHisSup.BackColor = Color.White;
            buttonHisSup.Dock = DockStyle.Right;
            buttonHisSup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHisSup.Location = new Point(631, 13);
            buttonHisSup.Name = "buttonHisSup";
            buttonHisSup.Padding = new Padding(10);
            buttonHisSup.Size = new Size(200, 51);
            buttonHisSup.TabIndex = 3;
            buttonHisSup.Text = "История поставок";
            buttonHisSup.UseVisualStyleBackColor = false;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewSuppliers);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 77);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(847, 373);
            panelFill.TabIndex = 6;
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.BackgroundColor = Color.White;
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers.Dock = DockStyle.Fill;
            dataGridViewSuppliers.Location = new Point(10, 10);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.ReadOnly = true;
            dataGridViewSuppliers.Size = new Size(827, 353);
            dataGridViewSuppliers.TabIndex = 0;
            // 
            // FormSuppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 450);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanel1);
            Name = "FormSuppliers";
            Text = "Поставщики";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDel;
        private Button buttonHisSup;
        private Panel panelFill;
        private DataGridView dataGridViewSuppliers;
    }
}
