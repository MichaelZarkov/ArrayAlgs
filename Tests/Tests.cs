namespace Tests
{
    [TestClass]
    public class ClassManipTests
    {
        [TestMethod]
        public void ReverseTest()
        {
            // Arrange.
            int[] input = { 1, 2, 3 };
            int[] expected = { 3, 2, 1 };

            // Act.
            ArrAlgs.Manip.Reverse(input);

            // Assert.
            bool areEqual = Enumerable.SequenceEqual(input, expected);    // Compare.
            Assert.IsTrue(areEqual);
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            // Arrange.
            int[] input = { -7, 29, 33, 8 };
            int[] expected = { -7, 8, 29, 33 };

            // Act.
            ArrAlgs.Manip.InsertionSort(input);

            // Assert.
            Assert.IsTrue(Enumerable.SequenceEqual(input, expected));
        }

        [TestMethod]
        public void SelectionSort1SortTest()
        {
            // Arrange.
            int[] input = { 0, 0, 0, -7, -7 };
            int[] expected = { -7, -7, 0, 0, 0 };

            // Act.
            ArrAlgs.Manip.SelectionSort1(input);

            // Assert.
            Assert.IsTrue(Enumerable.SequenceEqual(input, expected));
        }

        [TestMethod]
        public void SelectionSort2SortTest()
        {
            // Arrange.
            int[] input = { 0, 0, 0, -7, -7 };
            int[] expected = { -7, -7, 0, 0, 0 };

            // Act.
            ArrAlgs.Manip.SelectionSort2(input);

            // Assert.
            Assert.IsTrue(Enumerable.SequenceEqual(input, expected));
        }

        [TestMethod]
        public void HeapsortTest()
        {
            int[] input1 = new int[0];
            int[] input2 = { 1, 2, 3, 4, 5 };
            int[] input3 = { -2, -2, 9, 9, -2 };

            int[] output2 = { 1, 2, 3, 4, 5 };
            int[] output3 = { -2, -2, -2, 9, 9 };

            ArrAlgs.Manip.Heapsort(input1);    // This will throw exception if something is not right.
            ArrAlgs.Manip.Heapsort(input2);
            ArrAlgs.Manip.Heapsort(input3);

            Assert.IsTrue(Enumerable.SequenceEqual(input2, output2));
            Assert.IsTrue(Enumerable.SequenceEqual(input3, output3));
        }

        [TestMethod]
        public void MergesortTest()
        {
            int[] input1 = new int[0];
            int[] input2 = { 1, 2, 3, 4, 5 };
            int[] input3 = { -2, -2, 9, 9, -2 };

            int[] output2 = { 1, 2, 3, 4, 5 };
            int[] output3 = { -2, -2, -2, 9, 9 };

            ArrAlgs.Manip.Mergesort(input1);    // This will throw exception if something is not right.
            ArrAlgs.Manip.Mergesort(input2);
            ArrAlgs.Manip.Mergesort(input3);

            Assert.IsTrue(Enumerable.SequenceEqual(input2, output2));
            Assert.IsTrue(Enumerable.SequenceEqual(input3, output3));
        }

        [TestMethod]
        public void QuicksortTest()
        {
            int[] input1 = new int[0];
            int[] input2 = { 1, 2, 3, 4, 5 };
            int[] input3 = { -2, -2, 9, 9, -2 };

            int[] output2 = { 1, 2, 3, 4, 5 };
            int[] output3 = { -2, -2, -2, 9, 9 };

            ArrAlgs.Manip.Quicksort(input1);    // This will throw exception if something is not right.
            ArrAlgs.Manip.Quicksort(input2);
            ArrAlgs.Manip.Quicksort(input3);

            Assert.IsTrue(Enumerable.SequenceEqual(input2, output2));
            Assert.IsTrue(Enumerable.SequenceEqual(input3, output3));
        }

        [TestMethod]
        public void CompareSortingAlgs()
        {
            // Make a bunch of arrays and test if the sorting algos agree
            // on the result.
            var rand = new Random();
            const int upTo = 100;      // Test with arrays with length up to this number.
            for (int i = 0; i < upTo; i++)
            {
                int[] insertionsort = new int[i];
                int[] selectionsort = new int[i];
                int[] heapsort = new int[i];
                int[] mergesort = new int[i];
                int[] quicksort = new int[i];

                // Fill with random numbers.
                for (int j = 0; j < insertionsort.Length; j++)
                {
                    insertionsort[j] = rand.Next();
                    selectionsort[j] = insertionsort[j];
                    heapsort[j] = insertionsort[j];
                    mergesort[j] = insertionsort[j];
                    quicksort[j] = insertionsort[j];
                }

                // Act.
                ArrAlgs.Manip.InsertionSort(insertionsort);
                ArrAlgs.Manip.SelectionSort1(selectionsort);
                ArrAlgs.Manip.Heapsort(heapsort);
                ArrAlgs.Manip.Mergesort(mergesort);
                ArrAlgs.Manip.Quicksort(quicksort);

                // Test if sorting algos agree with each other.
                Assert.IsTrue(Enumerable.SequenceEqual(insertionsort, selectionsort));
                Assert.IsTrue(Enumerable.SequenceEqual(selectionsort, heapsort));
                Assert.IsTrue(Enumerable.SequenceEqual(heapsort, mergesort));
                Assert.IsTrue(Enumerable.SequenceEqual(mergesort, quicksort));
            }
        }
    }

    [TestClass]
    public class ClassSrchTests
    {
        [TestMethod]
        public void BinarySearchTest()
        {
            int[] input1 = { 2, 3, 5, 7, 11, 13, 17 };
            int inpNum1 = 13;
            int output1 = 5;

            int[] input2 = { 2, 3, 5, 7, 11, 13, 17 };
            int inpNum2 = 100;
            int output2 = -1;

            int[] input3 = { 0, 1 };
            int inpNum3 = 1;
            int output3 = 1;

            int[] input4 = { 0, 1 };
            int inpNum4 = 0;
            int output4 = 0;

            // 'BinarySearchIter()'
            Assert.IsTrue(output1 == ArrAlgs.Srch.BinarySrchIter(input1, inpNum1));
            Assert.IsTrue(output2 == ArrAlgs.Srch.BinarySrchIter(input2, inpNum2));
            Assert.IsTrue(output3 == ArrAlgs.Srch.BinarySrchIter(input3, inpNum3));
            Assert.IsTrue(output4 == ArrAlgs.Srch.BinarySrchIter(input4, inpNum4));

            // 'BinarySearchRec()'
            Assert.IsTrue(output1 == ArrAlgs.Srch.BinarySrchIter(input1, inpNum1));
            Assert.IsTrue(output2 == ArrAlgs.Srch.BinarySrchIter(input2, inpNum2));
            Assert.IsTrue(output3 == ArrAlgs.Srch.BinarySrchIter(input3, inpNum3));
            Assert.IsTrue(output4 == ArrAlgs.Srch.BinarySrchIter(input4, inpNum4));
        }
    }
}