/*
 * Created by SharpDevelop.
 * User: yaell
 * Date: 21/11/2024
 * Time: 08:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tapetes_ger
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		private int total = 0;
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form3 form2 = new Form3(total);
			form2.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		

		
		void Button3Click(object sender, EventArgs e)
		{
			int al, la, co, ma, oal;
			al = int.Parse(textBox1.Text);
			la = int.Parse(textBox2.Text);
			co = int.Parse(textBox3.Text);
			ma = int.Parse(textBox4.Text);
			oal = al * la;
			co = co * 102;
			total = co + ma;
			
		}
	}
}
