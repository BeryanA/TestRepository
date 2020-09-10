using System.Collections.Generic;

namespace SportsStore.Models {
    public class Department {

        public long Departmentid { get; set; }
        public string Name { get; set; }

        public IEnumerable<Person> People { get; set; }
    }
}
