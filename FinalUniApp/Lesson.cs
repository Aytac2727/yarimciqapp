using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalUniApp
{
    class Lesson
    {
        public int Id { get; private set; }
        public string ProgramName { get; set; }
        public List<Teacher> Teachers { get; set; }
        public static int ProgramId = 1;

        public Lesson(string ProgramName)
        {
            this.ProgramName = ProgramName;
            Teachers = new List<Teacher>();
            ProgramId++;
            Id = ProgramId;

        }
    }
}
