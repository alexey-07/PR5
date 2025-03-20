namespace Materials_PR5
{
    partial class FormTypesAddSuppliers
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
            components = new System.ComponentModel.Container();
            errorProvider = new ErrorProvider(components);
            flowLayoutPanelFill = new FlowLayoutPanel();
            labelSup = new Label();
            comboBox1 = new ComboBox();
            labelName = new Label();
            textBoxName = new TextBox();
            labelInn = new Label();
            textBoxInn = new TextBox();
            labelActive = new Label();
            checkBoxActive = new CheckBox();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            buttonCancel = new Button();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            flowLayoutPanelFill.SuspendLayout();
            flowLayoutPanelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // flowLayoutPanelFill
            // 
            flowLayoutPanelFill.Controls.Add(labelSup);
            flowLayoutPanelFill.Controls.Add(comboBox1);
            flowLayoutPanelFill.Controls.Add(labelName);
            flowLayoutPanelFill.Controls.Add(textBoxName);
            flowLayoutPanelFill.Controls.Add(labelInn);
            flowLayoutPanelFill.Controls.Add(textBoxInn);
            flowLayoutPanelFill.Controls.Add(labelActive);
            flowLayoutPanelFill.Controls.Add(checkBoxActive);
            flowLayoutPanelFill.Dock = DockStyle.Fill;
            flowLayoutPanelFill.Location = new Point(0, 0);
            flowLayoutPanelFill.Name = "flowLayoutPanelFill";
            flowLayoutPanelFill.Padding = new Padding(10);
            flowLayoutPanelFill.Size = new Size(291, 398);
            flowLayoutPanelFill.TabIndex = 0;
            // 
            // labelSup
            // 
            labelSup.AutoSize = true;
            labelSup.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSup.Location = new Point(13, 10);
            labelSup.Name = "labelSup";
            labelSup.Padding = new Padding(10);
            labelSup.Size = new Size(141, 45);
            labelSup.TabIndex = 0;
            labelSup.Text = "Поставщики";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 25);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(13, 86);
            labelName.Name = "labelName";
            labelName.Padding = new Padding(10);
            labelName.Size = new Size(163, 45);
            labelName.TabIndex = 2;
            labelName.Text = "Наименование";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName.Location = new Point(13, 134);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(232, 25);
            textBoxName.TabIndex = 3;
            // 
            // labelInn
            // 
            labelInn.AutoSize = true;
            labelInn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInn.Location = new Point(13, 162);
            labelInn.Name = "labelInn";
            labelInn.Padding = new Padding(10);
            labelInn.Size = new Size(197, 45);
            labelInn.TabIndex = 4;
            labelInn.Text = "ИНН                         ";
            // 
            // textBoxInn
            // 
            textBoxInn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxInn.Location = new Point(13, 210);
            textBoxInn.Name = "textBoxInn";
            textBoxInn.Size = new Size(232, 25);
            textBoxInn.TabIndex = 5;
            // 
            // labelActive
            // 
            labelActive.AutoSize = true;
            labelActive.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelActive.Location = new Point(13, 238);
            labelActive.Name = "labelActive";
            labelActive.Padding = new Padding(10);
            labelActive.Size = new Size(163, 45);
            labelActive.TabIndex = 6;
            labelActive.Text = "Действующая  ";
            // 
            // checkBoxActive
            // 
            checkBoxActive.AutoSize = true;
            checkBoxActive.Location = new Point(182, 241);
            checkBoxActive.Name = "checkBoxActive";
            checkBoxActive.Padding = new Padding(10);
            checkBoxActive.Size = new Size(79, 39);
            checkBoxActive.TabIndex = 7;
            checkBoxActive.Text = "           ";
            checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.Controls.Add(buttonCancel);
            flowLayoutPanelBottom.Controls.Add(buttonSave);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Location = new Point(0, 303);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10);
            flowLayoutPanelBottom.Size = new Size(291, 95);
            flowLayoutPanelBottom.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(13, 13);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(117, 51);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(136, 13);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(117, 51);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // FormTypesAddSuppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 398);
            Controls.Add(flowLayoutPanelBottom);
            Controls.Add(flowLayoutPanelFill);
            Name = "FormTypesAddSuppliers";
            Text = "FormTypesAddSuppliers";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            flowLayoutPanelFill.ResumeLayout(false);
            flowLayoutPanelFill.PerformLayout();
            flowLayoutPanelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProvider;
        private FlowLayoutPanel flowLayoutPanelFill;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Label labelSup;
        private ComboBox comboBox1;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelInn;
        private TextBox textBoxInn;
        private Button buttonCancel;
        private Label labelActive;
        private CheckBox checkBoxActive;
        private Button buttonSave;
    }
}