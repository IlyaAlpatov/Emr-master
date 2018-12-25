using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace Emr.Database.Models
{
    /// <summary>
    /// Админ
    /// </summary>
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid AdminGuid { get; set; }
		
		[ForeignKey(nameof(Patient))]
        public Guid ClientGuid { get; set; }
		
		public virtual Client Client { get; set; }

		public Admin()
		
        {
            AdminGuid = Guid.NewGuid();
        }
    }
}
