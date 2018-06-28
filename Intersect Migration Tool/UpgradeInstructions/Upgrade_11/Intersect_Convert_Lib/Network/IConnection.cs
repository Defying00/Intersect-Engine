﻿using System;

namespace Intersect.Migration.UpgradeInstructions.Upgrade_11.Intersect_Convert_Lib.Network
{
    public interface IConnection : IDisposable
    {
        Guid Guid { get; }

        bool IsConnected { get; }

        string Ip { get; }
        int Port { get; }

        bool Send(IPacket packet);

        void HandleConnected();
        void HandleApproved();
        void HandleDisconnected();
    }
}