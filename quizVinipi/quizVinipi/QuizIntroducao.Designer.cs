/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 23/10/2025
 * Time: 21:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace quizVinipi
{
	partial class QuizIntroducao
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizIntroducao));
			this.picLogo1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnConhecer = new System.Windows.Forms.Button();
			this.pictureBoxClickVoltar = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
			this.linkLabelRanking = new System.Windows.Forms.LinkLabel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lblNomeUsuario = new System.Windows.Forms.Label();
			this.linkLabelPerfil = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClickVoltar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// picLogo1
			// 
			this.picLogo1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.picLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.picLogo1.Cursor = System.Windows.Forms.Cursors.Default;
			this.picLogo1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picLogo1.ErrorImage")));
			this.picLogo1.Image = ((System.Drawing.Image)(resources.GetObject("picLogo1.Image")));
			this.picLogo1.Location = new System.Drawing.Point(36, 23);
			this.picLogo1.Name = "picLogo1";
			this.picLogo1.Size = new System.Drawing.Size(122, 111);
			this.picLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picLogo1.TabIndex = 4;
			this.picLogo1.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(41, 155);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(292, 187);
			this.label2.TabIndex = 31;
			this.label2.Text = resources.GetString("label2.Text");
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel3.Location = new System.Drawing.Point(388, 100);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(10, 330);
			this.panel3.TabIndex = 32;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(76, 360);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 20);
			this.label1.TabIndex = 33;
			this.label1.Text = "Duração: 1h e 40 min";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(76, 396);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(245, 20);
			this.label3.TabIndex = 34;
			this.label3.Text = "Pontos possíveis: 150 pts";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(41, 357);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(29, 28);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 35;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(41, 391);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(29, 28);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 36;
			this.pictureBox2.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel2.Location = new System.Drawing.Point(-2, 439);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(763, 44);
			this.panel2.TabIndex = 37;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Default;
			this.pictureBox5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.ErrorImage")));
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(442, 228);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(245, 121);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 38;
			this.pictureBox5.TabStop = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(442, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(284, 61);
			this.label4.TabIndex = 39;
			this.label4.Text = "Quiz do dia: Ciências da Natureza";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// btnConhecer
			// 
			this.btnConhecer.BackColor = System.Drawing.Color.Red;
			this.btnConhecer.Font = new System.Drawing.Font("Corbel", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConhecer.ForeColor = System.Drawing.Color.White;
			this.btnConhecer.Location = new System.Drawing.Point(428, 355);
			this.btnConhecer.Name = "btnConhecer";
			this.btnConhecer.Size = new System.Drawing.Size(277, 44);
			this.btnConhecer.TabIndex = 40;
			this.btnConhecer.Text = "Começar quiz";
			this.btnConhecer.UseVisualStyleBackColor = false;
			this.btnConhecer.Click += new System.EventHandler(this.BtnConhecerClick);
			// 
			// pictureBoxClickVoltar
			// 
			this.pictureBoxClickVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClickVoltar.Image")));
			this.pictureBoxClickVoltar.Location = new System.Drawing.Point(176, 35);
			this.pictureBoxClickVoltar.Name = "pictureBoxClickVoltar";
			this.pictureBoxClickVoltar.Size = new System.Drawing.Size(46, 38);
			this.pictureBoxClickVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxClickVoltar.TabIndex = 41;
			this.pictureBoxClickVoltar.TabStop = false;
			this.pictureBoxClickVoltar.Click += new System.EventHandler(this.PictureBox6Click);
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label5.Location = new System.Drawing.Point(225, 45);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 23);
			this.label5.TabIndex = 42;
			this.label5.Text = "Voltar";
			// 
			// pictureBoxAvatar
			// 
			this.pictureBoxAvatar.Location = new System.Drawing.Point(612, 12);
			this.pictureBoxAvatar.Name = "pictureBoxAvatar";
			this.pictureBoxAvatar.Size = new System.Drawing.Size(114, 105);
			this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxAvatar.TabIndex = 43;
			this.pictureBoxAvatar.TabStop = false;
			// 
			// linkLabelRanking
			// 
			this.linkLabelRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabelRanking.ForeColor = System.Drawing.Color.MidnightBlue;
			this.linkLabelRanking.LinkColor = System.Drawing.Color.MidnightBlue;
			this.linkLabelRanking.Location = new System.Drawing.Point(515, 34);
			this.linkLabelRanking.Name = "linkLabelRanking";
			this.linkLabelRanking.Size = new System.Drawing.Size(75, 23);
			this.linkLabelRanking.TabIndex = 44;
			this.linkLabelRanking.TabStop = true;
			this.linkLabelRanking.Text = "Ranking";
			this.linkLabelRanking.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelRankingLinkClicked);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(480, 27);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(29, 30);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 45;
			this.pictureBox3.TabStop = false;
			// 
			// lblNomeUsuario
			// 
			this.lblNomeUsuario.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeUsuario.Location = new System.Drawing.Point(591, 120);
			this.lblNomeUsuario.Name = "lblNomeUsuario";
			this.lblNomeUsuario.Size = new System.Drawing.Size(154, 23);
			this.lblNomeUsuario.TabIndex = 46;
			this.lblNomeUsuario.Text = "*nome do usuario";
			this.lblNomeUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// linkLabelPerfil
			// 
			this.linkLabelPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabelPerfil.ForeColor = System.Drawing.Color.MidnightBlue;
			this.linkLabelPerfil.LinkColor = System.Drawing.Color.MidnightBlue;
			this.linkLabelPerfil.Location = new System.Drawing.Point(515, 69);
			this.linkLabelPerfil.Name = "linkLabelPerfil";
			this.linkLabelPerfil.Size = new System.Drawing.Size(75, 23);
			this.linkLabelPerfil.TabIndex = 47;
			this.linkLabelPerfil.TabStop = true;
			this.linkLabelPerfil.Text = "Perfil";
			this.linkLabelPerfil.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.linkLabelPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelPerfilLinkClicked);
			// 
			// QuizIntroducao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(757, 466);
			this.Controls.Add(this.linkLabelPerfil);
			this.Controls.Add(this.lblNomeUsuario);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.linkLabelRanking);
			this.Controls.Add(this.pictureBoxAvatar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pictureBoxClickVoltar);
			this.Controls.Add(this.btnConhecer);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.picLogo1);
			this.Name = "QuizIntroducao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QuizIntroducao";
			this.Activated += new System.EventHandler(this.QuizIntroducaoActivated);
			this.Load += new System.EventHandler(this.QuizIntroducaoLoad);
			((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClickVoltar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.LinkLabel linkLabelPerfil;
		private System.Windows.Forms.PictureBox pictureBoxAvatar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBoxClickVoltar;
		private System.Windows.Forms.Button btnConhecer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel linkLabelRanking;
		private System.Windows.Forms.Label lblNomeUsuario;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox picLogo1;
		
		void LblUsuarionomeClick(object sender, System.EventArgs e)
		{
			DadosGlobais.NomeUsuario = lblNomeUsuario.Text;
		}
	}
}
