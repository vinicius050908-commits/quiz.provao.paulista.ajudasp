/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 23/10/2025
 * Time: 18:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace quizVinipi
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.picLogo1 = new System.Windows.Forms.PictureBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.lblConta = new System.Windows.Forms.Label();
			this.linkLabelCadastro = new System.Windows.Forms.LinkLabel();
			this.lblTexto1 = new System.Windows.Forms.Label();
			this.lblTexto2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel1.Location = new System.Drawing.Point(-3, 296);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(633, 44);
			this.panel1.TabIndex = 0;
			// 
			// picLogo1
			// 
			this.picLogo1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.picLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.picLogo1.Cursor = System.Windows.Forms.Cursors.Default;
			this.picLogo1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picLogo1.ErrorImage")));
			this.picLogo1.Image = ((System.Drawing.Image)(resources.GetObject("picLogo1.Image")));
			this.picLogo1.Location = new System.Drawing.Point(326, 12);
			this.picLogo1.Name = "picLogo1";
			this.picLogo1.Size = new System.Drawing.Size(125, 102);
			this.picLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picLogo1.TabIndex = 1;
			this.picLogo1.TabStop = false;
			// 
			// txtSenha
			// 
			this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtSenha.Location = new System.Drawing.Point(267, 180);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(243, 22);
			this.txtSenha.TabIndex = 2;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(267, 131);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(243, 22);
			this.txtUsuario.TabIndex = 3;
			// 
			// btnEntrar
			// 
			this.btnEntrar.BackColor = System.Drawing.Color.Red;
			this.btnEntrar.Font = new System.Drawing.Font("Corbel", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntrar.ForeColor = System.Drawing.Color.White;
			this.btnEntrar.Location = new System.Drawing.Point(267, 210);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(243, 45);
			this.btnEntrar.TabIndex = 6;
			this.btnEntrar.Text = "Entrar";
			this.btnEntrar.UseVisualStyleBackColor = false;
			this.btnEntrar.Click += new System.EventHandler(this.BtnEntrarClick);
			// 
			// lblConta
			// 
			this.lblConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConta.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lblConta.Location = new System.Drawing.Point(248, 265);
			this.lblConta.Name = "lblConta";
			this.lblConta.Size = new System.Drawing.Size(145, 23);
			this.lblConta.TabIndex = 7;
			this.lblConta.Text = "Não tem uma conta?";
			// 
			// linkLabelCadastro
			// 
			this.linkLabelCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabelCadastro.ForeColor = System.Drawing.Color.MidnightBlue;
			this.linkLabelCadastro.LinkColor = System.Drawing.Color.MidnightBlue;
			this.linkLabelCadastro.Location = new System.Drawing.Point(384, 264);
			this.linkLabelCadastro.Name = "linkLabelCadastro";
			this.linkLabelCadastro.Size = new System.Drawing.Size(137, 23);
			this.linkLabelCadastro.TabIndex = 8;
			this.linkLabelCadastro.TabStop = true;
			this.linkLabelCadastro.Text = "Cadastre-se aqui";
			this.linkLabelCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelCadastroLinkClicked);
			// 
			// lblTexto1
			// 
			this.lblTexto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTexto1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lblTexto1.Location = new System.Drawing.Point(28, 12);
			this.lblTexto1.Name = "lblTexto1";
			this.lblTexto1.Size = new System.Drawing.Size(207, 79);
			this.lblTexto1.TabIndex = 9;
			this.lblTexto1.Text = "Bem vindo ao Ajuda SP!";
			// 
			// lblTexto2
			// 
			this.lblTexto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTexto2.Location = new System.Drawing.Point(28, 97);
			this.lblTexto2.Name = "lblTexto2";
			this.lblTexto2.Size = new System.Drawing.Size(180, 100);
			this.lblTexto2.TabIndex = 10;
			this.lblTexto2.Text = "Junte-se a nós para ainda mais conhecimento.";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(267, 117);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Usuário:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(267, 164);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Senha: ";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(556, 335);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTexto2);
			this.Controls.Add(this.lblTexto1);
			this.Controls.Add(this.linkLabelCadastro);
			this.Controls.Add(this.lblConta);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.picLogo1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "quizVinipi";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label lblTexto2;
		private System.Windows.Forms.Label lblTexto1;
		private System.Windows.Forms.LinkLabel linkLabelCadastro;
		private System.Windows.Forms.Label lblConta;
		private System.Windows.Forms.Button btnEntrar;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.PictureBox picLogo1;
		private System.Windows.Forms.Panel panel1;
		
		
			
		
		void LinkLabelCadastroLinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
		Cadastro novaTela = new Cadastro();
 		novaTela.Show();
 		this.Enabled = false;
     	this.Hide();						
		}
		}
	}
