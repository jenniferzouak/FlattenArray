using System;
using Xunit;

namespace FlattenArray.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Flattener f = new Flattener();
            object[] testArray = new object[]
            {};
            var rc = 
            f.Flatten(testArray);
            Assert.True(rc.Length == 0, "Length is incorrect, should be 0");
        }

        [Fact]
        public void Test2()
        {
            Flattener f = new Flattener();
            object[] testArray = new object[]
            { 1, 2, 3, 4 };
            var rc =
            f.Flatten(testArray);
            Assert.True(rc.Length == 4, "Length is incorrect, should be 4");
        }

        [Fact]
        public void Test3()
        {
            Flattener f = new Flattener();
            object[] testArray = new object[]
            { 1, new object[] { } , 3, 4 };
            var rc =
            f.Flatten(testArray);
            Assert.True(rc.Length == 3, "Length is incorrect, should be 3");
        }

        [Fact]
        public void Test4()
        {
            Flattener f = new Flattener();
            object[] testArray = new object[]
            { 1, new object[] { 2,3, new object[] { 6,7,8} } , 4, 5 };
            var rc =
            f.Flatten(testArray);
            Assert.True(rc.Length == 8, "Length is incorrect, should be 8");
        }
    }
}
