using Xunit;

namespace Pathing.Tests.CSharp {
  public class PathingTests {
    [Fact]
    public void Test1() {
      Assert.True(true);
      Pathing.ToAbsoluteDirectoryPath("k");
    }
  }
}
