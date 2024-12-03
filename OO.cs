public class Fan
{
    public const int SLOW = 1;
    public const int MEDIUM = 2;
    public const int FAST = 3;

    private int speed;
    private bool on;
    private double radius;
    private string color;

    public Fan()
    {
        speed = SLOW;
        on = false;
        radius = 5;
        color = "blue";
    }

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public bool On
    {
        get { return on; }
        set { on = value; }
    }

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public override string ToString()
    {
        if (on)
        {
            return $"Fan speed: {speed}, color: {color}, radius: {radius} - fan is on";
        }
        else
        {
            return $"Fan color: {color}, radius: {radius} - fan is off";
        }
    }
}
