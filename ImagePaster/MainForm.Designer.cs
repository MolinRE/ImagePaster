namespace ImagePaster
{
    partial class MainForm
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

        private void widthTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }

        }

        private void heightTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (textBoxHeight.Text.Length == 0 && e.KeyChar == 48)
            {
                e.Handled = true;
                return;
            }
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            System.Environment.Exit(0);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.leftRB = new System.Windows.Forms.RadioButton();
            this.rightRB = new System.Windows.Forms.RadioButton();
            this.buttonDownloadImg = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxRatio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonFromClipboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAlt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxBorder = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(428, 112);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(0, 12);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(418, 20);
            this.sourceTextBox.TabIndex = 1;
            this.sourceTextBox.Click += new System.EventHandler(this.sourceTextBox_TextChanged);
            this.sourceTextBox.TextChanged += new System.EventHandler(this.sourceTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL адрес:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultTextBox.Location = new System.Drawing.Point(80, 36);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(515, 329);
            this.resultTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат:";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(0, 6);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(98, 20);
            this.textBoxWidth.TabIndex = 7;
            this.textBoxWidth.TextChanged += new System.EventHandler(this.widthTextBox_TextChanged);
            this.textBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.widthTextBox_KeyPress);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(0, 32);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(98, 20);
            this.textBoxHeight.TabIndex = 8;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.heightTextBox_TextChanged);
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Текст обтекает:";
            // 
            // leftRB
            // 
            this.leftRB.AutoSize = true;
            this.leftRB.Checked = true;
            this.leftRB.Location = new System.Drawing.Point(205, 7);
            this.leftRB.Name = "leftRB";
            this.leftRB.Size = new System.Drawing.Size(55, 17);
            this.leftRB.TabIndex = 10;
            this.leftRB.TabStop = true;
            this.leftRB.Text = "слева";
            this.leftRB.UseVisualStyleBackColor = true;
            this.leftRB.CheckedChanged += new System.EventHandler(this.sourceTextBox_TextChanged);
            // 
            // rightRB
            // 
            this.rightRB.AutoSize = true;
            this.rightRB.Location = new System.Drawing.Point(266, 7);
            this.rightRB.Name = "rightRB";
            this.rightRB.Size = new System.Drawing.Size(61, 17);
            this.rightRB.TabIndex = 11;
            this.rightRB.Text = "справа";
            this.rightRB.UseVisualStyleBackColor = true;
            this.rightRB.CheckedChanged += new System.EventHandler(this.sourceTextBox_TextChanged);
            // 
            // buttonDownloadImg
            // 
            this.buttonDownloadImg.Location = new System.Drawing.Point(428, 7);
            this.buttonDownloadImg.Name = "buttonDownloadImg";
            this.buttonDownloadImg.Size = new System.Drawing.Size(75, 23);
            this.buttonDownloadImg.TabIndex = 12;
            this.buttonDownloadImg.Text = "Скачать";
            this.buttonDownloadImg.UseVisualStyleBackColor = true;
            this.buttonDownloadImg.Click += new System.EventHandler(this.buttonDownloadImg_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(10, 208);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 13;
            // 
            // textBoxRatio
            // 
            this.textBoxRatio.Location = new System.Drawing.Point(194, 32);
            this.textBoxRatio.Name = "textBoxRatio";
            this.textBoxRatio.ReadOnly = true;
            this.textBoxRatio.Size = new System.Drawing.Size(66, 20);
            this.textBoxRatio.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Соотношение:";
            // 
            // buttonFromClipboard
            // 
            this.buttonFromClipboard.Location = new System.Drawing.Point(428, 10);
            this.buttonFromClipboard.Name = "buttonFromClipboard";
            this.buttonFromClipboard.Size = new System.Drawing.Size(75, 23);
            this.buttonFromClipboard.TabIndex = 16;
            this.buttonFromClipboard.Text = "Из буфера";
            this.buttonFromClipboard.UseVisualStyleBackColor = true;
            this.buttonFromClipboard.Click += new System.EventHandler(this.buttonFromClipboard_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 365);
            this.panel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ширина (px):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Высота (px):";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxAlt);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.comboBoxBorder);
            this.panel2.Controls.Add(this.textBoxWidth);
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Controls.Add(this.textBoxHeight);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxRatio);
            this.panel2.Controls.Add(this.leftRB);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.rightRB);
            this.panel2.Controls.Add(this.buttonDownloadImg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(80, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 147);
            this.panel2.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Описание:";
            // 
            // textBoxAlt
            // 
            this.textBoxAlt.Location = new System.Drawing.Point(69, 85);
            this.textBoxAlt.Name = "textBoxAlt";
            this.textBoxAlt.Size = new System.Drawing.Size(434, 20);
            this.textBoxAlt.TabIndex = 19;
            this.textBoxAlt.TextChanged += new System.EventHandler(this.sourceTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Пример";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Толщина рамки (px):";
            // 
            // comboBoxBorder
            // 
            this.comboBoxBorder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBorder.FormattingEnabled = true;
            this.comboBoxBorder.Items.AddRange(new object[] {
            "0 (нет)",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxBorder.Location = new System.Drawing.Point(194, 58);
            this.comboBoxBorder.Name = "comboBoxBorder";
            this.comboBoxBorder.Size = new System.Drawing.Size(66, 21);
            this.comboBoxBorder.TabIndex = 16;
            this.comboBoxBorder.SelectedIndexChanged += new System.EventHandler(this.comboBoxBorder_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.sourceTextBox);
            this.panel4.Controls.Add(this.buttonFromClipboard);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(80, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 36);
            this.panel4.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 365);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(603, 299);
            this.Name = "MainForm";
            this.Text = "Image Paster v0.1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton leftRB;
        private System.Windows.Forms.RadioButton rightRB;
        private System.Windows.Forms.Button buttonDownloadImg;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox textBoxRatio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonFromClipboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBoxBorder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAlt;
    }
}

