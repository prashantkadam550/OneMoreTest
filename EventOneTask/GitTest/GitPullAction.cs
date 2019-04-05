using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    public class GitPullAction : GitAction
    {
        protected override string mCommand
        {
            get
            {
                return "pull";
            }
        }
        public override void beginProcess()
        {
            base.beginProcess();
        }
    }
}
