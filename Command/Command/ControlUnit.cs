using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class ControlUnit
    {
        private List<Command> commands = new List<Command>();
        private int current = 0;
        public void StoreCommand(Command command)
        {
            commands.Add(command);
        }
        public void ExecuteCommand()
        {
            commands[current].Execute();
            current++;
        }
        public void Undo()
        {
            commands[current - 1].UnExecute();
        }
        public void Redo()
        {
            commands[current - 1].Execute();
        }
    }
    class ConcreteCommand
    {
        class Add : Command
        {
            public Add(ArithmeticUnit unit, double operand)
            {
                this.unit = unit;
                this.operand = operand;
            }
            public override void Execute()
            {
                unit.Run('+', operand);
            }
            public override void UnExecute()

            {
                unit.Run('-', operand);
            }
        }
    }

    class Calculator
    {
        ArithmeticUnit arithmeticUnit;
        ControlUnit controlUnit;
        public Calculator()
        {
            arithmeticUnit = new ArithmeticUnit();
            controlUnit = new ControlUnit();
        }
        private double Run(Command command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();
            return arithmeticUnit.Register;
        }
        public double Add(double operand)
        {
            return Run(new Add(arithmeticUnit, operand));
        }
    }

}
