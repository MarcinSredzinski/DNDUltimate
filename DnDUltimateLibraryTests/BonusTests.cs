using DnDUltimateLibrary.bonus;
using DnDUltimateLibrary.factories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DnDUltimateLibraryTests
{
    public class BonusTests
    {
        SourceFactory sourceFactory = new SourceFactory();

        [Fact]
        void AddingBonusesStackVariousTest() {
            Bonus bonus1 = new Bonus(12, sourceFactory.Create("name", true));
            Bonus bonus2 = new Bonus(4, sourceFactory.Create("otherName", false));
            BonusCollection bonusCollection = new BonusCollection();
            bonusCollection.Add(bonus1);
            bonusCollection.Add(bonus2);
            Assert.Equal(bonus1.NumericValue + bonus2.NumericValue, bonusCollection.Sum());
        }

        [Fact]
        void AddingBonusesStackSameTest()
        {
            Source source = sourceFactory.Create("name", true);
            Bonus bonus1 = new Bonus(12, source);
            Bonus bonus2 = new Bonus(4, source);
            BonusCollection bonusCollection = new BonusCollection();
            bonusCollection.Add(bonus1);
            bonusCollection.Add(bonus2);
            Assert.Equal(bonus1.NumericValue + bonus2.NumericValue, bonusCollection.Sum());
        }

        [Fact]
        void AddingBonusesNotStackTest()
        {
            Source source = sourceFactory.Create("otherName", false);
            Bonus bonus1 = new Bonus(12, source);
            Bonus bonus2 = new Bonus(4, source);
            BonusCollection bonusCollection = new BonusCollection();
            bonusCollection.Add(bonus1);
            bonusCollection.Add(bonus2);
            Assert.Equal(Math.Max(bonus1.NumericValue, bonus2.NumericValue), bonusCollection.Sum());
        }
        //todo Dodaj test jeżeli source of bonus ma tą samą nazwę to nie powinien
        //się kumulować z samym sobą
    }
}
