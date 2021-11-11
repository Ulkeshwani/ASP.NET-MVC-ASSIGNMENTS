using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstMVCApplication.Models;

namespace FirstMVCApplication.DAL
{
    public class SportsDAL
    {
        public List<MatchSchedule> matchList = new List<MatchSchedule>()
        {
            new MatchSchedule(){MatchTitle ="IND VS PAK",ScheduleDate=DateTime.Now.ToShortDateString()},
            new MatchSchedule(){MatchTitle ="IND VS NZ",ScheduleDate=DateTime.Now.ToShortDateString()},
            new MatchSchedule(){MatchTitle ="IND VS AUS",ScheduleDate=DateTime.Now.ToShortDateString()},

        };

        public List<MatchSchedule> ListAllMatchSchedules()
        {
            return this.matchList;
        }
    }
}