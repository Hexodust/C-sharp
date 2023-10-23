using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectia1.StandardTypes
{
    internal class BasicTypes
    {
        byte age0 = 1; // unsigned 8bit integer
        Byte age00 = 2;
        sbyte age02 = 3; // signed 8 bit integer
        SByte age01 = 3;

        short age03 = 4; // signed 16 bit integer
        Int16 age04 = 5;

        int age1 = 1;
        Int32 age2 = 1;
        long age3 = 1L;
        Int64 age4;
        short age5 = 1;
        Int16 age6;
        Int128 age7;

        float age8 = 1f;
        Single age9;
        double age10 = 1d;
        Double age11;
        decimal age12 = 1m; // Attention: NOT a basic type

        string name = "Adrian";
        char letter = 'A';

        bool active = true;
    }
}
