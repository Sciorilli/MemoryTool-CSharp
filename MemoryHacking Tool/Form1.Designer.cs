namespace MemoryHacking_Tool
{
	partial class MainForm
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.processName = new System.Windows.Forms.TextBox();
			this.adresses = new System.Windows.Forms.RichTextBox();
			this.ByteValue = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.HexArray = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.ByteConverter = new System.Windows.Forms.TextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.textBoxConverter = new System.Windows.Forms.RichTextBox();
			this.ConvertBtn = new System.Windows.Forms.Button();
			this.Change = new System.Windows.Forms.Button();
			this.info = new System.Windows.Forms.Label();
			this.closelbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Maroon;
			this.panel1.Location = new System.Drawing.Point(-12, -24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(20, 458);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Maroon;
			this.panel2.Location = new System.Drawing.Point(25, 72);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(188, 10);
			this.panel2.TabIndex = 1;
			// 
			// processName
			// 
			this.processName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.processName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.processName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.processName.Location = new System.Drawing.Point(25, 53);
			this.processName.Name = "processName";
			this.processName.Size = new System.Drawing.Size(188, 19);
			this.processName.TabIndex = 2;
			this.processName.Text = "process name";
			this.processName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// adresses
			// 
			this.adresses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
			this.adresses.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.adresses.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adresses.Location = new System.Drawing.Point(25, 260);
			this.adresses.Name = "adresses";
			this.adresses.Size = new System.Drawing.Size(198, 150);
			this.adresses.TabIndex = 3;
			this.adresses.Text = "";
			// 
			// ByteValue
			// 
			this.ByteValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.ByteValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ByteValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ByteValue.Location = new System.Drawing.Point(25, 101);
			this.ByteValue.Name = "ByteValue";
			this.ByteValue.Size = new System.Drawing.Size(188, 19);
			this.ByteValue.TabIndex = 4;
			this.ByteValue.Text = "Hex Array (Find)";
			this.ByteValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Maroon;
			this.panel3.Location = new System.Drawing.Point(25, 120);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(188, 10);
			this.panel3.TabIndex = 3;
			// 
			// HexArray
			// 
			this.HexArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.HexArray.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.HexArray.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HexArray.Location = new System.Drawing.Point(25, 152);
			this.HexArray.Name = "HexArray";
			this.HexArray.Size = new System.Drawing.Size(188, 19);
			this.HexArray.TabIndex = 6;
			this.HexArray.Text = "Hex Array (Change)";
			this.HexArray.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Maroon;
			this.panel4.Location = new System.Drawing.Point(25, 171);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(188, 10);
			this.panel4.TabIndex = 5;
			// 
			// ByteConverter
			// 
			this.ByteConverter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.ByteConverter.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ByteConverter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ByteConverter.Location = new System.Drawing.Point(293, 53);
			this.ByteConverter.Name = "ByteConverter";
			this.ByteConverter.Size = new System.Drawing.Size(188, 19);
			this.ByteConverter.TabIndex = 8;
			this.ByteConverter.Text = "Value to bytes";
			this.ByteConverter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Maroon;
			this.panel5.Location = new System.Drawing.Point(293, 72);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(188, 10);
			this.panel5.TabIndex = 7;
			// 
			// textBoxConverter
			// 
			this.textBoxConverter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
			this.textBoxConverter.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxConverter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxConverter.Location = new System.Drawing.Point(293, 136);
			this.textBoxConverter.Name = "textBoxConverter";
			this.textBoxConverter.Size = new System.Drawing.Size(188, 70);
			this.textBoxConverter.TabIndex = 9;
			this.textBoxConverter.Text = "";
			// 
			// ConvertBtn
			// 
			this.ConvertBtn.BackColor = System.Drawing.Color.Maroon;
			this.ConvertBtn.FlatAppearance.BorderSize = 2;
			this.ConvertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ConvertBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConvertBtn.ForeColor = System.Drawing.Color.Black;
			this.ConvertBtn.Location = new System.Drawing.Point(293, 97);
			this.ConvertBtn.Name = "ConvertBtn";
			this.ConvertBtn.Size = new System.Drawing.Size(188, 33);
			this.ConvertBtn.TabIndex = 10;
			this.ConvertBtn.Text = "Convert";
			this.ConvertBtn.UseVisualStyleBackColor = false;
			this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
			// 
			// Change
			// 
			this.Change.BackColor = System.Drawing.Color.Maroon;
			this.Change.FlatAppearance.BorderSize = 2;
			this.Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Change.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Change.ForeColor = System.Drawing.Color.Black;
			this.Change.Location = new System.Drawing.Point(25, 201);
			this.Change.Name = "Change";
			this.Change.Size = new System.Drawing.Size(188, 46);
			this.Change.TabIndex = 11;
			this.Change.Text = "Change";
			this.Change.UseVisualStyleBackColor = false;
			this.Change.Click += new System.EventHandler(this.Change_Click);
			// 
			// info
			// 
			this.info.AutoSize = true;
			this.info.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.info.Location = new System.Drawing.Point(486, 399);
			this.info.Name = "info";
			this.info.Size = new System.Drawing.Size(47, 19);
			this.info.TabIndex = 12;
			this.info.Text = "INFO";
			this.info.Click += new System.EventHandler(this.info_Click);
			// 
			// closelbl
			// 
			this.closelbl.AutoSize = true;
			this.closelbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.closelbl.Location = new System.Drawing.Point(513, 3);
			this.closelbl.Name = "closelbl";
			this.closelbl.Size = new System.Drawing.Size(20, 19);
			this.closelbl.TabIndex = 13;
			this.closelbl.Text = "X";
			this.closelbl.Click += new System.EventHandler(this.closelbl_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(487, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 19);
			this.label1.TabIndex = 14;
			this.label1.Text = "-";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.ClientSize = new System.Drawing.Size(536, 422);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.closelbl);
			this.Controls.Add(this.info);
			this.Controls.Add(this.Change);
			this.Controls.Add(this.ConvertBtn);
			this.Controls.Add(this.textBoxConverter);
			this.Controls.Add(this.ByteConverter);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.HexArray);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.ByteValue);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.adresses);
			this.Controls.Add(this.processName);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Memory Hacking Tool";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox processName;
		private System.Windows.Forms.RichTextBox adresses;
		private System.Windows.Forms.TextBox ByteValue;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox HexArray;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox ByteConverter;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.RichTextBox textBoxConverter;
		private System.Windows.Forms.Button ConvertBtn;
		private System.Windows.Forms.Button Change;
		private System.Windows.Forms.Label info;
		private System.Windows.Forms.Label closelbl;
		private System.Windows.Forms.Label label1;
	}
}

