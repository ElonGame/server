using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestCreateNewCharacter.
    /// </summary>
    public class PacketBRequestCreateNewCharacter
    {

        public byte[] Variable { get; }

        public PacketBRequestCreateNewCharacter(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestCreateNewCharacter\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
