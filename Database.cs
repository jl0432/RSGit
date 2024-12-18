using System.Collections.Generic;

namespace RandomSelection {
    public class Database {
        public List<Organ> Organs { get; set; } = new List<Organ>();
        public List<Log> Log { get; set; } = new List<Log>();
    }
}