namespace inheritancelabtest;
using inheritancelab;
[TestClass]
public class SalariedTest
{
    [TestMethod]
    public void TestDefaultAttributeValues()
    {
        Salaried employee = new Salaried();
        Assert.AreEqual("", employee.ID);
        Assert.AreEqual("", employee.Name);
        Assert.AreEqual("", employee.Address);
        Assert.AreEqual("", employee.Phone);
        Assert.AreEqual(0, employee.SIN);
        Assert.AreEqual("", employee.DOB);
        Assert.AreEqual("", employee.Dept);
        Assert.AreEqual(0, employee.Salary);
    }

    [TestMethod]
    public void TestParse()
    {
        string s = "1234987:Sam Packitaway:345 Stash Road, Piles, Alot:(660) 546-9867:999888777:March 19, 1958:Capital Acquisition:25675\r\n";
        Salaried employee = Salaried.Parse(s);

        Assert.AreEqual("1234987", employee.ID);
        Assert.AreEqual("Sam Packitaway", employee.Name);
        Assert.AreEqual("345 Stash Road, Piles, Alot", employee.Address);
        Assert.AreEqual("(660) 546-9867", employee.Phone);
        Assert.AreEqual(999888777, employee.SIN);
        Assert.AreEqual("March 19, 1958", employee.DOB);
        Assert.AreEqual("Capital Acquisition", employee.Dept);
        Assert.AreEqual(25675, employee.Salary);
    }
}
