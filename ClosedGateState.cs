using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class ClosedGateState:IGateState
    {
        private Gate gate;
        public ClosedGateState(Gate gate)
        {
            this.gate = gate;
        }

        public void Arrive()
        {
            Console.WriteLine("Benvenuto la tua targa è XXXXX");
            this.gate.ChangeState(new ProcessedGateState(this.gate));
        }

        public void Exit()
        {
            Console.WriteLine("Non puoi passare SBARRA CHIUSA");
            this.gate.ChangeState(new ClosedGateState(this.gate));
        }

        public void Pay()
        {
            Console.WriteLine("Prima Fermati alla Sbarra poi Paga");
            this.gate.ChangeState(new ClosedGateState(this.gate));
        }
    }
}
