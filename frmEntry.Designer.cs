namespace Prime_Movie_Project
{
    partial class frmEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntry));
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.cbRating = new System.Windows.Forms.ComboBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtSynopsis = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cbCast = new System.Windows.Forms.ComboBox();
            this.bunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtRuntime = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbDirector = new System.Windows.Forms.ComboBox();
            this.bunifuSeparator7 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.bunifuSeparator8 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtD720 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtD1080 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.checkSeries = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkPopular = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbQuality = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.bunifuSeparator9 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtTitle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pbMovie = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pbEdit = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // cbYear
            // 
            this.cbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbYear.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.FormatString = "N2";
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbYear.Location = new System.Drawing.Point(359, 167);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(331, 30);
            this.cbYear.TabIndex = 53;
            this.cbYear.Text = "Year";
            // 
            // cbGenre
            // 
            this.cbGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGenre.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbGenre.Location = new System.Drawing.Point(359, 213);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(331, 30);
            this.cbGenre.TabIndex = 54;
            this.cbGenre.Text = "Genre";
            // 
            // cbRating
            // 
            this.cbRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRating.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRating.FormattingEnabled = true;
            this.cbRating.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbRating.Location = new System.Drawing.Point(359, 259);
            this.cbRating.Name = "cbRating";
            this.cbRating.Size = new System.Drawing.Size(331, 30);
            this.cbRating.TabIndex = 55;
            this.cbRating.Text = "Rating";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(359, 180);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(331, 35);
            this.bunifuSeparator1.TabIndex = 56;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(359, 226);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(331, 35);
            this.bunifuSeparator2.TabIndex = 57;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(359, 272);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(331, 35);
            this.bunifuSeparator3.TabIndex = 58;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // txtSynopsis
            // 
            this.txtSynopsis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSynopsis.Font = new System.Drawing.Font("Ubuntu Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSynopsis.Location = new System.Drawing.Point(361, 428);
            this.txtSynopsis.Name = "txtSynopsis";
            this.txtSynopsis.Size = new System.Drawing.Size(712, 126);
            this.txtSynopsis.TabIndex = 59;
            this.txtSynopsis.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 60;
            this.label2.Text = "SYNOPSIS";
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(359, 407);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(714, 35);
            this.bunifuSeparator4.TabIndex = 61;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator5.LineThickness = 1;
            this.bunifuSeparator5.Location = new System.Drawing.Point(353, 425);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(10, 144);
            this.bunifuSeparator5.TabIndex = 62;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = true;
            // 
            // cbCast
            // 
            this.cbCast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCast.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCast.FormattingEnabled = true;
            this.cbCast.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbCast.Location = new System.Drawing.Point(742, 126);
            this.cbCast.Name = "cbCast";
            this.cbCast.Size = new System.Drawing.Size(331, 30);
            this.cbCast.TabIndex = 63;
            this.cbCast.Text = "Cast";
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator6.LineThickness = 1;
            this.bunifuSeparator6.Location = new System.Drawing.Point(742, 139);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Size = new System.Drawing.Size(331, 35);
            this.bunifuSeparator6.TabIndex = 64;
            this.bunifuSeparator6.Transparency = 255;
            this.bunifuSeparator6.Vertical = false;
            // 
            // txtRuntime
            // 
            this.txtRuntime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRuntime.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuntime.ForeColor = System.Drawing.Color.Black;
            this.txtRuntime.HintForeColor = System.Drawing.Color.DimGray;
            this.txtRuntime.HintText = "Runtime";
            this.txtRuntime.isPassword = false;
            this.txtRuntime.LineFocusedColor = System.Drawing.Color.Black;
            this.txtRuntime.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRuntime.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtRuntime.LineThickness = 1;
            this.txtRuntime.Location = new System.Drawing.Point(359, 297);
            this.txtRuntime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRuntime.Name = "txtRuntime";
            this.txtRuntime.Size = new System.Drawing.Size(331, 36);
            this.txtRuntime.TabIndex = 65;
            this.txtRuntime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbDirector
            // 
            this.cbDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDirector.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDirector.FormattingEnabled = true;
            this.cbDirector.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbDirector.Location = new System.Drawing.Point(742, 167);
            this.cbDirector.Name = "cbDirector";
            this.cbDirector.Size = new System.Drawing.Size(331, 30);
            this.cbDirector.TabIndex = 66;
            this.cbDirector.Text = "Director";
            // 
            // bunifuSeparator7
            // 
            this.bunifuSeparator7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator7.LineThickness = 1;
            this.bunifuSeparator7.Location = new System.Drawing.Point(742, 180);
            this.bunifuSeparator7.Name = "bunifuSeparator7";
            this.bunifuSeparator7.Size = new System.Drawing.Size(331, 35);
            this.bunifuSeparator7.TabIndex = 67;
            this.bunifuSeparator7.Transparency = 255;
            this.bunifuSeparator7.Vertical = false;
            // 
            // cbLanguage
            // 
            this.cbLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLanguage.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbLanguage.Location = new System.Drawing.Point(742, 213);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(331, 30);
            this.cbLanguage.TabIndex = 68;
            this.cbLanguage.Text = "Language";
            // 
            // bunifuSeparator8
            // 
            this.bunifuSeparator8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator8.LineThickness = 1;
            this.bunifuSeparator8.Location = new System.Drawing.Point(742, 226);
            this.bunifuSeparator8.Name = "bunifuSeparator8";
            this.bunifuSeparator8.Size = new System.Drawing.Size(331, 35);
            this.bunifuSeparator8.TabIndex = 69;
            this.bunifuSeparator8.Transparency = 255;
            this.bunifuSeparator8.Vertical = false;
            // 
            // txtD720
            // 
            this.txtD720.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtD720.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD720.ForeColor = System.Drawing.Color.Black;
            this.txtD720.HintForeColor = System.Drawing.Color.DimGray;
            this.txtD720.HintText = "Download 720p";
            this.txtD720.isPassword = false;
            this.txtD720.LineFocusedColor = System.Drawing.Color.Black;
            this.txtD720.LineIdleColor = System.Drawing.Color.Gray;
            this.txtD720.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtD720.LineThickness = 1;
            this.txtD720.Location = new System.Drawing.Point(742, 297);
            this.txtD720.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtD720.Name = "txtD720";
            this.txtD720.Size = new System.Drawing.Size(156, 36);
            this.txtD720.TabIndex = 70;
            this.txtD720.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtD1080
            // 
            this.txtD1080.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtD1080.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD1080.ForeColor = System.Drawing.Color.Black;
            this.txtD1080.HintForeColor = System.Drawing.Color.DimGray;
            this.txtD1080.HintText = "Download 1080p";
            this.txtD1080.isPassword = false;
            this.txtD1080.LineFocusedColor = System.Drawing.Color.Black;
            this.txtD1080.LineIdleColor = System.Drawing.Color.Gray;
            this.txtD1080.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtD1080.LineThickness = 1;
            this.txtD1080.Location = new System.Drawing.Point(917, 297);
            this.txtD1080.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtD1080.Name = "txtD1080";
            this.txtD1080.Size = new System.Drawing.Size(156, 36);
            this.txtD1080.TabIndex = 71;
            this.txtD1080.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // checkSeries
            // 
            this.checkSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkSeries.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkSeries.Checked = false;
            this.checkSeries.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkSeries.ForeColor = System.Drawing.Color.White;
            this.checkSeries.Location = new System.Drawing.Point(742, 357);
            this.checkSeries.Name = "checkSeries";
            this.checkSeries.Size = new System.Drawing.Size(20, 20);
            this.checkSeries.TabIndex = 72;
            // 
            // checkPopular
            // 
            this.checkPopular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkPopular.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkPopular.Checked = false;
            this.checkPopular.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkPopular.ForeColor = System.Drawing.Color.White;
            this.checkPopular.Location = new System.Drawing.Point(917, 357);
            this.checkPopular.Name = "checkPopular";
            this.checkPopular.Size = new System.Drawing.Size(20, 20);
            this.checkPopular.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(768, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 74;
            this.label3.Text = "Is Series";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(943, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 75;
            this.label4.Text = "Is Popular";
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(938, 563);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(179, 42);
            this.btnSave.TabIndex = 76;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(755, 563);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(167, 42);
            this.btnCancel.TabIndex = 77;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbQuality
            // 
            this.cbQuality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbQuality.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuality.ForeColor = System.Drawing.Color.Black;
            this.cbQuality.HintForeColor = System.Drawing.Color.DimGray;
            this.cbQuality.HintText = "Quality";
            this.cbQuality.isPassword = false;
            this.cbQuality.LineFocusedColor = System.Drawing.Color.Black;
            this.cbQuality.LineIdleColor = System.Drawing.Color.Gray;
            this.cbQuality.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cbQuality.LineThickness = 1;
            this.cbQuality.Location = new System.Drawing.Point(742, 253);
            this.cbQuality.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbQuality.Name = "cbQuality";
            this.cbQuality.Size = new System.Drawing.Size(331, 36);
            this.cbQuality.TabIndex = 78;
            this.cbQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbCountry
            // 
            this.cbCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCountry.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbCountry.Location = new System.Drawing.Point(359, 341);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(331, 30);
            this.cbCountry.TabIndex = 79;
            this.cbCountry.Text = "Country";
            // 
            // bunifuSeparator9
            // 
            this.bunifuSeparator9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator9.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator9.LineThickness = 1;
            this.bunifuSeparator9.Location = new System.Drawing.Point(359, 354);
            this.bunifuSeparator9.Name = "bunifuSeparator9";
            this.bunifuSeparator9.Size = new System.Drawing.Size(331, 35);
            this.bunifuSeparator9.TabIndex = 80;
            this.bunifuSeparator9.Transparency = 255;
            this.bunifuSeparator9.Vertical = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.HintForeColor = System.Drawing.Color.DimGray;
            this.txtTitle.HintText = "Title";
            this.txtTitle.isPassword = false;
            this.txtTitle.LineFocusedColor = System.Drawing.Color.Black;
            this.txtTitle.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTitle.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTitle.LineThickness = 1;
            this.txtTitle.Location = new System.Drawing.Point(359, 123);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(331, 36);
            this.txtTitle.TabIndex = 81;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pbMovie
            // 
            this.pbMovie.BackColor = System.Drawing.SystemColors.Control;
            this.pbMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMovie.Location = new System.Drawing.Point(133, 190);
            this.pbMovie.Name = "pbMovie";
            this.pbMovie.Size = new System.Drawing.Size(188, 289);
            this.pbMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMovie.TabIndex = 46;
            this.pbMovie.TabStop = false;
            this.pbMovie.Click += new System.EventHandler(this.pbMovie_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.CadetBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(80, 617);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.btnExit);
            this.bunifuGradientPanel2.Controls.Add(this.pbEdit);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel2.Controls.Add(this.label1);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Gainsboro;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1150, 113);
            this.bunifuGradientPanel2.TabIndex = 45;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Prime_Movie_Project.Properties.Resources.Multiply_96px;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(1082, 40);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 46;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbEdit
            // 
            this.pbEdit.BackColor = System.Drawing.Color.Transparent;
            this.pbEdit.BackgroundImage = global::Prime_Movie_Project.Properties.Resources.Edit_96px;
            this.pbEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEdit.BorderRadius = 5;
            this.pbEdit.BottomSahddow = true;
            this.pbEdit.color = System.Drawing.Color.Transparent;
            this.pbEdit.LeftSahddow = false;
            this.pbEdit.Location = new System.Drawing.Point(1038, 40);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.RightSahddow = true;
            this.pbEdit.ShadowDepth = 20;
            this.pbEdit.Size = new System.Drawing.Size(35, 35);
            this.pbEdit.TabIndex = 45;
            this.pbEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.pbEdit_Paint);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(107, 75);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(145, 19);
            this.bunifuCustomLabel1.TabIndex = 44;
            this.bunifuCustomLabel1.Text = "Manage Movie Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Ubuntu Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 35);
            this.label1.TabIndex = 44;
            this.label1.Text = "Entry";
            // 
            // frmEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1150, 617);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.bunifuSeparator9);
            this.Controls.Add(this.cbQuality);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkPopular);
            this.Controls.Add(this.checkSeries);
            this.Controls.Add(this.txtD1080);
            this.Controls.Add(this.txtD720);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.bunifuSeparator8);
            this.Controls.Add(this.cbDirector);
            this.Controls.Add(this.bunifuSeparator7);
            this.Controls.Add(this.txtRuntime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSynopsis);
            this.Controls.Add(this.cbRating);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.pbMovie);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.bunifuSeparator5);
            this.Controls.Add(this.cbCast);
            this.Controls.Add(this.bunifuSeparator6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEntry";
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.PictureBox pbMovie;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.ComboBox cbRating;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.RichTextBox txtSynopsis;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
        private System.Windows.Forms.ComboBox cbCast;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRuntime;
        private System.Windows.Forms.ComboBox cbDirector;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator7;
        private System.Windows.Forms.ComboBox cbLanguage;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtD720;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtD1080;
        private Bunifu.Framework.UI.BunifuCheckbox checkSeries;
        private Bunifu.Framework.UI.BunifuCheckbox checkPopular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private Bunifu.Framework.UI.BunifuCards pbEdit;
        private System.Windows.Forms.PictureBox btnExit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cbQuality;
        private System.Windows.Forms.ComboBox cbCountry;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTitle;
    }
}