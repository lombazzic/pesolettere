using System;
using System.Collections.Generic;

public static class PesoLettere
{
    
    public static int Pesa(string input)
    {
        //int lunghezza = input.Length;
        int p=0;
        int j;
        for(j=0; j<input.Length; j++)
        {

            switch (input[p])
            {
                
                case 'a':
                p=p+1;
                break;

                case 'A':
                p=p+1;
                break; 

                case 'b':
                p=p+3;
                break;
                
                case 'B':
                p=p+3;
                break;

                case 'c':
                p=p+3;
                break;

                case 'C':
                p=p+3;
                break;

                case 'd':
                p=p+2;
                break;

                case 'D':
                p=p+2;
                break;

                case 'e':
                p=p+1;
                break;

                case 'E':
                p=p+1;
                break;

                case 'f':
                p=p+4;
                break;

                case 'F':
                p=p+4;
                break;
                
                case 'g':
                p=p+2;
                break;

                case 'G':
                p=p+2;
                break;

                case 'h':
                p=p+4;
                break;

                case 'H':
                p=p+4;
                break;

                case 'i':
                p=p+1;
                break;

                case 'I':
                p=p+1;
                break;

                case 'j':
                p=p+8;
                break;

                case 'J':
                p=p+8;
                break;

                case 'k':
                p=p+5;
                break;

                case 'K':
                p=p+5;
                break;

                case 'l':
                p=p+1;
                break;

                case 'L':
                p=p+1;
                break;

                case 'm':
                p=p+3;
                break;

                case 'M':
                p=p+3;
                break;

                case 'n':
                p=p+1;
                break;

                case 'N':
                p=p+1;
                break;

                case 'o':
                p=p+1;
                break;

                case 'O':
                p=p+1;
                break;

                case 'p':
                p=p+3;
                break;

                case 'P':
                p=p+3;
                break;

                case 'q':
                p=p+10;
                break;

                case 'Q':
                p=p+10;
                break;


                case 'r':
                p=p+1;
                break;

                case 'R':
                p=p+1;
                break;

                case 's':
                p=p+1;
                break;

                case 'S':
                p=p+1;
                break;

                case 't':
                p=p+1;
                break;

                case 'T':
                p=p+1;
                break;

                case 'u':
                p=p+1;
                break;

                case 'U':
                p=p+1;
                break;

                case 'v':
                p=p+4;
                break;

                case 'V':
                p=p+4;
                break;

                case 'w':
                p=p+4;
                break;
                
                case 'W':
                p=p+4;
                break;

                case 'x':
                p=p+8;
                break;

                case 'X':
                p=p+8;
                break;

                case 'y':
                p=p+4;
                break;

                case 'Y':
                p=p+4;
                break;

                case 'z':
                p=p+10;
                break;

                case 'Z':
                p=p+10;
                break;
            }
        }
        return p;
        
    }
}