﻿using CloudChains.Spv.Lib.CoinParameters.Bitcoin;
using CloudChains.Spv.Lib.RPC.Specifications;

using System;
using System.Collections.Generic;
using System.Text;

namespace CloudChains.Spv.Lib.Services.Coins.Bitcoin
{
    public class BitcoinService : CoinService
    {
        public BitcoinService()
        {

        }
        public BitcoinService(string daemonUrl, string rpcUsername, string rpcPassword, string walletPassword)
            : base(daemonUrl, rpcUsername, rpcPassword, walletPassword)
        {
        }

        public BitcoinService(string daemonUrl, string rpcUsername, string rpcPassword, string walletPassword, short rpcRequestTimeoutInSeconds)
            : base(daemonUrl, rpcUsername, rpcPassword, walletPassword, rpcRequestTimeoutInSeconds)
        {
        }

        public BitcoinConstants.Constants Constants => BitcoinConstants.Constants.Instance;
    }
}
