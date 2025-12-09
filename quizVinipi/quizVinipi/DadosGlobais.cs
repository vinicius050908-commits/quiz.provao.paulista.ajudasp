/*
 * Created by SharpDevelop.
 * User: Viní
 * Date: 23/10/2025
 * Time: 20:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System;
using System.IO;

namespace quizVinipi
{
	public static class DadosGlobais
	{
		public static string NomeUsuario { get; set; }
		public static int Pontuacao { get; set; }
		public static int Acertos { get; set; }
		public static int Erros { get; set; }
		
		public static int PontuacaoTotal = 0;
		public static int QuizzesFeitos = 0;
		
		public static string AvatarSelecionado = "";
		
		public static DateTime TempoInicio { get; set; }
		public static string TempoFinal { get; set; }

		static DadosGlobais()
		{
			NomeUsuario = "";
			Pontuacao = 0;
			Acertos = 0;
			Erros = 0;
			TempoFinal = "00:00:00";
		}

		public static void Resetar()
		{
			Pontuacao = 0;
			Acertos = 0;
			Erros = 0;
			TempoFinal = "00:00:00";
		}
		
		public static void AtualizarAvatarNoArquivo()
		{
			string arquivo = "usuarios.txt";

			if (!File.Exists(arquivo))
				return;

			string usuarioAtual = NomeUsuario;
			string novoAvatar = AvatarSelecionado;

			string[] linhas = File.ReadAllLines(arquivo);

			for (int i = 0; i < linhas.Length; i++)
			{
				string[] dados = linhas[i].Split(';');

				// Se tiver menos de 3 campos, cria o campo do avatar
				while (dados.Length < 3)
					Array.Resize(ref dados, 3);

				if (dados[0] == usuarioAtual)
				{
					dados[2] = novoAvatar;
					linhas[i] = string.Join(";", dados);
					break;
				}
			}

			File.WriteAllLines(arquivo, linhas);
		}
	}
}


