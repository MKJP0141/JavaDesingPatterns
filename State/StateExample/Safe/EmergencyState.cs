using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample.Safe
{
    class EmergencyState : IState
    {
        private static readonly EmergencyState _instance = new EmergencyState();

        private EmergencyState() { }

        public static EmergencyState Instance => _instance;

        public void DoAlarm(IContext context)
        {
            context.CallSecurityCenter("非常ベル（緊急事態によるもの）");
        }

        public void DoClock(IContext context, int hour)
        {
            
        }

        public void DoPhone(IContext context)
        {
            context.CallSecurityCenter("警備センターを呼び出します（緊急事態）");
        }

        public void DoUse(IContext context)
        {
            context.CallSecurityCenter("金庫が使用されています！（緊急事態）");
        }
    }
}
