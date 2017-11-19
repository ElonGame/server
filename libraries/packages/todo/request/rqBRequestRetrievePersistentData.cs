using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestRetrievePersistentData.
    /// </summary>
    public class PacketBRequestRetrievePersistentData
    {

        public byte[] Variable { get; }

        public PacketBRequestRetrievePersistentData(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestRetrievePersistentData\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
