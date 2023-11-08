using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEFORTRPG
{
    internal class SelectedCommand
    {
        public Command[] command = new Command[4];
        public void AddCommand(int index, Command command)
        {
            this.command[index] = command;
        }
        public void SortCommand()
        {
            for (int i = 0; i < this.command.Length; i++)
            {
                for (int j = 0; j < this.command.Length - 1; j++)
                {
                    if (command[i].priority > this.command[j].priority)
                    {
                        Command temp = command[i];
                        command[i] = command[j];
                        command[j] = temp;
                    }
                }

            }
        }

        public void Execute()
        {
            for(int i =0; i < this.command.Length; i++)
            {
                command[i].Execute();
            }
        }
    }
}
