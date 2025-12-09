/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 01/12/2025
 * Time: 15:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quizVinipi
{
	/// <summary>
	/// Description of TelaErro.
	/// </summary>
	public partial class TelaErro : Form
	{
		public TelaErro()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PictureBoxClickVoltarClick(object sender, EventArgs e)
		{
			this.Close();		
		}
	}
}
