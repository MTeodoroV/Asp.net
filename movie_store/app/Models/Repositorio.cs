using System.Collections.Generic;
namespace App.Models
{
    public static class Repositorio
    {
        private static List<Resposta> respostas = new List<Resposta>();
        public static IEnumerable<Resposta> Respostas { get { return respostas; } }
        public static void AdicionarResposta(Resposta resposta)
        {
            respostas.Add(resposta);
        }

        static Repositorio()
        {
            respostas.Add(new Resposta(){ Nome="Fulano", Email = "fulano@gmail.com", Sim = true });
            respostas.Add(new Resposta(){ Nome="Cicrano", Email = "Cicrano@gmail.com", Sim = false });
            respostas.Add(new Resposta(){ Nome="Beltrano", Email = "Beltrano@gmail.com", Sim = true });
            respostas.Add(new Resposta(){ Nome="Maria", Email = "Maria@gmail.com", Sim = false });
            respostas.Add(new Resposta(){ Nome="José", Email = "José@gmail.com", Sim = false });
        }
    }
}