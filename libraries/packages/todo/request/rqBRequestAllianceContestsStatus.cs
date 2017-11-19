using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestAllianceContestsStatus.
    /// </summary>
    public class PacketBRequestAllianceContestsStatus
    {

        public byte[] Variable { get; }

        public PacketBRequestAllianceContestsStatus(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestAllianceContestsStatus\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
