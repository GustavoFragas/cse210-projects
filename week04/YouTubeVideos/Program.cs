using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to program in C#", "João Silva", 600);
        video1.AddComment(new Comment("Maria Santos", "Great tutorial! Very clear."));
        video1.AddComment(new Comment("Pedro Costa", "Helped a lot, thanks!"));
        video1.AddComment(new Comment("Ana Oliveira", "Could you make more videos about OOP?"));
        videos.Add(video1);

        Video video2 = new Video("Introduction to Git and GitHub", "Carlos Mendes", 780);
        video2.AddComment(new Comment("Luís Ferreira", "Finally understood Git!"));
        video2.AddComment(new Comment("Rita Alves", "Perfect explanation!"));
        video2.AddComment(new Comment("Bruno Rocha", "Very good, congratulations!"));
        video2.AddComment(new Comment("Sofia Lima", "Saved my project, thank you!"));
        videos.Add(video2);

        // Criar o terceiro vídeo
        Video video3 = new Video("Design Patterns in C#", "Fernanda Ribeiro", 920);
        video3.AddComment(new Comment("Miguel Torres", "Advanced content and well explained!"));
        video3.AddComment(new Comment("Isabel Martins", "Loved the practical examples."));
        video3.AddComment(new Comment("Tiago Sousa", "When is part 2 coming out?"));
        videos.Add(video3);

        // Exibir informações de cada vídeo
        foreach (Video video in videos)
        {
            video.DisplayInformation();
            Console.WriteLine(); // Linha em branco entre vídeos
        }
    }
}
