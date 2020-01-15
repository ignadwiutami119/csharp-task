using System;
using System.Collections.Generic;
using ChallengeApp;
using Xunit;

namespace ProgramUji {
    public class UnitTest1 {
        int[] numbers = { 1, 3, 6, 7, 9, 13, 4 };
        [Fact]
        public void BasicStaTest () {
            Assert.Equal (13, BasicStatistic.FindMax (numbers));
            Assert.Equal (1, BasicStatistic.FindMin (numbers));
            Assert.Equal (6, BasicStatistic.CalculateAverage (numbers));
        }

        [Fact]
        public void FlatArrayTest () {
            int[] theFirstArray = { 2, 52, 56, 12, 3 };
            int[] theSecondArray = { 1, 0, 65, 42 };
            int[] theThirdArray = { 3, 4, 6 };
            int[] expected = { 0, 1, 2, 3, 3, 4, 6, 12, 42, 52, 56, 65 };
            Assert.Equal (expected, FlatArray.Combine (theFirstArray, theSecondArray, theThirdArray));
        }

        [Fact]
        public void TriangleNumberTest () {
            Assert.Equal ("1\n12\n123\n", TriangleOfNumbers.Run (3));
        }

        [Fact]
        public void TriangleStarTest () {
            Assert.Equal ("*\n**\n***\n", TriangleStars.Run (3));
        }

        string expected2 = "m*i*n*u*m*s*u*s*u*s*a*p*i";
        [Fact]
        public void SeparatorTest () {
            Assert.Equal (expected2, Separator.Run ("minum susu sapi", '*'));
        }

        string expected3 = "mInUm AIr sUsU";
        [Fact]
        public void VowelToUppercaseTest () {
            Assert.Equal (expected3, VowelToUppercase.Run ("minum air susu"));
        }

        int[] firstArray = { 1, 3, -5, 4 };
        int[] secondArray = { 1, 4, -5, -2 };
        int[] expected4 = { 1, 12, 25, -8 };
        [Fact]
        public void MultipleArrayTest () {
            Assert.Equal (expected4, MultiplicationOfTwoArray.MultiplyArray (firstArray, secondArray));
        }

        [Fact]
        public void cekHowManyDup () {
            int[] numbers = { 1, 3, 5, 1, 4, 5, 2, 4, 3, 5, 3, 1 };

            string hasil = "jumlah 1 sebanyak 3\n" +
                "jumlah 3 sebanyak 3\n" +
                "jumlah 5 sebanyak 3\n" +
                "jumlah 4 sebanyak 2\n" +
                "jumlah 2 sebanyak 1\n";

            Assert.Equal (hasil, HowManyDuplicates.Run (numbers));
        }

        string expectedCal =
            "March           2020" +
            "--------------------" +
            "Su Mo Tu We Th Fr Sa" +
            " 1  2  3  4  5  6  7 \n" +
            " 8  9 10 11 12 13 14 \n" +
            "15 16 17 18 19 20 21 \n" +
            "22 23 24 25 26 27 28 \n" +
            "29 30 31 \n";
        [Fact]
        public void CalendarTest () {
            Assert.Equal (expectedCal, GenerateCalendar.Run (2020, 3));
        }
    }
}