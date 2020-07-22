using RiskFirst.Test.Api.Controllers;
using Xunit;

namespace RiskFirst.Test.Api.UnitTests.Controllers
{
    public class AddressBookControllerTests
    {
        private readonly AddressBookController _addressBookController;

        public AddressBookControllerTests()
        {
            _addressBookController = new AddressBookController();
        }

        [Fact(DisplayName = "Can Get Addresses Grouped By City")]
        public void CanGetAddressesGroupedByCity()
            => Assert.False(true);
    }
}
