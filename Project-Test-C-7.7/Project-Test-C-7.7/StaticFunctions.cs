using System;

namespace Project_Test_C_7._7
{
    public static class StaticFunctions
    {
        public enum TypeDelivery
        {
            tdHome,
            tdPickPoint,
            tdShop
        }
        static public bool CompareDateTime(DateTime dt1, DateTime dt2)
        {
            return dt1 > dt2;
        }
    }
}
