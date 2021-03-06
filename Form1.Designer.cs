﻿namespace CryptosV
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.rtbText = new System.Windows.Forms.RichTextBox();
			this.btnCode = new System.Windows.Forms.Button();
			this.btnDecode = new System.Windows.Forms.Button();
			this.rtbResult = new System.Windows.Forms.RichTextBox();
			this.gbMethod = new System.Windows.Forms.GroupBox();
			this.rbAtbash = new System.Windows.Forms.RadioButton();
			this.rbVigenere = new System.Windows.Forms.RadioButton();
			this.pnlColor = new System.Windows.Forms.Panel();
			this.lblSafety = new System.Windows.Forms.Label();
			this.rbNumber = new System.Windows.Forms.RadioButton();
			this.rbXor = new System.Windows.Forms.RadioButton();
			this.rbCaesar = new System.Windows.Forms.RadioButton();
			this.rbLitorea = new System.Windows.Forms.RadioButton();
			this.gbSettings = new System.Windows.Forms.GroupBox();
			this.tbVigenereKey = new System.Windows.Forms.TextBox();
			this.lblVigenereKey = new System.Windows.Forms.Label();
			this.tbXORKey = new System.Windows.Forms.TextBox();
			this.lblXORkey = new System.Windows.Forms.Label();
			this.lblCaesarShift = new System.Windows.Forms.Label();
			this.nudCaesarKey = new System.Windows.Forms.NumericUpDown();
			this.btnSwap = new System.Windows.Forms.Button();
			this.btnCrear = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAlphabetsSet = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.tbAlphabet2 = new System.Windows.Forms.TextBox();
			this.tbAlphabet1 = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiReadFromFile = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSaveToFile = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutCipersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.rbQwerty = new System.Windows.Forms.RadioButton();
			this.gbMethod.SuspendLayout();
			this.pnlColor.SuspendLayout();
			this.gbSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCaesarKey)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rtbText
			// 
			this.rtbText.DetectUrls = false;
			this.rtbText.Location = new System.Drawing.Point(12, 47);
			this.rtbText.Name = "rtbText";
			this.rtbText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.rtbText.Size = new System.Drawing.Size(296, 302);
			this.rtbText.TabIndex = 0;
			this.rtbText.Text = "Добрий ранок, Україно!";
			// 
			// btnCode
			// 
			this.btnCode.Location = new System.Drawing.Point(13, 356);
			this.btnCode.Name = "btnCode";
			this.btnCode.Size = new System.Drawing.Size(75, 23);
			this.btnCode.TabIndex = 1;
			this.btnCode.Text = "Encrypt";
			this.btnCode.UseVisualStyleBackColor = true;
			this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
			// 
			// btnDecode
			// 
			this.btnDecode.Location = new System.Drawing.Point(95, 356);
			this.btnDecode.Name = "btnDecode";
			this.btnDecode.Size = new System.Drawing.Size(75, 23);
			this.btnDecode.TabIndex = 2;
			this.btnDecode.Text = "Decrypt";
			this.btnDecode.UseVisualStyleBackColor = true;
			this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
			// 
			// rtbResult
			// 
			this.rtbResult.Location = new System.Drawing.Point(314, 47);
			this.rtbResult.Name = "rtbResult";
			this.rtbResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.rtbResult.Size = new System.Drawing.Size(296, 302);
			this.rtbResult.TabIndex = 3;
			this.rtbResult.Text = "";
			// 
			// gbMethod
			// 
			this.gbMethod.Controls.Add(this.rbQwerty);
			this.gbMethod.Controls.Add(this.rbAtbash);
			this.gbMethod.Controls.Add(this.rbVigenere);
			this.gbMethod.Controls.Add(this.pnlColor);
			this.gbMethod.Controls.Add(this.rbNumber);
			this.gbMethod.Controls.Add(this.rbXor);
			this.gbMethod.Controls.Add(this.rbCaesar);
			this.gbMethod.Controls.Add(this.rbLitorea);
			this.gbMethod.Location = new System.Drawing.Point(616, 28);
			this.gbMethod.Name = "gbMethod";
			this.gbMethod.Size = new System.Drawing.Size(150, 321);
			this.gbMethod.TabIndex = 4;
			this.gbMethod.TabStop = false;
			this.gbMethod.Text = "Method";
			// 
			// rbAtbash
			// 
			this.rbAtbash.AutoSize = true;
			this.rbAtbash.Location = new System.Drawing.Point(7, 89);
			this.rbAtbash.Name = "rbAtbash";
			this.rbAtbash.Size = new System.Drawing.Size(58, 17);
			this.rbAtbash.TabIndex = 4;
			this.rbAtbash.Text = "Atbash";
			this.rbAtbash.UseVisualStyleBackColor = true;
			this.rbAtbash.CheckedChanged += new System.EventHandler(this.rbAtbash_CheckedChanged);
			// 
			// rbVigenere
			// 
			this.rbVigenere.AutoSize = true;
			this.rbVigenere.Location = new System.Drawing.Point(7, 135);
			this.rbVigenere.Name = "rbVigenere";
			this.rbVigenere.Size = new System.Drawing.Size(67, 17);
			this.rbVigenere.TabIndex = 6;
			this.rbVigenere.Text = "Vigenere";
			this.rbVigenere.UseVisualStyleBackColor = true;
			this.rbVigenere.CheckedChanged += new System.EventHandler(this.rbVigenere_CheckedChanged);
			// 
			// pnlColor
			// 
			this.pnlColor.BackColor = System.Drawing.Color.Yellow;
			this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlColor.Controls.Add(this.lblSafety);
			this.pnlColor.Location = new System.Drawing.Point(7, 259);
			this.pnlColor.Name = "pnlColor";
			this.pnlColor.Size = new System.Drawing.Size(137, 56);
			this.pnlColor.TabIndex = 4;
			// 
			// lblSafety
			// 
			this.lblSafety.AutoSize = true;
			this.lblSafety.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSafety.Location = new System.Drawing.Point(4, 19);
			this.lblSafety.Name = "lblSafety";
			this.lblSafety.Size = new System.Drawing.Size(57, 13);
			this.lblSafety.TabIndex = 0;
			this.lblSafety.Text = "lblSafety";
			// 
			// rbNumber
			// 
			this.rbNumber.AutoSize = true;
			this.rbNumber.Location = new System.Drawing.Point(7, 19);
			this.rbNumber.Name = "rbNumber";
			this.rbNumber.Size = new System.Drawing.Size(57, 17);
			this.rbNumber.TabIndex = 1;
			this.rbNumber.Text = "A1Z26";
			this.rbNumber.UseVisualStyleBackColor = true;
			this.rbNumber.CheckedChanged += new System.EventHandler(this.rbNumber_CheckedChanged);
			// 
			// rbXor
			// 
			this.rbXor.AutoSize = true;
			this.rbXor.Location = new System.Drawing.Point(7, 112);
			this.rbXor.Name = "rbXor";
			this.rbXor.Size = new System.Drawing.Size(48, 17);
			this.rbXor.TabIndex = 5;
			this.rbXor.Text = "XOR";
			this.rbXor.UseVisualStyleBackColor = true;
			this.rbXor.CheckedChanged += new System.EventHandler(this.rbXor_CheckedChanged);
			// 
			// rbCaesar
			// 
			this.rbCaesar.AutoSize = true;
			this.rbCaesar.Checked = true;
			this.rbCaesar.Location = new System.Drawing.Point(7, 65);
			this.rbCaesar.Name = "rbCaesar";
			this.rbCaesar.Size = new System.Drawing.Size(58, 17);
			this.rbCaesar.TabIndex = 3;
			this.rbCaesar.TabStop = true;
			this.rbCaesar.Text = "Caesar";
			this.rbCaesar.UseVisualStyleBackColor = true;
			this.rbCaesar.CheckedChanged += new System.EventHandler(this.rbCaesar_CheckedChanged);
			// 
			// rbLitorea
			// 
			this.rbLitorea.AutoSize = true;
			this.rbLitorea.Location = new System.Drawing.Point(7, 42);
			this.rbLitorea.Name = "rbLitorea";
			this.rbLitorea.Size = new System.Drawing.Size(57, 17);
			this.rbLitorea.TabIndex = 2;
			this.rbLitorea.Text = "Litorea";
			this.rbLitorea.UseVisualStyleBackColor = true;
			this.rbLitorea.CheckedChanged += new System.EventHandler(this.rbLitorea_CheckedChanged);
			// 
			// gbSettings
			// 
			this.gbSettings.Controls.Add(this.tbVigenereKey);
			this.gbSettings.Controls.Add(this.lblVigenereKey);
			this.gbSettings.Controls.Add(this.tbXORKey);
			this.gbSettings.Controls.Add(this.lblXORkey);
			this.gbSettings.Controls.Add(this.lblCaesarShift);
			this.gbSettings.Controls.Add(this.nudCaesarKey);
			this.gbSettings.Location = new System.Drawing.Point(13, 385);
			this.gbSettings.Name = "gbSettings";
			this.gbSettings.Size = new System.Drawing.Size(295, 101);
			this.gbSettings.TabIndex = 5;
			this.gbSettings.TabStop = false;
			this.gbSettings.Text = "Methods settings";
			// 
			// tbVigenereKey
			// 
			this.tbVigenereKey.Location = new System.Drawing.Point(82, 69);
			this.tbVigenereKey.Name = "tbVigenereKey";
			this.tbVigenereKey.Size = new System.Drawing.Size(207, 20);
			this.tbVigenereKey.TabIndex = 6;
			this.tbVigenereKey.Text = "key";
			// 
			// lblVigenereKey
			// 
			this.lblVigenereKey.AutoSize = true;
			this.lblVigenereKey.Location = new System.Drawing.Point(7, 71);
			this.lblVigenereKey.Name = "lblVigenereKey";
			this.lblVigenereKey.Size = new System.Drawing.Size(69, 13);
			this.lblVigenereKey.TabIndex = 5;
			this.lblVigenereKey.Text = "Vigenere key";
			// 
			// tbXORKey
			// 
			this.tbXORKey.Location = new System.Drawing.Point(82, 43);
			this.tbXORKey.Name = "tbXORKey";
			this.tbXORKey.Size = new System.Drawing.Size(207, 20);
			this.tbXORKey.TabIndex = 4;
			this.tbXORKey.Text = "123";
			this.tbXORKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbXORKey_KeyPress);
			// 
			// lblXORkey
			// 
			this.lblXORkey.AutoSize = true;
			this.lblXORkey.Location = new System.Drawing.Point(7, 45);
			this.lblXORkey.Name = "lblXORkey";
			this.lblXORkey.Size = new System.Drawing.Size(50, 13);
			this.lblXORkey.TabIndex = 3;
			this.lblXORkey.Text = "XOR key";
			// 
			// lblCaesarShift
			// 
			this.lblCaesarShift.AutoSize = true;
			this.lblCaesarShift.Location = new System.Drawing.Point(7, 19);
			this.lblCaesarShift.Name = "lblCaesarShift";
			this.lblCaesarShift.Size = new System.Drawing.Size(62, 13);
			this.lblCaesarShift.TabIndex = 1;
			this.lblCaesarShift.Text = "Caesar shift";
			// 
			// nudCaesarKey
			// 
			this.nudCaesarKey.Location = new System.Drawing.Point(82, 16);
			this.nudCaesarKey.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.nudCaesarKey.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
			this.nudCaesarKey.Name = "nudCaesarKey";
			this.nudCaesarKey.Size = new System.Drawing.Size(207, 20);
			this.nudCaesarKey.TabIndex = 0;
			this.nudCaesarKey.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// btnSwap
			// 
			this.btnSwap.Location = new System.Drawing.Point(314, 356);
			this.btnSwap.Name = "btnSwap";
			this.btnSwap.Size = new System.Drawing.Size(75, 23);
			this.btnSwap.TabIndex = 6;
			this.btnSwap.Text = "Swap";
			this.btnSwap.UseVisualStyleBackColor = true;
			this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
			// 
			// btnCrear
			// 
			this.btnCrear.Location = new System.Drawing.Point(396, 356);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(75, 23);
			this.btnCrear.TabIndex = 7;
			this.btnCrear.Text = "Clear";
			this.btnCrear.UseVisualStyleBackColor = true;
			this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAlphabetsSet);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.tbAlphabet2);
			this.groupBox1.Controls.Add(this.tbAlphabet1);
			this.groupBox1.Location = new System.Drawing.Point(315, 386);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(295, 100);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Global settings";
			// 
			// btnAlphabetsSet
			// 
			this.btnAlphabetsSet.Location = new System.Drawing.Point(240, 40);
			this.btnAlphabetsSet.Name = "btnAlphabetsSet";
			this.btnAlphabetsSet.Size = new System.Drawing.Size(49, 49);
			this.btnAlphabetsSet.TabIndex = 3;
			this.btnAlphabetsSet.Text = "SET";
			this.btnAlphabetsSet.UseVisualStyleBackColor = true;
			this.btnAlphabetsSet.Click += new System.EventHandler(this.btnAlphabetsSet_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Alphabets";
			// 
			// tbAlphabet2
			// 
			this.tbAlphabet2.Location = new System.Drawing.Point(10, 68);
			this.tbAlphabet2.Name = "tbAlphabet2";
			this.tbAlphabet2.Size = new System.Drawing.Size(224, 20);
			this.tbAlphabet2.TabIndex = 1;
			this.tbAlphabet2.Text = "абв";
			// 
			// tbAlphabet1
			// 
			this.tbAlphabet1.Location = new System.Drawing.Point(10, 41);
			this.tbAlphabet1.Name = "tbAlphabet1";
			this.tbAlphabet1.Size = new System.Drawing.Size(224, 20);
			this.tbAlphabet1.TabIndex = 0;
			this.tbAlphabet1.Text = "adc";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiHelp});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(776, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsmiFile
			// 
			this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReadFromFile,
            this.tsmiSaveToFile});
			this.tsmiFile.Name = "tsmiFile";
			this.tsmiFile.Size = new System.Drawing.Size(37, 20);
			this.tsmiFile.Text = "File";
			// 
			// tsmiReadFromFile
			// 
			this.tsmiReadFromFile.Name = "tsmiReadFromFile";
			this.tsmiReadFromFile.Size = new System.Drawing.Size(171, 22);
			this.tsmiReadFromFile.Text = "Read text from file";
			this.tsmiReadFromFile.Click += new System.EventHandler(this.tsmiReadFromFile_Click);
			// 
			// tsmiSaveToFile
			// 
			this.tsmiSaveToFile.Name = "tsmiSaveToFile";
			this.tsmiSaveToFile.Size = new System.Drawing.Size(171, 22);
			this.tsmiSaveToFile.Text = "Save ciper to file";
			this.tsmiSaveToFile.Click += new System.EventHandler(this.tsmiSaveToFile_Click);
			// 
			// tsmiHelp
			// 
			this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutCipersToolStripMenuItem,
            this.aboutProgramToolStripMenuItem,
            this.aboutAuthorToolStripMenuItem});
			this.tsmiHelp.Name = "tsmiHelp";
			this.tsmiHelp.Size = new System.Drawing.Size(44, 20);
			this.tsmiHelp.Text = "Help";
			// 
			// aboutCipersToolStripMenuItem
			// 
			this.aboutCipersToolStripMenuItem.Name = "aboutCipersToolStripMenuItem";
			this.aboutCipersToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.aboutCipersToolStripMenuItem.Text = "About ciphers";
			this.aboutCipersToolStripMenuItem.Click += new System.EventHandler(this.aboutCipersToolStripMenuItem_Click);
			// 
			// aboutProgramToolStripMenuItem
			// 
			this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
			this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.aboutProgramToolStripMenuItem.Text = "About program";
			this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
			// 
			// aboutAuthorToolStripMenuItem
			// 
			this.aboutAuthorToolStripMenuItem.Name = "aboutAuthorToolStripMenuItem";
			this.aboutAuthorToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.aboutAuthorToolStripMenuItem.Text = "About author";
			this.aboutAuthorToolStripMenuItem.Click += new System.EventHandler(this.aboutAuthorsToolStripMenuItem_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(28, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Text";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(312, 28);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Cipher";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Text|*.txt|All files|*.*";
			this.openFileDialog1.Title = "Open text from file";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Text|*.txt";
			this.saveFileDialog1.Title = "Save ciper to file";
			// 
			// rbQwerty
			// 
			this.rbQwerty.AutoSize = true;
			this.rbQwerty.Location = new System.Drawing.Point(7, 158);
			this.rbQwerty.Name = "rbQwerty";
			this.rbQwerty.Size = new System.Drawing.Size(73, 17);
			this.rbQwerty.TabIndex = 7;
			this.rbQwerty.Text = "QWERTY";
			this.rbQwerty.UseVisualStyleBackColor = true;
			this.rbQwerty.CheckedChanged += new System.EventHandler(this.rbQwerty_CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 493);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.btnSwap);
			this.Controls.Add(this.gbSettings);
			this.Controls.Add(this.gbMethod);
			this.Controls.Add(this.rtbResult);
			this.Controls.Add(this.btnDecode);
			this.Controls.Add(this.btnCode);
			this.Controls.Add(this.rtbText);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "CryptosV";
			this.gbMethod.ResumeLayout(false);
			this.gbMethod.PerformLayout();
			this.pnlColor.ResumeLayout(false);
			this.pnlColor.PerformLayout();
			this.gbSettings.ResumeLayout(false);
			this.gbSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCaesarKey)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbText;
		private System.Windows.Forms.Button btnCode;
		private System.Windows.Forms.Button btnDecode;
		private System.Windows.Forms.RichTextBox rtbResult;
		private System.Windows.Forms.GroupBox gbMethod;
		private System.Windows.Forms.RadioButton rbXor;
		private System.Windows.Forms.RadioButton rbCaesar;
		private System.Windows.Forms.RadioButton rbLitorea;
		private System.Windows.Forms.GroupBox gbSettings;
		private System.Windows.Forms.Label lblCaesarShift;
		private System.Windows.Forms.NumericUpDown nudCaesarKey;
		private System.Windows.Forms.Button btnSwap;
		private System.Windows.Forms.TextBox tbXORKey;
		private System.Windows.Forms.Label lblXORkey;
		private System.Windows.Forms.Button btnCrear;
		private System.Windows.Forms.RadioButton rbNumber;
		private System.Windows.Forms.Panel pnlColor;
		private System.Windows.Forms.Label lblSafety;
		private System.Windows.Forms.RadioButton rbVigenere;
		private System.Windows.Forms.TextBox tbVigenereKey;
		private System.Windows.Forms.Label lblVigenereKey;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbAlphabet2;
		private System.Windows.Forms.TextBox tbAlphabet1;
		private System.Windows.Forms.Button btnAlphabetsSet;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiFile;
		private System.Windows.Forms.ToolStripMenuItem tsmiReadFromFile;
		private System.Windows.Forms.ToolStripMenuItem tsmiSaveToFile;
		private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
		private System.Windows.Forms.ToolStripMenuItem aboutCipersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutAuthorToolStripMenuItem;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.RadioButton rbAtbash;
		private System.Windows.Forms.RadioButton rbQwerty;
	}
}

