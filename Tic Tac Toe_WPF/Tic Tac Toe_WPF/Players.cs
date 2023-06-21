using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_WPF
{
     public class Players
    {
        string _name;

        public string Name
        {
            get { return _name; }
        }

        int _score;

        public int Score
        {
          get { return _score; }
        }


        public Players()
        {
                
        }

        public Players(string name, int score)
        {
            this._name = name;
            this._score = score;
        
        }
    }
}
