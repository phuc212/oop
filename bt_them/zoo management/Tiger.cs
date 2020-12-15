namespace zoo_management
{
    public class Tiger : Animal
    {
        public Tiger(){

        }
        private string _speak;
        public Tiger(string name, string description, int age, string speak) : base(name, description,age )
        {
            _speak = speak;
        }
        public override string ViewInfor()
        {
            return $"{base.ViewInfor()}\t\t{_speak}";
        }


    }
}