using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBGetMailMessagesRequest.
    /// </summary>
    public class PacketBGetMailMessagesRequest
    {

        public byte[] Variable { get; }

        public PacketBGetMailMessagesRequest(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBGetMailMessagesRequest\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
