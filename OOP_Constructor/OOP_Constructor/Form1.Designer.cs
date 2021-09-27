
namespace OOP_Constructor
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Example1 = new System.Windows.Forms.Button();
            this.btn_Example3 = new System.Windows.Forms.Button();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Example2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.btn_Example4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Example1
            // 
            this.btn_Example1.Location = new System.Drawing.Point(46, 12);
            this.btn_Example1.Name = "btn_Example1";
            this.btn_Example1.Size = new System.Drawing.Size(75, 23);
            this.btn_Example1.TabIndex = 0;
            this.btn_Example1.Text = "Example_1";
            this.btn_Example1.UseVisualStyleBackColor = true;
            this.btn_Example1.Click += new System.EventHandler(this.btn_Example1_Click);
            // 
            // btn_Example3
            // 
            this.btn_Example3.Location = new System.Drawing.Point(210, 152);
            this.btn_Example3.Name = "btn_Example3";
            this.btn_Example3.Size = new System.Drawing.Size(75, 23);
            this.btn_Example3.TabIndex = 1;
            this.btn_Example3.Text = "Example3";
            this.btn_Example3.UseVisualStyleBackColor = true;
            this.btn_Example3.Click += new System.EventHandler(this.btn_Example3_Click);

                // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(160, 22);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(60, 13);
            this.lbl_FirstName.TabIndex = 2;
            this.lbl_FirstName.Text = "First Name:";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(226, 22);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(100, 20);
            this.txt_FirstName.TabIndex = 3;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(226, 48);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(100, 20);
            this.txt_LastName.TabIndex = 3;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(185, 74);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 20);
            this.txt_Id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id:";
            // 
            // btn_Example2
            // 
            this.btn_Example2.Location = new System.Drawing.Point(212, 123);
            this.btn_Example2.Name = "btn_Example2";
            this.btn_Example2.Size = new System.Drawing.Size(75, 23);
            this.btn_Example2.TabIndex = 1;
            this.btn_Example2.Text = "Example_2";
            this.btn_Example2.UseVisualStyleBackColor = true;
            this.btn_Example2.Click += new System.EventHandler(this.btn_Example2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "City:";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(193, 100);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(100, 20);
            this.txt_City.TabIndex = 3;
            // 
            // btn_Example4
            // 
            this.btn_Example4.Location = new System.Drawing.Point(212, 181);
            this.btn_Example4.Name = "btn_Example4";
            this.btn_Example4.Size = new System.Drawing.Size(75, 23);
            this.btn_Example4.TabIndex = 4;
            this.btn_Example4.Text = "Example4";
            this.btn_Example4.UseVisualStyleBackColor = true;
            this.btn_Example4.Click += new System.EventHandler(this.btn_Example4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Example4);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.btn_Example2);
            this.Controls.Add(this.btn_Example3);
            this.Controls.Add(this.btn_Example1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Example1;
        private System.Windows.Forms.Button btn_Example3;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Example2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Button btn_Example4;
    }
}

