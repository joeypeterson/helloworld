using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Hosting;
using System.IO;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        
       /// <summary>
       /// Get the contents of the post
       /// </summary>
       /// <returns>Returns the post title</returns>
        public string Get()
        {
            Post post = new Post();
            
                return post.Title ;
        }



        /// <summary>
        /// This allows you to update the Hello World File with new contents
        /// </summary>
        /// <param name="value"> Contents of the message to update</param>
        // POST api/values
        public IHttpActionResult Put([FromBody]string name) 
        {
            if (!String.IsNullOrEmpty(name))
            {
                Post post = new Post();
                post.Title = name;
                return Ok();
            }

            return BadRequest("Request can not be empty");

        }

      
   
    }
}
