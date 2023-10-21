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
                Name = "Jesson Pascua",
                AboutMe = "I am a software developer with 10 years of experience in the industry.",
                Experiences = new List<Experiences>
                {
                    new Experiences
                    {
                        Title = "Software Developer",
                        Company = "MicroSourcing - EagleView, Philippines - Product Support Specialist",
                        Range = "May 2011 - PRESENT",
                        Responsibilities = new string[]
                        {
                            "Primary responsibility: Software Development.",
                            "Developing C# .NET Framework/Core solutions for the organization.",
                            "Creating in-house applications using the .NET framework/Core.",
                            "Debugging and maintaining written code.",
                            "Reporting and resolving issues related to .NET projects.",
                            "Identifying and handling technical risks and issues.",
                            "Providing technical support to stakeholders in the organization.",
                            "Performing tasks such as Software testing for both mobile and web applications.",
                        }
                    },
                    new Experiences
                    {
                        Title = "Software Developer",
                        Company = "Fiverr, Online Platform",
                        Range = "Aug 2020 - Apr 2022",
                        Responsibilities = new string[]
                        {
                            "Responsible for designing and maintaining various websites and databases.",
                            "Web data scraping.",
                        }
                    },
                },
                Educations = new List<Educations>
                {
                    new Educations
                    {
                        School = "Our Lady of Fatima University, Philippines.",
                        Degree = "Bachelor of Science (B.S.), Computer Science.",
                        Description = "I graduated from Our Lady of Fatima University with a Bachelor of Science in Computer Science."
                    }
                },
                Certifications = new List<Certifications>
                {
                    new Certifications
                    {
                        Name = "ASP.NET Core in .NET 6: Dependency Injection By: David Grace",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-09-30"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/1ee6a2d75224963d78cb608b38f4828727319ee0789f5ea84ceea4da42088e75",
                    },
                    new Certifications
                    {
                        Name = "ASP.NET Core: Token-Based Authentication By: Ervis Trupja",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-09-26"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/172829bd21ebad714736c484d5b51c9b440334d43f59e1f119c37aec4b6b314a",
                    },
                    new Certifications
                    {
                        Name = "Advanced C#: Language Features By: Joe Marini",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-09-10"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/14d387b9b395d57ed283fb7b0a173e2d8eb7149759144fe75ad38f9f3f1c969e",
                    },
                    new Certifications
                    {
                        Name = "Foundational C# with Microsoft",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-09-03"),
                        CredentialURL = "https://www.freecodecamp.org/certification/Jesson/foundational-c-sharp-with-microsoft",
                    },
                    new Certifications
                    {
                        Name = "JavaScript as a Second Language By: Ray Villalobos",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-09-17"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/630184009af6445092c1c189fcaaa7258fad0c525b32c4a4283ebc5038c8e8dc",
                    },
                    new Certifications
                    {
                        Name = "Learning TypeScript By: Jess Chadwick",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-09-17"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/51ab40a95755a48e5ae9dcbacffea8aab4bc59c0640ab74a00effe61209f55ea",
                    },
                    new Certifications
                    {
                        Name = "Securing ASP.NET Core Apps: Advanced Techniques for Web Application Security By: Ervis Trupja",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-09-16"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/b90dc52d6b235cf7b49f0fc8a1f169f20d54faabec5e032f3c87589ec735de8b",
                    },
                    new Certifications
                    {
                        Name = "Visual Studio Code for .NET Developers By: Jesse Freeman",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-09-24"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/3f0bd373731e9072b0715d8d10f8436456f93877d5a221a9096500c4fe7021af",
                    },
                    new Certifications
                    {
                        Name = "Advanced .NET: Commands, C# Enhancements, Web Apps, and Libraries By: Walt Ritscher",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-08-26"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/fe7d2dacc5d0ab77a44b3c742e09d128d53697de73c6b5975ad77169341fabc7",
                    },
                    new Certifications
                    {
                        Name = "Building Web APIs with ASP.NET Core in .NET By: Christian Wenz",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-08-20"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/2e1b8e4c2ee4aaf030dd291899644b2af609cba9dd339b6d42c2254ed5dc0c5d",
                    },
                    new Certifications
                    {
                        Name = "Designing RESTful APIs By: Keith Casey",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-08-28"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/7345ff08191ce9bc3d15b9ed3bfbaf7a18f98cae088de1265564b812ad17d942",
                    },
                    new Certifications
                    {
                        Name = "Learning GitHub By: Emanuele Bartolesi",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-08-15"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/95c48c2c00ea3d6d84e79de64937be3b316f650fade3f4d16b3ce6b50ae4f842",
                    },
                    new Certifications
                    {
                        Name = "jQuery Essential Training By: Joe Marini",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-08-15"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/4f337bae9c551506a41203972ddfb2aa8b009ea8919ebd1fa52bceae514bbb65",
                    },
                    new Certifications
                    {
                        Name = "PostgreSQL Essential Training (2020) By: Adam Wilbert",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-07-10"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/67a3f0e131b834a44446f71243d1900344f63688aa08effc3c7e60349b517cd0",
                    },
                    new Certifications
                    {
                        Name = "ASP.NET Core: Razor Pages By: Ervis Trupja",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-05-04"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/e2d3882f679bd54f749e73245b59f1d9199dcfc14456c08afb654de3a60f0c1f",
                    },
                    new Certifications
                    {
                        Name = "Getting Started as a C# Developer",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-04-10"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/ffe85a438457ffa688a89f08631956f62c103b2339ea44430b912abad45be9a5",
                    },
                    new Certifications
                    {
                        Name = "Learning Entity Framework Core By: Reynald Adolphe",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-03-14"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/7fbe46efa2874550e9fb19771248184c05a1e8d0ddafc30ef5f497c38030fcdc",
                    },
                    new Certifications
                    {
                        Name = "Learning Git and GitHub By: Ray Villalobos",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-03-20"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/ef41c347e1c5766f4bdeb93796be52fc8749c25ba7a55e24d44c59fea659a30a",
                    },
                    new Certifications
                    {
                        Name = "Learning REST APIs By: Morten Rand-Hendriksen",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-03-11"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/676d16a4a5d775985a67ebbc7b8e03008ef4b83c3afd0ed77ab6f1edecfda942",
                    },
                    new Certifications
                    {
                        Name = "Microsoft SQL Server 2022 Essential Training By: Adam Wilbert",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-03-28"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/9036b534fa468878668f4c473561a10d01000e89a4c146b9c3090d906a3293bf",
                    },
                    new Certifications
                    {
                        Name = "C#: Design Patterns Part 2 By: Richard Goforth",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-02-19"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/7ebd5ae81028538b3066564881f4a356b4c7fcc5bb3a493a30ce73e894f772ae",
                    },
                    new Certifications
                    {
                        Name = "Learning .NET Programming By: Reynald Adolphe",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-02-15"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/cb0b5208202cc456f416739231db28d8083744e67b6604adbe504dce8f0170df",
                    },
                    new Certifications
                    {
                        Name = "Using Generics in C# By: Robby Millsap",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-02-15"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/5dd07a8ad48275201a9eb1f61737f831f4a195c5e193832adbc374e59833c3db",
                    },
                    new Certifications
                    {
                        Name = "C# Algorithms By: Kathryn Hodge",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-01-21"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/c2933cf24b94b08622560a8500d6cfbddb487f8a2791041b90e066d0430d9c4f",
                    },
                    new Certifications
                    {
                        Name = "C# Object-Oriented Programming Tips and Tricks By: Jesse Freeman",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-01-23"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/352e46e4f99f85e4cda1731367f5c01a07f8ed8cb61d96368301ff5bb18ab737",
                    },
                    new Certifications
                    {
                        Name = "C#: Delegates, Events, and Lambdas By: Joe Marini",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-01-08"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/088e85c6bc0e6b74ffe191c17a7196a12075b2e073c7f054e71bfb1756cfa84d",
                    },
                    new Certifications
                    {
                        Name = "C#: Design Patterns Part 1 By: Joe Marini",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-01-16"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/4f50704911515b835cc9817fa39996d212adea5857adfd53e2e929683a17fd65",
                    },
                    new Certifications
                    {
                        Name = "C#: Interfaces and Generics By: Joe Marini",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-01-14"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/ec26c0be1ba1922d736e5c36d74f1f61f7edefdaca72e05791c4a1bb2f04fd8e",
                    },
                    new Certifications
                    {
                        Name = "Introducing ASP.NET Core By: Microsoft .NET and Leslie Richardson",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-01-06"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/11e8cd076274e13d37865338fc26c8c65f03b480bfba8684f99bde2a5ce94e71",
                    },
                    new Certifications
                    {
                        Name = "Learning C# By: Joe Marini",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2023-01-11"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/98434f2e3f2ddfdd99d632dbf9a6ed80165b3b5561bdd4e80753b9e57cdc5820",
                    },
                    new Certifications
                    {
                        Name = "C# Essential Training 1: Types and Control Flow By: Matt Milner",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2022-12-26"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/a65fbd03baf24679f571f0f747c8b6290200334b3ffca5fad5b3bbb12bfa8a4f",
                    },
                    new Certifications
                    {
                        Name = "C# Essential Training 2: Generics, Collections, and LINQ By: Matt Milner",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2022-12-26"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/2d864aaa04e294aa6ed38711765d8e1539abd10d25f8e23e1991cd78080c4607",
                    },
                    new Certifications
                    {
                        Name = "C# Essential Training 2: Generics, Collections, and LINQ By: Matt Milner",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2022-12-28"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/5b13336fcb6524bf5c62ac1a3864c3a106c8da770512a015b2c54247f12c9de3",
                    },
                    new Certifications
                    {
                        Name = ".NET with C# Essentials: Enhance Application Productivity and Performance By: Joe Marini",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2022-12-30"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/5b13336fcb6524bf5c62ac1a3864c3a106c8da770512a015b2c54247f12c9de3",
                    },
                    new Certifications
                    {
                        Name = "CSS Essential Training (2019) By: Christina Truong",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2022-12-30"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/5b13336fcb6524bf5c62ac1a3864c3a106c8da770512a015b2c54247f12c9de3",
                    },
                    new Certifications
                    {
                        Name = "JavaScript Essential Training By: Morten Rand-Hendriksen",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2022-12-30"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/015de11e8d310777230fd92ea7d9d3bc8aa85c9856719506b243df124a2b1128",
                    },
                    new Certifications
                    {
                        Name = "Crafting Meaningful HTML By: Jen Kramer",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2022-12-21"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/38565e3e43f51df9a59dab7a78d15ea17d9ced6cb2832427e1f5f18eaf92249b",
                    },
                    new Certifications
                    {
                        Name = "HTML Essential Training By: Jen Simmons",
                        Issuer = "LinkedIn",
                        IssueDate = DateTime.Parse("2022-12-21"),
                        CredentialURL = "https://www.linkedin.com/learning/certificates/38565e3e43f51df9a59dab7a78d15ea17d9ced6cb2832427e1f5f18eaf92249b",
                    },
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
                },
            };

            var apiRoutes = new Api
            {
                RoutesList = new List<RoutesList>
                {
                    new RoutesList
                    {
                        Description = "Route info",
                        Url = "https://jesson-pascua-resume-api.vercel.app/api",
                    },
                    new RoutesList
                    {
                        Description = "Get all resume info",
                        Url = "https://jesson-pascua-resume-api.vercel.app/api/resume",
                    },
                    new RoutesList
                    {
                        Description = "Get all certifications",
                        Url = "https://jesson-pascua-resume-api.vercel.app/api/certifications",
                    },
                    new RoutesList
                    {
                        Description = "Get all projects",
                        Url = "https://jesson-pascua-resume-api.vercel.app/api/projects",
                    },
                    new RoutesList
                    {
                        Description = "Get all contacts",
                        Url = "https://jesson-pascua-resume-api.vercel.app/api/contacts",
                    },
                    new RoutesList
                    {
                        Description = "Get all comments",
                        Url = "https://jesson-pascua-resume-api.vercel.app/api/comments",
                    }
                }
            };

            //check if has data in dbContext.Api table.
            if (!await dbContext.Api.AnyAsync())
            {
                dbContext.Api.Add(apiRoutes);
                await dbContext.SaveChangesAsync();
            }

            if (!await dbContext.Resume.AnyAsync(x => x.Name.ToLower() == myResume.Name.ToLower()))
            {
                dbContext.Resume.Add(myResume);
                await dbContext.SaveChangesAsync();
            }

            return;
        }
    }
}
