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
            dataGridViewSuppliers = new DataGridView();
            buttonSave = new Button();
            label1 = new Label();
            panelTop = new Panel();
            panelFill = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).BeginInit();
            panelTop.SuspendLayout();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.BackgroundColor = Color.White;
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers.Dock = DockStyle.Fill;
            dataGridViewSuppliers.Location = new Point(10, 10);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.Size = new Size(780, 351);
            dataGridViewSuppliers.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.White;
            buttonSave.Dock = DockStyle.Left;
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(10, 10);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(131, 59);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 335);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonSave);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(800, 79);
            panelTop.TabIndex = 3;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewSuppliers);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 79);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(800, 371);
            panelFill.TabIndex = 4;
            // 
            // FormSuppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFill);
            Controls.Add(panelTop);
            Controls.Add(label1);
            Name = "FormSuppliers";
            Text = "Поставщики";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            panelTop.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSuppliers;
        private Button buttonSave;
        private Label label1;
        private Panel panelTop;
        private Panel panelFill;
    }
}
