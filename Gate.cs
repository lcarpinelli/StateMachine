using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class Gate
    {
        IGateState state;
        public Gate()
        {
            this.state = new ClosedGateState(this);
        }

        public void Arrive()
        {
            this.state.Arrive();
        }
        public void Pay()
        {
            this.state.Pay();
        }
        public void Exit()
        {
            this.state.Exit();
        }
        public void ChangeState(IGateState s)
        {
            this.state = s;
        }
    }
}
