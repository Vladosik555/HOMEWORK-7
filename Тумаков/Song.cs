using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    internal class Song
    {
        private string name;
        private string author;
        public Song prev;

        public string FillingName()
        {
            Console.Write("Напишите название песни: ");
            name = Console.ReadLine();
            return name;
        }
        public string FillingAuthor()
        {
            Console.Write("Напишите автора песни: ");
            author = Console.ReadLine();
            return author;
        }
        public void Prev(Song[] song)
        {
            for (int i = 0; i < song.Length; i++)
            {
                song[i].FillingName();
                song[i].FillingAuthor();
                Title();
            }
        }
        public void Title()
        {
            string title = $"название песни: {name}, автор песни: {author}";
            Console.WriteLine(title);
        }
        public override bool Equals(object d)
        {
            Song song = d as Song;
            if (song == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
