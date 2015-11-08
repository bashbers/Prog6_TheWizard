using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wizard
{
    public class Toverstaf
    {
        private int _hoeveelheidEnergie;

        public int HoeveelheidEnergie
        {
            get { return _hoeveelheidEnergie; }
        }

        public Toverstaf()
        {
            _hoeveelheidEnergie = 10;
        }

        public Toverstaf(int energie)
        {
            _hoeveelheidEnergie = 100;
        }

        public void links()
        {
            _hoeveelheidEnergie--;
        }

        public void rechts()
        {
            _hoeveelheidEnergie--;
        }

        public void omhoog()
        {
            _hoeveelheidEnergie--;
        }

        public void omlaag()
        {
            _hoeveelheidEnergie--;
        }
    }
}
