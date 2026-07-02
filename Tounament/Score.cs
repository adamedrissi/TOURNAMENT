using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament
{
    public class Score
    {

        private string _player;
        private string _event;
        private int _result;

        public string Player
        {
            get { return _player; }
            set { _player = value; }
        }

        public string Event
        {
            get { return _event; }
            set { _event = value; }
        }

        public int Result
        {
            get { return _result; }
            set { _result = value; }
        }
    }
}
