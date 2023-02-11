using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementPortal.UIModel
{
    public class HallTickteViewModel
    {
        public HallTickteViewModel()
        {
            ProgrammeList = new List<LookUp>() {
                new LookUp{Code="1000",Description="B.Tech.Artificial Intelligence and Data Science"},
                new LookUp{Code="1001",Description="B.E.Biomedical Engineering"},
                new LookUp{Code="1002",Description="B.Tech.Biotechnology"},
                new LookUp{Code="1003",Description="B.Tech.Chemical Engineering"},
                new LookUp{Code="1004",Description="B.E. Civil Engineering"},
                new LookUp{Code="1005",Description="B.Tech Computer Science and Business System"},
                new LookUp{Code="1006",Description="B.E. Computer and Communication Engineering"},
                new LookUp{Code="1007",Description="B.E. Computer Science and Engineering"},
                new LookUp{Code="1008",Description="B.E. Electronics and Communication Engineering"},
                new LookUp{Code="1009",Description="B.E. Electrical and Electronics Engineering"},
                new LookUp{Code="1010",Description="B.Tech. Information Technology"},
                new LookUp{Code="1011",Description="B.E. Mechanical Engineering" }
        };
            SemesterList = new List<LookUp>() {
                new LookUp { Code = "10010", Description = "Semester I" },
                new LookUp { Code = "10011", Description = "Semester II" },
                new LookUp { Code = "10012", Description = "Semester III" },
                new LookUp { Code = "10013", Description = "Semester IV" },
                new LookUp { Code = "10014", Description = "Semester V" },
                new LookUp { Code = "10115", Description = "Semester VI" },
            new LookUp { Code = "10116", Description = "Semester VII" },
            new LookUp { Code = "1011", Description = "Semester VIII" },
            };
        }

        public List<LookUp> ProgrammeList { get; set; }
        public List<LookUp> SemesterList { get; set; }
    }

}
