/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 23/10/2025
 * Time: 22:21
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
	/// Description of Quiz1.
	/// </summary>
	public partial class Quiz1 : Form
	{
		public Quiz1()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			lblNomeUsuario.Text = DadosGlobais.NomeUsuario;
			lblPontuacao.Text = "Pontos: " + DadosGlobais.Pontuacao;
			timerQuiz1.Start(); // inicia o contador
			
			inicioQuiz = DateTime.Now;
			timerQuiz1.Start();
			
			BtnQ1Click(null, null);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		string AlternativaCorreta = "X";
		int pontos = 0;
		int tempoRestante = 3600;
		
		int questaoAtual = 1;
		int totalQuestoes = 10;
		
		DateTime inicioQuiz;
		
		
		void CarregarProximaQuestao()
		{
			
			if (btnQ2.Enabled == true) { BtnQ2Click(null, null); return; }
			if (btnQ3.Enabled == true) { BtnQ3Click(null, null); return; }
			if (btnQ4.Enabled == true) { BtnQ4Click(null, null); return; }
			if (btnQ5.Enabled == true) { BtnQ5Click(null, null); return; }
			if (btnQ6.Enabled == true) { BtnQ6Click(null, null); return; }
			if (btnQ7.Enabled == true) { BtnQ7Click(null, null); return; }
			if (btnQ8.Enabled == true) { BtnQ8Click(null, null); return; }
			if (btnQ9.Enabled == true) { BtnQ9Click(null, null); return; }
			if (btnQ10.Enabled == true) { BtnQ10Click(null, null); return; }}
		
		
		
		string GetTextoAlternativa(string letra)
		{
			if (letra == "A") return lblRespostaA.Text;
			if (letra == "B") return lblRespostaB.Text;
			if (letra == "C") return lblRespostaC.Text;
			if (letra == "D") return lblRespostaD.Text;
			if (letra == "E") return lblRespostaE.Text;

			return "";
		}
		
		void PictureBoxClickVoltarClick(object sender, EventArgs e)
		{
			QuizIntroducao novaTela = new QuizIntroducao();
			novaTela.Show();
			this.Enabled = false;
			this.Hide();
			DadosGlobais.Pontuacao = 0;
		}
		
		void BtnAlternativaAClick(object sender, EventArgs e)
		{
			if(AlternativaCorreta == "A"){
				TelaAcerto ta = new TelaAcerto();
				ta.lblPontos.Text = "+15 pontos\r\nPontos: " + DadosGlobais.Pontuacao.ToString();
				ta.ShowDialog();
				DadosGlobais.Pontuacao += 15;
				DadosGlobais.Acertos++;
				lblPontuacao.Text = "Pontos: " + DadosGlobais.Pontuacao;
			}else{
				TelaErro te = new TelaErro();
				string letraCorreta = AlternativaCorreta;
				string textoCorreto = GetTextoAlternativa(letraCorreta);
				te.lblMensagem.Text = "A resposta correta era:\r\n" + letraCorreta + " - " + textoCorreto;
				te.lblPontos.Text = "Pontos: " + DadosGlobais.Pontuacao.ToString();
				te.ShowDialog();
				DadosGlobais.Erros++;
			}
			panel1.Enabled = false;
			
			CarregarProximaQuestao();
		}
		
		void BtnAlternativaBClick(object sender, EventArgs e)
		{
			if(AlternativaCorreta == "B"){
				TelaAcerto ta = new TelaAcerto();
				ta.lblPontos.Text = "+15 pontos\r\nPontos: " + DadosGlobais.Pontuacao.ToString();
				ta.ShowDialog();
				DadosGlobais.Pontuacao += 15;
				DadosGlobais.Acertos++;
				lblPontuacao.Text = "Pontos: " + DadosGlobais.Pontuacao;
			}else{
				TelaErro te = new TelaErro();
				string letraCorreta = AlternativaCorreta;
				string textoCorreto = GetTextoAlternativa(letraCorreta);
				te.lblMensagem.Text = "A resposta correta era:\r\n" + letraCorreta + " - " + textoCorreto;
				te.lblPontos.Text = "Pontos: " + DadosGlobais.Pontuacao.ToString();
				te.ShowDialog();
				DadosGlobais.Erros++;
			}
			panel1.Enabled = false;
			
			CarregarProximaQuestao();
		}
		
		void BtnAlternativaCClick(object sender, EventArgs e)
		{
			if(AlternativaCorreta == "C"){
				TelaAcerto ta = new TelaAcerto();
				ta.lblPontos.Text = "+15 pontos\r\nPontos: " + DadosGlobais.Pontuacao.ToString();
				ta.ShowDialog();
				DadosGlobais.Pontuacao += 15;
				DadosGlobais.Acertos++;
				lblPontuacao.Text = "Pontos: " + DadosGlobais.Pontuacao;
			}else{
				TelaErro te = new TelaErro();
				string letraCorreta = AlternativaCorreta;
				string textoCorreto = GetTextoAlternativa(letraCorreta);
				te.lblMensagem.Text = "A resposta correta era:\r\n" + letraCorreta + " - " + textoCorreto;
				te.lblPontos.Text = "Pontos: " + DadosGlobais.Pontuacao.ToString();
				te.ShowDialog();
				DadosGlobais.Erros++;
			}
			panel1.Enabled = false;

			CarregarProximaQuestao();
		}
		
		void BtnAlternativaDClick(object sender, EventArgs e)
		{
			if(AlternativaCorreta == "D"){
				TelaAcerto ta = new TelaAcerto();
				ta.lblPontos.Text = "+15 pontos\r\nPontos: " + DadosGlobais.Pontuacao.ToString();
				ta.ShowDialog();
				DadosGlobais.Pontuacao += 15;
				DadosGlobais.Acertos++;
				lblPontuacao.Text = "Pontos: " + DadosGlobais.Pontuacao;
			}else{
				TelaErro te = new TelaErro();
				string letraCorreta = AlternativaCorreta;
				string textoCorreto = GetTextoAlternativa(letraCorreta);
				te.lblMensagem.Text = "A resposta correta era:\r\n" + letraCorreta + " - " + textoCorreto;
				te.lblPontos.Text = "Pontos: " + DadosGlobais.Pontuacao.ToString();
				te.ShowDialog();
				DadosGlobais.Erros++;
			}
			panel1.Enabled = false;

			CarregarProximaQuestao();
		}
		
		void BtnQ1Click(object sender, EventArgs e)
		{
			lblNumeroQuestao.Text = "1º";
			questaoAtual = 2;
			
			lblPergunta.Text = "Durante o processo de fotossíntese, as plantas utilizam a luz solar para transformar gás carbônico e água em glicose, liberando oxigênio. Esse processo é essencial para o equilíbrio da vida na Terra. Qual é o principal objetivo da fotossíntese para a planta?";
			lblRespostaA.Text = "Absorver oxigênio do ar.";
			lblRespostaB.Text = "Eliminar o excesso de gás carbônico.";
			lblRespostaC.Text = "Controlar a temperatura do ambiente.";
			lblRespostaD.Text = "Produzir energia em forma de glicose.";
			lblRespostaE.Text = "Captar água do solo.";
			AlternativaCorreta = "D";
			
			panel1.Enabled = true;
			btnQ1.Enabled = false;
			btnQ2.Enabled = true;
		}
		
		void BtnQ2Click(object sender, EventArgs e)
		{
			lblNumeroQuestao.Text = questaoAtual + "º";
			questaoAtual++;
			
			lblPergunta.Text = "Ao soltar uma bola de uma certa altura, ela acelera até tocar o chão, mesmo sem ser empurrada. Isso acontece por causa de uma força natural que atua sobre todos os corpos com massa. Que força é essa?";
			lblRespostaA.Text = "Força elástica.";
			lblRespostaB.Text = "Força de atrito.";
			lblRespostaC.Text = "Força da gravidade.";
			lblRespostaD.Text = "Força centrípeta.";
			lblRespostaE.Text = "Força magnética.";
			AlternativaCorreta = "C";
			
			panel1.Enabled = true;
			btnQ2.Enabled = false;
			btnQ3.Enabled = true;
			
		}
		
		void BtnQ3Click(object sender, EventArgs e)
		{
			lblNumeroQuestao.Text = questaoAtual + "º";
			questaoAtual++;
			
			lblPergunta.Text = "Um estudante aumenta a frequência de uma onda sonora produzida por um alto-falante, mantendo a velocidade do som constante. O que acontece com o comprimento da onda?";
			lblRespostaA.Text = "Aumenta.";
			lblRespostaB.Text = "Diminui.";
			lblRespostaC.Text = "Permanece constante.";
			lblRespostaD.Text = "Dobra.";
			lblRespostaE.Text = "Torna-se imprevisível.";
			AlternativaCorreta = "B";
			
			panel1.Enabled = true;
			btnQ3.Enabled = false;
			btnQ4.Enabled = true;
		}
		
		
		
		void BtnAlnternativaEClick(object sender, EventArgs e)
		{
			if(AlternativaCorreta == "E"){
				TelaAcerto ta = new TelaAcerto();
				ta.lblPontos.Text = "+15 pontos\r\nPontos: " + DadosGlobais.Pontuacao.ToString();
				ta.ShowDialog();
				DadosGlobais.Pontuacao += 15;
				DadosGlobais.Acertos++;
				lblPontuacao.Text = "Pontos: " + DadosGlobais.Pontuacao;
			}else{
				TelaErro te = new TelaErro();
				string letraCorreta = AlternativaCorreta;
				string textoCorreto = GetTextoAlternativa(letraCorreta);
				te.lblMensagem.Text = "A resposta correta era:\r\n" + letraCorreta + " - " + textoCorreto;
				te.lblPontos.Text = "Pontos: " + DadosGlobais.Pontuacao.ToString();
				te.ShowDialog();
				DadosGlobais.Erros++;
			}
			panel1.Enabled = false;
			
			CarregarProximaQuestao();
		}
		
		
		void BtnQ4Click(object sender, EventArgs e)
		{
			lblNumeroQuestao.Text = questaoAtual + "º";
			questaoAtual++;
			
			lblPergunta.Text = "Uma solução apresenta pOH = 3. Qual é o valor aproximado do pH da solução?";
			lblRespostaA.Text = "3";
			lblRespostaB.Text = "7";
			lblRespostaC.Text = "9";
			lblRespostaD.Text = "11";
			lblRespostaE.Text = "14";
			AlternativaCorreta = "D";
			
			panel1.Enabled = true;
			btnQ4.Enabled = false;
			btnQ5.Enabled = true;
		}
		
		void BtnQ5Click(object sender, EventArgs e)
		{
			lblNumeroQuestao.Text = questaoAtual + "º";
			questaoAtual++;
			
			lblPergunta.Text = "Na respiração celular aeróbica, a maior produção de ATP ocorre em:";
			lblRespostaA.Text = "Citoplasma.";
			lblRespostaB.Text = "Núcleo.";
			lblRespostaC.Text = "Complexo Golgiense.";
			lblRespostaD.Text = "Mitocôndria.";
			lblRespostaE.Text = "Retículo endoplasmático.";
			AlternativaCorreta = "D";
			
			panel1.Enabled = true;
			btnQ5.Enabled = false;
			btnQ6.Enabled = true;
		}
		
		void BtnQ6Click(object sender, EventArgs e)
		{
			lblNumeroQuestao.Text = questaoAtual + "º";
			questaoAtual++;
			
			lblPergunta.Text = "Em um circuito elétrico simples, a resistência total aumenta quando:";
			lblRespostaA.Text = "resistores em paralelo são adicionados.";
			lblRespostaB.Text = "a tensão é aumentada.";
			lblRespostaC.Text = "resistores em série são adicionados.";
			lblRespostaD.Text = "a corrente aumenta.";
			lblRespostaE.Text = "o resistor é retirado.";
			AlternativaCorreta = "C";
			
			panel1.Enabled = true;
			btnQ6.Enabled = false;
			btnQ7.Enabled = true;
		}
		
		void BtnQ7Click(object sender, EventArgs e)
		{
			lblNumeroQuestao.Text = questaoAtual + "º";
			questaoAtual++;
			
			lblPergunta.Text = "Considere a equação não balanceada:\n\n" +
				"Al + O₂ → Al₂O₃\n\n" +
				"O coeficiente correto do O₂ na equação balanceada é:";
			
			lblRespostaA.Text = "1";
			lblRespostaB.Text = "2";
			lblRespostaC.Text = "3";
			lblRespostaD.Text = "4";
			lblRespostaE.Text = "5";
			AlternativaCorreta = "C";
			
			panel1.Enabled = true;
			btnQ7.Enabled = false;
			btnQ8.Enabled = true;
		}
		
		void BtnQ8Click(object sender, EventArgs e)
		{
			lblNumeroQuestao.Text = questaoAtual + "º";
			questaoAtual++;
			
			lblPergunta.Text = "Uma mutação que não altera o aminoácido produzido é chamada de:";
			lblRespostaA.Text = "Mutação nonsense.";
			lblRespostaB.Text = "Mutação de inserção.";
			lblRespostaC.Text = "Mutação silenciosa.";
			lblRespostaD.Text = "Mutação frameshift.";
			lblRespostaE.Text = "Mutação de deleção.";
			AlternativaCorreta = "C";
			
			panel1.Enabled = true;
			btnQ8.Enabled = false;
			btnQ9.Enabled = true;
		}
		
		void BtnQ9Click(object sender, EventArgs e)
		{
			lblNumeroQuestao.Text = questaoAtual + "º";
			questaoAtual++;
			
			lblPergunta.Text = "Um objeto está sobre uma superfície horizontal sem atrito, sendo puxado com força constante. O que acontece com a velocidade dele?";
			lblRespostaA.Text = "Permanece constante.";
			lblRespostaB.Text = "Aumenta continuamente.";
			lblRespostaC.Text = "Diminui continuamente.";
			lblRespostaD.Text = "Zera após certo tempo.";
			lblRespostaE.Text = "Oscila.";
			AlternativaCorreta = "B";
			
			panel1.Enabled = true;
			btnQ9.Enabled = false;
			btnQ10.Enabled = true;
		}
		
		void BtnQ10Click(object sender, EventArgs e)
		{
			lblNumeroQuestao.Text = questaoAtual + "º";
			questaoAtual++;
			
			lblPergunta.Text = "A queima de combustíveis fósseis contribui para o aquecimento global porque libera:";
			lblRespostaA.Text = "N₂";
			lblRespostaB.Text = "O₂";
			lblRespostaC.Text = "CO₂.";
			lblRespostaD.Text = "H₂O pura";
			lblRespostaE.Text = "He";
			AlternativaCorreta = "C";
			
			panel1.Enabled = true;
			btnQ10.Enabled = false;
		}
		
		
		void LblPontuacaoClick(object sender, EventArgs e)
		{
			lblPontuacao.Text = "Pontos: " + DadosGlobais.Pontuacao;
		}
		
		void TimerQuiz1Tick(object sender, EventArgs e)
		{
			tempoRestante--;

			int horas = tempoRestante / 3600;
			int minutos = (tempoRestante % 3600) / 60;
			int segundos = tempoRestante % 60;

			lblTempo.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", horas, minutos, segundos);

			if (tempoRestante == 300)
			{
				lblTempo.ForeColor = Color.Red;
			}
			
			if (tempoRestante <= 0)
			{
				timerQuiz1.Stop();
				lblTempo.Text = "00:00:00";

				MessageBox.Show("⏰ O tempo acabou! Seu quiz será encerrado.");


				panel1.Enabled = false;

			}
		}
		
		
		void BtnConcluirClick(object sender, EventArgs e)
		{
			try
			{
				timerQuiz1.Stop();
				
				TimeSpan tempoGasto = DateTime.Now - inicioQuiz;
				DadosGlobais.TempoFinal = tempoGasto.ToString(@"hh\:mm\:ss");
				
				int pontosFinais = DadosGlobais.Pontuacao;
				DadosGlobais.QuizzesFeitos++;
				DadosGlobais.PontuacaoTotal += pontosFinais;
				
				string nomeJogador = DadosGlobais.NomeUsuario;
				if (string.IsNullOrWhiteSpace(nomeJogador))
				{
					nomeJogador = "Jogador";
				}
				
				string caminho = "pontuacoes.txt";
				using (StreamWriter sw = File.AppendText(caminho))
				{
					sw.WriteLine(nomeJogador + ", " + pontosFinais);
				}
				
				ResultadosQuiz1 novaTela = new ResultadosQuiz1();
				novaTela.Show();
				this.Enabled = false;
				this.Hide();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao concluir quiz / salvar pontuação: " + ex.Message);
			}
			
		}
		
		
		void Quiz1Activated(object sender, EventArgs e)
		{
			pictureBoxAvatar.Image = Image.FromFile(DadosGlobais.AvatarSelecionado);
		}
	}
}


