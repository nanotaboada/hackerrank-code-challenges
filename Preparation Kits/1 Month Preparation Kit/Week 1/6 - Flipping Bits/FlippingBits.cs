using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;    
    
    public static long flippingBits(long n)
    {
        /*
            A 32-bit unsigned integer has a minimum value of 0 and a maximum
            value of 4,294,967,295 (inclusive).
        
            00000000000000000000000000000000 = 0 (minimum)
            00000000000000000000000000000001 = 1 (2^0)
            00000000000000000000000000000010 = 2 (2^1)
            00000000000000000000000000000011 = 3 (2^0 + 2^1)
            00000000000000000000000000000100 = 4 (2^2)
            00000000000000000000000000000101 = 5 (2^0 + 2^2)
            00000000000000000000000000000110 = 6 (2^1 + 2^2)
            00000000000000000000000000000111 = 7 (2^0 + 2^1 + 2^2)
            00000000000000000000000000001000 = 8 (2^3)
            ...
            11111111111111111111111111111111 = 4294967295 (maximum)
        */

        long maximum = (long)Math.Pow(2, 32) - 1;
        
        /*
            Subtracting any given number (within the range) from the maximum
            will in fact produce the expected "flipping" of the bits.
            
            For example:

            11111111111111111111111111111111 = 4294967295
          - 00000000000000000000000000101010 = 42 (2^1 + 2^3 + 2^5)
            --------------------------------
            11111111111111111111111111010101 = 4294967253 (4294967295 - 42)
        */
    
        return maximum - n;
    }