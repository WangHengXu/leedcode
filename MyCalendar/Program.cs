using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Agenda
    {
        public int start;
        public int end;
        int cnt;//这个时间段已经安排的日程数
        public Agenda(int _start, int _end, int _cnt = 1)
        {
            start = _start;
            end = _end;
            cnt = _cnt;
        }
    }
    public class MyCalendarTwo
    {
        public MyCalendarTwo()
        {

        }
        private List<Agenda> AgendaList = new List<Agenda>();
        public bool Book(int start, int end)
        {
            AgendaList.Sort();
            var AgendaItem = AgendaList.FirstOrDefault(x => x.end < start);
           // if()

            return true;
        }
    }
}
