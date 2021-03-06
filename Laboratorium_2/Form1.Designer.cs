
namespace Laboratorium_2
{
    partial class Form1
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.showValueButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.rootButton = new System.Windows.Forms.Button();
            this.reverseButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.activeMethodLabel = new System.Windows.Forms.Label();
            this.ctrlStatusLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.backgroundCheck = new System.Windows.Forms.CheckBox();
            this.fontColorCheck = new System.Windows.Forms.CheckBox();
            this.fontCheck = new System.Windows.Forms.CheckBox();
            this.btn_sortDouble = new System.Windows.Forms.Button();
            this.btn_sortString = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(28, 57);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(129, 20);
            this.inputBox.TabIndex = 0;
            // 
            // showValueButton
            // 
            this.showValueButton.Location = new System.Drawing.Point(449, 121);
            this.showValueButton.Name = "showValueButton";
            this.showValueButton.Size = new System.Drawing.Size(129, 23);
            this.showValueButton.TabIndex = 1;
            this.showValueButton.Text = "Show Value";
            this.showValueButton.UseVisualStyleBackColor = true;
            this.showValueButton.Click += new System.EventHandler(this.showValueButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(236, 57);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(129, 23);
            this.squareButton.TabIndex = 2;
            this.squareButton.Text = "Square";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // rootButton
            // 
            this.rootButton.Location = new System.Drawing.Point(236, 121);
            this.rootButton.Name = "rootButton";
            this.rootButton.Size = new System.Drawing.Size(129, 23);
            this.rootButton.TabIndex = 3;
            this.rootButton.Text = "Root";
            this.rootButton.UseVisualStyleBackColor = true;
            this.rootButton.Click += new System.EventHandler(this.rootButton_Click);
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(236, 185);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(129, 23);
            this.reverseButton.TabIndex = 4;
            this.reverseButton.Text = "Reverse";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(449, 57);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(129, 20);
            this.outputBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Active method:";
            // 
            // activeMethodLabel
            // 
            this.activeMethodLabel.AutoSize = true;
            this.activeMethodLabel.Location = new System.Drawing.Point(308, 41);
            this.activeMethodLabel.Name = "activeMethodLabel";
            this.activeMethodLabel.Size = new System.Drawing.Size(16, 13);
            this.activeMethodLabel.TabIndex = 9;
            this.activeMethodLabel.Text = "...";
            // 
            // ctrlStatusLabel
            // 
            this.ctrlStatusLabel.AutoSize = true;
            this.ctrlStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.ctrlStatusLabel.Location = new System.Drawing.Point(557, 258);
            this.ctrlStatusLabel.Name = "ctrlStatusLabel";
            this.ctrlStatusLabel.Size = new System.Drawing.Size(21, 13);
            this.ctrlStatusLabel.TabIndex = 11;
            this.ctrlStatusLabel.Text = "Off";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ctrl status:";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(29, 185);
            this.applyButton.Margin = new System.Windows.Forms.Padding(2);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(130, 23);
            this.applyButton.TabIndex = 13;
            this.applyButton.Text = "Apply Changes";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // backgroundCheck
            // 
            this.backgroundCheck.AutoSize = true;
            this.backgroundCheck.Location = new System.Drawing.Point(29, 121);
            this.backgroundCheck.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundCheck.Name = "backgroundCheck";
            this.backgroundCheck.Size = new System.Drawing.Size(151, 17);
            this.backgroundCheck.TabIndex = 14;
            this.backgroundCheck.Text = "Change Background Color";
            this.backgroundCheck.UseVisualStyleBackColor = true;
            // 
            // fontColorCheck
            // 
            this.fontColorCheck.AutoSize = true;
            this.fontColorCheck.Location = new System.Drawing.Point(30, 143);
            this.fontColorCheck.Margin = new System.Windows.Forms.Padding(2);
            this.fontColorCheck.Name = "fontColorCheck";
            this.fontColorCheck.Size = new System.Drawing.Size(141, 17);
            this.fontColorCheck.TabIndex = 15;
            this.fontColorCheck.Text = "Change Input Font Color";
            this.fontColorCheck.UseVisualStyleBackColor = true;
            // 
            // fontCheck
            // 
            this.fontCheck.AutoSize = true;
            this.fontCheck.Location = new System.Drawing.Point(30, 165);
            this.fontCheck.Margin = new System.Windows.Forms.Padding(2);
            this.fontCheck.Name = "fontCheck";
            this.fontCheck.Size = new System.Drawing.Size(114, 17);
            this.fontCheck.TabIndex = 16;
            this.fontCheck.Text = "Change Input Font";
            this.fontCheck.UseVisualStyleBackColor = true;
            // 
            // btn_sortDouble
            // 
            this.btn_sortDouble.Location = new System.Drawing.Point(30, 248);
            this.btn_sortDouble.Name = "btn_sortDouble";
            this.btn_sortDouble.Size = new System.Drawing.Size(129, 23);
            this.btn_sortDouble.TabIndex = 17;
            this.btn_sortDouble.Text = "Sort Double";
            this.btn_sortDouble.UseVisualStyleBackColor = true;
            this.btn_sortDouble.Click += new System.EventHandler(this.sortDouble_Click);
            // 
            // btn_sortString
            // 
            this.btn_sortString.Location = new System.Drawing.Point(236, 248);
            this.btn_sortString.Name = "btn_sortString";
            this.btn_sortString.Size = new System.Drawing.Size(129, 23);
            this.btn_sortString.TabIndex = 18;
            this.btn_sortString.Text = "Sort String";
            this.btn_sortString.UseVisualStyleBackColor = true;
            this.btn_sortString.Click += new System.EventHandler(this.btn_sortString_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(449, 185);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(129, 23);
            this.btn_Clear.TabIndex = 19;
            this.btn_Clear.Text = "Clear Input";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(605, 292);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_sortString);
            this.Controls.Add(this.btn_sortDouble);
            this.Controls.Add(this.fontCheck);
            this.Controls.Add(this.fontColorCheck);
            this.Controls.Add(this.backgroundCheck);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctrlStatusLabel);
            this.Controls.Add(this.activeMethodLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.rootButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.showValueButton);
            this.Controls.Add(this.inputBox);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Delegaty & Zdarzenia";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button showValueButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button rootButton;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label activeMethodLabel;
        private System.Windows.Forms.Label ctrlStatusLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.CheckBox backgroundCheck;
        private System.Windows.Forms.CheckBox fontColorCheck;
        private System.Windows.Forms.CheckBox fontCheck;
        private System.Windows.Forms.Button btn_sortDouble;
        private System.Windows.Forms.Button btn_sortString;
        private System.Windows.Forms.Button btn_Clear;
    }
}

