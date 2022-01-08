using Flyweight;
double x = 0, y = 0;
int i = 0, j = 0;
FlyweightFactory factory = new FlyweightFactory();
while (i < 2)
{
    Anthurium red = factory.GetParticle("Red");
    if (red != null)
        red.Create(x, y);
    x += 1;
    Anthurium white = factory.GetParticle("White");
    if (white != null)
        white.Create(x, y);
    y += 1;
    i++;
}