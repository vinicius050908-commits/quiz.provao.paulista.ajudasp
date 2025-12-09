/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 30/11/2025
 * Time: 11:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quizVinipi
{
	/// <summary>
	/// Description of QuizzesAnteriores.
	/// </summary>
	public partial class QuizzesAnteriores : Form
	{
		public QuizzesAnteriores()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			lblNomeUsuario.Text = DadosGlobais.NomeUsuario;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PictureBoxClickVoltarClick(object sender, EventArgs e)
		{
			Inicio novaTela= new Inicio ();
			novaTela.Show();
			this.Enabled = false;
			this.Hide ();
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			
		}
		
		void QuizzesAnterioresLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
		}
		
		void LinkLabelRankingLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			TelaRanking novaTela = new TelaRanking(this);
			novaTela.Show();
			this.Hide();
		}
		
		
		
		void QuizzesAnterioresActivated(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(DadosGlobais.AvatarSelecionado))
			{
				pictureBoxAvatar.Image = Image.FromFile(DadosGlobais.AvatarSelecionado);
			}
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			TelaPerfil novaTela = new TelaPerfil(this);
			novaTela.Show();
			this.Hide();
		}
		
	}
}