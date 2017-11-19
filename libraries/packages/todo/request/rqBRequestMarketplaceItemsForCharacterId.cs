using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestMarketplaceItemsForCharacterId.
    /// </summary>
    public class PacketBRequestMarketplaceItemsForCharacterId
    {

        public byte[] Variable { get; }

        public PacketBRequestMarketplaceItemsForCharacterId(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestMarketplaceItemsForCharacterId\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
