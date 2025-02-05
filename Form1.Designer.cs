namespace currency_calculator
{
    partial class Form1
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
            bntCalculate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFromCurrency = new ComboBox();
            txtToCurrency = new ComboBox();
            txtAmount = new TextBox();
            lblResult = new Label();
            lblFromCurrency = new Label();
            lblToCurrency = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bntCalculate
            // 
            bntCalculate.Location = new Point(390, 250);
            bntCalculate.Name = "bntCalculate";
            bntCalculate.Size = new Size(120, 40);
            bntCalculate.TabIndex = 0;
            bntCalculate.Text = "Berechnen";
            bntCalculate.UseVisualStyleBackColor = true;
            bntCalculate.Click += bntCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 80);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 1;
            label1.Text = "Ausgangswährung";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(500, 80);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 2;
            label2.Text = "Zielwährung";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 172);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 3;
            label3.Text = "Betrag:";
            // 
            // txtFromCurrency
            // 
            txtFromCurrency.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtFromCurrency.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtFromCurrency.FormattingEnabled = true;
            txtFromCurrency.Items.AddRange(new object[] { "US-Dollar (USD)", "VAE-Dirham (AED)", "Afghanischer Afghani (AFN)", "Albanischer Lek (ALL)", "Armenischer Dram (AMD)", "Niederländischer-Antillen-Gulden (ANG)", "Angolanischer Kwanza (AOA)", "Argentinischer Peso (ARS)", "Australischer Dollar (AUD)", "Arubanischer Florin (AWG)", "Aserbaidschan-Manat (AZN)", "Bosnisch-herzegowinische Konvertible Mark (BAM)", "Barbados-Dollar (BBD)", "Bangladesch-Taka (BDT)", "Bulgarischer Lew (BGN)", "Bahrain-Dinar (BHD)", "Burundi-Franc (BIF)", "Bermuda-Dollar (BMD)", "Brunei-Dollar (BND)", "Bolivianischer Boliviano (BOB)", "Brasilianischer Real (BRL)", "Bahama-Dollar (BSD)", "Bhutan-Ngultrum (BTN)", "Botswanischer Pula (BWP)", "Weißrussischer Rubel (BYN)", "Belize-Dollar (BZD)", "Kanadischer Dollar (CAD)", "Kongolesischer Franc (CDF)", "Schweizer Franken (CHF)", "Chilenischer Peso (CLP)", "Chinesischer Yuan (CNY)", "Kolumbianischer Peso (COP)", "Costa-Rica-Colón (CRC)", "Kubanischer Peso (CUP)", "Kap-Verde-Escudo (CVE)", "Tschechische Krone (CZK)", "Dschibuti-Franc (DJF)", "Dänische Krone (DKK)", "Dominikanischer Peso (DOP)", "Algerischer Dinar (DZD)", "Ägyptisches Pfund (EGP)", "Eritreischer Nakfa (ERN)", "Äthiopischer Birr (ETB)", "Euro (EUR)", "Fidschi-Dollar (FJD)", "Falkland-Pfund (FKP)", "Färöische Krone (FOK)", "Britisches Pfund (GBP)", "Georgischer Lari (GEL)", "Guernsey-Pfund (GGP)", "Ghanaischer Cedi (GHS)", "Gibraltar-Pfund (GIP)", "Gambischer Dalasi (GMD)", "Guinea-Franc (GNF)", "Guatemaltekischer Quetzal (GTQ)", "Guyana-Dollar (GYD)", "Hongkong-Dollar (HKD)", "Honduranische Lempira (HNL)", "Kroatische Kuna (HRK)", "Haitianische Gourde (HTG)", "Ungarischer Forint (HUF)", "Indonesische Rupiah (IDR)", "Israelischer Schekel (ILS)", "Isle-of-Man-Pfund (IMP)", "Indische Rupie (INR)", "Irakischer Dinar (IQD)", "Iranischer Rial (IRR)", "Isländische Krone (ISK)", "Jersey-Pfund (JEP)", "Jamaika-Dollar (JMD)", "Jordanischer Dinar (JOD)", "Japanischer Yen (JPY)", "Kenia-Schilling (KES)", "Kirgisischer Som (KGS)", "Kambodschanischer Riel (KHR)", "Kiribati-Dollar (KID)", "Komoren-Franc (KMF)", "Südkoreanischer Won (KRW)", "Kuwait-Dinar (KWD)", "Kaiman-Dollar (KYD)", "Kasachischer Tenge (KZT)", "Laotischer Kip (LAK)", "Libanesisches Pfund (LBP)", "Sri-Lanka-Rupie (LKR)", "Liberianischer Dollar (LRD)", "Lesothischer Loti (LSL)", "Libyscher Dinar (LYD)", "Marokkanischer Dirham (MAD)", "Moldawischer Leu (MDL)", "Madagassischer Ariary (MGA)", "Mazedonischer Denar (MKD)", "Myanma-Kyat (MMK)", "Mongolischer Tögrög (MNT)", "Macau-Pataca (MOP)", "Mauretanischer Ouguiya (MRU)", "Mauritius-Rupie (MUR)", "Maledivische Rufiyaa (MVR)", "Malawischer Kwacha (MWK)", "Mexikanischer Peso (MXN)", "Malaysischer Ringgit (MYR)", "Mosambikanischer Metical (MZN)", "Namibischer Dollar (NAD)", "Nigerianische Naira (NGN)", "Nicaraguanischer Cordoba (NIO)", "Norwegische Krone (NOK)", "Nepalesische Rupie (NPR)", "Neuseeland-Dollar (NZD)", "Omanischer Rial (OMR)", "Panama-Balboa (PAB)", "Peruanischer Sol (PEN)", "Papua-Neuguinea-Kina (PGK)", "Philippinischer Peso (PHP)", "Pakistanische Rupie (PKR)", "Polnischer Zloty (PLN)", "Paraguayischer Guarani (PYG)", "Katar-Riyal (QAR)", "Rumänischer Leu (RON)", "Serbischer Dinar (RSD)", "Russischer Rubel (RUB)", "Ruandischer Franc (RWF)", "Saudi-Riyal (SAR)", "Salomonen-Dollar (SBD)", "Seychellen-Rupie (SCR)", "Sudanesisches Pfund (SDG)", "Schwedische Krone (SEK)", "Singapur-Dollar (SGD)", "St.-Helena-Pfund (SHP)", "Sierraleonischer Leone (SLE)", "Somalischer Schilling (SOS)", "Surinam-Dollar (SRD)", "Süd-Sudan-Pfund (SSP)", "Sao-tomeischer Dobra (STN)", "Syrisches Pfund (SYP)", "Eswatinischer Lilangeni (SZL)", "Thailändischer Baht (THB)", "Tadschikischer Somoni (TJS)", "Turkmenistan-Manat (TMT)", "Tunesischer Dinar (TND)", "Tonganischer Paʻanga (TOP)", "Türkische Lira (TRY)", "Trinidad-und-Tobago-Dollar (TTD)", "Taiwan-Dollar (TWD)", "Ukrainische Hrywnja (UAH)", "Uganda-Schilling (UGX)", "Uruguayischer Peso (UYU)", "Usbekischer Soʻm (UZS)", "Venezolanischer Bolivar (VES)", "Vietnamesischer Dong (VND)", "Samoanischer Tala (WST)", "Südafrikanischer Rand (ZAR)" });
            txtFromCurrency.Location = new Point(150, 120);
            txtFromCurrency.Name = "txtFromCurrency";
            txtFromCurrency.Size = new Size(250, 36);
            txtFromCurrency.TabIndex = 7;
            txtFromCurrency.TextChanged += txtFromCurrency_TextChanged;
            // 
            // txtToCurrency
            // 
            txtToCurrency.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtToCurrency.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtToCurrency.FormattingEnabled = true;
            txtToCurrency.Items.AddRange(new object[] { "US-Dollar (USD)", "VAE-Dirham (AED)", "Afghanischer Afghani (AFN)", "Albanischer Lek (ALL)", "Armenischer Dram (AMD)", "Niederländischer-Antillen-Gulden (ANG)", "Angolanischer Kwanza (AOA)", "Argentinischer Peso (ARS)", "Australischer Dollar (AUD)", "Arubanischer Florin (AWG)", "Aserbaidschan-Manat (AZN)", "Bosnisch-herzegowinische Konvertible Mark (BAM)", "Barbados-Dollar (BBD)", "Bangladesch-Taka (BDT)", "Bulgarischer Lew (BGN)", "Bahrain-Dinar (BHD)", "Burundi-Franc (BIF)", "Bermuda-Dollar (BMD)", "Brunei-Dollar (BND)", "Bolivianischer Boliviano (BOB)", "Brasilianischer Real (BRL)", "Bahama-Dollar (BSD)", "Bhutan-Ngultrum (BTN)", "Botswanischer Pula (BWP)", "Weißrussischer Rubel (BYN)", "Belize-Dollar (BZD)", "Kanadischer Dollar (CAD)", "Kongolesischer Franc (CDF)", "Schweizer Franken (CHF)", "Chilenischer Peso (CLP)", "Chinesischer Yuan (CNY)", "Kolumbianischer Peso (COP)", "Costa-Rica-Colón (CRC)", "Kubanischer Peso (CUP)", "Kap-Verde-Escudo (CVE)", "Tschechische Krone (CZK)", "Dschibuti-Franc (DJF)", "Dänische Krone (DKK)", "Dominikanischer Peso (DOP)", "Algerischer Dinar (DZD)", "Ägyptisches Pfund (EGP)", "Eritreischer Nakfa (ERN)", "Äthiopischer Birr (ETB)", "Euro (EUR)", "Fidschi-Dollar (FJD)", "Falkland-Pfund (FKP)", "Färöische Krone (FOK)", "Britisches Pfund (GBP)", "Georgischer Lari (GEL)", "Guernsey-Pfund (GGP)", "Ghanaischer Cedi (GHS)", "Gibraltar-Pfund (GIP)", "Gambischer Dalasi (GMD)", "Guinea-Franc (GNF)", "Guatemaltekischer Quetzal (GTQ)", "Guyana-Dollar (GYD)", "Hongkong-Dollar (HKD)", "Honduranische Lempira (HNL)", "Kroatische Kuna (HRK)", "Haitianische Gourde (HTG)", "Ungarischer Forint (HUF)", "Indonesische Rupiah (IDR)", "Israelischer Schekel (ILS)", "Isle-of-Man-Pfund (IMP)", "Indische Rupie (INR)", "Irakischer Dinar (IQD)", "Iranischer Rial (IRR)", "Isländische Krone (ISK)", "Jersey-Pfund (JEP)", "Jamaika-Dollar (JMD)", "Jordanischer Dinar (JOD)", "Japanischer Yen (JPY)", "Kenia-Schilling (KES)", "Kirgisischer Som (KGS)", "Kambodschanischer Riel (KHR)", "Kiribati-Dollar (KID)", "Komoren-Franc (KMF)", "Südkoreanischer Won (KRW)", "Kuwait-Dinar (KWD)", "Kaiman-Dollar (KYD)", "Kasachischer Tenge (KZT)", "Laotischer Kip (LAK)", "Libanesisches Pfund (LBP)", "Sri-Lanka-Rupie (LKR)", "Liberianischer Dollar (LRD)", "Lesothischer Loti (LSL)", "Libyscher Dinar (LYD)", "Marokkanischer Dirham (MAD)", "Moldawischer Leu (MDL)", "Madagassischer Ariary (MGA)", "Mazedonischer Denar (MKD)", "Myanma-Kyat (MMK)", "Mongolischer Tögrög (MNT)", "Macau-Pataca (MOP)", "Mauretanischer Ouguiya (MRU)", "Mauritius-Rupie (MUR)", "Maledivische Rufiyaa (MVR)", "Malawischer Kwacha (MWK)", "Mexikanischer Peso (MXN)", "Malaysischer Ringgit (MYR)", "Mosambikanischer Metical (MZN)", "Namibischer Dollar (NAD)", "Nigerianische Naira (NGN)", "Nicaraguanischer Cordoba (NIO)", "Norwegische Krone (NOK)", "Nepalesische Rupie (NPR)", "Neuseeland-Dollar (NZD)", "Omanischer Rial (OMR)", "Panama-Balboa (PAB)", "Peruanischer Sol (PEN)", "Papua-Neuguinea-Kina (PGK)", "Philippinischer Peso (PHP)", "Pakistanische Rupie (PKR)", "Polnischer Zloty (PLN)", "Paraguayischer Guarani (PYG)", "Katar-Riyal (QAR)", "Rumänischer Leu (RON)", "Serbischer Dinar (RSD)", "Russischer Rubel (RUB)", "Ruandischer Franc (RWF)", "Saudi-Riyal (SAR)", "Salomonen-Dollar (SBD)", "Seychellen-Rupie (SCR)", "Sudanesisches Pfund (SDG)", "Schwedische Krone (SEK)", "Singapur-Dollar (SGD)", "St.-Helena-Pfund (SHP)", "Sierraleonischer Leone (SLE)", "Somalischer Schilling (SOS)", "Surinam-Dollar (SRD)", "Süd-Sudan-Pfund (SSP)", "Sao-tomeischer Dobra (STN)", "Syrisches Pfund (SYP)", "Eswatinischer Lilangeni (SZL)", "Thailändischer Baht (THB)", "Tadschikischer Somoni (TJS)", "Turkmenistan-Manat (TMT)", "Tunesischer Dinar (TND)", "Tonganischer Paʻanga (TOP)", "Türkische Lira (TRY)", "Trinidad-und-Tobago-Dollar (TTD)", "Taiwan-Dollar (TWD)", "Ukrainische Hrywnja (UAH)", "Uganda-Schilling (UGX)", "Uruguayischer Peso (UYU)", "Usbekischer Soʻm (UZS)", "Venezolanischer Bolivar (VES)", "Vietnamesischer Dong (VND)", "Samoanischer Tala (WST)", "Südafrikanischer Rand (ZAR)" });
            txtToCurrency.Location = new Point(500, 120);
            txtToCurrency.Name = "txtToCurrency";
            txtToCurrency.Size = new Size(250, 36);
            txtToCurrency.TabIndex = 8;
            txtToCurrency.TextChanged += txtToCurrency_TextChanged;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(150, 170);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(140, 34);
            txtAmount.TabIndex = 9;
            txtAmount.Text = "1";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(500, 172);
            lblResult.MaximumSize = new Size(150, 28);
            lblResult.MinimumSize = new Size(60, 28);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(60, 28);
            lblResult.TabIndex = 13;
            // 
            // lblFromCurrency
            // 
            lblFromCurrency.AutoSize = true;
            lblFromCurrency.Location = new Point(350, 170);
            lblFromCurrency.MaximumSize = new Size(60, 28);
            lblFromCurrency.MinimumSize = new Size(50, 28);
            lblFromCurrency.Name = "lblFromCurrency";
            lblFromCurrency.Size = new Size(50, 28);
            lblFromCurrency.TabIndex = 14;
            // 
            // lblToCurrency
            // 
            lblToCurrency.AutoSize = true;
            lblToCurrency.Location = new Point(700, 172);
            lblToCurrency.MaximumSize = new Size(60, 28);
            lblToCurrency.MinimumSize = new Size(50, 28);
            lblToCurrency.Name = "lblToCurrency";
            lblToCurrency.Size = new Size(50, 28);
            lblToCurrency.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\Lukas\\Programmieren\\C#-Crashkurs\\currency_calculator\\swap.ico";
            pictureBox1.Location = new Point(425, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 38);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 394);
            Controls.Add(pictureBox1);
            Controls.Add(lblToCurrency);
            Controls.Add(lblFromCurrency);
            Controls.Add(lblResult);
            Controls.Add(txtAmount);
            Controls.Add(txtToCurrency);
            Controls.Add(txtFromCurrency);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bntCalculate);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntCalculate;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox txtFromCurrency;
        private ComboBox txtToCurrency;
        private TextBox txtAmount;
        private Label lblResult;
        private Label lblFromCurrency;
        private Label lblToCurrency;
        private PictureBox pictureBox1;
    }
}
