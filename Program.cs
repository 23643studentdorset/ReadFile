using System;
using System.IO;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileDemo.ReadDemo("jamaica.txt");

            string dc_heroesFile = "heroes-dc.txt";
            string[] dc_heroes = { "Batman: Bruce Wayne", "Superman: Clarke Kent", "Aquaman: ArthurCurry" };
            FileDemo.WriteDemo(dc_heroesFile, dc_heroes);

            
            string marvel_heroesfile = "heroes-marvel.txt";
            string[] marvel_heroes = { "Spiderman: Peter Parker", "The Hulk: David Banner", "Captain America: Steve Rogers" };
            FileDemo.WriteDemo(marvel_heroesfile, marvel_heroes);
            
            Console.WriteLine("Done");



        }
    }
}
