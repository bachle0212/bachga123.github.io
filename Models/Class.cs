//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Class
    {
        [DisplayName("Class Id")]
        [Required(ErrorMessage = " This field is empty")]
        public string ClassId { get; set; }
        [DisplayName("Class Name")]
        [Required(ErrorMessage = " This field is empty")]
        public string ClassName { get; set; }
        [DisplayName("Number of Student")]
        [Required(ErrorMessage = " This field is empty")]
        public Nullable<int> NumOfStu { get; set; }
        [DisplayName("Name of Teacher")]
        [Required(ErrorMessage = " This field is empty")]
        public string NameOfTeacher { get; set; }

        public string AddClassErrorMessage;
        public string EditClassErrorMessage;
    }
}
