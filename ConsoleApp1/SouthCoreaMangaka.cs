using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SouthCoreaMangaka : IAbstractMangaka
    {
        public IAbstractAnime Anime()
        {
            return new AnimeCorea();
        }

        public IAbstractManga Manga()
        {
            return new Manhwa();
        }

        public IAbstractNovel Novel()
        {
            return new CoreanNovel();
        }
    }
}
