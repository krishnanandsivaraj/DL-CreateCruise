using System;
using System.Collections.Generic;
using System.Text;

namespace DreamLines.Infrastructure.IntegrationTests.Model
{
    public class Ships
    {
        public int ship_id { get; set; }
        public int company_id { get; set; }
        public string title { get; set; }
        public List<Cabintypes> cabinTypes { get; set; }
    }

    public class Cabintypes
    {
        public int id { get; set; }
        public int nid { get; set; }
        public string title { get; set; }
    }
}
