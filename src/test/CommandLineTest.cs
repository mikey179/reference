using Xunit;
using Xp.Runners;

namespace Xp.Runners.Test
{
    public class CommandLineTest
    {
        [Fact]
        public void default_command_is_help()
        {
            Assert.IsType<Help>(new CommandLine(new string[] { }).Command);
        }

        [Fact]
        public void supply_run_command()
        {
            Assert.IsType<Run>(new CommandLine(new string[] { "run", "Test" }).Command);
        }

        [Fact]
        public void omit_run_command_but_pass_type()
        {
            Assert.IsType<Run>(new CommandLine(new string[] { "Test" }).Command);
        }

        [Theory]
        [InlineData("-?")]
        [InlineData("help")]
        public void help(string arg)
        {
            Assert.IsType<Help>(new CommandLine(new string[] { arg }).Command);
        }

        [Theory]
        [InlineData("-v")]
        [InlineData("version")]
        public void version(string arg)
        {
            Assert.IsType<Version>(new CommandLine(new string[] { arg }).Command);
        }

        [Theory]
        [InlineData("-e")]
        [InlineData("eval")]
        public void eval(string arg)
        {
            Assert.IsType<Eval>(new CommandLine(new string[] { arg }).Command);
        }

        [Theory]
        [InlineData("-w")]
        [InlineData("write")]
        public void write(string arg)
        {
            Assert.IsType<Write>(new CommandLine(new string[] { arg }).Command);
        }

        [Theory]
        [InlineData("-d")]
        [InlineData("dump")]
        public void dump(string arg)
        {
            Assert.IsType<Dump>(new CommandLine(new string[] { arg }).Command);
        }

        [Fact]
        public void classpath_initially_empty()
        {
            Assert.Equal(new string[] { }, new CommandLine(new string[] { }).Options["classpath"].ToArray());
        }

        [Fact]
        public void one_classpath_entry()
        {
            Assert.Equal(
                new string[] { "src/main/php" },
                new CommandLine(new string[] { "-cp", "src/main/php" }).Options["classpath"].ToArray()
            );
        }

        [Fact]
        public void multiple_classpath_entries()
        {
            Assert.Equal(
                new string[] { "src/main/php", "src/test/php" },
                new CommandLine(new string[] { "-cp", "src/main/php", "-cp", "src/test/php" }).Options["classpath"].ToArray()
            );
        }

        [Fact]
        public void modules_initially_empty()
        {
            Assert.Equal(new string[] { }, new CommandLine(new string[] { }).Options["modules"].ToArray());
        }

        [Fact]
        public void one_modules_entry()
        {
            Assert.Equal(
                new string[] { "test" },
                new CommandLine(new string[] { "-m", "test" }).Options["modules"].ToArray()
            );
        }

        [Fact]
        public void multiple_modules_entries()
        {
            Assert.Equal(
                new string[] { "test", "data" },
                new CommandLine(new string[] { "-m", "test", "-m", "data" }).Options["modules"].ToArray()
            );
        }
    }
}