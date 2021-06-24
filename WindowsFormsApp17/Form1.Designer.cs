
namespace WindowsFormsApp17
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
            this.FigureComboBox = new System.Windows.Forms.ComboBox();
            this.emptybtn = new System.Windows.Forms.RadioButton();
            this.fillbtn = new System.Windows.Forms.RadioButton();
            this.colorbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // FigureComboBox
            // 
            this.FigureComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FigureComboBox.FormattingEnabled = true;
            this.FigureComboBox.Location = new System.Drawing.Point(13, 13);
            this.FigureComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.FigureComboBox.Name = "FigureComboBox";
            this.FigureComboBox.Size = new System.Drawing.Size(243, 38);
            this.FigureComboBox.TabIndex = 1;
            // 
            // emptybtn
            // 
            this.emptybtn.AutoSize = true;
            this.emptybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emptybtn.Location = new System.Drawing.Point(650, 17);
            this.emptybtn.Margin = new System.Windows.Forms.Padding(4);
            this.emptybtn.Name = "emptybtn";
            this.emptybtn.Size = new System.Drawing.Size(117, 35);
            this.emptybtn.TabIndex = 12;
            this.emptybtn.TabStop = true;
            this.emptybtn.Text = "Empty";
            this.emptybtn.UseVisualStyleBackColor = true;
            // 
            // fillbtn
            // 
            this.fillbtn.AutoSize = true;
            this.fillbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillbtn.Location = new System.Drawing.Point(559, 20);
            this.fillbtn.Margin = new System.Windows.Forms.Padding(4);
            this.fillbtn.Name = "fillbtn";
            this.fillbtn.Size = new System.Drawing.Size(74, 35);
            this.fillbtn.TabIndex = 11;
            this.fillbtn.TabStop = true;
            this.fillbtn.Text = "Fill";
            this.fillbtn.UseVisualStyleBackColor = true;
            // 
            // colorbtn
            // 
            this.colorbtn.AutoSize = true;
            this.colorbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorbtn.Location = new System.Drawing.Point(410, 13);
            this.colorbtn.Margin = new System.Windows.Forms.Padding(4);
            this.colorbtn.Name = "colorbtn";
            this.colorbtn.Size = new System.Drawing.Size(100, 43);
            this.colorbtn.TabIndex = 10;
            this.colorbtn.Text = "Click";
            this.colorbtn.UseVisualStyleBackColor = true;
            this.colorbtn.Click += new System.EventHandler(this.colorbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(296, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emptybtn);
            this.Controls.Add(this.fillbtn);
            this.Controls.Add(this.colorbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FigureComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FigureComboBox;
        private System.Windows.Forms.RadioButton emptybtn;
        private System.Windows.Forms.RadioButton fillbtn;
        private System.Windows.Forms.Button colorbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

