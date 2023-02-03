namespace inheritancelabtest;
using inheritancelab;
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TestDefaultAttributeValues()
        {
        Employee employee = new Employee();
        Assert.AreEqual("", employee.id);
        Assert.AreEqual("", employee.name);
        Assert.AreEqual("", employee.address);
        Assert.AreEqual("", employee.phone);
        Assert.AreEqual(0,  employee.sin);
        Assert.AreEqual("", employee.dob);
        Assert.AreEqual("", employee.dept);

    }
}