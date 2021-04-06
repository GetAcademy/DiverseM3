using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiverseM3.TemplateMethod
{
    class Sub : Super
    {
        public override void DoSomething()
        {
            Step05();
            base.DoSomething();
            Step40();
        }

        protected override void Step20()
        {
            Step15();
            base.Step20();
            Step25();
        }



        private void Step25()
        {
        }

        private void Step15()
        {
        }

        private void Step40()
        {
            
        }

        private void Step05()
        {
            
        }
    }
}
