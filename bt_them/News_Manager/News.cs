using System;
namespace News_Manager
{
    public class News : INew
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        DateTime _publishDate;
        public DateTime PublishDate {get => _publishDate; set => _publishDate = value;}
        private string _author;
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        private string _content;
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        private float _averageRate;
        public float AverageRate
        {
            get { return _averageRate; }
            set { _averageRate = value; }
        }
        public string Display(){
            
           return $"{_title}\t\t{_publishDate}\t\t{_author}\t\t{_content}";

        }
        int[] RateList = new int[3];
        public void Calculate(){
            _averageRate = (float) (RateList[0] + RateList[1] + RateList[2])/3;
        }
    }
}