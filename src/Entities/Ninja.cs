namespace JogoHeroiDIO.src.Entities
{
    public class Ninja : Hero
    { 
        public Ninja(string Name, int Level, string HeroType) {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

         public string Attack(int Extra){

            if (Extra > 6){
                return this.Name + " Atacou furtivamente e com dano extra de  " + Extra;
            }
            else{
            return this.Name + " atacou e deu dano moderado de" + Extra;
            }
        }
        
    }
}