/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 30/11/2025
 * Time: 14:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quizVinipi
{
	/// <summary>
	/// Description of IntroQuiz29.
	/// </summary>
	public partial class IntroQuiz29 : Form
	{
		public IntroQuiz29()
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
			QuizzesAnteriores novaTela = new QuizzesAnteriores();
			novaTela.Show();
			this.Enabled = false;
			this.Hide();
		}
		
		void LinkLabelRankingLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			TelaRanking novaTela = new TelaRanking(this);
			novaTela.Show();
			this.Hide();
		}
		
		void BtnConhecerClick(object sender, EventArgs e)
		{
			Quiz29 novaTela = new Quiz29();
			novaTela.Show();
			this.Enabled = false;
			this.Hide();
		}
		
		void IntroQuiz29Load(object sender, EventArgs e)
		{
			
		}
		
		void IntroQuiz29Activated(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(DadosGlobais.AvatarSelecionado))
			{
				pictureBoxAvatar.Image = Image.FromFile(DadosGlobais.AvatarSelecionado);
			}
		}
		
		void LinkLabelPerfilLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			TelaPerfil novaTela = new TelaPerfil(this);
			novaTela.Show();
			this.Hide();			
		}
	}
}
