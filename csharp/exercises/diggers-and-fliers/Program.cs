using System;
using System.Collections.Generic;

namespace diggers_and_fliers {
    class Program {
        static void Main (string[] args) 
        {
            Earthworms earthworms = new Earthworms ();
            Ants ants = new Ants ();
            Gerbils gerbils = new Gerbils ();
            Finches finches = new Finches ();
            Parakeets parakeets = new Parakeets ();
            Terrapins terrapins = new Terrapins ();
            TimberRattlesnakes timberRattlesnakes = new TimberRattlesnakes ();
            Mice mice = new Mice ();
            BettaFish bettaFish = new BettaFish();
            Copperheads copperheads = new Copperheads();


            List<ILiveInGround> InGroundAnimalsContainer = new List<ILiveInGround>() {
                earthworms, ants, gerbils
            };
            InGroundAnimalsContainer
            .ForEach(iga => iga.Dig());
            
            Console.WriteLine($"Time for the In Ground Animals to dig in the dirt of their Container");

            List<IFly> FlyingAnimalsContainer = new List<IFly>() {
                finches, parakeets
            };
            FlyingAnimalsContainer.ForEach(fac => fac.Fly());
            Console.WriteLine($"Time for the Flying Animals to fly into their cages");

            List<ISwim> SwimmingAnimalsContainer = new List<ISwim>() {
                bettaFish, terrapins
            };
            SwimmingAnimalsContainer.ForEach(sac => sac.Swim());
            Console.WriteLine($"All swimmers, please swim to your container. Thank you. ");

            List<IMoveOnGround> GroundMovingAnimalsContainer = new List<IMoveOnGround>() {
                gerbils, terrapins, mice, copperheads, timberRattlesnakes
            };
            GroundMovingAnimalsContainer.ForEach(sac => sac.GetMobile());
            Console.WriteLine($"Ground moving animals need to slither or walk or do whatever they do to get to their container.");
            

            
            }

            }
    }

