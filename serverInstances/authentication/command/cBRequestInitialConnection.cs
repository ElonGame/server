using SuperSocket.SocketBase.Command;

using Libraries.helpers.package;
using Libraries.packages.authentication;
using Libraries.enums;


namespace Authentication.command
{

    public class BRequestInitialConnection : CommandBase<PlayerSession, Package>
    {

        public const short GamePort = 1510;

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(PlayerSession s, Package p)
        {

            var Request = new PacketBRequestInitialConnection(p.Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Execute command: {Request}");

            PacketBResponseInitialConnection ResponseContent;

            ResponseContent = new PacketBResponseInitialConnection(Request.Xuid, 0, 1, string.Empty, string.Empty, GamePort, string.Empty, string.Empty);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            var Response = ResponseContent.ToByteArray();
            var Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, Response.Length, PacketTypes.BResponseInitialConnection, p.HeaderRequestId, Response);

            var ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
