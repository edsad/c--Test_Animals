using System;
using Xunit;

namespace Animals.Tests
{
    public class AnimalsShould
    {
        private Animals _animals;
        private Dogs _doge;
        
        public AnimalsShould()
        {
            _animals = new Animals("Rusty");
            _doge = new Dogs("Bella");
        }

        [Fact]
        public void HaveCorrectName()
        {
            Assert.Equal(_animals.Name, "Rusty");
        }
    }
}
