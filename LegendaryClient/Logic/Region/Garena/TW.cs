﻿using System;
using System.Net;

namespace LegendaryClient.Logic.Region.Garena
{
    public sealed class TW : BaseRegion
    {
        public override string RegionName
        {
            get { return "tw"; }
        }

        public override string Server
        {
            get { return "prodtw.lol.garenanow.com"; }
        }

        public override string LoginQueue
        {
            get { return "https://loginqueuetw.lol.garenanow.com/"; }
        }

        public override string Location
        {
            get { return null; }
        }

        public override bool Garena
        {
            get { return true; }
        }

        public override string InternalName
        {
            get { return "TW"; }
        }

        public override string ChatName
        {
            get { return "tw"; }
        }

        public override Uri NewsAddress
        {
            get { return new Uri("http://ll.leagueoflegends.com/landingpage/data/na/en_US.js"); }
            //http://lol.garena.com/landing.php?[garneaUser]
        }

        public override string Locale
        {
            get { return "en_US"; }
        }

        public override IPAddress[] PingAddresses
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override Uri SpectatorLink
        {
            get { return new Uri("http://203.116.112.222:8088/observer-mode/rest/"); }
        }

        public override string SpectatorIpAddress
        {
            get { return ""; }
            set { }
        }
    }
}
