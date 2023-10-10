namespace NobelDijGUI
{
    partial class FrmNobelDij
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
            lblUI01 = new Label();
            tbxEv = new TextBox();
            btnMentes = new Button();
            lblUI02 = new Label();
            tbxNev = new TextBox();
            lblUI03 = new Label();
            tbxSzH = new TextBox();
            lblUI04 = new Label();
            tbxOrszag = new TextBox();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(51, 25);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(43, 32);
            lblUI01.TabIndex = 100;
            lblUI01.Text = "Év:";
            // 
            // tbxEv
            // 
            tbxEv.Location = new Point(219, 22);
            tbxEv.Name = "tbxEv";
            tbxEv.Size = new Size(125, 39);
            tbxEv.TabIndex = 0;
            // 
            // btnMentes
            // 
            btnMentes.Location = new Point(12, 297);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(513, 66);
            btnMentes.TabIndex = 4;
            btnMentes.Text = "Adatok mentése";
            btnMentes.UseVisualStyleBackColor = true;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(51, 96);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(62, 32);
            lblUI02.TabIndex = 100;
            lblUI02.Text = "Név:";
            // 
            // tbxNev
            // 
            tbxNev.Location = new Point(219, 93);
            tbxNev.Name = "tbxNev";
            tbxNev.Size = new Size(306, 39);
            tbxNev.TabIndex = 1;
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Location = new Point(51, 167);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(68, 32);
            lblUI03.TabIndex = 100;
            lblUI03.Text = "Sz/H:";
            // 
            // tbxSzH
            // 
            tbxSzH.Location = new Point(219, 164);
            tbxSzH.Name = "tbxSzH";
            tbxSzH.Size = new Size(207, 39);
            tbxSzH.TabIndex = 2;
            // 
            // lblUI04
            // 
            lblUI04.AutoSize = true;
            lblUI04.Location = new Point(51, 238);
            lblUI04.Name = "lblUI04";
            lblUI04.Size = new Size(92, 32);
            lblUI04.TabIndex = 100;
            lblUI04.Text = "Ország:";
            // 
            // tbxOrszag
            // 
            tbxOrszag.Location = new Point(219, 235);
            tbxOrszag.Name = "tbxOrszag";
            tbxOrszag.Size = new Size(125, 39);
            tbxOrszag.TabIndex = 3;
            // 
            // FrmNobelDij
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 389);
            Controls.Add(btnMentes);
            Controls.Add(tbxOrszag);
            Controls.Add(lblUI04);
            Controls.Add(tbxSzH);
            Controls.Add(lblUI03);
            Controls.Add(tbxNev);
            Controls.Add(lblUI02);
            Controls.Add(tbxEv);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FrmNobelDij";
            Text = "Orvosi Nobel-díjasok";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private TextBox tbxEv;
        private Button btnMentes;
        private Label lblUI02;
        private TextBox tbxNev;
        private Label lblUI03;
        private TextBox tbxSzH;
        private Label lblUI04;
        private TextBox tbxOrszag;
    }
}