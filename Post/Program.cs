using Post.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post {
    class Program {
        static void Main(string[] args) {

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's Awesome");
            Posti p1 = new Posti(
                DateTime.Parse("23/11/2019 01:00 "), " Traveling to New Zeland",
                " I'm going to visit this wonderful country",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good Night");
            Comment c4 = new Comment("May the force be with you");
            Posti p2 = new Posti(
                DateTime.Parse("23/11/2019 01:06 "), " Good night guys",
                " See you tomorrow", 5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
