using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestAndIncrementScenarioIdPacket.
    /// </summary>
    public class PacketBRequestAndIncrementScenarioIdPacket
    {

        public byte[] Variable { get; }

        public PacketBRequestAndIncrementScenarioIdPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestAndIncrementScenarioIdPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
