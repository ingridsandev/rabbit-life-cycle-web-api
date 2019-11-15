using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using RabbitsLifeCycle.Web.Api.Services;

namespace RabbitsLifeCycle.Web.Api.Tests
{
    public class RabbitServiceTests
    {
        private readonly IRabbitService _rabbitService;

        public RabbitServiceTests()
        {
            _rabbitService = new RabbitService();
        }

        [Theory(DisplayName = "At any month before 0 there are no Rabbits in existence")]
        [InlineData(-1, 0)]
        public async Task AtAnyMonthBeforeZeroThereAreNoRabbitsInExistenceAsync(int month, int rabbitsPair)
        {
            // Act
            var response = await _rabbitService.CountAsync(month);

            // Assert
            response.Value.Should().Be(rabbitsPair);
        }

        [Theory(DisplayName = "At month 0 there magically is 1 pair of Rabbits")]
        [InlineData(0, 1)]
        public async Task AtMonthZeroThereMagicallyIsOnePairOfRabbits(int month, int rabbitsPair)
        {
            // Act
            var response = await _rabbitService.CountAsync(month);

            // Assert
            response.Value.Should().Be(rabbitsPair);
        }

        [Theory(DisplayName = "Given 1 or 2 months we should have only one pair of Rabbits")] // Rabbits magically born in month 0, thus in the months given by the user (1 or 2) they are not mature to procreate
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        public async Task GivenOneOrTwoMonthsTheMethodShouldReturnOnlyOnePairOfRabbits(int month, int rabbitsPair)
        {
            // Act
            var response = await _rabbitService.CountAsync(month);

            // Assert
            response.Value.Should().Be(rabbitsPair);
        }

        [Theory(DisplayName = "Given 3 months we should have 2 pairs of Rabbits")]
        [InlineData(3, 2)]
        public async Task GivenThreeMonthsWeShouldHaveTwoPairsOfRabbits(int month, int rabbitsPair)
        {
            // Act
            var response = await _rabbitService.CountAsync(month);

            // Assert
            response.Value.Should().Be(rabbitsPair);
        }

        [Theory(DisplayName = "Given 6 months we should have 6 pairs of Rabbits")]
        [InlineData(6, 6)]
        public async Task GivenSixMonthsWeShouldHaveSixPairsOfRabbits(int month, int rabbitsPair)
        {
            // Act
            var response = await _rabbitService.CountAsync(month);

            // Assert
            response.Value.Should().Be(rabbitsPair);
        }

        [Theory(DisplayName = "Given 7 months we should have 13 pairs of Rabbits")]
        [InlineData(7, 9)]
        public async Task GivenSevenMonthsWeShouldHaveThirteenPairsOfRabbits(int month, int rabbitsPair)
        {
            // Act
            var response = await _rabbitService.CountAsync(month);

            // Assert
            response.Value.Should().Be(rabbitsPair);
        }

        [Theory(DisplayName = "Given 8 months we should have 13 pairs of Rabbits")]
        [InlineData(8, 13)]
        public async Task GivenEightMonthsWeShouldHaveThirteenPairsOfRabbits(int month, int rabbitsPair)
        {
            // Act
            var response = await _rabbitService.CountAsync(month);

            // Assert
            response.Value.Should().Be(rabbitsPair);
        }

        [Theory(DisplayName = "Given 9 months we should have 13 pairs of Rabbits")]
        [InlineData(9, 19)]
        public async Task GivenNineMonthsWeShouldHaveThirteenPairsOfRabbits(int month, int rabbitsPair)
        {
            // Act
            var response = await _rabbitService.CountAsync(month);

            // Assert
            response.Value.Should().Be(rabbitsPair);
        }

        [Theory(DisplayName = "Given 10 months we should have 13 pairs of Rabbits")]
        [InlineData(10, 28)]
        public async Task GivenTenMonthsWeShouldHaveThirteenPairsOfRabbits(int month, int rabbitsPair)
        {
            // Act
            var response = await _rabbitService.CountAsync(month);

            // Assert
            response.Value.Should().Be(rabbitsPair);
        }

        [Theory(DisplayName = "Given 24 months we should have enough to give Santa Ernestina population (county in the state of São Paulo in Brazil) one Rabbit each hehehe Joking it should be 5896 ;) ")]
        [InlineData(24, 5896)]
        public async Task GivenTwentyFourMonthsWeShouldHaveThirteenPairsOfRabbits(int month, int rabbitsPair)
        {
            // Act
            var response = await _rabbitService.CountAsync(month);

            // Assert
            response.Value.Should().Be(rabbitsPair);
        }
    }
}
