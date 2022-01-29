namespace JogoHeroiDIO.src.Entities
{
    public abstract class Hero
    {
        public string Name;
        public int Level;
        public string HeroType;


//Construtor
        public Hero(string Name, int Level, string HeroType) {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

//Construtor que não pedirá nenhum parâmetro para a criação do objeto.
        public Hero(){}

        public override string ToString(){
        return this.Name + " " + this.Level + " " +this.HeroType;
        }

        public virtual string Attack (){
            return this.Name + " atacou com a espada";
        }

    }
}