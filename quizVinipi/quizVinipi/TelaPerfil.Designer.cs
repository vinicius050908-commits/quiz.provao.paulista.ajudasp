/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 07/12/2025
 * Time: 16:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace quizVinipi
{
	partial class TelaPerfil
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPerfil));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
			this.lblNomeUsuario = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBoxClickVoltar = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblQuizzes = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label2 = new System.Windows.Forms.Label();
			this.lblPontuacao = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClickVoltar)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel1.Location = new System.Drawing.Point(-65, 526);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(633, 44);
			this.panel1.TabIndex = 18;
			// 
			// pictureBoxAvatar
			// 
			this.pictureBoxAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar.Image")));
			this.pictureBoxAvatar.Location = new System.Drawing.Point(143, 12);
			this.pictureBoxAvatar.Name = "pictureBoxAvatar";
			this.pictureBoxAvatar.Size = new System.Drawing.Size(220, 170);
			this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxAvatar.TabIndex = 21;
			this.pictureBoxAvatar.TabStop = false;
			// 
			// lblNomeUsuario
			// 
			this.lblNomeUsuario.BackColor = System.Drawing.Color.White;
			this.lblNomeUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblNomeUsuario.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lblNomeUsuario.Location = new System.Drawing.Point(34, 185);
			this.lblNomeUsuario.Name = "lblNomeUsuario";
			this.lblNomeUsuario.Size = new System.Drawing.Size(445, 43);
			this.lblNomeUsuario.TabIndex = 111;
			this.lblNomeUsuario.Text = "usuario";
			this.lblNomeUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label5.Location = new System.Drawing.Point(64, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 23);
			this.label5.TabIndex = 113;
			this.label5.Text = "Voltar";
			// 
			// pictureBoxClickVoltar
			// 
			this.pictureBoxClickVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClickVoltar.Image")));
			this.pictureBoxClickVoltar.Location = new System.Drawing.Point(15, 18);
			this.pictureBoxClickVoltar.Name = "pictureBoxClickVoltar";
			this.pictureBoxClickVoltar.Size = new System.Drawing.Size(46, 38);
			this.pictureBoxClickVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxClickVoltar.TabIndex = 112;
			this.pictureBoxClickVoltar.TabStop = false;
			this.pictureBoxClickVoltar.Click += new System.EventHandler(this.PictureBoxClickVoltarClick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.MidnightBlue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(180, 222);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(154, 32);
			this.button1.TabIndex = 114;
			this.button1.Text = "Editar avatar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel2.Controls.Add(this.lblQuizzes);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.progressBar1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.lblPontuacao);
			this.panel2.Location = new System.Drawing.Point(43, 283);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(411, 208);
			this.panel2.TabIndex = 115;
			// 
			// lblQuizzes
			// 
			this.lblQuizzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuizzes.ForeColor = System.Drawing.Color.White;
			this.lblQuizzes.Location = new System.Drawing.Point(53, 164);
			this.lblQuizzes.Name = "lblQuizzes";
			this.lblQuizzes.Size = new System.Drawing.Size(336, 30);
			this.lblQuizzes.TabIndex = 4;
			this.lblQuizzes.Text = "000";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(21, 129);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(195, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Quizzes concluídos:";
			// 
			// progressBar1
			// 
			this.progressBar1.BackColor = System.Drawing.Color.MidnightBlue;
			this.progressBar1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.progressBar1.Location = new System.Drawing.Point(21, 93);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(368, 23);
			this.progressBar1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(21, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Pontuação Total:";
			// 
			// lblPontuacao
			// 
			this.lblPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPontuacao.ForeColor = System.Drawing.Color.White;
			this.lblPontuacao.Location = new System.Drawing.Point(53, 54);
			this.lblPontuacao.Name = "lblPontuacao";
			this.lblPontuacao.Size = new System.Drawing.Size(336, 36);
			this.lblPontuacao.TabIndex = 0;
			this.lblPontuacao.Text = "000";
			// 
			// TelaPerfil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(502, 565);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pictureBoxClickVoltar);
			this.Controls.Add(this.lblNomeUsuario);
			this.Controls.Add(this.pictureBoxAvatar);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "TelaPerfil";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TelaPerfil";
			this.Activated += new System.EventHandler(this.TelaPerfilActivated);
			this.Load += new System.EventHandler(this.TelaPerfilLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClickVoltar)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblQuizzes;
		public System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label lblPontuacao;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBoxClickVoltar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblNomeUsuario;
		private System.Windows.Forms.PictureBox pictureBoxAvatar;
		private System.Windows.Forms.Panel panel1;
		
	}
}
