namespace kafe3
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtmasano = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmasasifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btngirisyap = new System.Windows.Forms.Button();
            this.lblyanlisveri = new System.Windows.Forms.Label();
            this.lblyanlis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Paneli";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtmasano
            // 
            this.txtmasano.Location = new System.Drawing.Point(172, 122);
            this.txtmasano.Name = "txtmasano";
            this.txtmasano.Size = new System.Drawing.Size(120, 22);
            this.txtmasano.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Masa Numarası";
            // 
            // txtmasasifre
            // 
            this.txtmasasifre.Location = new System.Drawing.Point(172, 162);
            this.txtmasasifre.Name = "txtmasasifre";
            this.txtmasasifre.Size = new System.Drawing.Size(120, 22);
            this.txtmasasifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Masa Şifresi";
            // 
            // btngirisyap
            // 
            this.btngirisyap.Location = new System.Drawing.Point(159, 221);
            this.btngirisyap.Name = "btngirisyap";
            this.btngirisyap.Size = new System.Drawing.Size(75, 23);
            this.btngirisyap.TabIndex = 7;
            this.btngirisyap.Text = "Giriş Yap";
            this.btngirisyap.UseVisualStyleBackColor = true;
            this.btngirisyap.Click += new System.EventHandler(this.btngirisyap_Click);
            // 
            // lblyanlisveri
            // 
            this.lblyanlisveri.AutoSize = true;
            this.lblyanlisveri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyanlisveri.ForeColor = System.Drawing.Color.Red;
            this.lblyanlisveri.Location = new System.Drawing.Point(126, 199);
            this.lblyanlisveri.Name = "lblyanlisveri";
            this.lblyanlisveri.Size = new System.Drawing.Size(0, 16);
            this.lblyanlisveri.TabIndex = 8;
            // 
            // lblyanlis
            // 
            this.lblyanlis.AutoSize = true;
            this.lblyanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyanlis.ForeColor = System.Drawing.Color.Red;
            this.lblyanlis.Location = new System.Drawing.Point(22, 269);
            this.lblyanlis.Name = "lblyanlis";
            this.lblyanlis.Size = new System.Drawing.Size(0, 16);
            this.lblyanlis.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 294);
            this.Controls.Add(this.lblyanlis);
            this.Controls.Add(this.lblyanlisveri);
            this.Controls.Add(this.btngirisyap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmasasifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmasano);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtmasano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmasasifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btngirisyap;
        private System.Windows.Forms.Label lblyanlisveri;
        private System.Windows.Forms.Label lblyanlis;
    }
}