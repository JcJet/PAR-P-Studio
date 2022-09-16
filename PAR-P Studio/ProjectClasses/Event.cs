using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Класс события
//©PAR-P Corp.

namespace PAR_P_Studio.ProjectClasses
{
    [Serializable]
   public class Event
    {
       public DateTime Time { get; set; }
       public string User { get; set; }
       public string EventType { get; set; }
       public string Element { get; set; }   
       public string Dataset { get; set; }       

       public Event()
       {
           Time = new DateTime();
           Time = DateTime.Now;
           User = StaticParams.CurrentUser.Login;
           EventType = "";
           Element = "";
           Dataset = StaticParams.Access.ToString();
       }
       public Event(string eventtype, string element)
       {
           Time = new DateTime();
           Time = DateTime.Now;
           User = StaticParams.CurrentUser.Login;
           EventType = eventtype;
           Element = element;
           Dataset = StaticParams.Access.ToString();
       }
    }
}
