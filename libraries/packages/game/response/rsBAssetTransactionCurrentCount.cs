using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 175.
    /// </summary>
    public class PacketBAssetTransactionCurrentCount
    {

        public long CurrentCount { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="count">Xuid from request content.</param>
        public PacketBAssetTransactionCurrentCount(long count)
        {

            CurrentCount = count;

        }

        /// <summary>
        /// Write instance to byte array.
        /// </summary>
        /// <returns>Returns the instance as byte array.</returns>
        public byte[] ToByteArray()
        {

            using (var Stream = new MemoryStream())
            {

                using (var Writer = new BinaryWriter(Stream))
                {

                    byte[] Package;

                    Writer.Write(CurrentCount);

                    Package = Stream.ToArray();

                    return Package;

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBAssetTransactionCurrentCount\r\n" +
                "CurrentCount = {0}\r\n",
                CurrentCount
            );

        }

    }

}
