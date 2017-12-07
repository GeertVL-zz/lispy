using System;
using Xunit;

namespace lispy.tests
{
    public class UnitTest1
    {
        [Fact]
        public void CorrectTokens()
        {
            var program = "(begin (define r 10) (* pi (* r r)))";
            var actual = new Tokenizer().Tokenize(program);
            var expected = new[] {"(", "begin", "(", "define", "r", "10", ")", "(", "*", "pi", "(", "*", "r", "r", ")", ")", ")"};
            Assert.Equal(expected, actual);
        }
    }
}