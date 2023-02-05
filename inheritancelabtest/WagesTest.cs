namespace inheritancelabtest;
using inheritancelab;
[TestClass]
public class WagesTest
{
    [TestMethod]
    public void TestDefaultAttributeValues()
    {
        Wages employee = new Wages();
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
        string s = "54153:BobBob Never:22 NeverReally Lane, Neverland: (234) 674-7865:98765678:September 3, 1988:Never Media:30.60:48";
        Wages employee = Wages.Parse(s);

        Assert.AreEqual("54153", employee.ID);
        Assert.AreEqual("BobBob Never", employee.Name);
        Assert.AreEqual("22 NeverReally Lane, Neverland", employee.Address);
        Assert.AreEqual("(234) 674-7865", employee.Phone);
        Assert.AreEqual(98765678, employee.SIN);
        Assert.AreEqual("September 3, 1988", employee.DOB);
        Assert.AreEqual("Never Media", employee.Dept);
        Assert.AreEqual(30.60, employee.Rate);
        Assert.AreEqual(48, employee.Hours);
    }
}