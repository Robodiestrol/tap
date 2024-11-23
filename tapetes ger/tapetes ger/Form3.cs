/*
 * Created by SharpDevelop.
 * User: yaell
 * Date: 21/11/2024
 * Time: 10:34 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tapetes_ger
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		private int total1;
		public Form3(int t1)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			total1 = t1;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form4 form9 = new Form4(total1);
			form9.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			int ase, fru, pin;
			ase = int.Parse(textBox1.Text);
			fru = int.Parse(textBox2.Text);
			pin = int.Parse(textBox3.Text);
			fru = fru * 100;
			ase = ase*100;
			pin = pin * 300;
			total1 = fru + ase + pin;
		}
	}
}
