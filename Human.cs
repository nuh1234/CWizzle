using System;
namespace first_csharp {
    public class Human {
        public string name {get; set;}
        public int strength {get; set;}
        public int intelligence {get; set;}
        public int dexterity {get; set;}
        public int health {get; set;}

        public Human(string name) {
            this.name = name;
            this.strength = 3;
            this.intelligence = 3;
            this.dexterity = 3;
            this.health = 100;
        }
        public Human(string name, int strength, int intelligence, int dexterity, int health) {
            this.name = name;
            this.strength = strength;
            this.intelligence = intelligence;
            this.dexterity = dexterity;
            this.health = health;
        }

        public void attack(object o) {     
            Human h = o as Human;
            if(h != null) {
                h.health -= (this.strength * 5);
            }else {
                Console.WriteLine("Failed Attack");
            }
        }
    }
}