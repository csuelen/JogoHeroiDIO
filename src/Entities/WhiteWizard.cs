namespace JogoHeroiDIO.src.Entities
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string Name, int Level, string HeroType) {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " lançou magia";
        }

        public string Attack(int Bonus){

            if (Bonus > 6){
                return this.Name + " lançou magia superefetiva com bonus de  " + Bonus;
            }
            else{
            return this.Name + " lançou magia força franca com bonus de" + Bonus;
            }
        }
    }
}