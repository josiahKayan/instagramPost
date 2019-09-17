using InstagramApiSharp.Classes.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebAppMidias.Models;

namespace WebAppMidias.Controllers
{
    public class InstagramController : ApiController
    {

        // POST api/values
        //public void Post([FromBody]InstagramPost instragramPost)
        public async Task GetAsync()

        {

            InstagramPost instagram = new InstagramPost();

            instagram.Login = "projeto.cits";
            instagram.Password = "123456789@aBc";
            instagram.UrlLink = "http://10.10.0.193:80/Videos/2bbca089-1916-47d8-809a-23f8b400d629/video.mp4";

            

        }


        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }



    }
}
