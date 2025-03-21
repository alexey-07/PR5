
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
            comboBoxTypes = new ComboBox();
            labelName = new Label();
            textBoxName = new TextBox();
            labelInn = new Label();
            textBoxInn = new TextBox();
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
            flowLayoutPanelFill.Controls.Add(comboBoxTypes);
            flowLayoutPanelFill.Controls.Add(labelName);
            flowLayoutPanelFill.Controls.Add(textBoxName);
            flowLayoutPanelFill.Controls.Add(labelInn);
            flowLayoutPanelFill.Controls.Add(textBoxInn);
            flowLayoutPanelFill.Controls.Add(checkBoxActive);
            flowLayoutPanelFill.Dock = DockStyle.Fill;
            flowLayoutPanelFill.Location = new Point(0, 0);
            flowLayoutPanelFill.Margin = new Padding(5);
            flowLayoutPanelFill.Name = "flowLayoutPanelFill";
            flowLayoutPanelFill.Padding = new Padding(16, 17, 16, 17);
            flowLayoutPanelFill.Size = new Size(457, 460);
            flowLayoutPanelFill.TabIndex = 0;
            // 
            // labelSup
            // 
            labelSup.AutoSize = true;
            labelSup.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSup.Location = new Point(21, 17);
            labelSup.Margin = new Padding(5, 0, 5, 0);
            labelSup.Name = "labelSup";
            labelSup.Padding = new Padding(16, 17, 16, 17);
            labelSup.Size = new Size(153, 59);
            labelSup.TabIndex = 0;
            labelSup.Text = "Поставщики";
            // 
            // comboBoxTypes
            // 
            comboBoxTypes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxTypes.FormattingEnabled = true;
            comboBoxTypes.Location = new Point(21, 81);
            comboBoxTypes.Margin = new Padding(5);
            comboBoxTypes.Name = "comboBoxTypes";
            comboBoxTypes.Size = new Size(362, 25);
            comboBoxTypes.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(21, 111);
            labelName.Margin = new Padding(5, 0, 5, 0);
            labelName.Name = "labelName";
            labelName.Padding = new Padding(16, 17, 16, 17);
            labelName.Size = new Size(175, 59);
            labelName.TabIndex = 2;
            labelName.Text = "Наименование";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName.Location = new Point(21, 175);
            textBoxName.Margin = new Padding(5);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(362, 25);
            textBoxName.TabIndex = 3;
            textBoxName.TextChanged += textBoxName_TextChanged;
            textBoxName.Validating += textBoxName_Validating;
            // 
            // labelInn
            // 
            labelInn.AutoSize = true;
            labelInn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInn.Location = new Point(21, 205);
            labelInn.Margin = new Padding(5, 0, 5, 0);
            labelInn.Name = "labelInn";
            labelInn.Padding = new Padding(16, 17, 16, 17);
            labelInn.Size = new Size(209, 59);
            labelInn.TabIndex = 4;
            labelInn.Text = "ИНН                         ";
            // 
            // textBoxInn
            // 
            textBoxInn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxInn.Location = new Point(21, 269);
            textBoxInn.Margin = new Padding(5);
            textBoxInn.Name = "textBoxInn";
            textBoxInn.Size = new Size(362, 25);
            textBoxInn.TabIndex = 5;
            textBoxInn.TextChanged += textBoxInn_TextChanged;
            textBoxInn.Validating += textBoxInn_Validating;
            // 
            // checkBoxActive
            // 
            checkBoxActive.AutoSize = true;
            checkBoxActive.Location = new Point(21, 304);
            checkBoxActive.Margin = new Padding(5);
            checkBoxActive.Name = "checkBoxActive";
            checkBoxActive.Padding = new Padding(16, 17, 16, 17);
            checkBoxActive.Size = new Size(239, 63);
            checkBoxActive.TabIndex = 7;
            checkBoxActive.Text = "    Действующая       ";
            checkBoxActive.UseVisualStyleBackColor = true;
            checkBoxActive.CheckedChanged += checkBoxActive_CheckedChanged;
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.Controls.Add(buttonCancel);
            flowLayoutPanelBottom.Controls.Add(buttonSave);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Location = new Point(0, 366);
            flowLayoutPanelBottom.Margin = new Padding(5);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(16, 17, 16, 17);
            flowLayoutPanelBottom.Size = new Size(457, 94);
            flowLayoutPanelBottom.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.AutoSize = true;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(21, 22);
            buttonCancel.Margin = new Padding(5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(170, 50);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.AutoSize = true;
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(201, 22);
            buttonSave.Margin = new Padding(5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(170, 50);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // FormTypesAddSuppliers
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 460);
            Controls.Add(flowLayoutPanelBottom);
            Controls.Add(flowLayoutPanelFill);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormTypesAddSuppliers";
            Text = "FormTypesAddSuppliers";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            flowLayoutPanelFill.ResumeLayout(false);
            flowLayoutPanelFill.PerformLayout();
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider errorProvider;
        private FlowLayoutPanel flowLayoutPanelFill;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Label labelSup;
        private Label labelName;
        private Label labelInn;
        private Button buttonCancel;
        private Button buttonSave;
        private EventHandler comboBox1_SelectedIndexChanged;
        public ComboBox comboBoxTypes;
        public TextBox textBoxName;
        public TextBox textBoxInn;
        public CheckBox checkBoxActive;
    }
}