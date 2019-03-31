using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample.Safe
{
    class NightState : IState
    {
        private static NightState _instance = new NightState();

        private NightState()
        {
        }

        public static IState Instance => _instance;

        public void DoAlarm(IContext context)
        {
            context.CallSecurityCenter("非常ベル(夜間)");
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
            context.CallSecurityCenter("夜間の通話録音");
        }

        public void DoUse(IContext context)
        {
            context.RecordLog("非常：夜間の金庫使用");
        }

        public override string ToString()
        {
            return "[夜間]";
        }
    }
}
