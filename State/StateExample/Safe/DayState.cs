using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample.Safe
{
    class DayState : IState
    {
        private static DayState _instance = new DayState();

        private DayState()
        {
        }

        public static IState Instance => _instance;

        public void DoAlarm(IContext context)
        {
            context.CallSecurityCenter("非常ベル(昼間)");
        }

        public void DoClock(IContext context, int hour)
        {
            if (12 <= hour && hour < 13)
            {
                context.ChangeState(LunchState.Instance);
            }
            else if (hour < 9 || 17 <= hour)
            {
                context.ChangeState(NightState.Instance);
            }
        }

        public void DoPhone(IContext context)
        {
            context.CallSecurityCenter("通常の通話(昼間)");
        }

        public void DoUse(IContext context)
        {
            context.RecordLog("金庫使用(昼間)");
        }

        public override string ToString()
        {
            return "[昼間]";
        }
    }
}
