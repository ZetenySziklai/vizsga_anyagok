using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace wpf_notepad
{
    internal class MyViewModel
    {
        private ICommand newTabItem;
        private TabControl tabc;

        public MyViewModel(TabControl tabcontrol)
        {
            tabc = tabcontrol;
        }


        public ICommand NewTabItem
        {
            get
            {
                return newTabItem ?? (newTabItem = new ActionCommand(
                    () =>
                    {
                        TabItem ti = new TabItem();
                        ti.MouseDown += TabItem_MouseDown;
                        ti.Header = "new file";
                        RichTextBox rtb = new RichTextBox();
                        ti.Content = rtb;
                        tabc.Items.Add(ti);
                    }
                ));
            }
        }
        private void TabItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (tabc.Items.Count > 1 && e.ChangedButton == MouseButton.Middle)
            {
                tabc.Items.RemoveAt(tabc.SelectedIndex);
            }
        }
    }
}
