using System;

namespace RpgBattle
{
    public class Humano
    {
        public String Nome { get; set; }
        public String Forca { get; set; }
        public String HabilidadeEspecial { get; set; }
        public String Raca { get; set; }

        public Humano(String nome, String forca, String habilidadeEspecial, String raca)
        {
            Nome = nome;
            Forca = forca;
            HabilidadeEspecial = habilidadeEspecial;
            Raca = raca;
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Forca: " + Forca);
            Console.WriteLine("Habilidade: " + HabilidadeEspecial);
            Console.WriteLine("Raca: " + Raca);
        }
    }
    
    
}