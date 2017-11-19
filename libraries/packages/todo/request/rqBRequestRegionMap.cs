using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestRegionMap.
    /// </summary>
    public class PacketBRequestRegionMap
    {

        public byte[] Variable { get; }

        public PacketBRequestRegionMap(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestRegionMap\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
