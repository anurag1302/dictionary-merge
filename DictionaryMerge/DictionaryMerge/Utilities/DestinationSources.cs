using System.Collections.Generic;

namespace DictionaryMerge.Utilities
{
    public class DestinationSources
    {
        public List<ServiceLevel> ServiceLevels { get; set; }

        public List<SourceMediaFormat> SourceMediaFormats { get; set; }

        public List<SubType> SubTypes { get; set; }

        public List<TargetMediaFormat> TargetMediaFormats { get; set; }
    }
}
