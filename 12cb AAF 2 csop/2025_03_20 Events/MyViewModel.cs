using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _2025_03_20_Events
{
    internal class MyViewModel
    {
        private ICommand someCommand;
        public ICommand SomeCommand 
        {
            get {
                /*
                 * a;
                    if(felt)
                        a = 5
                    else
                        a = 6
                    a = felt ? 5 : 6; 

                    if(felt)
                        a = 7
                    a = felt ?? 7;
                 */


                return someCommand ?? (someCommand = new ActionCommand(
                    () =>
                    {
                        MessageBox.Show("some command HotKey");
                    }
                ));
            }  
        }
    }
}
