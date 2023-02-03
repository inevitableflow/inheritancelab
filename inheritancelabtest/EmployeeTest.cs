namespace inheritancelabtest;
using inheritancelab;
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TestDefaultAttributeValues()
        {
        Employee employee = new Employee();
        Assert.AreEqual("", employee.ID);
        Assert.AreEqual("", employee.Name);
        Assert.AreEqual("", employee.Address);
        Assert.AreEqual("", employee.Phone);
        Assert.AreEqual(0,  employee.SIN);
        Assert.AreEqual("", employee.DOB);
        Assert.AreEqual("", employee.Dept);

    }
}