using Atata;
using NUnit.Framework;

namespace AtataSamples.ExtentReports
{
    public class UsingOwnDriverTests : UITestFixture
    {
        [TearDown]
        public void Tear()
        {
            Assert.IsTrue(false);
        }

        [Test]
        public void Test1()
        {
            Go.To<HomePage>()
                .Report.Screenshot()
                .Header.Should.Contain("Atata");
        }

        [Test]
        public void Test2()
        {
            Go.To<HomePage>()
                .Report.Screenshot()
                .AggregateAssert(x => x
                    .PageTitle.Should.Contain("Atata")
                    .Header.Should.Contain("Atata"));
        }

        [Test]
        public void Test3()
        {
            Go.To<HomePage>()
                .Report.Screenshot()
                .Header.Should.Contain("Atata");
        }

        [Test]
        public void Test4()
        {
            Go.To<HomePage>()
                .Report.Screenshot()
                .AggregateAssert(x => x
                    .PageTitle.Should.Contain("Atata")
                    .Header.Should.Contain("Atata"));
        }

        [Test]
        public void Test5()
        {
            Go.To<HomePage>()
                .Report.Screenshot()
                .Header.Should.Contain("Atata");
        }

        [Test]
        public void Test6()
        {
            Go.To<HomePage>()
                .Report.Screenshot()
                .AggregateAssert(x => x
                    .PageTitle.Should.Contain("Atata")
                    .Header.Should.Contain("Atata"));
        }

        [Test]
        public void Test7()
        {
            Go.To<HomePage>()
                .Report.Screenshot()
                .Header.Should.Contain("Atata");
        }

        [Test]
        public void Test8()
        {
            Go.To<HomePage>()
                .Report.Screenshot()
                .AggregateAssert(x => x
                    .PageTitle.Should.Contain("Atata")
                    .Header.Should.Contain("Atata"));
        }
    }
}
