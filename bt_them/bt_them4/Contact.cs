namespace bt_them4
{
    public class Contact
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _number;
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public Contact(){

        }
        public Contact(string name, int number){
            _name = name;
            _number = number;
        }
        public string Info()
        {
            return $"{_name}\t\t{_number}";
        }
        
        
    }
}