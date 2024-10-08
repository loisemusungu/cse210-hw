using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "Lessons from Steve Jobs";
        video1._author = "Steve Jobs";
        video1._length = 180;
        //video1._comments = 2;

        Video video2 = new Video();
        video2._title = "Lessons from Bill Gates";
        video2._author = "Bill Gates";
        video2._length = 120;
        //video2._comments = 3;

        Video video3 = new Video();
        video3._title = "Lessons from Elon Musk";
        video3._author = "Elon Musk";
        video3._length = 240;
       // video3._comments = 4;

        video1.Display();
        Comment myComment = new Comment();
        myComment._name = "Becky Smith";
        myComment._text = "Great video!";
        // myComment._comments.Add(myComment);
        myComment.Display();

        video2.Display();
        Comment myComment2 = new Comment();
        myComment2._name = "John Doe";
        myComment2._text = "I love this video!";
        // myComment2._comments.Add(myComment);
        myComment2.Display();
        
        video3.Display();
        Comment myComment3 = new Comment();
        myComment3._name = "Jane Here";
        myComment3._text = "I learned a lot!";
        // myComment3._comments.Add(myComment);
        myComment3.Display();

    }
}