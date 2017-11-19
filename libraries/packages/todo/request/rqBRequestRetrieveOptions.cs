using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestRetrieveOptions.
    /// </summary>
    public class PacketBRequestRetrieveOptions
    {

        public byte[] Variable { get; }

        public PacketBRequestRetrieveOptions(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestRetrieveOptions\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
