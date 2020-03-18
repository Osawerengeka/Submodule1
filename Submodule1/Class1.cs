using System;

namespace Submodule1
{
    public class Security
    {
        public int hashfunc(string pass)
        {
            int hash = 0;
            for (int i = 1; i < pass.Length; i++)
            {
                hash = hash + pass[i] * pass[0];

            }
            return hash;
        }
    }
}
