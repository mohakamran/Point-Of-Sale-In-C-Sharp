namespace POS
{
    partial class delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete));
            this.label2 = new System.Windows.Forms.Label();
            this.p_id1 = new System.Windows.Forms.TextBox();
            this.pname = new System.Windows.Forms.TextBox();
            this.p_name1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product ID:";
            // 
            // p_id1
            // 
            this.p_id1.Location = new System.Drawing.Point(166, 64);
            this.p_id1.Name = "p_id1";
            this.p_id1.Size = new System.Drawing.Size(208, 20);
            this.p_id1.TabIndex = 2;
            // 
            // pname
            // 
            this.pname.Location = new System.Drawing.Point(166, 101);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(208, 20);
            this.pname.TabIndex = 4;
            // 
            // p_name1
            // 
            this.p_name1.AutoSize = true;
            this.p_name1.Location = new System.Drawing.Point(82, 104);
            this.p_name1.Name = "p_name1";
            this.p_name1.Size = new System.Drawing.Size(78, 13);
            this.p_name1.TabIndex = 3;
            this.p_name1.Text = "Product Name:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(198, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(441, 345);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.p_name1);
            this.Controls.Add(this.p_id1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox p_id1;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.Label p_name1;
        private System.Windows.Forms.Button button1;
    }
}