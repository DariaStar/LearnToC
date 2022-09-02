int distance = 10000;
int speedFirstMan = 6;
int speedSecMan = 5;
int speedDog = 13;
int friend = 1;
int count =0;
int T = 0;

while(distance > 10)
{
if (friend == 1) 
{ 
    T = distance / (speedFirstMan + speedDog);
     friend = 2;
    }
    
else 
{
    T = distance / (speedSecMan + speedDog);
    friend = 1;
}
distance = distance - (speedFirstMan + speedSecMan) * T;
count++;
}
Console.WriteLine(count);