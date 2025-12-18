using static TravelSyncTeamCity.Program;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void TestSmallNumbers()
        {
            Assert.IsTrue(GetPellIterative(0) == 0);
        }

        [Test]
        public void TestMediumNumbers()
        {
            Assert.IsTrue(GetPellIterative(10) == 2378);
        }

        [Test]
        public void TestBigNumbers()
        {
            Assert.IsTrue(GetPellIterative(31) == 259717522849);
        }
    }
}