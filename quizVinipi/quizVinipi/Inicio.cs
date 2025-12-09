/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 23/10/2025
 * Time: 19:38
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
	/// Description of Inicio.
	/// </summary>
	public partial class Inicio : Form
	{
		public Inicio()
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
		
		void BtnConhecerClick(object sender, EventArgs e)
		{
			QuizIntroducao novaTela = new QuizIntroducao();
			novaTela.Show();
			this.Enabled = false;
			this.Hide();
			
		}
		
		void LinkLabelAnterioresLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			QuizzesAnteriores novaTela = new QuizzesAnteriores();
			novaTela.Show();
			this.Enabled = false;
			this.Hide();
		}
		
		
		void LblNomeUsuarioClick(object sender, EventArgs e)
		{
			
		}
		
		void LinkLabelRankingLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			TelaRanking novaTela = new TelaRanking(this);
			novaTela.Show();
			this.Hide();
		}
		
		
		void InicioLoad(object sender, EventArgs e)
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
		
		void InicioActivated(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(DadosGlobais.AvatarSelecionado))
			{
				pictureBoxAvatar.Image = Image.FromFile(DadosGlobais.AvatarSelecionado);
			}
		}
	}
}
