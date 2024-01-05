namespace Calculator
{
    public class CalcOperations
    {
        public int Fnum { get; set; }
        public int Snum { get; set; }
        int res;
      
        public int Sub()
        {
            
            res = Fnum - Snum;
            return res;
        }
        public int Mul()
        {

            res = Fnum * Snum;
            return res;
        }
        public int Div()
        {

            res = Fnum / Snum;
            return res;
        }


    }
}
