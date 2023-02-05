namespace inheritancelabtest;
using inheritancelab;
[TestClass]
public class PartTimeTest
{
    [TestMethod]
    public void TestDefaultAttributeValues()
    {
        PartTime employee = new PartTime();
        Assert.AreEqual("", employee.ID);
        Assert.AreEqual("", employee.Name);
        Assert.AreEqual("", employee.Address);
        Assert.AreEqual("", employee.Phone);
        Assert.AreEqual(0, employee.SIN);
        Assert.AreEqual("", employee.DOB);
        Assert.AreEqual("", employee.Dept);
        Assert.AreEqual(0, employee.Rate);
        Assert.AreEqual(0, employee.Hours);
    }

    [TestMethod]
    public void TestParse()
    {
        string s = "9536476: Perky Volunteer:343 Volly Road, Volunteersalot:(212) 345-9876:867643782:October 14, 1947:Volunteer Organization:16.80:22";
        PartTime employee = PartTime.Parse(s);

        Assert.AreEqual("9536476", employee.ID);
        Assert.AreEqual("Perky Volunteer", employee.Name);
        Assert.AreEqual("343 Volly Road, Volunteersalot", employee.Address);
        Assert.AreEqual("(212) 345-9876", employee.Phone);
        Assert.AreEqual(867643782, employee.SIN);
        Assert.AreEqual("October 14, 1947", employee.DOB);
        Assert.AreEqual("Volunteer Organization", employee.Dept);
        Assert.AreEqual(16.80, employee.Rate);
       Assert.AreEqual(22, employee.Hours);
    }
}