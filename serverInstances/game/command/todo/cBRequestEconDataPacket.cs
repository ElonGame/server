﻿using SuperSocket.SocketBase.Command;

using Libraries.helpers.package;
using Libraries.packages.game;
using Libraries.enums;


namespace Game.Command
{

    public class BRequestEconDataPacket : CommandBase<PlayerSession, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(PlayerSession s, Package p)
        {

            var Request = new Libraries.packages.todo.PacketBRequestEconDataPacket(p.Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Execute command: {Request}");





        }

    }

}
