//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WaslnyLib.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            this.CarClassifications = new HashSet<CarClassification>();
            this.CarMaintenances = new HashSet<CarMaintenance>();
            this.Trips = new HashSet<Trip>();
        }
    
        public int CarID { get; set; }

        [Required(ErrorMessage = "Please enter this Field")]
        public string CarColor { get; set; }

        [Required(ErrorMessage = "Please enter this Field")]
        public string CarBrand { get; set; }

        [Required(ErrorMessage = "Please enter this Field")]
        public string CarModel { get; set; }

        [Required(ErrorMessage = "Please enter this Field")]
        public int CarVersion { get; set; }

        [Required(ErrorMessage = "Please enter this Field")]
        public string CarType { get; set; }

        [Required(ErrorMessage = "Please enter this Field")]
        public int CarCapacity { get; set; }

        [Required(ErrorMessage = "Please enter this Field")]
        public string CarPN { get; set; }

        [Required(ErrorMessage = "Please enter this Field")]
        public System.DateTime CarLED { get; set; }

        [Required(ErrorMessage = "Please enter this Field")]
        public bool CarRented { get; set; }

        [Required(ErrorMessage = "Please enter this Field")]
        public int CarKMDashboard { get; set; }

        [Required(ErrorMessage = "Please enter this Field")]
        public string CarPhoto { get; set; }

        [Required(ErrorMessage = "Please enter this Field")]
        public bool CarIsAvailable { get; set; }

        [Required(ErrorMessage = "Please enter this Field")]
        public bool IsDeleted { get; set; }


        public bool IsLicenseExpired()
        {
            if (CarLED <= DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarClassification> CarClassifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarMaintenance> CarMaintenances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trip> Trips { get; set; }
    }
}
