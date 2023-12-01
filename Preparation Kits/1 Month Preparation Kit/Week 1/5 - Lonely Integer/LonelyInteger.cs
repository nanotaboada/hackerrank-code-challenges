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

class Result
{
    public static int lonelyinteger(List<int> integers)
    {
        var groups = integers.GroupBy(integer => integer);
        
        var unique = groups
            .Where(group => group.Count() == 1)
            .Select(element => element.Key)
            .Single();
            
        return unique;
    }

}
