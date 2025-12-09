/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 30/11/2025
 * Time: 16:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quizVinipi
{
	/// <summary>
	/// Description of ResultadosQuiz1.
	/// </summary>
	public partial class ResultadosQuiz1 : Form
	{
		public ResultadosQuiz1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			lblNomeUsuario.Text = DadosGlobais.NomeUsuario;
			
			lblPontosTotal.Text = "Pontos: " + DadosGlobais.Pontuacao + " pts ";
            lblTempoFinal.Text   = "Tempo gasto: " + DadosGlobais.TempoFinal;
            lblAcertos.Text      = "Acertos: " + DadosGlobais.Acertos;
            lblErros.Text        = "Erros: " + DadosGlobais.Erros;
            
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void LblTempoFinalClick(object sender, EventArgs e)
		{
			
		}
		
		void PictureBoxClickVoltarClick(object sender, EventArgs e)
		{
			Inicio novaTela = new Inicio();
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
		
		void ResultadosQuiz1Activated(object sender, EventArgs e)
		{
			pictureBoxAvatar.Image = Image.FromFile(DadosGlobais.AvatarSelecionado);
			}
		
		void LinkLabelPerfilLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			TelaPerfil novaTela = new TelaPerfil(this);
			novaTela.Show();
			this.Hide();			
		}
		
		}
	}

