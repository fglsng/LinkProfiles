using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public enum CvEntryType
    {
        Experience,
        Education
    }
    public class CvEntry
    {
        public CvEntryType Type { get; set; }
        public string? YearFrom { get; set; }
        public string? YearTo { get; set; }
        public string? Title { get; set; }
        public string? Employer { get; set; }
        public string? Description { get; set; }

        public CvEntry(CvEntryType type)
        {
            Type = type;
        }
    }
}
