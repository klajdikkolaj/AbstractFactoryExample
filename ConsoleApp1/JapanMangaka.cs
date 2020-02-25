using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class JapanMangaka : IAbstractMangaka
    {
        public IAbstractAnime Anime()
        {
            return new AnimeJapan();
        }

        public IAbstractManga Manga()
        {
            return new Manga();
        }

        public IAbstractNovel Novel()
        {
            return new JapanNovel();
        }
    }
}
