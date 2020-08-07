using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeBlog_1
{
    public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new MyDBContext())
            {
                /*var group = new Group()
                {
                    Name = "Rammstein",
                    Year = 1994
                };
                var group2 = new Group()
                {
                    Name = "Linkin Park",
                    Year = 1996
                };

                context.Groups.Add(group);
                context.Groups.Add(group2);
                context.SaveChanges();

                var songs = new List<Song>
                {
                    new Song() { Name = "What I've Done", GroupId = group2.Id},
                    new Song() { Name = "Given Up", GroupId = group2.Id},
                    new Song() { Name = "Benzin", GroupId = group.Id}
                };

                context.Songs.AddRange(songs);
                context.SaveChanges();

                foreach (var song  in songs)
                {
                    Console.WriteLine($"Song name: {song.Name}, Year: {song.Group.Name}");
                }*/

                var card1 = new GraphicsCard()
                {
                    corp = "AMD",
                    vendor = "Sapphire"
                };

                context.GraphicsCards.Add(card1);
                context.SaveChanges();

                Console.WriteLine($"Vendor of GC: {card1.vendor}, Corp of seller gpu: {card1.corp}, serial number: {card1.Id}");
                context.GraphicsCards.Remove(card1);
                context.SaveChanges();

                // ключ по которому будем менять данные 
                int key = 2;

                // Вариант 1. Изменение записи. 
                var item = context.GraphicsCards.Find(key); // найдем запись 
                if (item != null)
                {
                    item.corp = "Nvidia";
                    item.vendor = "ASUS ROG";
                    context.SaveChanges();
                }
            }
        }
    }

}
