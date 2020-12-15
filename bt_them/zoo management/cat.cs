namespace zoo_management
{
    public class cat : Animal
    {
        public cat() {

        }
        private string _speak;
         public cat(string nameAnimal, string descrAnimal, int ageAnimal, string speak) : base(nameAnimal, descrAnimal, ageAnimal)
        {
            _speak = speak;
        }
        public override string ViewInfor()
        {
            return $"{base.ViewInfor()}\t\t{_speak}";
        }
    }
}