namespace FormHostingApp
{
    partial class Form2
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
            this.generate = new System.Windows.Forms.Button();
            this.Creditnumber = new System.Windows.Forms.Label();
            this.templatename = new System.Windows.Forms.Label();
            this.CreditNumberbox = new System.Windows.Forms.TextBox();
            this.templatenameBox = new System.Windows.Forms.TextBox();
            this.resBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(508, 461);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(263, 81);
            this.generate.TabIndex = 0;
            this.generate.Text = "Generate Template";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // Creditnumber
            // 
            this.Creditnumber.AutoSize = true;
            this.Creditnumber.Location = new System.Drawing.Point(198, 164);
            this.Creditnumber.Name = "Creditnumber";
            this.Creditnumber.Size = new System.Drawing.Size(173, 32);
            this.Creditnumber.TabIndex = 1;
            this.Creditnumber.Text = "Credit Number";
            // 
            // templatename
            // 
            this.templatename.AutoSize = true;
            this.templatename.Location = new System.Drawing.Point(198, 245);
            this.templatename.Name = "templatename";
            this.templatename.Size = new System.Drawing.Size(183, 32);
            this.templatename.TabIndex = 2;
            this.templatename.Text = "Template Name";
            // 
            // CreditNumberbox
            // 
            this.CreditNumberbox.Location = new System.Drawing.Point(489, 161);
            this.CreditNumberbox.Name = "CreditNumberbox";
            this.CreditNumberbox.Size = new System.Drawing.Size(200, 39);
            this.CreditNumberbox.TabIndex = 3;
            // 
            // templatenameBox
            // 
            this.templatenameBox.Location = new System.Drawing.Point(494, 246);
            this.templatenameBox.Name = "templatenameBox";
            this.templatenameBox.Size = new System.Drawing.Size(200, 39);
            this.templatenameBox.TabIndex = 4;
            // 
            // resBox
            // 
            this.resBox.Location = new System.Drawing.Point(508, 578);
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(667, 239);
            this.resBox.TabIndex = 5;
            this.resBox.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 935);
            this.Controls.Add(this.resBox);
            this.Controls.Add(this.templatenameBox);
            this.Controls.Add(this.CreditNumberbox);
            this.Controls.Add(this.templatename);
            this.Controls.Add(this.Creditnumber);
            this.Controls.Add(this.generate);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button generate;
        private Label Creditnumber;
        private Label templatename;
        private TextBox CreditNumberbox;
        private TextBox templatenameBox;
        private RichTextBox resBox;
    }
}