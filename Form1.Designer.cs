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
			this.rtbText = new System.Windows.Forms.RichTextBox();
			this.btnCode = new System.Windows.Forms.Button();
			this.btnDecode = new System.Windows.Forms.Button();
			this.rtbResult = new System.Windows.Forms.RichTextBox();
			this.gbMethod = new System.Windows.Forms.GroupBox();
			this.rbXor = new System.Windows.Forms.RadioButton();
			this.rbCaesar = new System.Windows.Forms.RadioButton();
			this.rbLitorea = new System.Windows.Forms.RadioButton();
			this.gbSettings = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.nudCaesarKey = new System.Windows.Forms.NumericUpDown();
			this.btnSwap = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tbXORKey = new System.Windows.Forms.TextBox();
			this.btnCrear = new System.Windows.Forms.Button();
			this.gbMethod.SuspendLayout();
			this.gbSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCaesarKey)).BeginInit();
			this.SuspendLayout();
			// 
			// rtbText
			// 
			this.rtbText.Location = new System.Drawing.Point(12, 12);
			this.rtbText.Name = "rtbText";
			this.rtbText.Size = new System.Drawing.Size(296, 337);
			this.rtbText.TabIndex = 0;
			this.rtbText.Text = "";
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
			this.rtbResult.Size = new System.Drawing.Size(296, 337);
			this.rtbResult.TabIndex = 3;
			this.rtbResult.Text = "";
			// 
			// gbMethod
			// 
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
			// rbXor
			// 
			this.rbXor.AutoSize = true;
			this.rbXor.Location = new System.Drawing.Point(7, 66);
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
			this.rbCaesar.Location = new System.Drawing.Point(7, 43);
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
			this.rbLitorea.Location = new System.Drawing.Point(7, 20);
			this.rbLitorea.Name = "rbLitorea";
			this.rbLitorea.Size = new System.Drawing.Size(57, 17);
			this.rbLitorea.TabIndex = 0;
			this.rbLitorea.Text = "Litorea";
			this.rbLitorea.UseVisualStyleBackColor = true;
			this.rbLitorea.CheckedChanged += new System.EventHandler(this.rbLitorea_CheckedChanged);
			// 
			// gbSettings
			// 
			this.gbSettings.Controls.Add(this.tbXORKey);
			this.gbSettings.Controls.Add(this.label2);
			this.gbSettings.Controls.Add(this.label1);
			this.gbSettings.Controls.Add(this.nudCaesarKey);
			this.gbSettings.Location = new System.Drawing.Point(13, 385);
			this.gbSettings.Name = "gbSettings";
			this.gbSettings.Size = new System.Drawing.Size(753, 74);
			this.gbSettings.TabIndex = 5;
			this.gbSettings.TabStop = false;
			this.gbSettings.Text = "Settings";
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
			this.nudCaesarKey.Location = new System.Drawing.Point(75, 16);
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
			this.nudCaesarKey.Size = new System.Drawing.Size(120, 20);
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "XOR key";
			// 
			// tbXORKey
			// 
			this.tbXORKey.Location = new System.Drawing.Point(75, 43);
			this.tbXORKey.Name = "tbXORKey";
			this.tbXORKey.Size = new System.Drawing.Size(120, 20);
			this.tbXORKey.TabIndex = 4;
			this.tbXORKey.Text = "123";
			this.tbXORKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbXORKey_KeyPress);
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 471);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.btnSwap);
			this.Controls.Add(this.gbSettings);
			this.Controls.Add(this.gbMethod);
			this.Controls.Add(this.rtbResult);
			this.Controls.Add(this.btnDecode);
			this.Controls.Add(this.btnCode);
			this.Controls.Add(this.rtbText);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "CryptosV";
			this.gbMethod.ResumeLayout(false);
			this.gbMethod.PerformLayout();
			this.gbSettings.ResumeLayout(false);
			this.gbSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCaesarKey)).EndInit();
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
	}
}

