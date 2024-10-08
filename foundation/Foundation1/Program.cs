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

        Video video2 = new Video();
        video2._title = "Lessons from Bill Gates";
        video2._author = "Bill Gates";
        video2._length = 120;

        Video video3 = new Video();
        video3._title = "Lessons from Elon Musk";
        video3._author = "Elon Musk";
        video3._length = 240;

        video1.AddComment(new Comment { _name = "Becky Smith", _text = "Great video!" });
        
        // Adding comments to video2
        video2.AddComment(new Comment { _name = "John Doe", _text = "I love this video!" });
        
        // Adding comments to video3
        video3.AddComment(new Comment { _name = "Jane Here", _text = "I learned a lot!" });

        // Display videos and comments
        video1.Display();
        video2.Display();
        video3.Display();

    }
}