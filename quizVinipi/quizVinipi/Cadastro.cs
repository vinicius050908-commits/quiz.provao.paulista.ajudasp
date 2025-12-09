/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 23/10/2025
 * Time: 19:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.IO;

namespace quizVinipi
{
	/// <summary>
	/// Description of Cadastro.
	/// </summary>
	public partial class Cadastro : Form
	{
		public Cadastro()
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
		
		void BtnCadastrarClick(object sender, EventArgs e)
		{
			DadosGlobais.NomeUsuario = txtUsuario.Text;

			string nome = txtUsuario.Text.Trim();
			string usuario = txtUsuario.Text.Trim();
			if (usuario != null) {
				
			}
			string senha = txtSenha.Text.Trim();

			if (usuario == "" || senha == "" ){
				MessageBox.Show("Preencha todos os campos.");
			} else {
				bool  cadastrado = false;
				if (File.Exists(arquivo)){
					foreach(string linha in File.ReadAllLines(arquivo)){
						string[] dados = linha.Split(';');
						if (dados[0] == usuario){
							MessageBox.Show("Usuário já cadastrado.");
							return;
							
							
						}
					}
					if (cadastrado == false){
						using (StreamWriter sw = File.AppendText(arquivo)){
							sw.WriteLine(usuario + ";" + senha + ";" + DadosGlobais.AvatarSelecionado);
						}
						MessageBox.Show("Usuário cadastrado com sucesso.");
					}MainForm novaMainForm = new MainForm();
					novaMainForm.Show();
					this.Enabled = false;
					this.Hide();

				}
			}}
		void CadastrarLoad(object sender, EventArgs e)
		{
			
			
		}
		
		void LinkLabelEntrarLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MainForm novaTela = new MainForm();
			novaTela.Show();
			this.Enabled = false;
			this.Hide();
		}
		
		void PictureBoxAvatarClick(object sender, EventArgs e)
		{
			TelaAvatar novaTela = new TelaAvatar(this);
			novaTela.Show();
			this.Hide();
		}
		
		private void CadastroLoad(object sender, EventArgs e)
		{
			if (DadosGlobais.AvatarSelecionado != "")
			{
				pictureBoxAvatar.Image = Image.FromFile(DadosGlobais.AvatarSelecionado);
				pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
			}
		}
		
		void CadastroActivated(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(DadosGlobais.AvatarSelecionado))
			{
				pictureBoxAvatar.Image = Image.FromFile(DadosGlobais.AvatarSelecionado);
			}
		}
	}
}


