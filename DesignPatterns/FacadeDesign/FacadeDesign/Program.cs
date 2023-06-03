using Microsoft.Extensions.DependencyInjection;

// Register dependencies with DI container
var services = new ServiceCollection();
services.AddSingleton<UserService>();
services.AddSingleton<OrderService>();
services.AddSingleton<ApiFacade>();

// Create an instance of the facade class
var serviceProvider = services.BuildServiceProvider();
var apiFacade = serviceProvider.GetRequiredService<ApiFacade>();

// Use the facade to perform operations
string result = apiFacade.GetUserAndOrder(123);
Console.WriteLine(result);

public class UserService
{
    public string GetUserById(int id)
    {
        // Logic to retrieve user by ID
        return $"User {id}";
    }
}

public class OrderService
{
    public string GetOrderByUserId(int userId)
    {
        // Logic to retrieve order by user ID
        return $"Order for user {userId}";
    }
}

// Facade class

public class ApiFacade
{
    private readonly UserService userService;
    private readonly OrderService orderService;

    public ApiFacade(UserService userService, OrderService orderService)
    {
        this.userService = userService;
        this.orderService = orderService;
    }

    public string GetUserAndOrder(int userId)
    {
        string user = userService.GetUserById(userId);
        string order = orderService.GetOrderByUserId(userId);
        return $"{user}, {order}";
    }
}