using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestInventoryDataPacket.
    /// </summary>
    public class PacketBRequestInventoryDataPacket
    {

        public byte[] Variable { get; }

        public PacketBRequestInventoryDataPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestInventoryDataPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
