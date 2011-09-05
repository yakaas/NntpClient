﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace NntpClient.Testing {
    class Program {
        static void Main(string[] args) {
            var settings = ConfigurationManager.AppSettings;
            string hostname = settings["NntpHost"],
                   user = settings["NntpUser"],
                   pass = settings["NntpPass"];
            int port = int.Parse(settings["NntpPort"]);

            using(Client nntp = new Client()) {
                nntp.Connect(hostname, port, true);
                nntp.Authenticate(user, pass);
            }
        }
    }
}
