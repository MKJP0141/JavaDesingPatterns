using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample.Safe
{
    public interface IState
    {
        void DoClock(IContext context, int hour);

        void DoUse(IContext context);

        void DoAlarm(IContext context);

        void DoPhone(IContext context);
    }
}
