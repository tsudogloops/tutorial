using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shuffle.Models
{
    public class ShuffleViewModel
    {
        public HashSet<string> Registers { get; set; }
    }

    public class SignalRViewModel
    {
        public string CookieKey { get; set; }
        public string CookieValue { get; set; }
        public string CookieDomain { get; set; }
    }
}