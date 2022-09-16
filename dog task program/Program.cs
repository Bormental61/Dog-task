// dog task from Введение в программирование семинар 1

System.Console.WriteLine("Два друга идут навстречу друг другу. Между ними бегает собака. Каждый раз, когда собака добегает до одного друга, она разворачивается и бежит к другому. Нужно вычислить сколько раз собака пробежит между друзьями, пока они не встретятся.");

Console.Write("Введите расстояние между друзьями: ");
double distance = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость первого друга: ");
double firstFriendSpeed = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость второго друга: ");
double secondFriendSpeed = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите скорость собаки: ");
double dogSpeed = Convert.ToDouble(Console.ReadLine());
double count = 0;
double friend = 2;
double time = 0;

while(distance > 3)
{
    if(friend == 1)
    {
        time = distance/(firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance/(secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed)*time;
    count++;
}

System.Console.WriteLine($"Ответ: Собака пробежит между друзьями {count} раз.");