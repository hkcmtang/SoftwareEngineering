
namespace TestGUIApp
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
            this.btClose = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btView = new System.Windows.Forms.Button();
            this.paMainMenu = new System.Windows.Forms.Panel();
            this.paAdd = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.paMainMenu.SuspendLayout();
            this.paAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(458, 317);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(121, 63);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(27, 21);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(121, 72);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btView
            // 
            this.btView.Location = new System.Drawing.Point(27, 119);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(111, 53);
            this.btView.TabIndex = 5;
            this.btView.Text = "View";
            this.btView.UseVisualStyleBackColor = true;
            // 
            // paMainMenu
            // 
            this.paMainMenu.Controls.Add(this.btAdd);
            this.paMainMenu.Controls.Add(this.btClose);
            this.paMainMenu.Controls.Add(this.btView);
            this.paMainMenu.Location = new System.Drawing.Point(30, 12);
            this.paMainMenu.Name = "paMainMenu";
            this.paMainMenu.Size = new System.Drawing.Size(642, 399);
            this.paMainMenu.TabIndex = 6;
            // 
            // paAdd
            // 
            this.paAdd.Controls.Add(this.button1);
            this.paAdd.Controls.Add(this.label1);
            this.paAdd.Location = new System.Drawing.Point(691, 33);
            this.paAdd.Name = "paAdd";
            this.paAdd.Size = new System.Drawing.Size(198, 337);
            this.paAdd.TabIndex = 7;
            this.paAdd.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "btBack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 464);
            this.Controls.Add(this.paAdd);
            this.Controls.Add(this.paMainMenu);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.paMainMenu.ResumeLayout(false);
            this.paAdd.ResumeLayout(false);
            this.paAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btView;
        private System.Windows.Forms.Panel paMainMenu;
        private System.Windows.Forms.Panel paAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

