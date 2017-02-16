namespace UseCaseHelper
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
            this.panel = new System.Windows.Forms.Panel();
            this.ModesgroupBox = new System.Windows.Forms.GroupBox();
            this.Createbtn = new System.Windows.Forms.RadioButton();
            this.Selectbtn = new System.Windows.Forms.RadioButton();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Removebtn = new System.Windows.Forms.Button();
            this.ElementengroupBox = new System.Windows.Forms.GroupBox();
            this.Actorbtn = new System.Windows.Forms.RadioButton();
            this.Usecasebtn = new System.Windows.Forms.RadioButton();
            this.Linebtn = new System.Windows.Forms.RadioButton();
            this.ModesgroupBox.SuspendLayout();
            this.ElementengroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Location = new System.Drawing.Point(12, 118);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(700, 600);
            this.panel.TabIndex = 14;
            // 
            // ModesgroupBox
            // 
            this.ModesgroupBox.Controls.Add(this.Createbtn);
            this.ModesgroupBox.Controls.Add(this.Selectbtn);
            this.ModesgroupBox.Location = new System.Drawing.Point(132, 12);
            this.ModesgroupBox.Name = "ModesgroupBox";
            this.ModesgroupBox.Size = new System.Drawing.Size(114, 100);
            this.ModesgroupBox.TabIndex = 13;
            this.ModesgroupBox.TabStop = false;
            this.ModesgroupBox.Text = "Modes";
            // 
            // Createbtn
            // 
            this.Createbtn.AutoSize = true;
            this.Createbtn.Checked = true;
            this.Createbtn.Location = new System.Drawing.Point(6, 19);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(56, 17);
            this.Createbtn.TabIndex = 2;
            this.Createbtn.TabStop = true;
            this.Createbtn.Text = "Create";
            this.Createbtn.UseVisualStyleBackColor = true;
            // 
            // Selectbtn
            // 
            this.Selectbtn.AutoSize = true;
            this.Selectbtn.Location = new System.Drawing.Point(6, 42);
            this.Selectbtn.Name = "Selectbtn";
            this.Selectbtn.Size = new System.Drawing.Size(55, 17);
            this.Selectbtn.TabIndex = 1;
            this.Selectbtn.Text = "Select";
            this.Selectbtn.UseVisualStyleBackColor = true;
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(641, 12);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(75, 23);
            this.Clearbtn.TabIndex = 12;
            this.Clearbtn.Text = "Clear all";
            this.Clearbtn.UseVisualStyleBackColor = true;
            // 
            // Removebtn
            // 
            this.Removebtn.Location = new System.Drawing.Point(641, 41);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(75, 23);
            this.Removebtn.TabIndex = 11;
            this.Removebtn.Text = "Remove";
            this.Removebtn.UseVisualStyleBackColor = true;
            // 
            // ElementengroupBox
            // 
            this.ElementengroupBox.Controls.Add(this.Actorbtn);
            this.ElementengroupBox.Controls.Add(this.Usecasebtn);
            this.ElementengroupBox.Controls.Add(this.Linebtn);
            this.ElementengroupBox.Location = new System.Drawing.Point(12, 12);
            this.ElementengroupBox.Name = "ElementengroupBox";
            this.ElementengroupBox.Size = new System.Drawing.Size(114, 100);
            this.ElementengroupBox.TabIndex = 10;
            this.ElementengroupBox.TabStop = false;
            this.ElementengroupBox.Text = "Elementen";
            // 
            // Actorbtn
            // 
            this.Actorbtn.AutoSize = true;
            this.Actorbtn.Checked = true;
            this.Actorbtn.Location = new System.Drawing.Point(15, 19);
            this.Actorbtn.Name = "Actorbtn";
            this.Actorbtn.Size = new System.Drawing.Size(50, 17);
            this.Actorbtn.TabIndex = 5;
            this.Actorbtn.TabStop = true;
            this.Actorbtn.Text = "Actor";
            this.Actorbtn.UseVisualStyleBackColor = true;
            // 
            // Usecasebtn
            // 
            this.Usecasebtn.AutoSize = true;
            this.Usecasebtn.Location = new System.Drawing.Point(15, 42);
            this.Usecasebtn.Name = "Usecasebtn";
            this.Usecasebtn.Size = new System.Drawing.Size(70, 17);
            this.Usecasebtn.TabIndex = 4;
            this.Usecasebtn.Text = "Use case";
            this.Usecasebtn.UseVisualStyleBackColor = true;
            // 
            // Linebtn
            // 
            this.Linebtn.AutoSize = true;
            this.Linebtn.Location = new System.Drawing.Point(15, 65);
            this.Linebtn.Name = "Linebtn";
            this.Linebtn.Size = new System.Drawing.Size(45, 17);
            this.Linebtn.TabIndex = 3;
            this.Linebtn.Text = "Line";
            this.Linebtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 732);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.ModesgroupBox);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Removebtn);
            this.Controls.Add(this.ElementengroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ModesgroupBox.ResumeLayout(false);
            this.ModesgroupBox.PerformLayout();
            this.ElementengroupBox.ResumeLayout(false);
            this.ElementengroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox ModesgroupBox;
        private System.Windows.Forms.RadioButton Createbtn;
        private System.Windows.Forms.RadioButton Selectbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Removebtn;
        private System.Windows.Forms.GroupBox ElementengroupBox;
        private System.Windows.Forms.RadioButton Actorbtn;
        private System.Windows.Forms.RadioButton Usecasebtn;
        private System.Windows.Forms.RadioButton Linebtn;
    }
}

