using System;
using Xunit;
using ChallengeApp;

namespace ProgramUji
{
    public class UnitTest1
    {
        int[] numbers = { 1, 3, 6, 7, 9, 13, 4 };
        [Fact]
        public void BasicStaTest()
        {
            Assert.Equal(13, BasicStatistic.FindMax(numbers));
            Assert.Equal(1, BasicStatistic.FindMin(numbers));
            Assert.Equal(6, BasicStatistic.CalculateAverage(numbers));
        }


        // int[] theFirstArray = { 2, 52, 56, 12, 3 };
        // int[] theSecondArray = { 1, 0, 65, 42 };
        // int[] theThirdArray = { 3, 4, 6 };
        // int[] expected = {0, 1, 2, 3, 3, 4, 6, 12, 42, 52, 56, 65};
        // [Fact]
        // public void FlatArrayTest()
        // {
        //     Assert.Equal(expected, FlatArray.Combine(theFirstArray,theSecondArray,theThirdArray));
        // }

        [Fact]
        public void TriangleNumberTest()
        {
            Assert.Equal("1\n12\n123\n", TriangleOfNumbers.Run(3));
        }

        [Fact]
        public void TriangleStarTest()
        {
            Assert.Equal("*\n**\n***\n", TriangleStars.Run(3));
        }

        string expected2 = "m*i*n*u*m*s*u*s*u*s*a*p*i";
        [Fact]
        public void SeparatorTest()
        {
            Assert.Equal(expected2, Separator.Run("minum susu sapi",'*'));
        }

        string expected3 = "mInUm AIr sUsU";
        [Fact]
        public void VowelToUppercaseTest()
        {
            Assert.Equal(expected3, VowelToUppercase.Run("minum air susu"));
        }

        int[] firstArray = {1, 3, -5, 4};
        int[] secondArray = {1, 4, -5, -2};
        int[] expected4 = {1, 12, 25, -8};
         [Fact]
        public void MultipleArrayTest()
        {
            Assert.Equal(expected4, MultiplicationOfTwoArray.MultiplyArray(firstArray,secondArray));
        }
    }
}
