using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IColleague
    {
        void SetMediator(IMediator mediator);

        void SetColleagueEnabled(bool enabled);
    }
}
