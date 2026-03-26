namespace Bewertungstool
{
    partial class FrmMain
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
            lbxNotenKurz = new ListBox();
            tbxPunkteMoeglich = new TextBox();
            tbxPunkteErreicht = new TextBox();
            btnNoteErzeugen = new Button();
            lblPunkteErreicht = new Label();
            lblPunkteMoeglich = new Label();
            cbxPunkteMoeglichBehalten = new CheckBox();
            SuspendLayout();
            // 
            // lbxNotenKurz
            // 
            lbxNotenKurz.FormattingEnabled = true;
            lbxNotenKurz.Location = new Point(326, 75);
            lbxNotenKurz.Name = "lbxNotenKurz";
            lbxNotenKurz.Size = new Size(94, 308);
            lbxNotenKurz.TabIndex = 0;
            // 
            // tbxPunkteMoeglich
            // 
            tbxPunkteMoeglich.Location = new Point(170, 75);
            tbxPunkteMoeglich.Name = "tbxPunkteMoeglich";
            tbxPunkteMoeglich.Size = new Size(56, 26);
            tbxPunkteMoeglich.TabIndex = 1;
            // 
            // tbxPunkteErreicht
            // 
            tbxPunkteErreicht.Location = new Point(167, 112);
            tbxPunkteErreicht.Name = "tbxPunkteErreicht";
            tbxPunkteErreicht.Size = new Size(59, 26);
            tbxPunkteErreicht.TabIndex = 2;
            tbxPunkteErreicht.KeyDown += tbxPunkteErreicht_KeyDown;
            // 
            // btnNoteErzeugen
            // 
            btnNoteErzeugen.Location = new Point(52, 229);
            btnNoteErzeugen.Name = "btnNoteErzeugen";
            btnNoteErzeugen.Size = new Size(190, 37);
            btnNoteErzeugen.TabIndex = 3;
            btnNoteErzeugen.Text = "Note erzeugen";
            btnNoteErzeugen.UseVisualStyleBackColor = true;
            btnNoteErzeugen.Click += btnNoteErzeugen_Click;
            // 
            // lblPunkteErreicht
            // 
            lblPunkteErreicht.AutoSize = true;
            lblPunkteErreicht.Location = new Point(52, 119);
            lblPunkteErreicht.Name = "lblPunkteErreicht";
            lblPunkteErreicht.Size = new Size(109, 19);
            lblPunkteErreicht.TabIndex = 4;
            lblPunkteErreicht.Text = "Erreichte Punkte";
            // 
            // lblPunkteMoeglich
            // 
            lblPunkteMoeglich.AutoSize = true;
            lblPunkteMoeglich.Location = new Point(54, 78);
            lblPunkteMoeglich.Name = "lblPunkteMoeglich";
            lblPunkteMoeglich.Size = new Size(112, 19);
            lblPunkteMoeglich.TabIndex = 5;
            lblPunkteMoeglich.Text = "Mögliche Punkte";
            // 
            // cbxPunkteMoeglichBehalten
            // 
            cbxPunkteMoeglichBehalten.AutoSize = true;
            cbxPunkteMoeglichBehalten.Location = new Point(54, 200);
            cbxPunkteMoeglichBehalten.Name = "cbxPunkteMoeglichBehalten";
            cbxPunkteMoeglichBehalten.Size = new Size(188, 23);
            cbxPunkteMoeglichBehalten.TabIndex = 6;
            cbxPunkteMoeglichBehalten.Text = "Mögliche Punkte behalten";
            cbxPunkteMoeglichBehalten.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbxPunkteMoeglichBehalten);
            Controls.Add(lblPunkteMoeglich);
            Controls.Add(lblPunkteErreicht);
            Controls.Add(btnNoteErzeugen);
            Controls.Add(tbxPunkteErreicht);
            Controls.Add(tbxPunkteMoeglich);
            Controls.Add(lbxNotenKurz);
            Name = "FrmMain";
            Text = "FrmMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxNotenKurz;
        private TextBox tbxPunkteMoeglich;
        private TextBox tbxPunkteErreicht;
        private Button btnNoteErzeugen;
        private Label lblPunkteErreicht;
        private Label lblPunkteMoeglich;
        private CheckBox cbxPunkteMoeglichBehalten;
    }
}