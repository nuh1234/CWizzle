namespace first_csharp {
    public class Wizard : Human {
        public Wizard(string name) : base(name) {
            base.health = 50;
            base.intelligence = 25;
        }

        public void heal() {
            base.health += base.intelligence * 10;
        }
    }
}