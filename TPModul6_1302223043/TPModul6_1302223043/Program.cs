using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        int PlayCount;
        PlayCount = playCount;
        try
        {
            PlayCount = checked(playCount + count);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Playcount Value Overflow");
        }
        playCount = PlayCount;


    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID: " + id);
        Console.WriteLine($"Title: " + title);
        Console.WriteLine($"Play Count: " + playCount);
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design - Farid Hanafi");
        video.IncreasePlayCount(int.MaxValue);
        video.IncreasePlayCount(1);
        video.PrintVideoDetails();
    }
}
