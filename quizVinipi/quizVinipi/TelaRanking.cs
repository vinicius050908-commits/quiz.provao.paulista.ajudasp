using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace quizVinipi
{
	public partial class TelaRanking : Form
	{
		private Form telaAnterior;

		public TelaRanking(Form telaAnteriorRecebida)
		{
			InitializeComponent();
			telaAnterior = telaAnteriorRecebida;
			lblNomeUsuario.Text = DadosGlobais.NomeUsuario;
		}

		void TelaRankingLoad(object sender, EventArgs e)
		{
			try
			{
				string caminhoArquivo = "pontuacoes.txt";

				if (!File.Exists(caminhoArquivo))
				{
					MessageBox.Show("Arquivo 'pontuacoes.txt' não encontrado!");
					return;
				}

				string[] linhas = File.ReadAllLines(caminhoArquivo);

				int qtd = linhas.Length;
				string[] nomes = new string[qtd];
				int[] pontos = new int[qtd];
				int contador = 0;

				foreach (string linha in linhas)
				{
					string[] partes = linha.Split(',');

					if (partes.Length == 2)
					{
						string nome = partes[0].Trim();

						int valor;

						if (int.TryParse(partes[1].Trim(), out valor))
						{
							nomes[contador] = nome;
							pontos[contador] = valor;
							contador++;
						}
					}
				}

				// Ordenação decrescente
				for (int i = 0; i < contador - 1; i++)
				{
					for (int j = i + 1; j < contador; j++)
					{
						if (pontos[j] > pontos[i])
						{
							int tempP = pontos[i];
							pontos[i] = pontos[j];
							pontos[j] = tempP;

							string tempN = nomes[i];
							nomes[i] = nomes[j];
							nomes[j] = tempN;
						}
					}
				}

				// Configuração da DataGridView
				dataGridView1.Columns.Clear();
				dataGridView1.Rows.Clear();
				dataGridView1.ReadOnly = true;
				dataGridView1.AllowUserToAddRows = false;
				dataGridView1.RowHeadersVisible = false;
				dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

				dataGridView1.Columns.Add("Posicao", "Posição");
				dataGridView1.Columns.Add("Nome", "Nome");
				dataGridView1.Columns.Add("Pontos", "Pontos");

				for (int i = 0; i < contador; i++)
				{
					dataGridView1.Rows.Add((i + 1).ToString() + "º", nomes[i], pontos[i]);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao carregar o arquivo: " + ex.Message);
			}
		}

		void DataGridView1RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			// 1º
			if (dataGridView1.Rows.Count > 0)
				dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Gold;

			// 2º
			if (dataGridView1.Rows.Count > 1)
				dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Silver;

			// 3º
			if (dataGridView1.Rows.Count > 2)
				dataGridView1.Rows[2].DefaultCellStyle.BackColor = Color.Peru;
		}
		
		void PictureBoxClickVoltarClick(object sender, EventArgs e)
		{
			this.Close();
			if (telaAnterior != null)
				telaAnterior.Show();
		}
		
		private void TelaRanking_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (telaAnterior != null)
				telaAnterior.Show();
		}
		
		void TelaRankingActivated(object sender, EventArgs e)
		{
			pictureBoxAvatar.Image = Image.FromFile(DadosGlobais.AvatarSelecionado);
		}
	}
}

