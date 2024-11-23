/*
 * Created by SharpDevelop.
 * User: yaell
 * Date: 21/11/2024
 * Time: 10:43 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tapetes_ger
{
	/// <summary>
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		private int total1;
		
		public Form4(int t1)
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
			Form5 form2 = new Form5(total1);
			form2.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		

		
		void Button3Click(object sender, EventArgs e)
		{
			int CEM, PER, AG;
			CEM = int.Parse(textBox1.Text);
			PER = int.Parse(textBox2.Text);
			AG = int.Parse(textBox3.Text);
			CEM = CEM * 50;
			PER = PER*150;
			AG = AG * 3;
			total1 = CEM + PER + AG;
		}
	}
}
