using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VertexWebForm.Models
{
    public class UserForm
    {
        [Key, ScaffoldColumn(false)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required(ErrorMessage = "Filed Empty")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Filed Empty")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Filed Empty")]
        public string PresentCollege { get; set; }
        [Required(ErrorMessage = "Filed Empty")]
        public string PresentConference { get; set; }
        [Required(ErrorMessage = "Filed Empty")]
        public string Sports { get; set; }
        [Required(ErrorMessage = "Filed Empty")]
        public int PreviousSeasons { get; set; }
        [Required(ErrorMessage = "Filed Empty")]
        public string StudentId { get; set; }
        [Required(ErrorMessage = "Filed Empty")]
        public string Telephone { get; set; }
        [Required(ErrorMessage = "Filed Empty")]
        public string PresentAddress { get; set; }
        [Required(ErrorMessage = "Filed Empty")]
        public string DateOfFilled { get; set; }
        [Required(ErrorMessage = "Filed Empty")]
        public string DateOfBirth { get; set; }
        [Required(ErrorMessage = "Filed Empty")]

        [Key, ScaffoldColumn(false)]
        public string HighSchoolId { get; set; }
        public HighSchool HighSchool { get; set; }
        public ICollection<PostHighSchool> PostHighSchool { get; set; }
        public ICollection<CollegeSport> CollegeSport { get; set; }
    }
}