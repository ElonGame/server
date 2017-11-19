using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBGetEmpireRequest.
    /// </summary>
    public class PacketBGetEmpireRequest
    {

        public byte[] Variable { get; }

        public PacketBGetEmpireRequest(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBGetEmpireRequest\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
