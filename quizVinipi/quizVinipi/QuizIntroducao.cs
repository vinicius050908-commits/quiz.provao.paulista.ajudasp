/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 23/10/2025
 * Time: 21:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace quizVinipi
{
	/// <summary>
	/// Description of QuizIntroducao.
	/// </summary>
	public partial class QuizIntroducao : Form
	{
		public QuizIntroducao()
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
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void PictureBox6Click(object sender, EventArgs e)
		{
			Inicio novaTela= new Inicio ();
			novaTela.Show();
			this.Enabled = false;
			this.Hide ();
		}
		
		void BtnConhecerClick(object sender, EventArgs e)
		{
			Quiz1 novaTela = new Quiz1();
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
		
		
		void QuizIntroducaoLoad(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(DadosGlobais.AvatarSelecionado))
			{
				string caminho = Path.Combine(Application.StartupPath, DadosGlobais.AvatarSelecionado);

				if (File.Exists(caminho))
				{
					pictureBoxAvatar.Image = Image.FromFile(caminho);
				}
			}
		}
		
		void LinkLabelPerfilLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			TelaPerfil novaTela = new TelaPerfil(this);
			novaTela.Show();
			this.Hide();
		}
		
		void QuizIntroducaoActivated(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(DadosGlobais.AvatarSelecionado))
			{
				pictureBoxAvatar.Image = Image.FromFile(DadosGlobais.AvatarSelecionado);
			}
		}
	}
}