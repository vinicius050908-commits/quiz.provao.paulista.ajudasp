/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 07/12/2025
 * Time: 12:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace quizVinipi
{
	partial class TelaRanking
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRanking));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.picLogo1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBoxClickVoltar = new System.Windows.Forms.PictureBox();
			this.linkLabelPerfil = new System.Windows.Forms.LinkLabel();
			this.lblNomeUsuario = new System.Windows.Forms.Label();
			this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClickVoltar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.Location = new System.Drawing.Point(20, 205);
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(670, 300);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGridView1RowPrePaint);
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label5.Location = new System.Drawing.Point(211, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 23);
			this.label5.TabIndex = 68;
			this.label5.Text = "Voltar";
			// 
			// picLogo1
			// 
			this.picLogo1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.picLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.picLogo1.Cursor = System.Windows.Forms.Cursors.Default;
			this.picLogo1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picLogo1.ErrorImage")));
			this.picLogo1.Image = ((System.Drawing.Image)(resources.GetObject("picLogo1.Image")));
			this.picLogo1.Location = new System.Drawing.Point(12, 22);
			this.picLogo1.Name = "picLogo1";
			this.picLogo1.Size = new System.Drawing.Size(122, 111);
			this.picLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picLogo1.TabIndex = 62;
			this.picLogo1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel2.Location = new System.Drawing.Point(-27, 529);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(763, 44);
			this.panel2.TabIndex = 70;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label7.Location = new System.Drawing.Point(142, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(445, 44);
			this.label7.TabIndex = 111;
			this.label7.Text = "Ranking Geral";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBoxClickVoltar
			// 
			this.pictureBoxClickVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClickVoltar.Image")));
			this.pictureBoxClickVoltar.Location = new System.Drawing.Point(159, 24);
			this.pictureBoxClickVoltar.Name = "pictureBoxClickVoltar";
			this.pictureBoxClickVoltar.Size = new System.Drawing.Size(46, 38);
			this.pictureBoxClickVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxClickVoltar.TabIndex = 112;
			this.pictureBoxClickVoltar.TabStop = false;
			this.pictureBoxClickVoltar.Click += new System.EventHandler(this.PictureBoxClickVoltarClick);
			// 
			// linkLabelPerfil
			// 
			this.linkLabelPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabelPerfil.ForeColor = System.Drawing.Color.MidnightBlue;
			this.linkLabelPerfil.LinkColor = System.Drawing.Color.MidnightBlue;
			this.linkLabelPerfil.Location = new System.Drawing.Point(463, 24);
			this.linkLabelPerfil.Name = "linkLabelPerfil";
			this.linkLabelPerfil.Size = new System.Drawing.Size(75, 23);
			this.linkLabelPerfil.TabIndex = 117;
			this.linkLabelPerfil.TabStop = true;
			this.linkLabelPerfil.Text = "Perfil";
			this.linkLabelPerfil.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblNomeUsuario
			// 
			this.lblNomeUsuario.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeUsuario.Location = new System.Drawing.Point(532, 118);
			this.lblNomeUsuario.Name = "lblNomeUsuario";
			this.lblNomeUsuario.Size = new System.Drawing.Size(168, 23);
			this.lblNomeUsuario.TabIndex = 116;
			this.lblNomeUsuario.Text = "*nome do usuario";
			this.lblNomeUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBoxAvatar
			// 
			this.pictureBoxAvatar.Location = new System.Drawing.Point(556, 12);
			this.pictureBoxAvatar.Name = "pictureBoxAvatar";
			this.pictureBoxAvatar.Size = new System.Drawing.Size(114, 105);
			this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxAvatar.TabIndex = 113;
			this.pictureBoxAvatar.TabStop = false;
			// 
			// TelaRanking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(709, 572);
			this.Controls.Add(this.linkLabelPerfil);
			this.Controls.Add(this.lblNomeUsuario);
			this.Controls.Add(this.pictureBoxAvatar);
			this.Controls.Add(this.pictureBoxClickVoltar);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.picLogo1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "TelaRanking";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TelaRanking";
			this.Activated += new System.EventHandler(this.TelaRankingActivated);
			this.Load += new System.EventHandler(this.TelaRankingLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClickVoltar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBoxAvatar;
		private System.Windows.Forms.Label lblNomeUsuario;
		private System.Windows.Forms.LinkLabel linkLabelPerfil;
		private System.Windows.Forms.PictureBox pictureBoxClickVoltar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox picLogo1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dataGridView1;
		
					
		
		
	}
}
