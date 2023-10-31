using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Lib6;

namespace Lib_6_version_2._0_
{
    public struct Lessons
    {
        string _lesson, _lector;
        int _classNumber, _hours;

        public string Lesson
        {
            get { return _lesson; }
            set { _lesson = value; }
        }

        public string Lector
        {
            get { return _lector; }
            set { _lector = value; }
        }

        public int ClassNumber
        {
            get { return _classNumber; }
            set { _classNumber = value; }
        }

        public int Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }

        public Lessons()
        {
            _lesson = "Введите название предмета";
            _lector = "Введите имя лектора";
            _classNumber = 0;
            _hours = 0;
        }
        public Lessons(string lesson, string lector, int classNumber, int hours)
        {
            _lesson = lesson; _lector = lector;
            _classNumber = classNumber; _hours = hours;
        }

        public static List<string> GetLectorsInClass(List<Lessons> lessons, int classNumber)
        {
            List<string> result = new List<string>();

            foreach (Lessons i in lessons)
            {
                if (i.ClassNumber == classNumber) result.Add(i.Lector);
            }
            if (result.Count == 0)
            {
                throw new LectorsNotFoundException();
            }

            return result;
        }
    }
}