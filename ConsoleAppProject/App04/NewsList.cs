﻿using System;
using System.Collections.Generic;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Michael Kölling and David J. Barnes
    ///  version 0.1
    ///</author> 
    public class NewsList
    {
        public const string AUTHOR = "Samuel";
        public readonly List<Post> PostList;

        public int itemNumber;
        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsList()
        {
            PostList = new List<Post>();



        }
     
      
        public void AddPost(Post post)
        {
            PostList.Add(post);
        }
        ///<summary>
        
        public void Display()
        {
            // display all posts

            ConsoleHelper.OutputTitle("Displaying All Posts");
            foreach (Post post in PostList)
            {
                post.Display();
                Console.WriteLine();   
            }


        }

        public void RemovePost(int id)
        {
            Post post = FindPost(id);
            if (post != null)
            {
                Console.WriteLine($"\n Post with ID = {id} not exist! \n");
            }
            else if (post is MessagePost mp)
            {
                mp.Display();
            }
            else if (post is PhotoPost pp)
            {
                pp.Display();
            }

            PostList.Remove(post);
        }

        private Post FindPost(int id)
        {
            foreach (Post post in PostList)
            {
                if (post.PostId == id)
                {
                    return post;
                }
            }
            return null;
        }
    }

}