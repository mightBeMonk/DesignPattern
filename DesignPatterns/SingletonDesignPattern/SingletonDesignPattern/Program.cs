using SingletonDesignPattern;

var a = Singleton.Instance;
var b = Singleton.Instance;

var value = a.GetUserDetails();

// Like this you can validate that the both references are equal.
bool answer = System.Object.ReferenceEquals(a, b);

Console.WriteLine(value);
Console.WriteLine(answer);
Console.ReadLine();

