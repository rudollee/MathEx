using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathExtention;

namespace MathExExample
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.numPrimitive.Value = 285.30m;
			this.numInterval.Value = 2.5m;
		}

		private void num_ValueChanged(object sender, EventArgs e)
		{
			if (this.numInterval.Value != 0)
			{
				this.numResult.Value = MathEx.RoundEx(this.numPrimitive.Value, this.numInterval.Value);
				this.numPrimitive.Focus();
			}
		}
	}
}
