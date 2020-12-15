namespace zoo_management
{
    public class Animal
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public Animal(){

        }
        public Animal (string name, string description, int age)
        {
            _name = name;
            _description = description;
            _age = age;
        }
        public Animal (string name)
        {
            _name = name;
        }
        public Animal (string name, int age)
        {
            _name =name;
            _age = age;
        }
        public virtual string ViewInfor()
        {
            
            return $"{_name}\t\t{_description}\t\t{_age}";
        }
        public virtual string Speak()
        {
            return "";
        }
    }
}