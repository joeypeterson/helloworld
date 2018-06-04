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
                //read the content in the file
                StreamReader sr = new StreamReader(HostingEnvironment.MapPath(WebApiApplication.ApiFileName));
                title = sr.ReadToEnd();
                sr.Close();
                return title;
            }
            set {
                //write the update to the file
                
                System.IO.File.WriteAllText(HostingEnvironment.MapPath(WebApiApplication.ApiFileName),value);
               
            }
        }

    }
}