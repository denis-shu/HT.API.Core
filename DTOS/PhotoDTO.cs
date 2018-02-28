using System;
using Microsoft.AspNetCore.Http;

namespace DatingApp.API.DTOS
{
    public class PhotoDTO
    {
        public string Url { get; set; }
        public IFormFile File { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public string PublicId { get; set; }

        public PhotoDTO()
        {
            DateAdded=DateTime.Now;
        }
    }
}