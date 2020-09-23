namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(CourseMetaData))]
    public partial class Course
    {
    }
    
    public partial class CourseMetaData
    {
        [Required]
        public int CourseID { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        public string Title { get; set; }
        [Required]
        public int Credits { get; set; }
        [Required]
        public int DepartmentID { get; set; }
        [Required]
        public System.DateTime CreatedOn { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<Enrollment> Enrollment { get; set; }
        public virtual ICollection<Person> Students { get; set; }
    }
}
