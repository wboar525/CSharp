int count = 0;
double distance = 1000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
double time = 0;

while(distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2; 
        Console.WriteLine(time);
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
        Console.WriteLine(time);
    }
    distance -= (firstFriendSpeed + secondFriendSpeed)*time;
    count++;
}
Console.Write("Собака пробежит ");
Console.WriteLine(count + " раз");