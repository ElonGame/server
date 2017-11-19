using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestCityDataPacket.
    /// </summary>
    public class PacketBRequestCityDataPacket
    {

        public byte[] Variable { get; }

        public PacketBRequestCityDataPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestCityDataPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
