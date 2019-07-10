using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void ShowProgress()
        {
            TestContext.Progress.WriteLine("Progress");
        }

        [Test]
        public void ShowOut()
        {
            TestContext.Out.WriteLine("Out");
        }

        [Test]
        public void ShowWriteLine()
        {
            TestContext.WriteLine("WriteLine");
        }
        [Test]
        public void ShowWriteLineFails()
        {
            TestContext.Error.WriteLine("WriteLine");
           
        }

    }
}