
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Testing;


public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }
    
    [Fact]
public static void TestIsLowercaseLetter() {
    Assert.True(cipher.IsLowercaseLetter("hello","a"));
    Assert.True(cipher.IsLowercaseLetter("bye","b"));
    Assert.False(cipher.IsLowercaseLetter("Hello","z"));
    Assert.False(cipher.IsLowercaseLetter("bye","A"));
    Assert.False(cipher.IsLowercaseLetter("hello","`"));
    Assert.False(cipher.IsLowercaseLetter("Bye","{"));
}

[Fact]
public static void TestIsValidInput(){
    Assert.True(cipher.IsValidInput(true));
    Assert.False(cipher.IsValidInput(false));
}

[Fact]
public static void TestShiftLetter(){
    Assert.Equal('b', cipher.ShiftLetter('a','a'));
    Assert.Equal('d', cipher.ShiftLetter('a','c'));
    Assert.Equal('b', cipher.ShiftLetter('z','b'));
}

[Fact]
public static void TestShiftMessage(){
    Assert.Equal("ifmmp", cipher.ShiftMessage("hello", "a"));
    Assert.Equal("igmnp", cipher.ShiftMessage("hello", "ab"));
    Assert.Equal("igomq", cipher.ShiftMessage("hello", "abc"));
}
}