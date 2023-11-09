namespace ThreadFormTime
{
    partial class Control_panel
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDontShow = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(52, 29);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(204, 50);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "zobrazuj";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDontShow
            // 
            this.btnDontShow.Location = new System.Drawing.Point(52, 100);
            this.btnDontShow.Name = "btnDontShow";
            this.btnDontShow.Size = new System.Drawing.Size(203, 61);
            this.btnDontShow.TabIndex = 1;
            this.btnDontShow.Text = "nezobrazuj";
            this.btnDontShow.UseVisualStyleBackColor = true;
            this.btnDontShow.Click += new System.EventHandler(this.btnDontShow_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(52, 186);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(203, 55);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "konec";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Control_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 272);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDontShow);
            this.Controls.Add(this.btnShow);
            this.Name = "Control_panel";
            this.Text = "Control_Panel";
            this.Load += new System.EventHandler(this.Control_panel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDontShow;
        private System.Windows.Forms.Button btnClose;
    }
}

