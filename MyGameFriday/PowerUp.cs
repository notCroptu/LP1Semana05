using System;
using System.Text;

namespace MyGameFriday
{
    [Flags]
    public enum PowerUp
    {
        Health = 1 << 0,
        Shield = 1 << 1
    }
}
