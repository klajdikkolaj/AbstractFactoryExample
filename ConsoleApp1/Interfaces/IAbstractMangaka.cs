using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IAbstractMangaka
    {
        IAbstractNovel Novel();
        IAbstractManga Manga();

        IAbstractAnime Anime();
    }
}
