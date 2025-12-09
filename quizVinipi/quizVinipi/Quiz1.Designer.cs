/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 23/10/2025
 * Time: 22:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace quizVinipi
{
	partial class Quiz1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz1));
			this.btnQ1 = new System.Windows.Forms.Button();
			this.btnQ2 = new System.Windows.Forms.Button();
			this.btnQ4 = new System.Windows.Forms.Button();
			this.btnQ3 = new System.Windows.Forms.Button();
			this.btnQ5 = new System.Windows.Forms.Button();
			this.btnQ7 = new System.Windows.Forms.Button();
			this.btnQ6 = new System.Windows.Forms.Button();
			this.btnQ10 = new System.Windows.Forms.Button();
			this.btnQ9 = new System.Windows.Forms.Button();
			this.btnQ8 = new System.Windows.Forms.Button();
			this.picLogo1 = new System.Windows.Forms.PictureBox();
			this.lblTexto2 = new System.Windows.Forms.Label();
			this.btnConcluirClick = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBoxClickVoltar = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblNumeroQuestao = new System.Windows.Forms.Label();
			this.lblTempo = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblRespostaE = new System.Windows.Forms.Label();
			this.btnAlnternativaE = new System.Windows.Forms.Button();
			this.lblPergunta = new System.Windows.Forms.Label();
			this.lblQ = new System.Windows.Forms.Label();
			this.lblRespostaD = new System.Windows.Forms.Label();
			this.lblRespostaC = new System.Windows.Forms.Label();
			this.lblRespostaB = new System.Windows.Forms.Label();
			this.btnAlternativaA = new System.Windows.Forms.Button();
			this.btnAlternativaB = new System.Windows.Forms.Button();
			this.lblRespostaA = new System.Windows.Forms.Label();
			this.btnAlternativaC = new System.Windows.Forms.Button();
			this.btnAlternativaD = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblPontuacao = new System.Windows.Forms.Label();
			this.timerQuiz1 = new System.Windows.Forms.Timer(this.components);
			this.lblNomeUsuario = new System.Windows.Forms.Label();
			this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClickVoltar)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
			this.SuspendLayout();
			// 
			// btnQ1
			// 
			this.btnQ1.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.btnQ1.FlatAppearance.BorderSize = 2;
			this.btnQ1.Location = new System.Drawing.Point(32, 145);
			this.btnQ1.Name = "btnQ1";
			this.btnQ1.Size = new System.Drawing.Size(52, 41);
			this.btnQ1.TabIndex = 41;
			this.btnQ1.Text = "1";
			this.btnQ1.UseVisualStyleBackColor = true;
			this.btnQ1.Click += new System.EventHandler(this.BtnQ1Click);
			// 
			// btnQ2
			// 
			this.btnQ2.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.btnQ2.FlatAppearance.BorderSize = 2;
			this.btnQ2.Location = new System.Drawing.Point(32, 196);
			this.btnQ2.Name = "btnQ2";
			this.btnQ2.Size = new System.Drawing.Size(52, 41);
			this.btnQ2.TabIndex = 42;
			this.btnQ2.Text = "2";
			this.btnQ2.UseVisualStyleBackColor = true;
			this.btnQ2.Click += new System.EventHandler(this.BtnQ2Click);
			// 
			// btnQ4
			// 
			this.btnQ4.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.btnQ4.FlatAppearance.BorderSize = 2;
			this.btnQ4.Location = new System.Drawing.Point(32, 298);
			this.btnQ4.Name = "btnQ4";
			this.btnQ4.Size = new System.Drawing.Size(52, 41);
			this.btnQ4.TabIndex = 43;
			this.btnQ4.Text = "4";
			this.btnQ4.UseVisualStyleBackColor = true;
			this.btnQ4.Click += new System.EventHandler(this.BtnQ4Click);
			// 
			// btnQ3
			// 
			this.btnQ3.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.btnQ3.FlatAppearance.BorderSize = 2;
			this.btnQ3.Location = new System.Drawing.Point(32, 247);
			this.btnQ3.Name = "btnQ3";
			this.btnQ3.Size = new System.Drawing.Size(52, 41);
			this.btnQ3.TabIndex = 44;
			this.btnQ3.Text = "3";
			this.btnQ3.UseVisualStyleBackColor = true;
			this.btnQ3.Click += new System.EventHandler(this.BtnQ3Click);
			// 
			// btnQ5
			// 
			this.btnQ5.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.btnQ5.FlatAppearance.BorderSize = 2;
			this.btnQ5.Location = new System.Drawing.Point(32, 349);
			this.btnQ5.Name = "btnQ5";
			this.btnQ5.Size = new System.Drawing.Size(52, 41);
			this.btnQ5.TabIndex = 45;
			this.btnQ5.Text = "5";
			this.btnQ5.UseVisualStyleBackColor = true;
			this.btnQ5.Click += new System.EventHandler(this.BtnQ5Click);
			// 
			// btnQ7
			// 
			this.btnQ7.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.btnQ7.FlatAppearance.BorderSize = 2;
			this.btnQ7.Location = new System.Drawing.Point(98, 196);
			this.btnQ7.Name = "btnQ7";
			this.btnQ7.Size = new System.Drawing.Size(52, 41);
			this.btnQ7.TabIndex = 48;
			this.btnQ7.Text = "7";
			this.btnQ7.UseVisualStyleBackColor = true;
			this.btnQ7.Click += new System.EventHandler(this.BtnQ7Click);
			// 
			// btnQ6
			// 
			this.btnQ6.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.btnQ6.FlatAppearance.BorderSize = 2;
			this.btnQ6.Location = new System.Drawing.Point(98, 145);
			this.btnQ6.Name = "btnQ6";
			this.btnQ6.Size = new System.Drawing.Size(52, 41);
			this.btnQ6.TabIndex = 46;
			this.btnQ6.Text = "6";
			this.btnQ6.UseVisualStyleBackColor = true;
			this.btnQ6.Click += new System.EventHandler(this.BtnQ6Click);
			// 
			// btnQ10
			// 
			this.btnQ10.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.btnQ10.FlatAppearance.BorderSize = 2;
			this.btnQ10.Location = new System.Drawing.Point(98, 349);
			this.btnQ10.Name = "btnQ10";
			this.btnQ10.Size = new System.Drawing.Size(52, 41);
			this.btnQ10.TabIndex = 72;
			this.btnQ10.Text = "10";
			this.btnQ10.UseVisualStyleBackColor = true;
			this.btnQ10.Click += new System.EventHandler(this.BtnQ10Click);
			// 
			// btnQ9
			// 
			this.btnQ9.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.btnQ9.FlatAppearance.BorderSize = 2;
			this.btnQ9.Location = new System.Drawing.Point(98, 298);
			this.btnQ9.Name = "btnQ9";
			this.btnQ9.Size = new System.Drawing.Size(52, 41);
			this.btnQ9.TabIndex = 71;
			this.btnQ9.Text = "9";
			this.btnQ9.UseVisualStyleBackColor = true;
			this.btnQ9.Click += new System.EventHandler(this.BtnQ9Click);
			// 
			// btnQ8
			// 
			this.btnQ8.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.btnQ8.FlatAppearance.BorderSize = 2;
			this.btnQ8.Location = new System.Drawing.Point(98, 247);
			this.btnQ8.Name = "btnQ8";
			this.btnQ8.Size = new System.Drawing.Size(52, 41);
			this.btnQ8.TabIndex = 70;
			this.btnQ8.Text = "8";
			this.btnQ8.UseVisualStyleBackColor = true;
			this.btnQ8.Click += new System.EventHandler(this.BtnQ8Click);
			// 
			// picLogo1
			// 
			this.picLogo1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.picLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.picLogo1.Cursor = System.Windows.Forms.Cursors.Default;
			this.picLogo1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picLogo1.ErrorImage")));
			this.picLogo1.Image = ((System.Drawing.Image)(resources.GetObject("picLogo1.Image")));
			this.picLogo1.Location = new System.Drawing.Point(32, 14);
			this.picLogo1.Name = "picLogo1";
			this.picLogo1.Size = new System.Drawing.Size(112, 104);
			this.picLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picLogo1.TabIndex = 73;
			this.picLogo1.TabStop = false;
			// 
			// lblTexto2
			// 
			this.lblTexto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTexto2.Location = new System.Drawing.Point(1038, 381);
			this.lblTexto2.Name = "lblTexto2";
			this.lblTexto2.Size = new System.Drawing.Size(151, 123);
			this.lblTexto2.TabIndex = 74;
			this.lblTexto2.Text = "Boa sorte no quiz!\r\nConfie em você, respire fundo e arrase nas respostas — temos " +
			"certeza de que vai se sair muito bem!";
			this.lblTexto2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnConcluirClick
			// 
			this.btnConcluirClick.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnConcluirClick.Font = new System.Drawing.Font("Corbel", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConcluirClick.ForeColor = System.Drawing.Color.White;
			this.btnConcluirClick.Location = new System.Drawing.Point(32, 405);
			this.btnConcluirClick.Name = "btnConcluirClick";
			this.btnConcluirClick.Size = new System.Drawing.Size(118, 43);
			this.btnConcluirClick.TabIndex = 77;
			this.btnConcluirClick.Text = "Concluir";
			this.btnConcluirClick.UseVisualStyleBackColor = false;
			this.btnConcluirClick.Click += new System.EventHandler(this.BtnConcluirClick);
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label5.Location = new System.Drawing.Point(212, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 23);
			this.label5.TabIndex = 79;
			this.label5.Text = "Voltar";
			// 
			// pictureBoxClickVoltar
			// 
			this.pictureBoxClickVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClickVoltar.Image")));
			this.pictureBoxClickVoltar.Location = new System.Drawing.Point(163, 21);
			this.pictureBoxClickVoltar.Name = "pictureBoxClickVoltar";
			this.pictureBoxClickVoltar.Size = new System.Drawing.Size(46, 38);
			this.pictureBoxClickVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxClickVoltar.TabIndex = 78;
			this.pictureBoxClickVoltar.TabStop = false;
			this.pictureBoxClickVoltar.Click += new System.EventHandler(this.PictureBoxClickVoltarClick);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.lblNumeroQuestao);
			this.panel1.Controls.Add(this.lblTempo);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.lblRespostaE);
			this.panel1.Controls.Add(this.btnAlnternativaE);
			this.panel1.Controls.Add(this.lblPergunta);
			this.panel1.Controls.Add(this.lblQ);
			this.panel1.Controls.Add(this.lblRespostaD);
			this.panel1.Controls.Add(this.lblRespostaC);
			this.panel1.Controls.Add(this.lblRespostaB);
			this.panel1.Controls.Add(this.btnAlternativaA);
			this.panel1.Controls.Add(this.btnAlternativaB);
			this.panel1.Controls.Add(this.lblRespostaA);
			this.panel1.Controls.Add(this.btnAlternativaC);
			this.panel1.Controls.Add(this.btnAlternativaD);
			this.panel1.Location = new System.Drawing.Point(212, 70);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(789, 394);
			this.panel1.TabIndex = 80;
			// 
			// lblNumeroQuestao
			// 
			this.lblNumeroQuestao.AutoSize = true;
			this.lblNumeroQuestao.BackColor = System.Drawing.Color.Transparent;
			this.lblNumeroQuestao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblNumeroQuestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumeroQuestao.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lblNumeroQuestao.Location = new System.Drawing.Point(14, 10);
			this.lblNumeroQuestao.Name = "lblNumeroQuestao";
			this.lblNumeroQuestao.Size = new System.Drawing.Size(49, 38);
			this.lblNumeroQuestao.TabIndex = 92;
			this.lblNumeroQuestao.Text = "1º";
			// 
			// lblTempo
			// 
			this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTempo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblTempo.Location = new System.Drawing.Point(663, 12);
			this.lblTempo.Name = "lblTempo";
			this.lblTempo.Size = new System.Drawing.Size(100, 23);
			this.lblTempo.TabIndex = 91;
			this.lblTempo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel2.Location = new System.Drawing.Point(23, 215);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(750, 10);
			this.panel2.TabIndex = 90;
			// 
			// lblRespostaE
			// 
			this.lblRespostaE.Location = new System.Drawing.Point(606, 248);
			this.lblRespostaE.Name = "lblRespostaE";
			this.lblRespostaE.Size = new System.Drawing.Size(167, 101);
			this.lblRespostaE.TabIndex = 89;
			this.lblRespostaE.Text = "?";
			// 
			// btnAlnternativaE
			// 
			this.btnAlnternativaE.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.btnAlnternativaE.FlatAppearance.BorderSize = 2;
			this.btnAlnternativaE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlnternativaE.Location = new System.Drawing.Point(571, 242);
			this.btnAlnternativaE.Name = "btnAlnternativaE";
			this.btnAlnternativaE.Size = new System.Drawing.Size(29, 28);
			this.btnAlnternativaE.TabIndex = 88;
			this.btnAlnternativaE.Text = "E";
			this.btnAlnternativaE.UseVisualStyleBackColor = true;
			this.btnAlnternativaE.Click += new System.EventHandler(this.BtnAlnternativaEClick);
			// 
			// lblPergunta
			// 
			this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPergunta.Location = new System.Drawing.Point(61, 48);
			this.lblPergunta.Name = "lblPergunta";
			this.lblPergunta.Size = new System.Drawing.Size(667, 164);
			this.lblPergunta.TabIndex = 83;
			this.lblPergunta.Text = "?";
			// 
			// lblQ
			// 
			this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQ.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lblQ.Location = new System.Drawing.Point(61, 11);
			this.lblQ.Name = "lblQ";
			this.lblQ.Size = new System.Drawing.Size(115, 36);
			this.lblQ.TabIndex = 82;
			this.lblQ.Text = "Pergunta:";
			// 
			// lblRespostaD
			// 
			this.lblRespostaD.Location = new System.Drawing.Point(345, 327);
			this.lblRespostaD.Name = "lblRespostaD";
			this.lblRespostaD.Size = new System.Drawing.Size(209, 63);
			this.lblRespostaD.TabIndex = 87;
			this.lblRespostaD.Text = "?";
			// 
			// lblRespostaC
			// 
			this.lblRespostaC.Location = new System.Drawing.Point(345, 242);
			this.lblRespostaC.Name = "lblRespostaC";
			this.lblRespostaC.Size = new System.Drawing.Size(209, 60);
			this.lblRespostaC.TabIndex = 86;
			this.lblRespostaC.Text = "?";
			// 
			// lblRespostaB
			// 
			this.lblRespostaB.Location = new System.Drawing.Point(66, 327);
			this.lblRespostaB.Name = "lblRespostaB";
			this.lblRespostaB.Size = new System.Drawing.Size(205, 58);
			this.lblRespostaB.TabIndex = 85;
			this.lblRespostaB.Text = "?";
			// 
			// btnAlternativaA
			// 
			this.btnAlternativaA.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.btnAlternativaA.FlatAppearance.BorderSize = 2;
			this.btnAlternativaA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlternativaA.Location = new System.Drawing.Point(26, 236);
			this.btnAlternativaA.Name = "btnAlternativaA";
			this.btnAlternativaA.Size = new System.Drawing.Size(29, 28);
			this.btnAlternativaA.TabIndex = 1;
			this.btnAlternativaA.Text = "A";
			this.btnAlternativaA.UseVisualStyleBackColor = true;
			this.btnAlternativaA.Click += new System.EventHandler(this.BtnAlternativaAClick);
			// 
			// btnAlternativaB
			// 
			this.btnAlternativaB.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.btnAlternativaB.FlatAppearance.BorderSize = 2;
			this.btnAlternativaB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlternativaB.Location = new System.Drawing.Point(26, 321);
			this.btnAlternativaB.Name = "btnAlternativaB";
			this.btnAlternativaB.Size = new System.Drawing.Size(29, 28);
			this.btnAlternativaB.TabIndex = 2;
			this.btnAlternativaB.Text = "B";
			this.btnAlternativaB.UseVisualStyleBackColor = true;
			this.btnAlternativaB.Click += new System.EventHandler(this.BtnAlternativaBClick);
			// 
			// lblRespostaA
			// 
			this.lblRespostaA.Location = new System.Drawing.Point(61, 242);
			this.lblRespostaA.Name = "lblRespostaA";
			this.lblRespostaA.Size = new System.Drawing.Size(210, 56);
			this.lblRespostaA.TabIndex = 84;
			this.lblRespostaA.Text = "?";
			// 
			// btnAlternativaC
			// 
			this.btnAlternativaC.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.btnAlternativaC.FlatAppearance.BorderSize = 2;
			this.btnAlternativaC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlternativaC.Location = new System.Drawing.Point(310, 239);
			this.btnAlternativaC.Name = "btnAlternativaC";
			this.btnAlternativaC.Size = new System.Drawing.Size(29, 28);
			this.btnAlternativaC.TabIndex = 3;
			this.btnAlternativaC.Text = "C";
			this.btnAlternativaC.UseVisualStyleBackColor = true;
			this.btnAlternativaC.Click += new System.EventHandler(this.BtnAlternativaCClick);
			// 
			// btnAlternativaD
			// 
			this.btnAlternativaD.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.btnAlternativaD.FlatAppearance.BorderSize = 2;
			this.btnAlternativaD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlternativaD.Location = new System.Drawing.Point(310, 327);
			this.btnAlternativaD.Name = "btnAlternativaD";
			this.btnAlternativaD.Size = new System.Drawing.Size(29, 28);
			this.btnAlternativaD.TabIndex = 4;
			this.btnAlternativaD.Text = "D";
			this.btnAlternativaD.UseVisualStyleBackColor = true;
			this.btnAlternativaD.Click += new System.EventHandler(this.BtnAlternativaDClick);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel3.Location = new System.Drawing.Point(-22, 507);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1224, 44);
			this.panel3.TabIndex = 82;
			// 
			// lblPontuacao
			// 
			this.lblPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPontuacao.Location = new System.Drawing.Point(32, 467);
			this.lblPontuacao.Name = "lblPontuacao";
			this.lblPontuacao.Size = new System.Drawing.Size(160, 23);
			this.lblPontuacao.TabIndex = 83;
			this.lblPontuacao.Text = "Pontuação: 000";
			this.lblPontuacao.Click += new System.EventHandler(this.LblPontuacaoClick);
			// 
			// timerQuiz1
			// 
			this.timerQuiz1.Interval = 1000;
			this.timerQuiz1.Tick += new System.EventHandler(this.TimerQuiz1Tick);
			// 
			// lblNomeUsuario
			// 
			this.lblNomeUsuario.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeUsuario.Location = new System.Drawing.Point(1021, 118);
			this.lblNomeUsuario.Name = "lblNomeUsuario";
			this.lblNomeUsuario.Size = new System.Drawing.Size(168, 23);
			this.lblNomeUsuario.TabIndex = 85;
			this.lblNomeUsuario.Text = "*nome do usuario";
			this.lblNomeUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBoxAvatar
			// 
			this.pictureBoxAvatar.Location = new System.Drawing.Point(1045, 12);
			this.pictureBoxAvatar.Name = "pictureBoxAvatar";
			this.pictureBoxAvatar.Size = new System.Drawing.Size(114, 105);
			this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxAvatar.TabIndex = 84;
			this.pictureBoxAvatar.TabStop = false;
			// 
			// Quiz1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1194, 547);
			this.Controls.Add(this.lblNomeUsuario);
			this.Controls.Add(this.pictureBoxAvatar);
			this.Controls.Add(this.lblPontuacao);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pictureBoxClickVoltar);
			this.Controls.Add(this.btnConcluirClick);
			this.Controls.Add(this.lblTexto2);
			this.Controls.Add(this.picLogo1);
			this.Controls.Add(this.btnQ10);
			this.Controls.Add(this.btnQ9);
			this.Controls.Add(this.btnQ8);
			this.Controls.Add(this.btnQ7);
			this.Controls.Add(this.btnQ6);
			this.Controls.Add(this.btnQ5);
			this.Controls.Add(this.btnQ3);
			this.Controls.Add(this.btnQ4);
			this.Controls.Add(this.btnQ2);
			this.Controls.Add(this.btnQ1);
			this.Name = "Quiz1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quiz1";
			this.Activated += new System.EventHandler(this.Quiz1Activated);
			((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClickVoltar)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBoxAvatar;
		private System.Windows.Forms.Label lblNomeUsuario;
		private System.Windows.Forms.Label lblNumeroQuestao;
		private System.Windows.Forms.Timer timerQuiz1;
		private System.Windows.Forms.Label lblTempo;
		private System.Windows.Forms.Label lblPontuacao;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnAlnternativaE;
		private System.Windows.Forms.Label lblRespostaE;
		private System.Windows.Forms.Label lblRespostaC;
		private System.Windows.Forms.Label lblRespostaD;
		private System.Windows.Forms.Label lblQ;
		private System.Windows.Forms.Label lblPergunta;
		private System.Windows.Forms.Label lblRespostaA;
		private System.Windows.Forms.Label lblRespostaB;
		private System.Windows.Forms.Button btnAlternativaA;
		private System.Windows.Forms.Button btnAlternativaB;
		private System.Windows.Forms.Button btnAlternativaC;
		private System.Windows.Forms.Button btnAlternativaD;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBoxClickVoltar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnConcluirClick;
		private System.Windows.Forms.Label lblTexto2;
		private System.Windows.Forms.PictureBox picLogo1;
		private System.Windows.Forms.Button btnQ8;
		private System.Windows.Forms.Button btnQ9;
		private System.Windows.Forms.Button btnQ10;
		private System.Windows.Forms.Button btnQ6;
		private System.Windows.Forms.Button btnQ7;
		private System.Windows.Forms.Button btnQ5;
		private System.Windows.Forms.Button btnQ3;
		private System.Windows.Forms.Button btnQ4;
		private System.Windows.Forms.Button btnQ2;
		private System.Windows.Forms.Button btnQ1;
		
		
		}
	}
