using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class OpenGateState:IGateState
    {
        private Gate gate;
        public OpenGateState(Gate gate)
        {
            this.gate = gate;
        }

        public void Arrive()
        {
            Console.WriteLine("Sei gia fermo  puoi pagare, il pagamento è andato a buon fine");
            this.gate.ChangeState(new OpenGateState(this.gate));
        }

        public void Exit()
        {
            Console.WriteLine("Arrivederci, dopo il tuo passaggio si chiuderà la Sbarra");
            this.gate.ChangeState(new ClosedGateState(this.gate));
        }

        public void Pay()
        {
            Console.WriteLine("Hai gia Pagato");
            this.gate.ChangeState(new OpenGateState(this.gate));
        }
    }
}
