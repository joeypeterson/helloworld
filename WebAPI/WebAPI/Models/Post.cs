using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace WebAPI.Models
{/// <summary>
/// This is the model for a post
/// </summary>
    public class Post
    {
        private string title;
        /// <summary>
        /// This is the getter/setter for title.
        /// </summary>
        public string Title
        {
          
        get {
              
                StreamReader sr = new StreamReader(WebApiApplication.ApiFileName);
                title = sr.ReadToEnd();
                sr.Close();
                return title;
            }
            set {
                //write the update to the file
                
                System.IO.File.WriteAllText(WebApiApplication.ApiFileName, value);
               
            }
        }

    }
}