namespace ProjetoCSGrupo
{
    partial class frmAlerta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlerta));
            this.lblMsg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picSimbolo = new System.Windows.Forms.PictureBox();
            this.picCancel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSimbolo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.Location = new System.Drawing.Point(65, 22);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(116, 21);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "Message Text";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picSimbolo
            // 
            this.picSimbolo.Image = global::ProjetoCSGrupo.Properties.Resources.errornovo;
            this.picSimbolo.Location = new System.Drawing.Point(12, 13);
            this.picSimbolo.Name = "picSimbolo";
            this.picSimbolo.Size = new System.Drawing.Size(41, 39);
            this.picSimbolo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSimbolo.TabIndex = 5;
            this.picSimbolo.TabStop = false;
            // 
            // picCancel
            // 
            this.picCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCancel.Image = global::ProjetoCSGrupo.Properties.Resources.icons8_cancel_25px1;
            this.picCancel.Location = new System.Drawing.Point(378, 22);
            this.picCancel.Name = "picCancel";
            this.picCancel.Size = new System.Drawing.Size(26, 30);
            this.picCancel.TabIndex = 4;
            this.picCancel.TabStop = false;
            this.picCancel.Click += new System.EventHandler(this.picCancel_Click);
            // 
            // frmAlerta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(416, 70);
            this.Controls.Add(this.picSimbolo);
            this.Controls.Add(this.picCancel);
            this.Controls.Add(this.lblMsg);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlerta";
            this.ShowInTaskbar = false;
            this.Text = "Notificação";
            this.Load += new System.EventHandler(this.frmAlerta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSimbolo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picCancel;
        private System.Windows.Forms.PictureBox picSimbolo;
    }
}