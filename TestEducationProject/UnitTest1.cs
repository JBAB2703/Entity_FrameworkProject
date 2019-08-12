using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entity_FrameworkProject.Models;
using Entity_FrameworkProject;

namespace TestEducationProject {
    [TestClass]
    public class UnitTest1 {

        AppDbContext context = null;

        [TestInitialize]
        public void TestInit() {
            context = new AppDbContext();
        }

        [TestMethod]
        public void TestStudentGetByLastname() {
            var student = Program.GetStudentByLastname("Doe");
            Assert.IsNotNull(student);
            Assert.AreEqual("Doe", student.Lastname);
            student = Program.GetStudentByLastname("Dooe");
            Assert.IsNull(student, "student is null");
            
        }

        [TestMethod]
        public void TestStudentGetByPk() {
            var janedoe = Program.GetStudentById(1);
            Assert.IsNotNull(janedoe);
            Assert.AreEqual("Doe", janedoe.Lastname);
            var nobody = Program.GetStudentById(999);
            Assert.IsNull(nobody);
        }
    }
}
