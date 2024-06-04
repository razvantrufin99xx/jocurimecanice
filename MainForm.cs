/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/4/2024
 * Time: 5:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JocuriMecanice
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		Random r = new Random();
		string s = " ";
		public int rr()
		{
				 int a = r.Next(0,25);
				 int b = r.Next(0,25);
				 int c = r.Next(0,25);
				 int d = a+b+c;
				 s = a.ToString() + " , " + b.ToString() + " , " + c.ToString() + " = " + d.ToString();
				 return d;
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			int x = rr();
			Text = s ;
			Text += ": "+ x.ToString();
		}
		
	}
}
