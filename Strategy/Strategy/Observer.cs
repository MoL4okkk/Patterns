using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Observer
    {
        private IStrategy Start;
        private IStrategy Finish;

        public void ChangeUpdate(object Object, EventArgs e)
        {
            IStrategy[] strategies = Object as IStrategy[];
            Update(strategies[0], strategies[1]);
        }

        private void Update(IStrategy Start, IStrategy Finish)
        {
            this.Start = Start;
            this.Finish = Finish;
        }
    }
}
