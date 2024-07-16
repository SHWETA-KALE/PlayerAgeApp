using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using PlayerApp.models;
using System.Xml.Linq;
using System.Runtime.CompilerServices;

namespace PlayerApp.models
{
    internal class Player
    {


        private const int DEFAULT_AGE = 18;

        public int Id { get;  }
        public string Name { get ; } 
        
        public int Age { get; } 

//constructor

        public Player(int id, string name)
        {
            Id = id;
            Name = name;
            Age = DEFAULT_AGE;
        }
        public Player(int id, string name, int age): this(id, name)
        {
            Age = age;
        }

        public static Player WhoIsElder(Player[]players)
        {
            Player elderPlayerAge = null;
            int elder = DEFAULT_AGE;
            foreach (Player player in players) {

                if (player.Age> elder)
                {
                    elder = player.Age;
                    elderPlayerAge =player;
                }
            }
            return elderPlayerAge;


    }
        public override string ToString()
        {
            return $"Eldest Id: {Id}\n" +
                $"Eldest Player Name: {Name}\n" +
                $"Age: {Age}" ;
        }



    }
}
