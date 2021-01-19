using System;

namespace FinalTestEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarm ar = new Alarm();
            Fier fr = new Fier();
            ar.SomeEvent += fr.WakeUP;
            ar.FireAlarm(DateTime.Now);
        }
    }



    public class Alarm {

        public event MyDelegate SomeEvent;
        public void FireAlarm(DateTime DT)
        {
            if (SomeEvent != null)
            {
                SomeEvent(this, new DelegateEvent(DT));


            }

        }
    
    }


    public class Fier
    {

        public void WakeUP(object sender, DelegateEvent e)
        {
            Console.WriteLine("wakeup {0}", e.SetDate.ToString());

        }
    }


    public delegate void MyDelegate(object sender, DelegateEvent e);

    public class DelegateEvent : EventArgs
    { 
    
    public DateTime SetDate { get; set; }
        public DelegateEvent(DateTime setTime)
        {

            SetDate = setTime;
        }
    }
}
