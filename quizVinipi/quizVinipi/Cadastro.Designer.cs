/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 23/10/2025
 * Time: 19:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace quizVinipi
{
	partial class Cadastro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.lblSenha = new System.Windows.Forms.Label();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblConta = new System.Windows.Forms.Label();
			this.linkLabelEntrar = new System.Windows.Forms.LinkLabel();
			this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
			this.SuspendLayout();
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(115, 320);
			this.txtUsuario.Multiline = true;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(274, 30);
			this.txtUsuario.TabIndex = 4;
			// 
			// lblUsuario
			// 
			this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
			this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblUsuario.Location = new System.Drawing.Point(115, 220);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(101, 19);
			this.lblUsuario.TabIndex = 12;
			this.lblUsuario.Text = "Usuário:";
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(115, 246);
			this.txtSenha.Multiline = true;
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(274, 30);
			this.txtSenha.TabIndex = 13;
			this.txtSenha.UseSystemPasswordChar = true;
			// 
			// lblSenha
			// 
			this.lblSenha.BackColor = System.Drawing.Color.Transparent;
			this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblSenha.Location = new System.Drawing.Point(115, 293);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(101, 24);
			this.lblSenha.TabIndex = 14;
			this.lblSenha.Text = "Senha: ";
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.AutoSize = true;
			this.btnCadastrar.BackColor = System.Drawing.Color.Red;
			this.btnCadastrar.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar.ForeColor = System.Drawing.Color.White;
			this.btnCadastrar.Location = new System.Drawing.Point(115, 371);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(274, 56);
			this.btnCadastrar.TabIndex = 16;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrarClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel1.Location = new System.Drawing.Point(-127, 496);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(633, 44);
			this.panel1.TabIndex = 17;
			// 
			// lblConta
			// 
			this.lblConta.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConta.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lblConta.Location = new System.Drawing.Point(124, 440);
			this.lblConta.Name = "lblConta";
			this.lblConta.Size = new System.Drawing.Size(173, 23);
			this.lblConta.TabIndex = 18;
			this.lblConta.Text = "Já tem uma conta?";
			// 
			// linkLabelEntrar
			// 
			this.linkLabelEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabelEntrar.ForeColor = System.Drawing.Color.MidnightBlue;
			this.linkLabelEntrar.LinkColor = System.Drawing.Color.MidnightBlue;
			this.linkLabelEntrar.Location = new System.Drawing.Point(277, 440);
			this.linkLabelEntrar.Name = "linkLabelEntrar";
			this.linkLabelEntrar.Size = new System.Drawing.Size(137, 23);
			this.linkLabelEntrar.TabIndex = 19;
			this.linkLabelEntrar.TabStop = true;
			this.linkLabelEntrar.Text = "Entre aqui";
			this.linkLabelEntrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelEntrarLinkClicked);
			// 
			// pictureBoxAvatar
			// 
			this.pictureBoxAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar.Image")));
			this.pictureBoxAvatar.Location = new System.Drawing.Point(143, 12);
			this.pictureBoxAvatar.Name = "pictureBoxAvatar";
			this.pictureBoxAvatar.Size = new System.Drawing.Size(220, 170);
			this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxAvatar.TabIndex = 20;
			this.pictureBoxAvatar.TabStop = false;
			this.pictureBoxAvatar.Click += new System.EventHandler(this.PictureBoxAvatarClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label1.Location = new System.Drawing.Point(147, 185);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 23);
			this.label1.TabIndex = 21;
			this.label1.Text = "Selecione seu avatar";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Cadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(502, 539);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBoxAvatar);
			this.Controls.Add(this.linkLabelEntrar);
			this.Controls.Add(this.lblConta);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.txtUsuario);
			this.Name = "Cadastro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro";
			this.Activated += new System.EventHandler(this.CadastroActivated);
			this.Load += new System.EventHandler(this.CadastroLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBoxAvatar;
		private System.Windows.Forms.LinkLabel linkLabelEntrar;
		private System.Windows.Forms.Label lblConta;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.TextBox txtUsuario;
	}
}
