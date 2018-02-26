public class MoodFactory
{
    private static int AngryUpperBorder = -5;
    private static int SadUpperBorder = 0;
    private static int HappyUpperBorder = 15;

    public static Mood CreateMood(int points)
    {
        if (points < AngryUpperBorder)
        {
            return new Angry();
        }
        else if(points <= SadUpperBorder)
        {
            return new Sad();
        }
        else if (points <= HappyUpperBorder)
        {
            return new Happy();
        }
        else
        {
            return new JavaScript();
        }
    }
}
