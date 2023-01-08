namespace VendingMachine.Win
{
	partial class FormVendingMachine
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonPutCoinIn = new System.Windows.Forms.Button();
			this.buttonProductOut = new System.Windows.Forms.Button();
			this.buttonCoinOut = new System.Windows.Forms.Button();
			this.textBoxPutCoinIn = new System.Windows.Forms.TextBox();
			this.textBoxCoinInMachine = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonPutCoinIn
			// 
			this.buttonPutCoinIn.Location = new System.Drawing.Point(468, 61);
			this.buttonPutCoinIn.Name = "buttonPutCoinIn";
			this.buttonPutCoinIn.Size = new System.Drawing.Size(107, 33);
			this.buttonPutCoinIn.TabIndex = 0;
			this.buttonPutCoinIn.Text = "投幣";
			this.buttonPutCoinIn.UseVisualStyleBackColor = true;
			this.buttonPutCoinIn.Click += new System.EventHandler(this.buttonPutCoinIn_Click);
			// 
			// buttonProductOut
			// 
			this.buttonProductOut.Location = new System.Drawing.Point(478, 354);
			this.buttonProductOut.Name = "buttonProductOut";
			this.buttonProductOut.Size = new System.Drawing.Size(97, 31);
			this.buttonProductOut.TabIndex = 1;
			this.buttonProductOut.Text = "出貨";
			this.buttonProductOut.UseVisualStyleBackColor = true;
			this.buttonProductOut.Click += new System.EventHandler(this.buttonProductOut_Click);
			// 
			// buttonCoinOut
			// 
			this.buttonCoinOut.Location = new System.Drawing.Point(360, 354);
			this.buttonCoinOut.Name = "buttonCoinOut";
			this.buttonCoinOut.Size = new System.Drawing.Size(97, 31);
			this.buttonCoinOut.TabIndex = 2;
			this.buttonCoinOut.Text = "退幣";
			this.buttonCoinOut.UseVisualStyleBackColor = true;
			this.buttonCoinOut.Click += new System.EventHandler(this.buttonCoinOut_Click);
			// 
			// textBoxPutCoinIn
			// 
			this.textBoxPutCoinIn.Location = new System.Drawing.Point(134, 67);
			this.textBoxPutCoinIn.Name = "textBoxPutCoinIn";
			this.textBoxPutCoinIn.Size = new System.Drawing.Size(297, 25);
			this.textBoxPutCoinIn.TabIndex = 3;
			// 
			// textBoxCoinInMachine
			// 
			this.textBoxCoinInMachine.Location = new System.Drawing.Point(134, 116);
			this.textBoxCoinInMachine.Multiline = true;
			this.textBoxCoinInMachine.Name = "textBoxCoinInMachine";
			this.textBoxCoinInMachine.ReadOnly = true;
			this.textBoxCoinInMachine.Size = new System.Drawing.Size(441, 219);
			this.textBoxCoinInMachine.TabIndex = 4;
			// 
			// FormVendingMachine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(707, 450);
			this.Controls.Add(this.textBoxCoinInMachine);
			this.Controls.Add(this.textBoxPutCoinIn);
			this.Controls.Add(this.buttonCoinOut);
			this.Controls.Add(this.buttonProductOut);
			this.Controls.Add(this.buttonPutCoinIn);
			this.Name = "FormVendingMachine";
			this.Text = "FormVendingMachine";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonPutCoinIn;
		private System.Windows.Forms.Button buttonProductOut;
		private System.Windows.Forms.Button buttonCoinOut;
		private System.Windows.Forms.TextBox textBoxPutCoinIn;
		private System.Windows.Forms.TextBox textBoxCoinInMachine;
	}
}

