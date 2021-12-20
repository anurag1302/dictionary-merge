using DictionaryMerge.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            var records = new List<Dictionary<string, DestinationSources>>
            {
                Repository.PopulateDictionary("US"),
                Repository.PopulateDictionary("UK")
            };

            var formats1 = records[0].Values.Select(x => x.TargetMediaFormats).ToList();
            var formats2 = records[1].Values.Select(x => x.TargetMediaFormats).ToList();

            var concatenatedFormats = formats1.Concat(formats2).ToList();

            var freshFormats = new List<TargetMediaFormat>();

            foreach(var format in concatenatedFormats)
            {
                foreach(var item in format)
                {
                    freshFormats.Add(item);
                }
            }

            var newDestinationSources = new DestinationSources
            {
                ServiceLevels = new List<ServiceLevel>(),
                SourceMediaFormats = new List<SourceMediaFormat>(),
                SubTypes = new List<SubType>(),
                TargetMediaFormats = freshFormats
            };

            var newdictItem = new Dictionary<string, DestinationSources>
            {
                { "US UK", newDestinationSources}
            };

            Console.WriteLine("Hello World!");
        }
    }
}
