/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 30/11/2025
 * Time: 15:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quizVinipi
{
	/// <summary>
	/// Description of Quiz29.
	/// </summary>
	public partial class Quiz29 : Form
	{
		public Quiz29()
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
			IntroQuiz29 novaTela = new IntroQuiz29();
			novaTela.Show();
			this.Enabled = false;
			this.Hide();			
		}
			string AlternativaCorreta = "X";
		int pontos = 0;
			
		void BtnAlternativaAClick(object sender, EventArgs e)
		{
			if(AlternativaCorreta == "A"){
				MessageBox.Show("Parabéns, você acertou! =) ");
				pontos ++;
			}else{
				MessageBox.Show("Resposta Errada =( ");
			}
			panel1.Enabled = false;
		}
		
		void BtnAlternativaBClick(object sender, EventArgs e)
		{
			if(AlternativaCorreta == "B"){
				MessageBox.Show("Parabéns, você acertou! =) ");
				pontos ++;
			}else{
				MessageBox.Show("Resposta Errada =( ");
			}
			panel1.Enabled = false;
		}
		
		void BtnAlternativaCClick(object sender, EventArgs e)
		{
			if(AlternativaCorreta == "C"){
				MessageBox.Show("Parabéns, você acertou! =) ");
				pontos ++;
			}else{
				MessageBox.Show("Resposta Errada =( ");
			}
			panel1.Enabled = false;			
		}
		
		void BtnAlternativaDClick(object sender, EventArgs e)
		{
			if(AlternativaCorreta == "D"){
				MessageBox.Show("Parabéns, você acertou! =) ");
				pontos ++;
			}else{
				MessageBox.Show("Resposta Errada =( ");
			}
			panel1.Enabled = false;			
		}
		
			
		
		void Button1Click(object sender, EventArgs e)
		{
			Quiz29Pt2 novaTela = new Quiz29Pt2();
			novaTela.Show();
			this.Enabled = false;
			this.Hide();
		}
	}	
}
