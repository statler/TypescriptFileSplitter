namespace TypescriptFileSplitter
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
            this.beDest = new DevExpress.XtraEditors.ButtonEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.meFileHeader = new DevExpress.XtraEditors.MemoEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.meURL = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.beDest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meFileHeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meURL.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // beDest
            // 
            this.beDest.EditValue = "C:\\Users\\dennisg\\Documents\\cpNet\\data";
            this.beDest.Location = new System.Drawing.Point(138, 125);
            this.beDest.Name = "beDest";
            this.beDest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beDest.Size = new System.Drawing.Size(365, 20);
            this.beDest.TabIndex = 3;
            this.beDest.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beDest_ButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dest Folder";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(428, 151);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Split";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // meFileHeader
            // 
            this.meFileHeader.EditValue = "/// <reference path=\"../cp.d.ts\" />";
            this.meFileHeader.Location = new System.Drawing.Point(138, 67);
            this.meFileHeader.Name = "meFileHeader";
            this.meFileHeader.Size = new System.Drawing.Size(363, 52);
            this.meFileHeader.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "File Header";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Swagger JSON";
            // 
            // meURL
            // 
            this.meURL.EditValue = "http://localhost:60000/swagger/v2/swagger.json";
            this.meURL.Location = new System.Drawing.Point(138, 9);
            this.meURL.Name = "meURL";
            this.meURL.Size = new System.Drawing.Size(363, 52);
            this.meURL.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 185);
            this.Controls.Add(this.meURL);
            this.Controls.Add(this.meFileHeader);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.beDest);
            this.Name = "Form1";
            this.Text = "File Splitter";
            ((System.ComponentModel.ISupportInitialize)(this.beDest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meFileHeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meURL.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.ButtonEdit beDest;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.MemoEdit meFileHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.MemoEdit meURL;
    }
}

