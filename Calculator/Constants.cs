using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Constants
    {
        const string ADD_INOUT = "a";
        const string SUBSTRACT_INOUT = "s";
        const string MULTIPLY_INOUT = "m";
        const string DIVIDE_INOUT = "d";
        const string EQUAL_INOUT = "=";
        const string ENDAPP = "n";
        const string NULL = "";

        public static int CodeConvert(string arg)
        {
            switch (arg)
            {
                case ADD_INOUT:
                    return 0;
                case SUBSTRACT_INOUT:
                    return 1;
                case MULTIPLY_INOUT:
                    return 2;
                case DIVIDE_INOUT:
                    return 3;
                case EQUAL_INOUT:
                    return 4;
                default:
                    return 999;
            }
        }

        public static string GetENDAPP()
        {
            return ENDAPP;
        }

        public static string GetNULL()
        {
            return NULL;
        }
    }
}
