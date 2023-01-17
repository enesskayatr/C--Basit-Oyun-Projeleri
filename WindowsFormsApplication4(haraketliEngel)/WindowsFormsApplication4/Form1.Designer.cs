namespace WindowsFormsApplication4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelengel = new System.Windows.Forms.Label();
            this.timerengelyukari = new System.Windows.Forms.Timer(this.components);
            this.timerengelasagi = new System.Windows.Forms.Timer(this.components);
            this.timersag = new System.Windows.Forms.Timer(this.components);
            this.timersol = new System.Windows.Forms.Timer(this.components);
            this.timeryukari = new System.Windows.Forms.Timer(this.components);
            this.timerasagi = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.at = new System.Windows.Forms.PictureBox();
            this.ateş = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.at)).BeginInit();
            this.SuspendLayout();
            // 
            // labelengel
            // 
            this.labelengel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelengel.Location = new System.Drawing.Point(431, 164);
            this.labelengel.Name = "labelengel";
            this.labelengel.Size = new System.Drawing.Size(22, 79);
            this.labelengel.TabIndex = 0;
            this.labelengel.Text = "label1";
            // 
            // timerengelyukari
            // 
            this.timerengelyukari.Interval = 1;
            this.timerengelyukari.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerengelasagi
            // 
            this.timerengelasagi.Interval = 1;
            this.timerengelasagi.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timersag
            // 
            this.timersag.Interval = 1;
            this.timersag.Tick += new System.EventHandler(this.timersag_Tick);
            // 
            // timersol
            // 
            this.timersol.Interval = 1;
            this.timersol.Tick += new System.EventHandler(this.timersol_Tick);
            // 
            // timeryukari
            // 
            this.timeryukari.Interval = 1;
            this.timeryukari.Tick += new System.EventHandler(this.timeryukari_Tick);
            // 
            // timerasagi
            // 
            this.timerasagi.Interval = 1;
            this.timerasagi.Tick += new System.EventHandler(this.timerasagi_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // at
            // 
            this.at.Image = ((System.Drawing.Image)(resources.GetObject("at.Image")));
            this.at.Location = new System.Drawing.Point(12, 226);
            this.at.Name = "at";
            this.at.Size = new System.Drawing.Size(86, 70);
            this.at.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.at.TabIndex = 1;
            this.at.TabStop = false;
            // 
            // ateş
            // 
            this.ateş.Interval = 1;
            this.ateş.Tick += new System.EventHandler(this.ateş_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 441);
            this.Controls.Add(this.at);
            this.Controls.Add(this.labelengel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.at)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelengel;
        private System.Windows.Forms.Timer timerengelyukari;
        private System.Windows.Forms.Timer timerengelasagi;
        private System.Windows.Forms.Timer timersag;
        private System.Windows.Forms.Timer timersol;
        private System.Windows.Forms.Timer timeryukari;
        private System.Windows.Forms.Timer timerasagi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox at;
        private System.Windows.Forms.Timer ateş;
    }
}

