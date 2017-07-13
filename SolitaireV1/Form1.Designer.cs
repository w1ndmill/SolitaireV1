namespace SolitaireV1
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
            this.txt_CardViewer = new System.Windows.Forms.TextBox();
            this.btn_GenerateDeck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_CardViewer
            // 
            this.txt_CardViewer.Location = new System.Drawing.Point(12, 12);
            this.txt_CardViewer.Multiline = true;
            this.txt_CardViewer.Name = "txt_CardViewer";
            this.txt_CardViewer.ReadOnly = true;
            this.txt_CardViewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_CardViewer.Size = new System.Drawing.Size(593, 437);
            this.txt_CardViewer.TabIndex = 0;
            // 
            // btn_GenerateDeck
            // 
            this.btn_GenerateDeck.Location = new System.Drawing.Point(673, 32);
            this.btn_GenerateDeck.Name = "btn_GenerateDeck";
            this.btn_GenerateDeck.Size = new System.Drawing.Size(190, 122);
            this.btn_GenerateDeck.TabIndex = 1;
            this.btn_GenerateDeck.Text = "Generate";
            this.btn_GenerateDeck.UseVisualStyleBackColor = true;
            this.btn_GenerateDeck.Click += new System.EventHandler(this.btn_GenerateDeck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(634, 168);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(50, 10, 50, 150);
            this.label1.Size = new System.Drawing.Size(137, 175);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(634, 202);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(50, 10, 50, 150);
            this.label2.Size = new System.Drawing.Size(137, 175);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(634, 236);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(50, 10, 50, 150);
            this.label3.Size = new System.Drawing.Size(137, 175);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(824, 274);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(50, 10, 50, 150);
            this.label4.Size = new System.Drawing.Size(137, 175);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            this.label4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 482);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GenerateDeck);
            this.Controls.Add(this.txt_CardViewer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CardViewer;
        private System.Windows.Forms.Button btn_GenerateDeck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

