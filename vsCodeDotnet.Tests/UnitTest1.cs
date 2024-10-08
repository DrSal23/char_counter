using NUnit.Framework;
using vsCodeDotnet; // Adjust based on your actual namespace

namespace vsCodeDotnet.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void Test_FindMostCommonCharacter_HelloWorld_ReturnsL()
        {
            var result = Program.FindMostCommonCharacter("Hello World");
            Assert.AreEqual(('L', 3), result);
        }

        [Test]
        public void Test_FindMostCommonCharacter_CSharpTesting_ReturnsS()
        {
            var result = Program.FindMostCommonCharacter("CSharp Testing");
            Assert.AreEqual(('S', 2), result);
        }
        
        // Add additional test cases as needed
        [Test]
        public void Test_FindMostCommonCharacter_EmptyString_ReturnsSpace()
        {
            var result = Program.FindMostCommonCharacter("");
            Assert.AreEqual((' ', 0), result); // Expecting no character in an empty string
        }

        [Test]
        public void Test_FindMostCommonCharacter_SpacesOnly_ReturnsSpace()
        {
            var result = Program.FindMostCommonCharacter("     "); // Only spaces
            Assert.AreEqual((' ', 5), result); // Expecting space with count 5
        }
    }
}
