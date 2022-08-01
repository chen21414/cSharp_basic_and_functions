using System;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;

//getter, setter 限制屬性的存取

class Video
{
    public string title;
    public string author;
    //type of videos should limited to only education, entertainment, music, other
    private string type; //private makes it only useable in below constructor

    //** static type is belonging to class not constructor
    public static int video_count = 0;


    public Video(string title, string author, string type)
    {
        this.title = title;
        this.author = author;
        Type = type;
        video_count++; //documented how many videos created
    }

    //or
    public int getVideoCount()
    {
        return video_count;
    }

    public string Type //like a proxy
    {
        get { return type; } //if want to get type; will directly return
        set
        {
            if (value == "education" || value = "entertainment" || value = "music" || value == "other")
            {
                type = value;
            }
            else
            {
                type = "other";
            }
        }
    }
}

//program.cs
Video video1 = new Video("good", "white", "haha");
video1.Type = "Education"; //means setting

Console.Write(video1.Type);

//this is how you wrtie if you want to get static 
Console.Write(Video.video_count);

//or if really want to get from video1
Console.Write(video1.getVideoCount());