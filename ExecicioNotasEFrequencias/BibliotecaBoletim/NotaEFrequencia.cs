using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecicioNotasEFrequencias.NotasEFrequencias
{
    public class NotaEFrequencia
    {
        
        /// <summary>
        /// Metodo que recebe a informação das notas e faz a média do aluno
        /// </summary>
        /// <param name="nota1">prineira nota</param>
        /// <param name="nota2">segunda nota</param>
        /// <param name="nota3">terceira nota</param>
        /// <param name="media">media das notas</param>
        /// <returns></returns>
        public int Nota(int nota1, int nota2, int nota3)
        {
            return nota1 + nota2 + nota3 / 3;
        }
        /// <summary>
        /// Metodo que recebe as presenca dos alunos e informa a sua frequencia nas aulas
        /// </summary>
        /// <param name="presenca">Presenca do aluno</param>
        /// <param name="aulas">Numero de aulas</param>
        /// <param name="frequencia">Frequencia nas aulas</param>
        /// <returns></returns>
        public int Frequencia(int presenca, int aulas)
        {
            return (presenca / aulas) * 100;
        }
        /// <summary>
        /// Metodo que mostra se o aluno esta aprovado ou não
        /// </summary>
        public void Status(int media, int frequencia)
        {
            if ((media >= 7) && (frequencia >= 75))
            {
                Console.WriteLine($"Aluno aprovado com média {media} e frequencia de {frequencia}%");
            }
            else
            {
                Console.WriteLine($"Aluno reprovado com média {media} e frequencia de {frequencia}%");
            }
        }
        public string RetornaStatus(int media, int frequencia)
        {
            if ((media >= 7) && (frequencia >= 75))
            {
                return "Aprovado";
            }
            return "Reprovado";
        }
    }
}
