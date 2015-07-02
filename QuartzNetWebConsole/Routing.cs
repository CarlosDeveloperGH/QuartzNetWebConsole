﻿using System;
using System.Collections.Generic;
using QuartzNetWebConsole.Controllers;
using QuartzNetWebConsole.Utils;

using Route = System.Collections.Generic.KeyValuePair<string, System.Func<QuartzNetWebConsole.Utils.RelativeUri, QuartzNetWebConsole.Utils.Response>>;

namespace QuartzNetWebConsole {
    public class Routing {

        private static ISchedulerWrapper GetSchedulerWrapper() {
            return new SchedulerWrapper(Setup.Scheduler());
        }
        public static readonly IEnumerable<Route> Routes =
            new[] {
            };

        private static Route Route(string path, Func<RelativeUri, Response> action) {

            return new Route(path, action);

        }
    }
}