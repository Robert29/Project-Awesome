using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ForecastingService.UnitTests
{
    public class BaseTests
    {
        public static bool TestInitializedOnce = false;

        [TestInitialize]
        public virtual void InitTests()
        {
            if (TestInitializedOnce)
                DeInitTests();

            TestInitializedOnce = true;
        }

        public void DeInitTests()
        {
        }
    }
}
