using SuperSocket.SocketBase;

using Libraries.helpers.package;


namespace Authentication
{

    public class PlayerSession : AppSession<PlayerSession, Package>
    {

        public string PlayerName { get; internal set; }
        public string Password { get; internal set; }

        /// <summary>
        /// Override called when [session closed].
        /// </summary>
        /// <param name="reason">The reason.</param>
        protected override void OnSessionClosed(CloseReason reason)
        {

            if (Logger.IsInfoEnabled)
                Logger.Info($"Authentication::OnSessionClosed - Session closed. Reason: ({reason})");

        }

        /// <summary>
        /// Handle Unknown request
        /// </summary>
        /// <param name="content"></param>
        protected override void HandleUnknownRequest(Package content)
        {

            if (Logger.IsDebugEnabled)
                Logger.Debug($"Authentication::HandleUnknownRequest - Unknown package. Content: {content}");

        }


               


    }

}