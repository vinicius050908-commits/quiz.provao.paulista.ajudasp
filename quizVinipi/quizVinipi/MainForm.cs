/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 23/10/2025
 * Time: 18:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace quizVinipi
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			

			
		}
		string arquivo = "usuarios.txt";
		void BtnEntrarClick(object sender, EventArgs e)
		{
			
			DadosGlobais.NomeUsuario = txtUsuario.Text;
			string nome = txtUsuario.Text.Trim();
			string usuario = txtUsuario.Text.Trim();
			string senha = txtSenha.Text.Trim();

			if (!File.Exists(arquivo)){
				MessageBox.Show("Nenhum usuário cadastrado com esse nome.");
				return;
				
			}
			
			bool encontrado = false;
			foreach (string linha in File.ReadAllLines(arquivo))
			{
				string[] dados = linha.Split(';');

				if (dados[0] == usuario && dados[1] == senha)
				{
					encontrado = true;

					// 🔹 Salva o nome do usuário logado
					DadosGlobais.NomeUsuario = usuario;

					// 🔹 Carrega o avatar salvo
					if (dados.Length >= 3)
						DadosGlobais.AvatarSelecionado = dados[2];
					else
						DadosGlobais.AvatarSelecionado = "";

					MessageBox.Show("Login realizado com sucesso.");
					MessageBox.Show("Seja bem-vindo(a), " + usuario);
					encontrado = true;
					break;
				}
			}

			if (encontrado == false) {
				MessageBox.Show("Usuário ou senha incorretos.");
				return;
			}
			Inicio novaTela = new Inicio();
			novaTela.Show();
			this.Enabled = false;
			this.Hide();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
	}
	
}


