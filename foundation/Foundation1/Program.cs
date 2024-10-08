using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "Lessons from Steve Jobs";
        video1._author = "Steve Jobs";
        video1._length = 180;
        video1._comments = 3;

        Video video2 = new Video();
        video2._title = "Lessons from Bill Gates";
        video2._author = "Bill Gates";
        video2._length = 120;
        video2._comments = 2;

        Video video3 = new Video();
        video3._title = "Lessons from Elon Musk";
        video3._author = "Elon Musk";
        video3._length = 240;
        video3._comments = 4;

        Comment myComment = new Comment();
        myComment._name = "Becky Smith";
        myComment._text = "Great video!";
        
        myComment.Display();

    }
}