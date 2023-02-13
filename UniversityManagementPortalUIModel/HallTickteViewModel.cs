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
            ProgrammeList = new List<LookUpViewModel>() {
                new LookUpViewModel{Code="1000",Description="B.Tech.Artificial Intelligence and Data Science"},
                new LookUpViewModel{Code="1001",Description="B.E.Biomedical Engineering"},
                new LookUpViewModel{Code="1002",Description="B.Tech.Biotechnology"},
                new LookUpViewModel{Code="1003",Description="B.Tech.Chemical Engineering"},
                new LookUpViewModel{Code="1004",Description="B.E. Civil Engineering"},
                new LookUpViewModel{Code="1005",Description="B.Tech Computer Science and Business System"},
                new LookUpViewModel{Code="1006",Description="B.E. Computer and Communication Engineering"},
                new LookUpViewModel{Code="1007",Description="B.E. Computer Science and Engineering"},
                new LookUpViewModel{Code="1008",Description="B.E. Electronics and Communication Engineering"},
                new LookUpViewModel{Code="1009",Description="B.E. Electrical and Electronics Engineering"},
                new LookUpViewModel{Code="1010",Description="B.Tech. Information Technology"},
                new LookUpViewModel{Code="1011",Description="B.E. Mechanical Engineering" }
        };
            SemesterList = new List<LookUpViewModel>() {
                new LookUpViewModel { Code = "10010", Description = "Semester I" },
                new LookUpViewModel { Code = "10011", Description = "Semester II" },
                new LookUpViewModel { Code = "10012", Description = "Semester III" },
                new LookUpViewModel { Code = "10013", Description = "Semester IV" },
                new LookUpViewModel { Code = "10014", Description = "Semester V" },
                new LookUpViewModel { Code = "10115", Description = "Semester VI" },
            new LookUpViewModel { Code = "10116", Description = "Semester VII" },
            new LookUpViewModel { Code = "1011", Description = "Semester VIII" },
            };
        }

        public List<LookUpViewModel> ProgrammeList { get; set; }
        public List<LookUpViewModel> SemesterList { get; set; }
    }

}
