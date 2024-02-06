namespace ExampleProject.Test;

public class DummyClassTest
{
    [Test]
    public void Test_Dummy_Method()
    {
        var dummyObject = new DummyClass();
        Assert.AreEqual("I am a dummy method, this is my received input: Dummy", dummyObject.DummyMethod("Dummy"));
    }
}