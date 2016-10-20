//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class Customer
    {
        public int CustomerID { get; set; }
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Please Enter Only Alphabets")]
        [Required]
        public string FirstName { get; set; }
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Please Enter Only Alphabets")]
        [Required]
        public string MiddleName { get; set; }
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Please Enter Only Alphabets")]
        [Required]
        public string LastName { get; set; }
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Please Enter Only Alphabets")]
        [Required]
        public string Company { get; set; }
        [Required]
        public int CustomerTypeID { get; set; }
        [Required]
        public int CustomerStatusID { get; set; }

        [Required]
        public string Email { get; set; }
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Please Enter Only Numbers")]
        [Required]
        public string Phone { get; set; }
        [Required]
        public string MainAddress1 { get; set; }
        [Required]
        public string MainAddress2 { get; set; }
        [Required]
        public string MainAddress3 { get; set; }
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Please Enter Only Alphabets")]
        [Required]
        public string MainCity { get; set; }
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Please Enter Only Alphabets")]
        [Required]
        public string MainState { get; set; }
        [RegularExpression(@"^\d{6}$", ErrorMessage = "Please Enter 6 digit Only Numbers")]
        [Required]
        public string MainZip { get; set; }
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Please Enter Only Alphabets")]
        [Required]
        public string MainCountry { get; set; }
        [Required]
        public string MailAddress1 { get; set; }
        [Required]
        public string MailAddress2 { get; set; }
        [Required]
        public string MailAddress3 { get; set; }
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Please Enter Only Alphabets")]
        [Required]
        public string MailCity { get; set; }
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Please Enter Only Alphabets")]
        [Required]
        public string MailState { get; set; }
        [RegularExpression(@"^\d{6}$", ErrorMessage = "Please Enter 6 digit Only Numbers")]
        [Required]
        public string MailZip { get; set; }
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Please Enter Only Alphabets")]
        [Required]
        public string MailCountry { get; set; }
        public bool CanLogin { get; set; }
        public string LoginName { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Enter valid date")]
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string CurrencyCode { get; set; }
        public Nullable<int> LanguageID { get; set; }
        [Required]
        public string Gender { get; set; }
        public string TaxCode { get; set; }
        [Required]
        public int TaxCodeTypeID { get; set; }
        public bool IsSalesTaxExempt { get; set; }
        public string SalesTaxCode { get; set; }
        public Nullable<bool> IsEmailSubscribed { get; set; }

        public string Notes { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Enter valid date")]
        [Required]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Enter valid date")]
        [Required]
        public DateTime ModifiedDate { get; set; }
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Please Enter Only Alphabets")]
        [Required]
        public string CreatedBy { get; set; }
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Please Enter Only Alphabets")]
        [Required]
        public string ModifiedBy { get; set; }

        public SelectList CountryList { get; set; }
    }
}
