using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Google.Places.API.Tests
{
    [TestClass]
    public class TestBase
    {
        #region Private Fields
        private ApiRequest api;

        private const string apiKey = "[YOUR-API-KEY]";
        #endregion

        #region Public Properties
        public ApiRequest API
        {
            get
            {
                return this.api;
            }
        }
        #endregion

        #region Public Methods
        [TestInitialize]
        public void Init()
        {
            this.api = new ApiRequest(apiKey);
        }
        #endregion
    }
}
