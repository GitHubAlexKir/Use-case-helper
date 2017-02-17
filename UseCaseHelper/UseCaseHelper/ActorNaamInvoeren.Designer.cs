namespace UseCaseHelper
{
    partial class ActorNaamInvoeren
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
            this.Actornaamtextbox = new System.Windows.Forms.TextBox();
            this.Invoerbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Actornaamtextbox
            // 
            this.Actornaamtextbox.Location = new System.Drawing.Point(15, 29);
            this.Actornaamtextbox.Name = "Actornaamtextbox";
            this.Actornaamtextbox.Size = new System.Drawing.Size(166, 22);
            this.Actornaamtextbox.TabIndex = 0;
            // 
            // Invoerbtn
            // 
            this.Invoerbtn.Location = new System.Drawing.Point(196, 27);
            this.Invoerbtn.Name = "Invoerbtn";
            this.Invoerbtn.Size = new System.Drawing.Size(75, 26);
            this.Invoerbtn.TabIndex = 1;
            this.Invoerbtn.Text = "Invoeren";
            this.Invoerbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vul naam in van de actor.";
            // 
            // ActorNaamInvoeren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 122);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Invoerbtn);
            this.Controls.Add(this.Actornaamtextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ActorNaamInvoeren";
            this.Text = "ActorNaamInvoeren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Actornaamtextbox;
        private System.Windows.Forms.Button Invoerbtn;
        private System.Windows.Forms.Label label1;
    }
}