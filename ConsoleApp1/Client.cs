using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("Testing Different Kinds of states");
            StateTypes(new ChineseMangaka());
            StateTypes(new JapanMangaka());
            StateTypes(new SouthCoreaMangaka());
        }

        private static void StateTypes(IAbstractMangaka mangakaFactory)
        {
            var mangas = mangakaFactory.Manga();
            var novels = mangakaFactory.Novel();
            var animes = mangakaFactory.Anime();

            Console.WriteLine(mangas.WriteManga());
            Console.WriteLine(novels.WriteNovel());
            Console.WriteLine(animes.WriteAnime());


        }
    }
}
