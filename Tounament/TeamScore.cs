using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament
{
    public class TeamScore
    {
        private string _team;
        private string _teamevent;
        private int _teamresult;

        public string Teams
        {
            get { return _team; }
            set { _team = value; }
        }

        public string Event
        {
            get { return _teamevent; }
            set { _teamevent = value; }
        }

        public int Result
        {
            get { return _teamresult; }
            set { _teamresult = value; }
        }
    }
}
