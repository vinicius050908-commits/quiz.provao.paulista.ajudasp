/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 01/12/2025
 * Time: 15:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace quizVinipi
{
	partial class TelaErro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaErro));
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblMensagem = new System.Windows.Forms.Label();
			this.lblPontos = new System.Windows.Forms.Label();
			this.pictureBoxClickVoltar = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelCard = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClickVoltar)).BeginInit();
			this.panelCard.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
			this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(15, 15);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(330, 60);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Eita... Você errou";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMensagem
			// 
			this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
			this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMensagem.ForeColor = System.Drawing.Color.White;
			this.lblMensagem.Location = new System.Drawing.Point(15, 80);
			this.lblMensagem.Name = "lblMensagem";
			this.lblMensagem.Size = new System.Drawing.Size(330, 80);
			this.lblMensagem.TabIndex = 1;
			this.lblMensagem.Text = "A resposta correta era: ______\r\n";
			// 
			// lblPontos
			// 
			this.lblPontos.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPontos.ForeColor = System.Drawing.Color.White;
			this.lblPontos.Location = new System.Drawing.Point(15, 180);
			this.lblPontos.Name = "lblPontos";
			this.lblPontos.Size = new System.Drawing.Size(185, 23);
			this.lblPontos.TabIndex = 64;
			this.lblPontos.Text = "Pontos:";
			// 
			// pictureBoxClickVoltar
			// 
			this.pictureBoxClickVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClickVoltar.Image")));
			this.pictureBoxClickVoltar.Location = new System.Drawing.Point(297, 173);
			this.pictureBoxClickVoltar.Name = "pictureBoxClickVoltar";
			this.pictureBoxClickVoltar.Size = new System.Drawing.Size(46, 38);
			this.pictureBoxClickVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxClickVoltar.TabIndex = 65;
			this.pictureBoxClickVoltar.TabStop = false;
			this.pictureBoxClickVoltar.Click += new System.EventHandler(this.PictureBoxClickVoltarClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(231, 184);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 23);
			this.label1.TabIndex = 66;
			this.label1.Text = "Próxima";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// panelCard
			// 
			this.panelCard.BackColor = System.Drawing.Color.Firebrick;
			this.panelCard.Controls.Add(this.label1);
			this.panelCard.Controls.Add(this.pictureBoxClickVoltar);
			this.panelCard.Controls.Add(this.lblPontos);
			this.panelCard.Controls.Add(this.lblMensagem);
			this.panelCard.Controls.Add(this.lblTitulo);
			this.panelCard.Location = new System.Drawing.Point(14, 15);
			this.panelCard.Name = "panelCard";
			this.panelCard.Size = new System.Drawing.Size(360, 230);
			this.panelCard.TabIndex = 1;
			// 
			// TelaErro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(390, 260);
			this.Controls.Add(this.panelCard);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TelaErro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TelaErro";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClickVoltar)).EndInit();
			this.panelCard.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBoxClickVoltar;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label lblPontos;
		private System.Windows.Forms.Label lblTitulo;
		public System.Windows.Forms.Label lblMensagem;
		private System.Windows.Forms.Panel panelCard;
	}
}
