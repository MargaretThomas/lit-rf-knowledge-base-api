using lit_rf_knowledge_base_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lit_rf_knowledge_base_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpaceCapsuleController : ControllerBase
    {
        private readonly ILogger<SpaceCapsuleController> _logger;

        public SpaceCapsuleController(ILogger<SpaceCapsuleController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSpaceCapsules")]
        public IEnumerable<SpaceCapsule> Get()
        {
            return
            [
                new SpaceCapsule()
                {
                    Id = 1,
                    Name = "Kaizen",
                    Url = "https://www.linkedin.com/posts/patrick-skene_excellence-incrementalgains-evolution-activity-7158549504755961856-DRHl/",
                    Group = new Group()
                    {
                        Name = "Group One",
                        ClassName = "group-one"
                    }
                },
                new SpaceCapsule()
                {
                    Id = 2,
                    Name = "Fifi the cat",
                    Url = "https://www.instagram.com/reel/C1u0CWzsM43/?igsh=MTR6eXp5aW0zbTJ0eQ==",
                    Group = new Group()
                    {
                        Name = "Group Two",
                        ClassName = "group-two"
                    }
                },
                new SpaceCapsule()
                {
                    Id = 3,
                    Name = "Naval on Quality",
                    Url = "https://x.com/naval/status/1309040145107243010?s=20",
                    Group = new Group()
                    {
                        Name = "Group Three",
                        ClassName = "group-three"
                    }
                },
                new SpaceCapsule()
                {
                    Id = 4,
                    Name = "Tech stack of Pinterest",
                    Url = "https://www.reddit.com/r/programming/s/5fYN98v2dP",
                    Group = new Group()
                    {
                        Name = "Group Four",
                        ClassName = "group-four"
                    }
                }
            ];
        }
    }
}
