using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestSavedUnitsToServerFirstTime.
    /// </summary>
    public class PacketBRequestSavedUnitsToServerFirstTime
    {

        public byte[] Variable { get; }

        public PacketBRequestSavedUnitsToServerFirstTime(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestSavedUnitsToServerFirstTime\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
