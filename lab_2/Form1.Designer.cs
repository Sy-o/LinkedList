namespace lab_2
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
            this.inputItemBox = new System.Windows.Forms.TextBox();
            this.addBut = new System.Windows.Forms.Button();
            this.delBut = new System.Windows.Forms.Button();
            this.viewBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputItemBox
            // 
            this.inputItemBox.Location = new System.Drawing.Point(12, 12);
            this.inputItemBox.Name = "inputItemBox";
            this.inputItemBox.Size = new System.Drawing.Size(187, 20);
            this.inputItemBox.TabIndex = 0;
            // 
            // addBut
            // 
            this.addBut.Location = new System.Drawing.Point(12, 38);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(47, 20);
            this.addBut.TabIndex = 1;
            this.addBut.Text = "Add";
            this.addBut.UseVisualStyleBackColor = true;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // delBut
            // 
            this.delBut.Location = new System.Drawing.Point(152, 38);
            this.delBut.Name = "delBut";
            this.delBut.Size = new System.Drawing.Size(47, 20);
            this.delBut.TabIndex = 2;
            this.delBut.Text = "Delete";
            this.delBut.UseVisualStyleBackColor = true;
            this.delBut.Click += new System.EventHandler(this.delBut_Click);
            // 
            // viewBox
            // 
            this.viewBox.Location = new System.Drawing.Point(12, 94);
            this.viewBox.Multiline = true;
            this.viewBox.Name = "viewBox";
            this.viewBox.Size = new System.Drawing.Size(187, 249);
            this.viewBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "View List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewBox);
            this.Controls.Add(this.delBut);
            this.Controls.Add(this.addBut);
            this.Controls.Add(this.inputItemBox);
            this.Name = "Form1";
            this.Text = "LinkedList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputItemBox;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Button delBut;
        private System.Windows.Forms.TextBox viewBox;
        private System.Windows.Forms.Button button1;
    }
}

