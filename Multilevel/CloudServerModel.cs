using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel
{
    public class CloudServerModel
    {
        public int Id { get; set; }
        public string ServerName { get; set; }
        public int Port { get; set; }
        public string IpAddress { get; set; }
        public string Secret { get; set; }
    }
}
