namespace kafe3
{
    partial class Form5
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
            this.txtboxdakika = new System.Windows.Forms.TextBox();
            this.btndakikaekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkalan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtucret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masa Paneli";
            // 
            // txtboxdakika
            // 
            this.txtboxdakika.Location = new System.Drawing.Point(16, 168);
            this.txtboxdakika.Name = "txtboxdakika";
            this.txtboxdakika.Size = new System.Drawing.Size(122, 22);
            this.txtboxdakika.TabIndex = 2;
            // 
            // btndakikaekle
            // 
            this.btndakikaekle.Location = new System.Drawing.Point(16, 215);
            this.btndakikaekle.Name = "btndakikaekle";
            this.btndakikaekle.Size = new System.Drawing.Size(89, 38);
            this.btndakikaekle.TabIndex = 3;
            this.btndakikaekle.Text = "Ekle";
            this.btndakikaekle.UseVisualStyleBackColor = true;
            this.btndakikaekle.Click += new System.EventHandler(this.btndakikaekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(469, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Eklemek istediğiniz zamanı dakika cinsinden yazınız";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "1 DK 30 kuruş olarak ücretlendirilecektir";
            // 
            // txtkalan
            // 
            this.txtkalan.Location = new System.Drawing.Point(205, 223);
            this.txtkalan.Name = "txtkalan";
            this.txtkalan.Size = new System.Drawing.Size(100, 22);
            this.txtkalan.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Toplam dakikanız";
            // 
            // txtucret
            // 
            this.txtucret.Location = new System.Drawing.Point(369, 223);
            this.txtucret.Name = "txtucret";
            this.txtucret.Size = new System.Drawing.Size(102, 22);
            this.txtucret.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Toplam ücret";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 307);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtucret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtkalan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btndakikaekle);
            this.Controls.Add(this.txtboxdakika);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxdakika;
        private System.Windows.Forms.Button btndakikaekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkalan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtucret;
        private System.Windows.Forms.Label label5;
    }
}