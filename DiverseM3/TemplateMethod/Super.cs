using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiverseM3.TemplateMethod
{
    class Super
    {
        public virtual void DoSomething()
        {
            Step10();
            Step20();
            Step30();
        }

        private void Step30()
        {
        }

        protected virtual void Step20()
        {
        }

        private void Step10()
        {
        }
    }
}
