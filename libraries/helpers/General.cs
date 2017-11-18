using System.Text;


namespace Libraries.helpers.general
{

    public static class Helper
    {

        /// <summary>
        ///  Convert byte array to string
        /// </summary>
        /// <param name="byteArray">Byte array</param>
        /// <returns>Converted string</returns>
        /// <see cref="https://stackoverflow.com/questions/10940883/c-converting-byte-array-to-string-and-printing-out-to-console"/>
        public static string PrintBytes(byte[] byteArray)
        {

            var sb = new StringBuilder("new byte[] { ");

            for (var i = 0; i < byteArray.Length; i++)
            {

                var b = byteArray[i];

                /// Format
                sb.AppendFormat("0x{0:X2}", b);

                if (i < byteArray.Length - 1)
                    sb.Append(", ");

            }

            sb.Append(" }");

            return sb.ToString();

        }

    }

}
