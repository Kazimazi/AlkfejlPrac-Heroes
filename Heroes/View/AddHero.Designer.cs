namespace Heroes
{
    partial class AddHero
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.heroNameTextBox = new System.Windows.Forms.TextBox();
            this.powerComboBox = new System.Windows.Forms.ComboBox();
            this.ageNumbericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumbericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hero Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Power";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(124, 35);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(205, 23);
            this.nameTextBox.TabIndex = 4;
            // 
            // heroNameTextBox
            // 
            this.heroNameTextBox.Location = new System.Drawing.Point(124, 88);
            this.heroNameTextBox.Name = "heroNameTextBox";
            this.heroNameTextBox.Size = new System.Drawing.Size(205, 23);
            this.heroNameTextBox.TabIndex = 5;
            // 
            // powerComboBox
            // 
            this.powerComboBox.FormattingEnabled = true;
            this.powerComboBox.Location = new System.Drawing.Point(124, 148);
            this.powerComboBox.Name = "powerComboBox";
            this.powerComboBox.Size = new System.Drawing.Size(205, 23);
            this.powerComboBox.TabIndex = 8;
            // 
            // ageNumbericUpDown
            // 
            this.ageNumbericUpDown.Location = new System.Drawing.Point(124, 212);
            this.ageNumbericUpDown.Name = "ageNumbericUpDown";
            this.ageNumbericUpDown.Size = new System.Drawing.Size(205, 23);
            this.ageNumbericUpDown.TabIndex = 9;
            this.ageNumbericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(124, 258);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 42);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButton.Location = new System.Drawing.Point(236, 258);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(93, 42);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addHero_Click);
            // 
            // AddHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 312);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.ageNumbericUpDown);
            this.Controls.Add(this.powerComboBox);
            this.Controls.Add(this.heroNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddHero";
            this.Text = "New Hero";
            ((System.ComponentModel.ISupportInitialize)(this.ageNumbericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nameTextBox;
        private TextBox heroNameTextBox;
        private ComboBox powerComboBox;
        private NumericUpDown ageNumbericUpDown;
        private Button cancelButton;
        private Button addButton;
    }
}