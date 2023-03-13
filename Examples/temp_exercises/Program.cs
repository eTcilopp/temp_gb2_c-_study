// // Задача с собакой

float person1Position = 0;
float person2Position = 100;
float dogPosition = 0;


MovingObject p1 = new MovingObject("Pers 1", person1Position, 5, 1);
MovingObject p2 = new MovingObject("Pers 2", person2Position, 7, -1);
MovingObject dog = new MovingObject("Dog", dogPosition, 10, 1);

float t = 0;
int dogChangeDirectionCount = 0;

while (person1Position < person2Position)
{
    person1Position = p1.GetPosition(t);
    person2Position = p2.GetPosition(t);
    dogPosition = dog.GetPosition(t);
    if ((dog.GetDirection() == 1 && dogPosition >= person2Position ) | (dog.GetDirection() == -1 && dogPosition <= person1Position))
        {
            dog.ChangeDirection();
            dogChangeDirectionCount++;
        }
    Console.WriteLine($"{person1Position}-{dogPosition}-{person2Position}");
    t += 1;
}

Console.WriteLine($"Dog changed direction {dogChangeDirectionCount} times.");

class MovingObject
{
    string objectName;
    float previousPosition;
    float previousTime;
    int speed;
    int direction;

    public MovingObject(string name, float previousPosition, int speed, int direction)
    {
        this.objectName = name;
        this.previousPosition = previousPosition;
        this.speed = speed;
        this.direction = direction;
        this.previousTime = 0;
    }
    public int GetDirection()
        {
            return this.direction;
        }

    public float GetPosition(float currentTime)
    {
        float currentPosition = this.previousPosition + (currentTime-this.previousTime) * this.speed * this.direction;
        this.previousPosition = currentPosition;
        this.previousTime = currentTime;
        return currentPosition;
    }

    public void ChangeDirection()
        {
            this.direction = -this.direction;
        }

}
