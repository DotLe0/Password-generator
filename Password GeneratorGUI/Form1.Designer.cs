
namespace Password_GeneratorGUI
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
            this.bnt_Generate = new System.Windows.Forms.Button();
            this.txtb_lenght = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chb_lower = new System.Windows.Forms.CheckBox();
            this.chb_capital = new System.Windows.Forms.CheckBox();
            this.chb_nums = new System.Windows.Forms.CheckBox();
            this.chb_symbols = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bnt_Generate
            // 
            this.bnt_Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bnt_Generate.Location = new System.Drawing.Point(380, 139);
            this.bnt_Generate.Name = "bnt_Generate";
            this.bnt_Generate.Size = new System.Drawing.Size(238, 43);
            this.bnt_Generate.TabIndex = 0;
            this.bnt_Generate.Text = "Generate password";
            this.bnt_Generate.UseVisualStyleBackColor = true;
            this.bnt_Generate.Click += new System.EventHandler(this.bnt_Generate_Click);
            // 
            // txtb_lenght
            // 
            this.txtb_lenght.Location = new System.Drawing.Point(177, 61);
            this.txtb_lenght.Name = "txtb_lenght";
            this.txtb_lenght.Size = new System.Drawing.Size(123, 20);
            this.txtb_lenght.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(59, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password lenght";
            // 
            // txtb_output
            // 
            this.txtb_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtb_output.Location = new System.Drawing.Point(62, 249);
            this.txtb_output.Name = "txtb_output";
            this.txtb_output.ReadOnly = true;
            this.txtb_output.Size = new System.Drawing.Size(556, 23);
            this.txtb_output.TabIndex = 3;
            this.txtb_output.Text = "You\'r password will be here";
            this.txtb_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(216, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customize your password";
            // 
            // chb_lower
            // 
            this.chb_lower.AutoSize = true;
            this.chb_lower.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_lower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.chb_lower.Location = new System.Drawing.Point(62, 105);
            this.chb_lower.Name = "chb_lower";
            this.chb_lower.Size = new System.Drawing.Size(108, 21);
            this.chb_lower.TabIndex = 5;
            this.chb_lower.Text = "Lower letters";
            this.chb_lower.UseVisualStyleBackColor = true;
            // 
            // chb_capital
            // 
            this.chb_capital.AutoSize = true;
            this.chb_capital.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_capital.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.chb_capital.Location = new System.Drawing.Point(62, 139);
            this.chb_capital.Name = "chb_capital";
            this.chb_capital.Size = new System.Drawing.Size(113, 21);
            this.chb_capital.TabIndex = 6;
            this.chb_capital.Text = "Capital letters";
            this.chb_capital.UseVisualStyleBackColor = true;
            // 
            // chb_nums
            // 
            this.chb_nums.AutoSize = true;
            this.chb_nums.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_nums.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.chb_nums.Location = new System.Drawing.Point(62, 172);
            this.chb_nums.Name = "chb_nums";
            this.chb_nums.Size = new System.Drawing.Size(84, 21);
            this.chb_nums.TabIndex = 7;
            this.chb_nums.Text = "Numbers";
            this.chb_nums.UseVisualStyleBackColor = true;
            // 
            // chb_symbols
            // 
            this.chb_symbols.AutoSize = true;
            this.chb_symbols.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_symbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.chb_symbols.Location = new System.Drawing.Point(62, 206);
            this.chb_symbols.Name = "chb_symbols";
            this.chb_symbols.Size = new System.Drawing.Size(128, 21);
            this.chb_symbols.TabIndex = 8;
            this.chb_symbols.Text = "Special symbols";
            this.chb_symbols.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 290);
            this.Controls.Add(this.chb_symbols);
            this.Controls.Add(this.chb_nums);
            this.Controls.Add(this.chb_capital);
            this.Controls.Add(this.chb_lower);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_lenght);
            this.Controls.Add(this.bnt_Generate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_Generate;
        private System.Windows.Forms.TextBox txtb_lenght;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chb_lower;
        private System.Windows.Forms.CheckBox chb_capital;
        private System.Windows.Forms.CheckBox chb_nums;
        private System.Windows.Forms.CheckBox chb_symbols;
    }
}

