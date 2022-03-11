
namespace TaskbarTidal
{
    partial class MainFrame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.colorMainForm = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoEllipsis = true;
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(33, 1);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblOutput.Size = new System.Drawing.Size(103, 27);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "Feincraft Tidy";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOutput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFrame_MouseDown);
            this.lblOutput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainFrame_MouseMove);
            // 
            // lblState
            // 
            this.lblState.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(0, 1);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(36, 35);
            this.lblState.TabIndex = 0;
            this.lblState.Text = "<";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorMainForm
            // 
            this.colorMainForm.AnyColor = true;
            this.colorMainForm.FullOpen = true;
            this.colorMainForm.SolidColorOnly = true;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(575, 35);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblOutput);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tidy";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrame_FormClosing);
            this.Shown += new System.EventHandler(this.MainFrame_Shown);
            this.DoubleClick += new System.EventHandler(this.MainFrame_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFrame_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFrame_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainFrame_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ColorDialog colorMainForm;
    }
}

