/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 30/11/2025
 * Time: 16:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace quizVinipi
{
	partial class ResultadosQuiz1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultadosQuiz1));
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBoxClickVoltar = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.picLogo1 = new System.Windows.Forms.PictureBox();
			this.lblPontosTotal = new System.Windows.Forms.Label();
			this.lblTempoFinal = new System.Windows.Forms.Label();
			this.lblAcertos = new System.Windows.Forms.Label();
			this.lblErros = new System.Windows.Forms.Label();
			this.linkLabelPerfil = new System.Windows.Forms.LinkLabel();
			this.lblNomeUsuario = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.linkLabelRanking = new System.Windows.Forms.LinkLabel();
			this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClickVoltar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label5.Location = new System.Drawing.Point(74, 150);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 23);
			this.label5.TabIndex = 61;
			this.label5.Text = "Voltar";
			// 
			// pictureBoxClickVoltar
			// 
			this.pictureBoxClickVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClickVoltar.Image")));
			this.pictureBoxClickVoltar.Location = new System.Drawing.Point(22, 140);
			this.pictureBoxClickVoltar.Name = "pictureBoxClickVoltar";
			this.pictureBoxClickVoltar.Size = new System.Drawing.Size(46, 38);
			this.pictureBoxClickVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxClickVoltar.TabIndex = 60;
			this.pictureBoxClickVoltar.TabStop = false;
			this.pictureBoxClickVoltar.Click += new System.EventHandler(this.PictureBoxClickVoltarClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel2.Location = new System.Drawing.Point(-23, 497);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(763, 44);
			this.panel2.TabIndex = 56;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel3.Location = new System.Drawing.Point(48, 405);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(404, 10);
			this.panel3.TabIndex = 51;
			// 
			// picLogo1
			// 
			this.picLogo1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.picLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.picLogo1.Cursor = System.Windows.Forms.Cursors.Default;
			this.picLogo1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picLogo1.ErrorImage")));
			this.picLogo1.Image = ((System.Drawing.Image)(resources.GetObject("picLogo1.Image")));
			this.picLogo1.Location = new System.Drawing.Point(21, 22);
			this.picLogo1.Name = "picLogo1";
			this.picLogo1.Size = new System.Drawing.Size(108, 105);
			this.picLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picLogo1.TabIndex = 44;
			this.picLogo1.TabStop = false;
			// 
			// lblPontosTotal
			// 
			this.lblPontosTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPontosTotal.Location = new System.Drawing.Point(123, 441);
			this.lblPontosTotal.Name = "lblPontosTotal";
			this.lblPontosTotal.Size = new System.Drawing.Size(303, 23);
			this.lblPontosTotal.TabIndex = 63;
			this.lblPontosTotal.Text = "pontos";
			// 
			// lblTempoFinal
			// 
			this.lblTempoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTempoFinal.Location = new System.Drawing.Point(123, 364);
			this.lblTempoFinal.Name = "lblTempoFinal";
			this.lblTempoFinal.Size = new System.Drawing.Size(287, 23);
			this.lblTempoFinal.TabIndex = 64;
			this.lblTempoFinal.Text = "label2";
			this.lblTempoFinal.Click += new System.EventHandler(this.LblTempoFinalClick);
			// 
			// lblAcertos
			// 
			this.lblAcertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAcertos.Location = new System.Drawing.Point(123, 220);
			this.lblAcertos.Name = "lblAcertos";
			this.lblAcertos.Size = new System.Drawing.Size(287, 23);
			this.lblAcertos.TabIndex = 65;
			this.lblAcertos.Text = "label3";
			// 
			// lblErros
			// 
			this.lblErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblErros.Location = new System.Drawing.Point(123, 294);
			this.lblErros.Name = "lblErros";
			this.lblErros.Size = new System.Drawing.Size(287, 23);
			this.lblErros.TabIndex = 66;
			this.lblErros.Text = "label4";
			// 
			// linkLabelPerfil
			// 
			this.linkLabelPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabelPerfil.ForeColor = System.Drawing.Color.MidnightBlue;
			this.linkLabelPerfil.LinkColor = System.Drawing.Color.MidnightBlue;
			this.linkLabelPerfil.Location = new System.Drawing.Point(256, 81);
			this.linkLabelPerfil.Name = "linkLabelPerfil";
			this.linkLabelPerfil.Size = new System.Drawing.Size(75, 23);
			this.linkLabelPerfil.TabIndex = 71;
			this.linkLabelPerfil.TabStop = true;
			this.linkLabelPerfil.Text = "Perfil";
			this.linkLabelPerfil.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.linkLabelPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelPerfilLinkClicked);
			// 
			// lblNomeUsuario
			// 
			this.lblNomeUsuario.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeUsuario.Location = new System.Drawing.Point(329, 128);
			this.lblNomeUsuario.Name = "lblNomeUsuario";
			this.lblNomeUsuario.Size = new System.Drawing.Size(168, 23);
			this.lblNomeUsuario.TabIndex = 70;
			this.lblNomeUsuario.Text = "*nome do usuario";
			this.lblNomeUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(221, 37);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(29, 30);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 69;
			this.pictureBox3.TabStop = false;
			// 
			// linkLabelRanking
			// 
			this.linkLabelRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabelRanking.ForeColor = System.Drawing.Color.MidnightBlue;
			this.linkLabelRanking.LinkColor = System.Drawing.Color.MidnightBlue;
			this.linkLabelRanking.Location = new System.Drawing.Point(256, 44);
			this.linkLabelRanking.Name = "linkLabelRanking";
			this.linkLabelRanking.Size = new System.Drawing.Size(75, 23);
			this.linkLabelRanking.TabIndex = 68;
			this.linkLabelRanking.TabStop = true;
			this.linkLabelRanking.Text = "Ranking";
			this.linkLabelRanking.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelRankingLinkClicked);
			// 
			// pictureBoxAvatar
			// 
			this.pictureBoxAvatar.Location = new System.Drawing.Point(353, 22);
			this.pictureBoxAvatar.Name = "pictureBoxAvatar";
			this.pictureBoxAvatar.Size = new System.Drawing.Size(114, 105);
			this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxAvatar.TabIndex = 67;
			this.pictureBoxAvatar.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(65, 431);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(52, 50);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 74;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(65, 204);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(52, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 75;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(65, 276);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(52, 50);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 76;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(65, 349);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(52, 50);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 77;
			this.pictureBox5.TabStop = false;
			// 
			// ResultadosQuiz1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(502, 539);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.linkLabelPerfil);
			this.Controls.Add(this.lblNomeUsuario);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.linkLabelRanking);
			this.Controls.Add(this.pictureBoxAvatar);
			this.Controls.Add(this.lblErros);
			this.Controls.Add(this.lblAcertos);
			this.Controls.Add(this.lblTempoFinal);
			this.Controls.Add(this.lblPontosTotal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pictureBoxClickVoltar);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.picLogo1);
			this.Name = "ResultadosQuiz1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ResultadosQuiz1";
			this.Activated += new System.EventHandler(this.ResultadosQuiz1Activated);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClickVoltar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBoxAvatar;
		private System.Windows.Forms.LinkLabel linkLabelRanking;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label lblNomeUsuario;
		private System.Windows.Forms.LinkLabel linkLabelPerfil;
		private System.Windows.Forms.Label lblErros;
		private System.Windows.Forms.Label lblAcertos;
		private System.Windows.Forms.Label lblTempoFinal;
		private System.Windows.Forms.Label lblPontosTotal;
		private System.Windows.Forms.PictureBox picLogo1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBoxClickVoltar;
		private System.Windows.Forms.Label label5;
	}
}
