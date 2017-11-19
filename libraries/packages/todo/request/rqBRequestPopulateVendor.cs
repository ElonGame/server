using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestPopulateVendor.
    /// </summary>
    public class PacketBRequestPopulateVendor
    {

        public byte[] Variable { get; }

        public PacketBRequestPopulateVendor(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestPopulateVendor\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
