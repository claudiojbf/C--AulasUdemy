namespace System
{
    static internal class StringExtencions
    {
        public static string Cut(this string thisObj, int n)
        {
            if (thisObj.Length <= n)
            {
                return thisObj;
            }
            else
            {

                return thisObj.Substring(0, n) + "...";
            }
        }
    }
}
