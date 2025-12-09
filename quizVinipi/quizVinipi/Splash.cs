/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 30/11/2025
 * Time: 16:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quizVinipi
{
	/// <summary>
	/// Description of Splash.
	/// </summary>
	public partial class Splash : Form
	{
		public Splash()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TimerSplashTick(object sender, EventArgs e)
		{
			timerSplash.Stop();

   	 	 	MainForm novaTela = new MainForm();
    		novaTela.Show();
			this.Enabled = false;
			this.Hide();
		}
		
		void SplashLoad(object sender, EventArgs e)
		{
			timerSplash.Start();
		}
	}
}
