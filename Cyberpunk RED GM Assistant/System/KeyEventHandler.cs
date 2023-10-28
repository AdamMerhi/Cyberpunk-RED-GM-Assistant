using System.Windows.Forms;

namespace System
{
    internal class KeyEventHandler
    {
        private Action<object, KeyPressEventArgs> rollDmgTBox1_KeyPress;

        public KeyEventHandler(Action<object, KeyPressEventArgs> rollDmgTBox1_KeyPress)
        {
            this.rollDmgTBox1_KeyPress = rollDmgTBox1_KeyPress;
        }
    }
}