namespace zoo_management
{
    public class dog : Animal
    {
        public dog (){

        }
    private string _speak;
     public dog(string name, string description, int age, string speak) : base(name, description,age )
        {
            _speak = speak;
        }
        public override string ViewInfor()
        {
            return $"{base.ViewInfor()}\t\t{_speak}";
        }


    }
}