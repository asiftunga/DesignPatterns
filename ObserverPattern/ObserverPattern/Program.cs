namespace ObserverPattern;

class Program
{
    static void Main(string[] args)
    {
        List<string> managerDishList = ["Lahmacun", "Beef Doner", "Iskender", "Ribeye"];
        List<string> teacherDishList = ["Chicken Saute", "Chicken Pilaf", "Spinach Pastry", "Baked Chicken", "Lahmacun", "Beef Doner", "Iskender", "Ribeye"];

        Teacher teacher = new(teacherDishList);
        Student student = new();
        Manager manager = new(managerDishList);
        SmartKitchen smartKitchen = new();

        smartKitchen.DishEventHandler += teacher.DishUpdate;
        smartKitchen.DishEventHandler += student.DishUpdate;
        smartKitchen.DishEventHandler += manager.DishUpdate;

        smartKitchen.DishEventHandler += delegate (object? sender, DishEventArgs e) //anonymous example
        {
            Console.WriteLine($"New dish for the staff 😋: '{e.Dish}'.");
        };

        smartKitchen.DishEventHandler += async (object? sender, DishEventArgs e) => //void async (.net not recommended void async, but we have to for this case)
        {
            try
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(5000);
                });
                Console.WriteLine("Task completed for staff");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        };

        for (int day = 1; day <= 7; day++)
        {
            string dailyDish = SelectFood();

            smartKitchen.CookAndNotify(dailyDish);

            Console.WriteLine($"----- {GetDay(day)} day ended -----");
            Thread.Sleep(2000);
        }
    }

    static string SelectFood()
    {
        List<string> dishes = ["Stuffed Vine Leaves", "Chicken Saute", "Chicken Pilaf", "Spinach Pastry", "Kebab", "Chicken Doner", "Hamburger", "Pizza", "Lahmacun", "Beef Doner", "Iskender", "Ribeye", "Baked Chicken"];
        return dishes[new Random().Next(dishes.Count)];
    }

    static string GetDay(int day)
    {
        return day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => ""
        };
    }
}
