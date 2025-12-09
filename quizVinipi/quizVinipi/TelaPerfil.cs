/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 07/12/2025
 * Time: 16:45
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
	/// Description of TelaPerfil.
	/// </summary>
	public partial class TelaPerfil : Form
	{
		
		private Form telaAnterior;
		
		public TelaPerfil(Form telaAnteriorRecebida)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			telaAnterior = telaAnteriorRecebida;
			lblNomeUsuario.Text = DadosGlobais.NomeUsuario;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TelaPerfilLoad(object sender, EventArgs e)
		{
			lblPontuacao.Text = "Pontuação Total: " + DadosGlobais.PontuacaoTotal + " pontos ";
			lblQuizzes.Text = "Quizzes Feitos: " + DadosGlobais.QuizzesFeitos + " quizzes ";
			
		}
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			TelaAvatar novaTela = new TelaAvatar(this);
			novaTela.Show();
			this.Hide();
		}
		
		void PictureBoxClickVoltarClick(object sender, EventArgs e)
		{
			this.Close();
			if (telaAnterior != null)
				telaAnterior.Show();
		}
		
		void TelaPerfilActivated(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(DadosGlobais.AvatarSelecionado))
			{
				string caminho = Path.Combine(Application.StartupPath, DadosGlobais.AvatarSelecionado);
				if (File.Exists(caminho))
					pictureBoxAvatar.Image = Image.FromFile(caminho);
			}
		}
	}
}

