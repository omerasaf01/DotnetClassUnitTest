using TextService;

namespace TextService.Tests;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange -> Tanımlamalar

        int a = 1;
        int b = 2;

        var names = new List<String>() {"Ali", "Mehmet", "Sadık"};

        //Act -> İşlem

        int response = Calculator.Topla(a, b);

        //Assert -> Doğrulama

        Assert.NotEqual(2, response); // Dönen sonuç 2 değil ise Başarılı
        Assert.Equal(3, response); // Dönen Sonuç 3 ise Başarılı

        Assert.Contains("Ömer", "Ömer Asaf Karasu"); // "Ömer Asaf Karasu" içinde "Ömer" var ise başarılı
        Assert.DoesNotContain("Mehmet", "Ömer Asaf Karasu"); // "Ömer Asaf Karasu" içinde mehmet yok ise başarılı

        Assert.Contains("Ali", names); // names listesinde Ali var ise başarılı

        Assert.True(a == 1); //a == 1 sonucu True ise başarılı
        Assert.False(b == 1); // b == 1 sonucu False ise başarılı


    }

    [Fact]
    public void Test2()
    {
        //Arange

        var regEx = "^dog";

        //Act

        //Assert

        Assert.Matches(regEx, "dog ali"); // regex ( regular expression ) kuralına uyuyor ise başarılı.
        Assert.DoesNotMatch(regEx, "ali"); // regex kuralına uymuyor ise başarılı

        //Regex Hakkında Kaynak https://ceaksan.com/tr/regex-regular-expressions-nedir

        Assert.EndsWith(".json", "test.json"); // ".json" ile bitiyor ise başarılı
        Assert.StartsWith("test", "test.json"); // "test" ile başlıyorsa başarılı

        Assert.Empty(""); Assert.Empty(new List<String>() {}); //Boş ise başarılı
        Assert.NotEmpty("a"); Assert.NotEmpty(new List<String>() {"Ali"}); //Boş değil ise başarılı
    }

    [Fact]
    public void Test3()
    {
        //Arrange

        int number = 10;

        //Assert

        Assert.InRange(number, 2, 19); // "number" 2 ve 19 arasında ise başarılı
        Assert.NotInRange(number, 11, 20 ); // "number" 11 ve 20 arasında değil ise başarılı
    }

    [Fact]
    public void Test4()
    {
        //Arrange

        var liste = new List<String>() {"Erdem"};

        //Assert

        Assert.Single(liste); //Eğer listede sadece bir eleman var ise başarılı
    }

    [Fact]
    public void Test5()
    {
        //Arrange
        string dataOne = "Selam";
        int dataTwo = 12;

        //Assert
        Assert.IsType<String>(dataOne); // Girilen değer belirtilen veri türünde ise başarılı. 
        Assert.IsNotType<int>(dataTwo); // Girilen değer belirtilen veri türünde değil ise başarılı.
    }
}