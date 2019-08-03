using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            while (pokemons.Count > 0 )
            {
                int index = int.Parse(Console.ReadLine());
                int poke = 0;
                if (index < 0)
                {
                    index = 0;
                    poke = pokemons[index];
                    sum += poke;
                    pokemons.RemoveAt(0);
                    pokemons.Insert(0, pokemons[pokemons.Count - 1]);

                }
                else if (index >= pokemons.Count)
                {
                    index = pokemons.Count - 1;
                    poke = pokemons[index];
                    sum += poke;
                    pokemons.RemoveAt(pokemons.Count - 1);
                    pokemons.Add(pokemons[0]);
                }
                else
                {
                    poke = pokemons[index];
                    sum += poke;
                    pokemons.RemoveAt(index);
                }
                
                
                for (int i = 0; i < pokemons.Count; i++)
                {
                    
                    if (pokemons[i] > poke)
                    {
                        pokemons[i] -= poke;
                    }
                    else
                    {
                        pokemons[i] += poke;
                    }
                }                
            }
            Console.WriteLine(sum);
        }
    }
}
