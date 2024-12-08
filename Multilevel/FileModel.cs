using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel
{
    internal class FileModel
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Secret { get; set; }
        public string FileContent { get; set; }
        public string Owner { get; set; }
        public string Server { get; set; }
        public string Description { get; set; }
    }
}
