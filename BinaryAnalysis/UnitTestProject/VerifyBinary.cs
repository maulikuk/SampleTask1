using BinaryAnalysis;

namespace UnitTestProject
{
    public class TestVerifyBinary
    {
        private VerifyBinary _verifyBinary;

        [SetUp]
        public void Setup()
        {
            _verifyBinary = new VerifyBinary();
        }

        [Test]
        public void Test1()
        {
            Assert.False(_verifyBinary.ValidateBinary("1"));
            Assert.False(_verifyBinary.ValidateBinary("0"));
            Assert.False(_verifyBinary.ValidateBinary(""));
            Assert.False(_verifyBinary.ValidateBinary("101"));
            Assert.False(_verifyBinary.ValidateBinary("010"));
            Assert.False(_verifyBinary.ValidateBinary("0001"));
            Assert.False(_verifyBinary.ValidateBinary("0111"));

            Assert.True(_verifyBinary.ValidateBinary("10"));
            Assert.True(_verifyBinary.ValidateBinary("1010"));
            Assert.True(_verifyBinary.ValidateBinary("101010"));
            Assert.True(_verifyBinary.ValidateBinary("111000"));
            Assert.True(_verifyBinary.ValidateBinary("11001100"));
            Assert.True(_verifyBinary.ValidateBinary("110100"));
        }
    }
}