using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample.Safe
{
    class LunchState : IState
    {
        public static LunchState _instance = new LunchState();

        private LunchState() { }

        public static LunchState Instance => _instance;

        public void DoAlarm(IContext context)
        {
            context.CallSecurityCenter("非常ベル（昼食）");
        }

        public void DoClock(IContext context, int hour)
        {
            if (9 <= hour && hour < 17)
            {
                context.ChangeState(DayState.Instance);
            }
        }

        public void DoPhone(IContext context)
        {
            context.RecordLog("留守録（昼食）");
        }

        public void DoUse(IContext context)
        {
            context.CallSecurityCenter("非常事態（昼食中）");
        }
    }
}
