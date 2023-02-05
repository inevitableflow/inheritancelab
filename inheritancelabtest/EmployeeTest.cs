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

    [TestMethod]
    public void TestParse()
    {
        string s = "634567:Fred Flintstone:34 Flintrock Way, Bedrock, BC:(345) 295-9076:678453234:June 15, 2000 BC:Pediatrics:27.85:44\r\n";
        Employee employee = Employee.Parse(s);

        Assert.AreEqual("634567", employee.ID);
        Assert.AreEqual("Fred Flintstone", employee.Name);
        Assert.AreEqual("34 Flintrock Way, Bedrock, BC", employee.Address);
        Assert.AreEqual("(345) 295-9076", employee.Phone);
        Assert.AreEqual(678453234, employee.SIN);
        Assert.AreEqual("June 15, 2000 BC", employee.DOB);
        Assert.AreEqual("Pediatrics", employee.Dept);
    }
}