
namespace OOP_Repository
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
            this.grp_Create = new System.Windows.Forms.GroupBox();
            this.textbox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grp_Update = new System.Windows.Forms.GroupBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_FindById = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_UpdateFullName = new System.Windows.Forms.TextBox();
            this.txt_UpdateDescription = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.grp_Delete = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DeleteId = new System.Windows.Forms.TextBox();
            this.grp_Create.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grp_Update.SuspendLayout();
            this.grp_Delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Create
            // 
            this.grp_Create.Controls.Add(this.textbox);
            this.grp_Create.Controls.Add(this.label2);
            this.grp_Create.Controls.Add(this.label1);
            this.grp_Create.Controls.Add(this.txt_Id);
            this.grp_Create.Controls.Add(this.txt_FullName);
            this.grp_Create.Controls.Add(this.txt_Description);
            this.grp_Create.Controls.Add(this.btn_Create);
            this.grp_Create.Location = new System.Drawing.Point(0, 0);
            this.grp_Create.Name = "grp_Create";
            this.grp_Create.Size = new System.Drawing.Size(296, 150);
            this.grp_Create.TabIndex = 0;
            this.grp_Create.TabStop = false;
            this.grp_Create.Text = "Create";
            // 
            // textbox
            // 
            this.textbox.AutoSize = true;
            this.textbox.Location = new System.Drawing.Point(50, 16);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(19, 13);
            this.textbox.TabIndex = 2;
            this.textbox.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description:";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(75, 13);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 20);
            this.txt_Id.TabIndex = 1;
            // 
            // txt_FullName
            // 
            this.txt_FullName.Location = new System.Drawing.Point(75, 36);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(100, 20);
            this.txt_FullName.TabIndex = 1;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(75, 60);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(100, 20);
            this.txt_Description.TabIndex = 1;
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(56, 97);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 0;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 194);
            this.dataGridView1.TabIndex = 3;
            // 
            // grp_Update
            // 
            this.grp_Update.Controls.Add(this.btn_Find);
            this.grp_Update.Controls.Add(this.label5);
            this.grp_Update.Controls.Add(this.txt_FindById);
            this.grp_Update.Controls.Add(this.label3);
            this.grp_Update.Controls.Add(this.label4);
            this.grp_Update.Controls.Add(this.txt_UpdateFullName);
            this.grp_Update.Controls.Add(this.txt_UpdateDescription);
            this.grp_Update.Controls.Add(this.btn_Update);
            this.grp_Update.Location = new System.Drawing.Point(302, 0);
            this.grp_Update.Name = "grp_Update";
            this.grp_Update.Size = new System.Drawing.Size(296, 150);
            this.grp_Update.TabIndex = 0;
            this.grp_Update.TabStop = false;
            this.grp_Update.Text = "Update";
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(42, 45);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(75, 23);
            this.btn_Find.TabIndex = 5;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id:";
            // 
            // txt_FindById
            // 
            this.txt_FindById.Location = new System.Drawing.Point(31, 22);
            this.txt_FindById.Name = "txt_FindById";
            this.txt_FindById.Size = new System.Drawing.Size(100, 20);
            this.txt_FindById.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description:";
            // 
            // txt_UpdateFullName
            // 
            this.txt_UpdateFullName.Location = new System.Drawing.Point(169, 69);
            this.txt_UpdateFullName.Name = "txt_UpdateFullName";
            this.txt_UpdateFullName.Size = new System.Drawing.Size(100, 20);
            this.txt_UpdateFullName.TabIndex = 1;
            // 
            // txt_UpdateDescription
            // 
            this.txt_UpdateDescription.Location = new System.Drawing.Point(169, 95);
            this.txt_UpdateDescription.Name = "txt_UpdateDescription";
            this.txt_UpdateDescription.Size = new System.Drawing.Size(100, 20);
            this.txt_UpdateDescription.TabIndex = 1;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(194, 121);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 0;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // grp_Delete
            // 
            this.grp_Delete.Controls.Add(this.btn_Delete);
            this.grp_Delete.Controls.Add(this.label6);
            this.grp_Delete.Controls.Add(this.txt_DeleteId);
            this.grp_Delete.Location = new System.Drawing.Point(604, 12);
            this.grp_Delete.Name = "grp_Delete";
            this.grp_Delete.Size = new System.Drawing.Size(184, 132);
            this.grp_Delete.TabIndex = 0;
            this.grp_Delete.TabStop = false;
            this.grp_Delete.Text = "Delete";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(42, 45);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Id:";
            // 
            // txt_DeleteId
            // 
            this.txt_DeleteId.Location = new System.Drawing.Point(31, 22);
            this.txt_DeleteId.Name = "txt_DeleteId";
            this.txt_DeleteId.Size = new System.Drawing.Size(100, 20);
            this.txt_DeleteId.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grp_Delete);
            this.Controls.Add(this.grp_Update);
            this.Controls.Add(this.grp_Create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_Create.ResumeLayout(false);
            this.grp_Create.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grp_Update.ResumeLayout(false);
            this.grp_Update.PerformLayout();
            this.grp_Delete.ResumeLayout(false);
            this.grp_Delete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Create;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FullName;
        private System.Windows.Forms.GroupBox grp_Update;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_FindById;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_UpdateFullName;
        private System.Windows.Forms.TextBox txt_UpdateDescription;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.GroupBox grp_Delete;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_DeleteId;
        private System.Windows.Forms.Label textbox;
        private System.Windows.Forms.TextBox txt_Id;
    }
}

