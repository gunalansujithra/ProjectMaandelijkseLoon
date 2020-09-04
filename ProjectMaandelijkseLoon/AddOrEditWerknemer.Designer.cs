namespace ProjectMaandelijkseLoon
{
    partial class AddOrEditWerknemer
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.rbVrouw = new System.Windows.Forms.RadioButton();
            this.dtpGeboorte = new System.Windows.Forms.DateTimePicker();
            this.mtbRijksNummer = new System.Windows.Forms.MaskedTextBox();
            this.dtpIndiensttreding = new System.Windows.Forms.DateTimePicker();
            this.mtbIban = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbFuncties = new System.Windows.Forms.ComboBox();
            this.cbContractType = new System.Windows.Forms.ComboBox();
            this.epNaam = new System.Windows.Forms.ErrorProvider(this.components);
            this.epGeslacht = new System.Windows.Forms.ErrorProvider(this.components);
            this.epGeboorte = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRijks = new System.Windows.Forms.ErrorProvider(this.components);
            this.epIban = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFunctie = new System.Windows.Forms.ErrorProvider(this.components);
            this.epContract = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbBedrijfsWagen = new System.Windows.Forms.ComboBox();
            this.lblBedrijfsWagen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epNaam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGeslacht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGeboorte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRijks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFunctie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epContract)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "IBAN Nummer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Datum van Indiensttreding ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rijksregisternummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Geboortedatum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Geslacht";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Naam";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(291, 72);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(200, 22);
            this.txtNaam.TabIndex = 13;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(297, 123);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(56, 21);
            this.rbMan.TabIndex = 14;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Man";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rbVrouw
            // 
            this.rbVrouw.AutoSize = true;
            this.rbVrouw.Location = new System.Drawing.Point(359, 123);
            this.rbVrouw.Name = "rbVrouw";
            this.rbVrouw.Size = new System.Drawing.Size(68, 21);
            this.rbVrouw.TabIndex = 15;
            this.rbVrouw.TabStop = true;
            this.rbVrouw.Text = "Vrouw";
            this.rbVrouw.UseVisualStyleBackColor = true;
            // 
            // dtpGeboorte
            // 
            this.dtpGeboorte.Location = new System.Drawing.Point(291, 169);
            this.dtpGeboorte.Name = "dtpGeboorte";
            this.dtpGeboorte.Size = new System.Drawing.Size(200, 22);
            this.dtpGeboorte.TabIndex = 16;
            // 
            // mtbRijksNummer
            // 
            this.mtbRijksNummer.Location = new System.Drawing.Point(291, 208);
            this.mtbRijksNummer.Mask = "000000-00-00";
            this.mtbRijksNummer.Name = "mtbRijksNummer";
            this.mtbRijksNummer.Size = new System.Drawing.Size(200, 22);
            this.mtbRijksNummer.TabIndex = 17;
            // 
            // dtpIndiensttreding
            // 
            this.dtpIndiensttreding.Location = new System.Drawing.Point(293, 257);
            this.dtpIndiensttreding.Name = "dtpIndiensttreding";
            this.dtpIndiensttreding.Size = new System.Drawing.Size(200, 22);
            this.dtpIndiensttreding.TabIndex = 18;
            // 
            // mtbIban
            // 
            this.mtbIban.Location = new System.Drawing.Point(293, 306);
            this.mtbIban.Mask = "BE00 0000 0000 0000";
            this.mtbIban.Name = "mtbIban";
            this.mtbIban.Size = new System.Drawing.Size(200, 22);
            this.mtbIban.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(151, 520);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 39);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(291, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 39);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Functies";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Contract Type";
            // 
            // cbFuncties
            // 
            this.cbFuncties.FormattingEnabled = true;
            this.cbFuncties.Location = new System.Drawing.Point(293, 356);
            this.cbFuncties.Name = "cbFuncties";
            this.cbFuncties.Size = new System.Drawing.Size(200, 24);
            this.cbFuncties.TabIndex = 24;
            this.cbFuncties.SelectedIndexChanged += new System.EventHandler(this.cbFuncties_SelectedIndexChanged);
            // 
            // cbContractType
            // 
            this.cbContractType.FormattingEnabled = true;
            this.cbContractType.Location = new System.Drawing.Point(293, 408);
            this.cbContractType.Name = "cbContractType";
            this.cbContractType.Size = new System.Drawing.Size(200, 24);
            this.cbContractType.TabIndex = 25;
            // 
            // epNaam
            // 
            this.epNaam.ContainerControl = this;
            // 
            // epGeslacht
            // 
            this.epGeslacht.ContainerControl = this;
            // 
            // epGeboorte
            // 
            this.epGeboorte.ContainerControl = this;
            // 
            // epRijks
            // 
            this.epRijks.ContainerControl = this;
            // 
            // epIban
            // 
            this.epIban.ContainerControl = this;
            // 
            // epFunctie
            // 
            this.epFunctie.ContainerControl = this;
            // 
            // epContract
            // 
            this.epContract.ContainerControl = this;
            // 
            // cbBedrijfsWagen
            // 
            this.cbBedrijfsWagen.FormattingEnabled = true;
            this.cbBedrijfsWagen.Location = new System.Drawing.Point(293, 462);
            this.cbBedrijfsWagen.Name = "cbBedrijfsWagen";
            this.cbBedrijfsWagen.Size = new System.Drawing.Size(200, 24);
            this.cbBedrijfsWagen.TabIndex = 27;
            // 
            // lblBedrijfsWagen
            // 
            this.lblBedrijfsWagen.AutoSize = true;
            this.lblBedrijfsWagen.Location = new System.Drawing.Point(110, 465);
            this.lblBedrijfsWagen.Name = "lblBedrijfsWagen";
            this.lblBedrijfsWagen.Size = new System.Drawing.Size(100, 17);
            this.lblBedrijfsWagen.TabIndex = 26;
            this.lblBedrijfsWagen.Text = "BedrijfsWagen";
            // 
            // AddOrEditWerknemer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 634);
            this.Controls.Add(this.cbBedrijfsWagen);
            this.Controls.Add(this.lblBedrijfsWagen);
            this.Controls.Add(this.cbContractType);
            this.Controls.Add(this.cbFuncties);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.mtbIban);
            this.Controls.Add(this.dtpIndiensttreding);
            this.Controls.Add(this.mtbRijksNummer);
            this.Controls.Add(this.dtpGeboorte);
            this.Controls.Add(this.rbVrouw);
            this.Controls.Add(this.rbMan);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOrEditWerknemer";
            this.Text = "AddOrEditWerknemer";
            this.Load += new System.EventHandler(this.AddOrEditWerknemer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epNaam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGeslacht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGeboorte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRijks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFunctie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epContract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.RadioButton rbVrouw;
        private System.Windows.Forms.DateTimePicker dtpGeboorte;
        private System.Windows.Forms.MaskedTextBox mtbRijksNummer;
        private System.Windows.Forms.DateTimePicker dtpIndiensttreding;
        private System.Windows.Forms.MaskedTextBox mtbIban;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbFuncties;
        private System.Windows.Forms.ComboBox cbContractType;
        private System.Windows.Forms.ErrorProvider epNaam;
        private System.Windows.Forms.ErrorProvider epGeslacht;
        private System.Windows.Forms.ErrorProvider epGeboorte;
        private System.Windows.Forms.ErrorProvider epRijks;
        private System.Windows.Forms.ErrorProvider epIban;
        private System.Windows.Forms.ErrorProvider epFunctie;
        private System.Windows.Forms.ErrorProvider epContract;
        private System.Windows.Forms.ComboBox cbBedrijfsWagen;
        private System.Windows.Forms.Label lblBedrijfsWagen;
    }
}