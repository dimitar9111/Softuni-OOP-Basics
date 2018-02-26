using System;
using System.Text;

public class Wizard
{
    private int happinessPoints;

    public Wizard()
    {
        happinessPoints = 0;
    }

    public void Eat(Food food)
    {
        var points = food.HappinessPoints;
        this.happinessPoints += points;
    }

    private Mood GetMood()
    {
        var mood = MoodFactory.CreateMood(this.happinessPoints);
        return mood;
    }

    public override string ToString()
    {
        var currentMood = GetMood();
        var sb = new StringBuilder();
        sb.AppendLine($"{this.happinessPoints}");
        sb.AppendLine($"{currentMood.Name}");

        return sb.ToString().Trim(); ;
    }
}
