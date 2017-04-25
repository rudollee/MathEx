namespace MathExExample
{
	partial class Form1
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
			this.numPrimitive = new System.Windows.Forms.NumericUpDown();
			this.numInterval = new System.Windows.Forms.NumericUpDown();
			this.lblInterval = new System.Windows.Forms.Label();
			this.lblResult = new System.Windows.Forms.Label();
			this.numResult = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numPrimitive)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numResult)).BeginInit();
			this.SuspendLayout();
			// 
			// numPrimitive
			// 
			this.numPrimitive.DecimalPlaces = 2;
			this.numPrimitive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.numPrimitive.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numPrimitive.Location = new System.Drawing.Point(91, 13);
			this.numPrimitive.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numPrimitive.Name = "numPrimitive";
			this.numPrimitive.Size = new System.Drawing.Size(90, 29);
			this.numPrimitive.TabIndex = 1;
			this.numPrimitive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numPrimitive.ValueChanged += new System.EventHandler(this.num_ValueChanged);
			// 
			// numInterval
			// 
			this.numInterval.DecimalPlaces = 2;
			this.numInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.numInterval.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numInterval.Location = new System.Drawing.Point(90, 48);
			this.numInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numInterval.Name = "numInterval";
			this.numInterval.Size = new System.Drawing.Size(90, 29);
			this.numInterval.TabIndex = 2;
			this.numInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numInterval.ValueChanged += new System.EventHandler(this.num_ValueChanged);
			// 
			// lblInterval
			// 
			this.lblInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblInterval.Location = new System.Drawing.Point(12, 48);
			this.lblInterval.Name = "lblInterval";
			this.lblInterval.Size = new System.Drawing.Size(72, 29);
			this.lblInterval.TabIndex = 1;
			this.lblInterval.Text = "Interval";
			this.lblInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblResult
			// 
			this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblResult.Location = new System.Drawing.Point(12, 80);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(72, 29);
			this.lblResult.TabIndex = 1;
			this.lblResult.Text = "Result";
			this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numResult
			// 
			this.numResult.DecimalPlaces = 2;
			this.numResult.Enabled = false;
			this.numResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.numResult.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numResult.Location = new System.Drawing.Point(90, 83);
			this.numResult.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numResult.Name = "numResult";
			this.numResult.ReadOnly = true;
			this.numResult.Size = new System.Drawing.Size(90, 29);
			this.numResult.TabIndex = 0;
			this.numResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(194, 128);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.lblInterval);
			this.Controls.Add(this.numResult);
			this.Controls.Add(this.numInterval);
			this.Controls.Add(this.numPrimitive);
			this.Name = "Form1";
			this.Text = "MathEx";
			((System.ComponentModel.ISupportInitialize)(this.numPrimitive)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numResult)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numPrimitive;
		private System.Windows.Forms.NumericUpDown numInterval;
		private System.Windows.Forms.Label lblInterval;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.NumericUpDown numResult;
	}
}

