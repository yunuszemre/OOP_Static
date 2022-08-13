using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Static
{
    public static class PyhsicsLibrary
    {
        public static double GravityForce = -9.81;

        //Const => kendiliğinden static olarak işaretlidir....!!
        public const int KaldirmaKuvveti = 12;

        //ReadOnly değişkenler oluşturmak için kullanılabilir
        public static readonly int ReadOnly = 15;

        public static void Kaldir()
        {

        }
    }
}
