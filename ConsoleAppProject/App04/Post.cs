using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class Post
    {
        public int PostId { get; }

        private int likes;

        private readonly List<String> comments;


        
        public String Author { get; }

        public DateTime Timestamp { get; }

        public static int instances = 0;

        public Post(string author)
        {
            instances++;
            PostId = instances;

            this.Author = author;
            Timestamp = DateTime.Now;

            likes = 0;
            comments = new List<String>();
        }

        public void Like()
        {
            likes++;
        }


       
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }


      
        public void AddComment(String text)
        {
            comments.Add(text);
        }


       
        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"    PostID:{PostId}");
            Console.WriteLine($"    Author:{Author}");
            Console.WriteLine($"    Time Elpased: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine();

            if (likes > 0)
            {
                Console.WriteLine($"    Likes:  {likes}  people like this.");
            }
            else
            {
                Console.WriteLine();
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("    No comments.");
            }
            else
            {
                Console.WriteLine($"    Comment(s): {comments.Count} ");
            }
        }


       
   
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
    }
}