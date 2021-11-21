namespace RestWithASPNET.Service
{
    public static class CalculatorHelper
    {
        public static bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any, // Verifica tipo de numero de todos paises
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);

            return isNumber;
        }

        public static decimal ConvertToDecimal(string strNumber)
        {
            decimal number;

            strNumber = strNumber.Replace(".", ",");


            if (decimal.TryParse(strNumber, out number))
            {
                return number;
            }

            return 0;
        }
    }
}
