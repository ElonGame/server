using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestAssignAdvisorPacket.
    /// </summary>
    public class PacketBRequestAssignAdvisorPacket
    {

        public byte[] Variable { get; }

        public PacketBRequestAssignAdvisorPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestAssignAdvisorPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
