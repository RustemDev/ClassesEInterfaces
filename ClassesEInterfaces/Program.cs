using ClassesEInterfaces.Dominio;
using ClassesEInterfaces.Interface;
using System;

namespace ClassesEInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Guerreiro g1 = new Guerreiro();
            g1.Nome = "Henry";
            g1.Forca = 8;

            Arqueiro a1 = new Arqueiro();
            a1.Nome = "Pedro";
            a1.Forca = 7;

            Ninja n1 = new Ninja();
            n1.Nome = "João";
            n1.Forca = 6;

;           Mago m1 = new Mago();
            m1.Nome = "Will";
            m1.Forca = 9;

            Barbaro b1 = new Barbaro();
            b1.Nome = "Paulo";
            b1.Forca = 5;

            UsarPersonagens(g1);
            UsarPersonagens(a1);
            UsarPersonagens(n1);
            UsarPersonagens(m1);
            UsarPersonagens(b1);
            Confronto(b1, a1);




            Console.ReadLine();
        }

        public static void UsarPersonagens(IAcao gue)
        {
            Console.WriteLine("Nome: "+ gue.Nome +" Força: " +gue.Forca);
            string arma = gue.ArmaAtaque();
            Console.WriteLine("Atacando com arma "+arma);

        }

        public static void Confronto(IAcao p1,IAcao p2)
        {
            Console.WriteLine("Luta entre "+p1.Nome+" e "+p2.Nome);
            string vencedor = "";
            int forca = 0;

            if (p1.Forca > p2.Forca)
            {
                vencedor = p1.Nome;
                forca = p1.Forca;

            }
            else
            {
                vencedor = p2.Nome;
                forca = p2.Forca;
            }

            Console.WriteLine("O vencedor é "+vencedor+" com a força de "+forca+" de luta. ");
        }

       
    }
}
