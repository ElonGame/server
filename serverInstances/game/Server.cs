using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Config;
using SuperSocket.SocketBase.Protocol;

using Libraries.helpers.package;


namespace Game
{

    [PackageCommandFilter]
    public class Server : AppServer<PlayerSession, Package>
    {

        public Server() : base(new DefaultReceiveFilterFactory<PackageParser, Package>())
        {

        }

        protected override bool Setup(IRootConfig rootConfig, IServerConfig config)
        {

            return base.Setup(rootConfig, config);

        }

        public override bool Start()
        {

            return base.Start();

        }

        public override void Stop()
        {

            base.Stop();

        }

    }

}
