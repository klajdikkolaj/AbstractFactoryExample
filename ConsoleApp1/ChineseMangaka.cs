using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ChineseMangaka : IAbstractMangaka
    {
        public IAbstractAnime Anime()
        {
            return new ChineseAnime();
        }

        public IAbstractManga Manga()
        {
            return new Manhua();
        }

        public IAbstractNovel Novel()
        {
            return new ChineseNovels();
        }
    }
}
