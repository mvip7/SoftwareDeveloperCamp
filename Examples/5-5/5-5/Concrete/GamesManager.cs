using _5_5.Abstract;
using _5_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5_5.Concrete
{
    public class GamesManager : IGamesService
    {
        public void Add(Games games)
        {
            Console.WriteLine(games.Name+" İsimli Oyun Eklendi !!!");
        }

        public void Delete(Games games)
        {
            Console.WriteLine(games.Name + " İsimli Oyun Silindi !!!");
        }

        public void Update(Games games,string newName)
        {
            Console.WriteLine(games.Name + " İsimli Oyun "+newName+" Olarak Güncellendi !!!");
        }
    }
}
