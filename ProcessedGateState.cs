using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class ProcessedGateState:IGateState
    {
        private Gate gate;
        public ProcessedGateState(Gate gate)
        {
            this.gate = gate;
        }
        public void Arrive()
        {
            Console.WriteLine("Sei gia fermo devi pagare");
            this.gate.ChangeState(new ProcessedGateState(this.gate));
        }

        public void Exit()
        {
            Console.WriteLine("Non puoi passare SBARRA CHIUSA");
            this.gate.ChangeState(new ProcessedGateState(this.gate));
        }

        public void Pay()
        {
            Console.WriteLine("Pagamento Effettuato");
            this.gate.ChangeState(new OpenGateState(this.gate));
        }
    }
}
