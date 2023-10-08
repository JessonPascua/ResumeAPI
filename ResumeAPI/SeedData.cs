using Microsoft.EntityFrameworkCore;
using ResumeAPI.Data;
using ResumeAPI.Models;

namespace ResumeAPI
{
    public class SeedData
    {
        public async static Task MySeedData(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ResumeAPIContext>();
                await SeedResume(dbContext);
            }
        }

        private static async Task SeedResume(ResumeAPIContext dbContext)
        {
            var myResume = new Resume
            {
                Name = "John Doe",
                AboutMe = "I am a software developer with 10 years of experience in the industry.",
                Experiences = new List<Experiences>
                {
                    new Experiences
                    {
                        Title = "Software Developer",
                        Company = "ABC Company",
                        Range = "2010 - 2015",
                        Responsibilities = new string[]
                        {
                            "I worked as a software developer for ABC Company from 2010 to 2015.",
                            "I worked as a software developer for ABC Company from 2010 to 2015.",
                            "I worked as a software developer for ABC Company from 2010 to 2015."
                        }
                    },
                    new Experiences
                    {
                        Title = "Software Developer II",
                        Company = "ABC Company",
                        Range = "2010 - 2015",
                        Responsibilities = new string[]
                        {
                            "I worked as a software developer for ABC Company from 2010 to 2015.",
                            "I worked as a software developer for ABC Company from 2010 to 2015.",
                            "I worked as a software developer for ABC Company from 2010 to 2015."
                        }
                    },
                },
                Educations = new List<Educations>
                {
                    new Educations
                    {
                        School = "ABC University",
                        Degree = "Bachelor of Science in Computer Science",
                        Description = "I graduated from ABC University with a Bachelor of Science in Computer Science in 2009."
                    }
                },
                Certifications = new List<Certifications>
                {
                    new Certifications
                    {
                        Name = "Microsoft Certified Solutions Developer",
                        Issuer = "Microsoft",
                        IssueDate = DateTime.Now,
                        CredentialURL = "https://www.microsoft.com/en-us/learning/mcsd-certification.aspx",
                    }
                },
                Projects = new List<Projects>
                {
                    new Projects
                    {
                        Name = "ResumeAPI",
                        Repo = "",
                        Live = "",
                        Description = "This is a RESTful API that serves as a resume for a software developer.",
                        Stacks = new string[]
                        {
                            "C#",
                            "ASP.NET Core",
                            "Entity Framework Core",
                            "PostgreSQL",
                            "Rest API"
                        },
                    }
                },
                Contacts = new List<Contacts>
                {
                    new Contacts
                    {
                        Email = "JessonPascua.Work@gmail.com",
                        Phone = "+639278819540",
                        GitHub = "https://github.com/JessonPascua",
                        LinkedIn= "https://www.linkedin.com/in/jessonpascua",
                    }
                },
                Comments = new List<Comments>
                {
                    new Comments
                    {
                        Name = "John Doe",
                        Email = "test@test.com",
                        Massage = "This is a comment.",
                    }
                }
            };

            if (!await dbContext.Resume.AnyAsync(x => x.Name.ToLower() == myResume.Name.ToLower()))
            {
                dbContext.Resume.Add(myResume);
                await dbContext.SaveChangesAsync();
            }

            return;
        }
    }
}
