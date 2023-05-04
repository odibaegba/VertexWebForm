using System.Collections.Generic;
using System.Data.Entity;
using VertexWebForm.Models;

namespace VertexWebForm.Data
{
    public class VertexWebFormDbInitializer : DropCreateDatabaseIfModelChanges<VertexWebFormDbContext>
    {
        protected override void Seed(VertexWebFormDbContext context)
        {
            GetUserForms().ForEach(n => context.UserForms.Add(n));
        }

        private static List<UserForm> GetUserForms()
        {
            var userForms = new List<UserForm>()
            {
                new UserForm()
                {
                    FullName = "Mark Odiba",
                    Gender = "Male",
                    DateOfBirth = "21/05/2002",
                    DateOfFilled = "1/05/2023",
                    PresentCollege = "Tenessee State University",
                    PresentConference = "Eastern",
                    Sports = "Basket Ball",
                    Telephone = "(666) 547-1237",
                    PresentAddress = "Alexender Street",
                    StudentId = "DVJKA/63947",
                    HighSchool = new HighSchool()
                    {
                        Name = "Kings High School for science and technology",
                        DateLastAttended = "04/09/2021"
                    },
                    PostHighSchool = new List< PostHighSchool>()
                    {
                        new PostHighSchool()
                        {
                            CollegesAttendedOrJobsHeld = "None"
                        }
                    },
                    CollegeSport = new List<CollegeSport>()
                    {
                        new CollegeSport()
                        {
                            College = "None"
                        }
                    }
                }
            };
            return userForms;
        }

    }
}