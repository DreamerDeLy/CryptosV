namespace CryptosV
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
			this.rbVigenere = new System.Windows.Forms.RadioButton();
			this.pnlColor = new System.Windows.Forms.Panel();
			this.lblSafety = new System.Windows.Forms.Label();
			this.rbNumber = new System.Windows.Forms.RadioButton();
			this.rbXor = new System.Windows.Forms.RadioButton();
			this.rbCaesar = new System.Windows.Forms.RadioButton();
			this.rbLitorea = new System.Windows.Forms.RadioButton();
			this.gbSettings = new System.Windows.Forms.GroupBox();
			this.tbVigenereKey = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbXORKey = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.nudCaesarKey = new System.Windows.Forms.NumericUpDown();
			this.btnSwap = new System.Windows.Forms.Button();
			this.btnCrear = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbAlphabet1 = new System.Windows.Forms.TextBox();
			this.tbAlphabet2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAlphabetsSet = new System.Windows.Forms.Button();
			this.gbMethod.SuspendLayout();
			this.pnlColor.SuspendLayout();
			this.gbSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCaesarKey)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rtbText
			// 
			this.rtbText.Location = new System.Drawing.Point(12, 12);
			this.rtbText.Name = "rtbText";
			this.rtbText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.rtbText.Size = new System.Drawing.Size(296, 337);
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
			this.rtbResult.Location = new System.Drawing.Point(314, 12);
			this.rtbResult.Name = "rtbResult";
			this.rtbResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.rtbResult.Size = new System.Drawing.Size(296, 337);
			this.rtbResult.TabIndex = 3;
			this.rtbResult.Text = "";
			// 
			// gbMethod
			// 
			this.gbMethod.Controls.Add(this.rbVigenere);
			this.gbMethod.Controls.Add(this.pnlColor);
			this.gbMethod.Controls.Add(this.rbNumber);
			this.gbMethod.Controls.Add(this.rbXor);
			this.gbMethod.Controls.Add(this.rbCaesar);
			this.gbMethod.Controls.Add(this.rbLitorea);
			this.gbMethod.Location = new System.Drawing.Point(616, 13);
			this.gbMethod.Name = "gbMethod";
			this.gbMethod.Size = new System.Drawing.Size(150, 336);
			this.gbMethod.TabIndex = 4;
			this.gbMethod.TabStop = false;
			this.gbMethod.Text = "Method";
			// 
			// rbVigenere
			// 
			this.rbVigenere.AutoSize = true;
			this.rbVigenere.Location = new System.Drawing.Point(7, 112);
			this.rbVigenere.Name = "rbVigenere";
			this.rbVigenere.Size = new System.Drawing.Size(67, 17);
			this.rbVigenere.TabIndex = 5;
			this.rbVigenere.Text = "Vigenere";
			this.rbVigenere.UseVisualStyleBackColor = true;
			this.rbVigenere.CheckedChanged += new System.EventHandler(this.rbVigenere_CheckedChanged);
			// 
			// pnlColor
			// 
			this.pnlColor.BackColor = System.Drawing.Color.Yellow;
			this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlColor.Controls.Add(this.lblSafety);
			this.pnlColor.Location = new System.Drawing.Point(7, 274);
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
			this.rbNumber.TabIndex = 3;
			this.rbNumber.Text = "A1Z26";
			this.rbNumber.UseVisualStyleBackColor = true;
			this.rbNumber.CheckedChanged += new System.EventHandler(this.rbNumber_CheckedChanged);
			// 
			// rbXor
			// 
			this.rbXor.AutoSize = true;
			this.rbXor.Location = new System.Drawing.Point(7, 89);
			this.rbXor.Name = "rbXor";
			this.rbXor.Size = new System.Drawing.Size(48, 17);
			this.rbXor.TabIndex = 2;
			this.rbXor.Text = "XOR";
			this.rbXor.UseVisualStyleBackColor = true;
			this.rbXor.CheckedChanged += new System.EventHandler(this.rbXor_CheckedChanged);
			// 
			// rbCaesar
			// 
			this.rbCaesar.AutoSize = true;
			this.rbCaesar.Checked = true;
			this.rbCaesar.Location = new System.Drawing.Point(6, 65);
			this.rbCaesar.Name = "rbCaesar";
			this.rbCaesar.Size = new System.Drawing.Size(58, 17);
			this.rbCaesar.TabIndex = 1;
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
			this.rbLitorea.TabIndex = 0;
			this.rbLitorea.Text = "Litorea";
			this.rbLitorea.UseVisualStyleBackColor = true;
			this.rbLitorea.CheckedChanged += new System.EventHandler(this.rbLitorea_CheckedChanged);
			// 
			// gbSettings
			// 
			this.gbSettings.Controls.Add(this.tbVigenereKey);
			this.gbSettings.Controls.Add(this.label3);
			this.gbSettings.Controls.Add(this.tbXORKey);
			this.gbSettings.Controls.Add(this.label2);
			this.gbSettings.Controls.Add(this.label1);
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Vigenere key";
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "XOR key";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Caesar shift";
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
			this.nudCaesarKey.ValueChanged += new System.EventHandler(this.nudCaesarKey_ValueChanged);
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
			// tbAlphabet1
			// 
			this.tbAlphabet1.Location = new System.Drawing.Point(10, 41);
			this.tbAlphabet1.Name = "tbAlphabet1";
			this.tbAlphabet1.Size = new System.Drawing.Size(226, 20);
			this.tbAlphabet1.TabIndex = 0;
			this.tbAlphabet1.Text = "adc";
			// 
			// tbAlphabet2
			// 
			this.tbAlphabet2.Location = new System.Drawing.Point(10, 68);
			this.tbAlphabet2.Name = "tbAlphabet2";
			this.tbAlphabet2.Size = new System.Drawing.Size(226, 20);
			this.tbAlphabet2.TabIndex = 1;
			this.tbAlphabet2.Text = "абв";
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
			// btnAlphabetsSet
			// 
			this.btnAlphabetsSet.Location = new System.Drawing.Point(242, 41);
			this.btnAlphabetsSet.Name = "btnAlphabetsSet";
			this.btnAlphabetsSet.Size = new System.Drawing.Size(47, 47);
			this.btnAlphabetsSet.TabIndex = 3;
			this.btnAlphabetsSet.Text = "SET";
			this.btnAlphabetsSet.UseVisualStyleBackColor = true;
			this.btnAlphabetsSet.Click += new System.EventHandler(this.btnAlphabetsSet_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 493);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.btnSwap);
			this.Controls.Add(this.gbSettings);
			this.Controls.Add(this.gbMethod);
			this.Controls.Add(this.rtbResult);
			this.Controls.Add(this.btnDecode);
			this.Controls.Add(this.btnCode);
			this.Controls.Add(this.rtbText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
			this.ResumeLayout(false);

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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nudCaesarKey;
		private System.Windows.Forms.Button btnSwap;
		private System.Windows.Forms.TextBox tbXORKey;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCrear;
		private System.Windows.Forms.RadioButton rbNumber;
		private System.Windows.Forms.Panel pnlColor;
		private System.Windows.Forms.Label lblSafety;
		private System.Windows.Forms.RadioButton rbVigenere;
		private System.Windows.Forms.TextBox tbVigenereKey;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbAlphabet2;
		private System.Windows.Forms.TextBox tbAlphabet1;
		private System.Windows.Forms.Button btnAlphabetsSet;
	}
}

