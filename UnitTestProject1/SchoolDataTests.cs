using NUnit.Framework;
using SchoolOopLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestFixture]
    public class SchoolDataTests
    {
        Student s = new Student();

        Subject sub = new Subject();

        Teacher ts = new Teacher();

        [TestCase("Deeraj", ExpectedResult = true)]
        [TestCase("Divya", ExpectedResult = false)]
        [TestCase("Arjun", ExpectedResult = false)]
        [TestCase("nanndini", ExpectedResult = false)]
        [TestCase("Aakash", ExpectedResult = false)]
        public bool IsName(string search)
        {

            return s.Search(search);

        }

        [TestCase("Maths", ExpectedResult = true)]
        [TestCase("Science", ExpectedResult = true)]
        [TestCase("Biology", ExpectedResult = false)]
        [TestCase("English", ExpectedResult = true)]
        public bool IsSubject(string subj)
        {

            return sub.Search(subj);

        }

        [TestCase("Oliver", ExpectedResult = true)]
        [TestCase("Ramu", ExpectedResult = true)]
        [TestCase("Ganesh", ExpectedResult = true)]
        [TestCase("Murgan", ExpectedResult = false)]
        public bool IsTeacher(string t)
        {

            return ts.Search(t);

        }


    }
}

