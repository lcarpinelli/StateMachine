using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class ProcessedGateState : IGateState
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
            int pedaggio = 3;
            Console.WriteLine($"Il prezzo ammonta a {pedaggio}Euro, inserisci una banconota da 5 oppure da 10");
            int money = Convert.ToInt32(Console.ReadLine());
            if (money == 5)
            {               
                int resto;
                resto = money - pedaggio;
                Console.WriteLine($"Pagamento Effettuato, ritiri il resto di {resto}Euro");
                this.gate.ChangeState(new OpenGateState(this.gate));
            }
            else if (money == 10)
            {
                int resto;
                resto = money - pedaggio;
                Console.WriteLine($"Pagamento Effettuato, ritiri il resto di {resto}Euro");
                this.gate.ChangeState(new OpenGateState(this.gate));
            }
            else
            {
                Console.WriteLine("Pagamento non accettato Riprovare");
                this.gate.ChangeState(new ProcessedGateState(this.gate));
            }            
        }
    }
}
