using System;
using Xunit;

namespace Animals.Tests
{
    public class AnimalShould
    {
        private Animal _animal;
        private Dog _doge;
        
        public AnimalShould()
        {
            _animal = new Animal();
            _doge = new Dog();
        }

        [Fact]
        public void HaveCorrectName()
        {
            string HaveCorrectName = _animal.Rename("Sammy");
            Assert.Equal(HaveCorrectName, "Sammy");
        }

        [Fact]
        public void HaveAnotherCorrectName()
        {
            string HaveAnotherCorrectName = _animal.AnotherRename("Snoopy");
            Assert.Equal(HaveAnotherCorrectName, "Snoopy");
        }

        [Fact]
        public void WhatSpecies()
        {
            string WhatSpecies = _animal.AnotherSpecies("Feline");
            Assert.Equal(WhatSpecies, "Feline");
        }

        [Fact]
        public void WhateverSpecies()
        {
            string WhateverSpecies = _animal.OneMoreSpecies("Canine");
            Assert.Equal(WhateverSpecies, "Canine");
        }

        [Fact]
        public void HowFast()
        {
            double HowFast = _animal.ThisFast(5);
            Assert.Equal(HowFast, 5);
        }

        [Fact]
        public void ThatFast()
        {
            double ThatFast = _animal.Wow(10);
            Assert.Equal(ThatFast, 10);
        }

        [Fact]
        public void HaveOneMoreCorrectName()
        {
            string HaveOneMoreCorrectName = _doge.RenameAgain("Prickly Pete");
            Assert.Equal(HaveOneMoreCorrectName, "Prickly Pete");
        }

        [Fact]
        public void HaveCorrectName2()
        {
            string HaveCorrectName2 = _doge.RenameDog("Hambone");
            Assert.Equal(HaveCorrectName2, "Hambone");
        }

        [Fact]
        public void WhatSpecies2()
        {
            string WhatSpecies2 = _doge.Species2("Yorkie");
            Assert.Equal(WhatSpecies2, "Yorkie");
        }

        [Fact]
        public void WhatSpecies3()
        {
            string WhatSpecies3 = _doge.Species3("Doberman");
            Assert.Equal(WhatSpecies3, "Doberman");
        }

        [Fact]
        public void HowFast2()
        {
            double HowFast2 = _doge.ThisFast2(6);
            Assert.Equal(HowFast2, 6);
        }

        [Fact]
        public void HowFast3()
        {
            double HowFast3 = _doge.ThisFast3(7);
            Assert.Equal(HowFast3, 7);
        }
    }
}
