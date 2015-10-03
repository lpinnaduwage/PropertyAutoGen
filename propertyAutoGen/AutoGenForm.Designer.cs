namespace propertyAutoGen
{
    partial class AutoGenForm
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
            this.classCode = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.methodType = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.methodCode = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GenerateClass = new System.Windows.Forms.Button();
            this.Database_Name = new System.Windows.Forms.ComboBox();
            this.nameOfTable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BLLObjectName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GenerateMethod = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // classCode
            // 
            this.classCode.BackColor = System.Drawing.Color.LightGray;
            this.classCode.Location = new System.Drawing.Point(6, 19);
            this.classCode.Name = "classCode";
            this.classCode.Size = new System.Drawing.Size(596, 177);
            this.classCode.TabIndex = 4;
            this.classCode.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.classCode);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 206);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GenerateMethod);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.methodType);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(12, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(608, 44);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Additional Methods";
            // 
            // methodType
            // 
            this.methodType.FormattingEnabled = true;
            this.methodType.Items.AddRange(new object[] {
            "Add",
            "Delete",
            "Update"});
            this.methodType.Location = new System.Drawing.Point(129, 16);
            this.methodType.Name = "methodType";
            this.methodType.Size = new System.Drawing.Size(148, 21);
            this.methodType.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.methodCode);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(12, 395);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(608, 227);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // methodCode
            // 
            this.methodCode.BackColor = System.Drawing.Color.LightGray;
            this.methodCode.Location = new System.Drawing.Point(6, 19);
            this.methodCode.Name = "methodCode";
            this.methodCode.Size = new System.Drawing.Size(596, 193);
            this.methodCode.TabIndex = 12;
            this.methodCode.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GenerateClass);
            this.groupBox1.Controls.Add(this.Database_Name);
            this.groupBox1.Controls.Add(this.nameOfTable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BLLObjectName);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // GenerateClass
            // 
            this.GenerateClass.Location = new System.Drawing.Point(501, 71);
            this.GenerateClass.Name = "GenerateClass";
            this.GenerateClass.Size = new System.Drawing.Size(101, 23);
            this.GenerateClass.TabIndex = 32;
            this.GenerateClass.Text = "Generate Class";
            this.GenerateClass.UseVisualStyleBackColor = true;
            this.GenerateClass.Click += new System.EventHandler(this.GenerateClass_Click);
            // 
            // Database_Name
            // 
            this.Database_Name.FormattingEnabled = true;
            this.Database_Name.Location = new System.Drawing.Point(140, 14);
            this.Database_Name.Name = "Database_Name";
            this.Database_Name.Size = new System.Drawing.Size(133, 21);
            this.Database_Name.TabIndex = 31;
            this.Database_Name.SelectedIndexChanged += new System.EventHandler(this.Database_Name_SelectedIndexChanged);
            // 
            // nameOfTable
            // 
            this.nameOfTable.FormattingEnabled = true;
            this.nameOfTable.Location = new System.Drawing.Point(140, 42);
            this.nameOfTable.Name = "nameOfTable";
            this.nameOfTable.Size = new System.Drawing.Size(133, 21);
            this.nameOfTable.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "BLL Object Name";
            // 
            // BLLObjectName
            // 
            this.BLLObjectName.Location = new System.Drawing.Point(140, 73);
            this.BLLObjectName.Name = "BLLObjectName";
            this.BLLObjectName.Size = new System.Drawing.Size(133, 20);
            this.BLLObjectName.TabIndex = 26;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(11, 45);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 13);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Table Name";
            // 
            // GenerateMethod
            // 
            this.GenerateMethod.Location = new System.Drawing.Point(501, 14);
            this.GenerateMethod.Name = "GenerateMethod";
            this.GenerateMethod.Size = new System.Drawing.Size(101, 23);
            this.GenerateMethod.TabIndex = 15;
            this.GenerateMethod.Text = "Generate Method";
            this.GenerateMethod.UseVisualStyleBackColor = true;
            this.GenerateMethod.Click += new System.EventHandler(this.GenerateMethod_Click);
            // 
            // AutoGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 634);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "AutoGenForm";
            this.Text = "AutoGen";
            this.Load += new System.EventHandler(this.AutoGenForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox classCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox methodType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox methodCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox nameOfTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BLLObjectName;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox Database_Name;
        private System.Windows.Forms.Button GenerateClass;
        private System.Windows.Forms.Button GenerateMethod;
    }
}

