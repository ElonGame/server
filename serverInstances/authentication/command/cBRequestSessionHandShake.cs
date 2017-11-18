using SuperSocket.SocketBase.Command;

using Libraries.helpers.package;
using Libraries.packages.custom;
using Libraries.enums;


namespace Authentication.Command
{

    public class BRequestSessionHandShake : CommandBase<PlayerSession, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(PlayerSession s, Package p)
        {

            var Request = new PacketBRequestSessionHandShake(p.Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Execute command: {Request}");

            PacketBResponseSessionHandShake ResponseContent;

            //@TODO validate player
            // Also duplicate on game instance

            ResponseContent = new PacketBResponseSessionHandShake(1);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            var Response = ResponseContent.ToByteArray();
            var Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, Response.Length, PacketTypes.BResponseSessionHandShake, p.HeaderRequestId, Response);

            var ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
