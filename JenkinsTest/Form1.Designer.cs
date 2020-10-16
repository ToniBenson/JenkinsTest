namespace JenkinsTEst
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbOperant1 = new System.Windows.Forms.TextBox();
            this.tbOperant2 = new System.Windows.Forms.TextBox();
            this.btAddition = new System.Windows.Forms.Button();
            this.btSubtraktion = new System.Windows.Forms.Button();
            this.btMultiplikation = new System.Windows.Forms.Button();
            this.btDivision = new System.Windows.Forms.Button();
            this.tbResultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version 1.0.1";
            // 
            // tbOperant1
            // 
            this.tbOperant1.Location = new System.Drawing.Point(34, 154);
            this.tbOperant1.Name = "tbOperant1";
            this.tbOperant1.Size = new System.Drawing.Size(86, 20);
            this.tbOperant1.TabIndex = 2;
            this.tbOperant1.Text = "0";
            this.tbOperant1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbOperant2
            // 
            this.tbOperant2.Location = new System.Drawing.Point(145, 154);
            this.tbOperant2.Name = "tbOperant2";
            this.tbOperant2.Size = new System.Drawing.Size(86, 20);
            this.tbOperant2.TabIndex = 3;
            this.tbOperant2.Text = "0";
            this.tbOperant2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btAddition
            // 
            this.btAddition.Location = new System.Drawing.Point(260, 107);
            this.btAddition.Name = "btAddition";
            this.btAddition.Size = new System.Drawing.Size(87, 24);
            this.btAddition.TabIndex = 4;
            this.btAddition.Text = "Addition";
            this.btAddition.UseVisualStyleBackColor = true;
            this.btAddition.Click += new System.EventHandler(this.btAddition_Click);
            // 
            // btSubtraktion
            // 
            this.btSubtraktion.Location = new System.Drawing.Point(260, 137);
            this.btSubtraktion.Name = "btSubtraktion";
            this.btSubtraktion.Size = new System.Drawing.Size(87, 24);
            this.btSubtraktion.TabIndex = 5;
            this.btSubtraktion.Text = "Subtraktion";
            this.btSubtraktion.UseVisualStyleBackColor = true;
            this.btSubtraktion.Click += new System.EventHandler(this.btSubtraktion_Click);
            // 
            // btMultiplikation
            // 
            this.btMultiplikation.Location = new System.Drawing.Point(260, 167);
            this.btMultiplikation.Name = "btMultiplikation";
            this.btMultiplikation.Size = new System.Drawing.Size(87, 24);
            this.btMultiplikation.TabIndex = 6;
            this.btMultiplikation.Text = "Multiplikation";
            this.btMultiplikation.UseVisualStyleBackColor = true;
            this.btMultiplikation.Click += new System.EventHandler(this.btMultiplikation_Click);
            // 
            // btDivision
            // 
            this.btDivision.Location = new System.Drawing.Point(260, 197);
            this.btDivision.Name = "btDivision";
            this.btDivision.Size = new System.Drawing.Size(87, 24);
            this.btDivision.TabIndex = 7;
            this.btDivision.Text = "Division";
            this.btDivision.UseVisualStyleBackColor = true;
            this.btDivision.Click += new System.EventHandler(this.btDivision_Click);
            // 
            // tbResultat
            // 
            this.tbResultat.Location = new System.Drawing.Point(376, 154);
            this.tbResultat.Name = "tbResultat";
            this.tbResultat.Size = new System.Drawing.Size(86, 20);
            this.tbResultat.TabIndex = 8;
            this.tbResultat.Text = "0";
            this.tbResultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbResultat);
            this.Controls.Add(this.btDivision);
            this.Controls.Add(this.btMultiplikation);
            this.Controls.Add(this.btSubtraktion);
            this.Controls.Add(this.btAddition);
            this.Controls.Add(this.tbOperant2);
            this.Controls.Add(this.tbOperant1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "get Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOperant1;
        private System.Windows.Forms.TextBox tbOperant2;
        private System.Windows.Forms.Button btAddition;
        private System.Windows.Forms.Button btSubtraktion;
        private System.Windows.Forms.Button btMultiplikation;
        private System.Windows.Forms.Button btDivision;
        private System.Windows.Forms.TextBox tbResultat;
    }
}

