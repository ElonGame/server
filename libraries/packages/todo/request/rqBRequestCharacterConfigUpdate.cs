using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestCharacterConfigUpdate.
    /// </summary>
    public class PacketBRequestCharacterConfigUpdate
    {

        public byte[] Variable { get; }

        public PacketBRequestCharacterConfigUpdate(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestCharacterConfigUpdate\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
