/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 07/12/2025
 * Time: 15:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quizVinipi
{
	/// <summary>
	/// Description of TelaAvatar.
	/// </summary>
	public partial class TelaAvatar : Form
	{
		
		private Form telaAnterior;
		
		public TelaAvatar(Form telaAnteriorRecebida)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			telaAnterior = telaAnteriorRecebida;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			DadosGlobais.AvatarSelecionado = "Avatars/avatar1.png";
			DadosGlobais.AtualizarAvatarNoArquivo();
			this.Close();
			if (telaAnterior != null)
				telaAnterior.Show();
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			DadosGlobais.AvatarSelecionado = "Avatars/avatar2.png";
			DadosGlobais.AtualizarAvatarNoArquivo();
			this.Close();
			if (telaAnterior != null)
				telaAnterior.Show();
		}
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			DadosGlobais.AvatarSelecionado = "Avatars/avatar7.png";
			DadosGlobais.AtualizarAvatarNoArquivo();
			this.Close();
			if (telaAnterior != null)
				telaAnterior.Show();
		}
		
		void PictureBox4Click(object sender, EventArgs e)
		{
			DadosGlobais.AvatarSelecionado = "Avatars/avatar4.png";
			DadosGlobais.AtualizarAvatarNoArquivo();
			this.Close();
			if (telaAnterior != null)
				telaAnterior.Show();
		}
		
		void PictureBox5Click(object sender, EventArgs e)
		{
			DadosGlobais.AvatarSelecionado = "Avatars/avatar9.png";
			DadosGlobais.AtualizarAvatarNoArquivo();
			this.Close();
			if (telaAnterior != null)
				telaAnterior.Show();
		}
		
		void PictureBox6Click(object sender, EventArgs e)
		{
			DadosGlobais.AvatarSelecionado = "Avatars/avatar5.png";
			DadosGlobais.AtualizarAvatarNoArquivo();
			this.Close();
			if (telaAnterior != null)
				telaAnterior.Show();
		}
		
		void PictureBox7Click(object sender, EventArgs e)
		{
			DadosGlobais.AvatarSelecionado = "Avatars/avatar8.png";
			DadosGlobais.AtualizarAvatarNoArquivo();
			this.Close();
			if (telaAnterior != null)
				telaAnterior.Show();
		}
		
		void PictureBox8Click(object sender, EventArgs e)
		{
			DadosGlobais.AvatarSelecionado = "Avatars/avatar3.png";
			DadosGlobais.AtualizarAvatarNoArquivo();
			this.Close();
			if (telaAnterior != null)
				telaAnterior.Show();
		}
		
		void PictureBox9Click(object sender, EventArgs e)
		{
			DadosGlobais.AvatarSelecionado = "Avatars/avatar6.png";
			DadosGlobais.AtualizarAvatarNoArquivo();
			this.Close();
			if (telaAnterior != null)
				telaAnterior.Show();
		}
		
	}
}

