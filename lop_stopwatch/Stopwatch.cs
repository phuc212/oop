using System;
namespace lop_stopwatch
{
    public class Stopwatch
    {
        private DateTime _starttime;
        public DateTime StarTime
        {
            get { return _starttime; }
            set { _starttime = value; }
        }
        private DateTime _endtime;
        public DateTime EndTiME
        {
            get { return _endtime; }
            set { _endtime = value; }
        }
        public Stopwatch(){
            StarTime = DateTime.Now;

        }
        public void Start (){
            StarTime = DateTime.Now;
        }
        public void Stop (){
            EndTiME = DateTime.Now;
        }
        public int GetElapsedTime(){
            return (int)(EndTiME - StarTime).TotalMilliseconds;
        }


        
        
    }
}