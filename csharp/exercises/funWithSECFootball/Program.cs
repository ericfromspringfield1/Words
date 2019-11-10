using System;
using System.Collections.Generic;
using System.Linq;

namespace funWithSECFootball
{
public class Game
{
    public int Year { get; set; }
    public int Alabama { get; set; }
    public int Tennessee { get; set; }
}
    class Program
    {
        static void Main(string[] args)
        { 
            //Since 2007
            List<Game> games = new List<Game>() {
            new Game(){ Year=2007, Alabama=41, Tennessee=17,},
            new Game(){ Year=2008, Alabama=29, Tennessee=9,},
            new Game(){ Year=2009, Alabama=12, Tennessee=10,},
            new Game(){ Year=2010, Alabama=41, Tennessee=10,},
            new Game(){ Year=2011, Alabama=37, Tennessee=6,},
            new Game(){ Year=2012, Alabama=44, Tennessee=13,},
            new Game(){ Year=2013, Alabama=45, Tennessee=10,},
            new Game(){ Year=2014, Alabama=34, Tennessee=20,},
            new Game(){ Year=2015, Alabama=19, Tennessee=14,},
            new Game(){ Year=2016, Alabama=49, Tennessee=10,},
            new Game(){ Year=2017, Alabama=45, Tennessee=7,},
            new Game(){ Year=2018, Alabama=58, Tennessee=21,},
        };
          
      var results = games
        .Where(g => g.Year >= 2006)
        .GroupBy(game => games);

        foreach (var gamesGroup in results)
        {
         foreach (var game in gamesGroup)
         {
             Console.WriteLine($"In {game.Year} Alabama beat Tennessee {game.Alabama} - {game.Tennessee}");
         }
        }

        }
       
    }
        }
    
        
