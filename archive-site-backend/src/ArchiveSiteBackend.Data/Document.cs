using System;
using System.ComponentModel.DataAnnotations;

namespace ArchiveSiteBackend.Data {
    public class Document : EntityBase {
        [Required, StringLength(1024)]
        public String FileName { get; set; }

        [Required]
        public Int64 ProjectId { get; set; }

        [Required]
        public DocumentStatus Status { get; set; } = DocumentStatus.PendingTranscription;

        public Int64? ActiveUser { get; set; }

        [Required]
        public DateTime UpdatedTime { get; set; }
    }
}
