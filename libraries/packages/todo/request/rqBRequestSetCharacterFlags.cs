using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestSetCharacterFlags.
    /// </summary>
    public class PacketBRequestSetCharacterFlags
    {

        public byte[] Variable { get; }

        public PacketBRequestSetCharacterFlags(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestSetCharacterFlags\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
