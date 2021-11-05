
namespace OOP_Class_Constructor_Encapsulation_Inheritance
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
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_User = new System.Windows.Forms.Button();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.txt_UserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Customer
            // 
            this.btn_Customer.Location = new System.Drawing.Point(29, 12);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(75, 23);
            this.btn_Customer.TabIndex = 0;
            this.btn_Customer.Text = "Example_1";
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_User
            // 
            this.btn_User.Location = new System.Drawing.Point(169, 90);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(75, 23);
            this.btn_User.TabIndex = 1;
            this.btn_User.Text = "Example_2";
            this.btn_User.UseVisualStyleBackColor = true;
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // txt_FullName
            // 
            this.txt_FullName.Location = new System.Drawing.Point(182, 41);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(100, 20);
            this.txt_FullName.TabIndex = 2;
            // 
            // txt_UserId
            // 
            this.txt_UserId.Location = new System.Drawing.Point(169, 64);
            this.txt_UserId.Name = "txt_UserId";
            this.txt_UserId.Size = new System.Drawing.Size(100, 20);
            this.txt_UserId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Id:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_UserId);
            this.Controls.Add(this.txt_FullName);
            this.Controls.Add(this.btn_User);
            this.Controls.Add(this.btn_Customer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.TextBox txt_FullName;
        private System.Windows.Forms.TextBox txt_UserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

