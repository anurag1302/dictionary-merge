using DictionaryMerge.Utilities;
using System.Collections.Generic;

namespace DictionaryMerge
{
    public class Repository
    {
        public static Dictionary<string, DestinationSources> PopulateDictionary(string type)
        {
            if(type=="US")
            {
                return new Dictionary<string, DestinationSources>
                {
                    { "US",US()}
                };
            }
            else
            {
                return new Dictionary<string, DestinationSources>
                {
                    { "UK",UK()}
                };
            }
        }

        private static DestinationSources US()
        {
            return new DestinationSources
            {
                ServiceLevels = new List<ServiceLevel>(),
                SourceMediaFormats = new List<SourceMediaFormat>(),
                SubTypes = new List<SubType>(),
                TargetMediaFormats = new List<TargetMediaFormat>
                {
                    new TargetMediaFormat
                    {
                        Items=new MediaFormat[]
                        {
                            new MediaFormat
                            {
                                Name="Test1",
                                Key="Key1"
                            },
                            new MediaFormat
                            {
                                Name="Test2",
                                Key="Key2"
                            },
                            new MediaFormat
                            {
                                Name="Test3",
                                Key="Key3"
                            }
                        }
                    },
                    new TargetMediaFormat
                    {
                        Items=new MediaFormat[]
                        {
                            new MediaFormat
                            {
                                Name="Test4",
                                Key="Key4"
                            },
                            new MediaFormat
                            {
                                Name="Test5",
                                Key="Key5"
                            },
                            new MediaFormat
                            {
                                Name="Test6",
                                Key="Key6"
                            }
                        }
                    }
                }
            };
        }

        private static DestinationSources UK()
        {
            return new DestinationSources
            {
                ServiceLevels = new List<ServiceLevel>(),
                SourceMediaFormats = new List<SourceMediaFormat>(),
                SubTypes = new List<SubType>(),
                TargetMediaFormats = new List<TargetMediaFormat>
                {
                    new TargetMediaFormat
                    {
                        Items=new MediaFormat[]
                        {
                            new MediaFormat
                            {
                                Name="Test7",
                                Key="Key7"
                            },
                            new MediaFormat
                            {
                                Name="Test8",
                                Key="Key8"
                            },
                            new MediaFormat
                            {
                                Name="Test9",
                                Key="Key9"
                            },
                            new MediaFormat
                            {
                                Name="Test10",
                                Key="Key10"
                            },
                            new MediaFormat
                            {
                                Name="Test11",
                                Key="Key11"
                            }
                        }
                    },
                    new TargetMediaFormat
                    {
                        Items=new MediaFormat[]
                        {
                            new MediaFormat
                            {
                                Name="Test12",
                                Key="Key12"
                            },
                            new MediaFormat
                            {
                                Name="Test13",
                                Key="Key13"
                            },
                            new MediaFormat
                            {
                                Name="Test14",
                                Key="Key14"
                            },
                            new MediaFormat
                            {
                                Name="Test15",
                                Key="Key15"
                            },
                            new MediaFormat
                            {
                                Name="Test16",
                                Key="Key16"
                            }
                        }
                    },
                    new TargetMediaFormat
                    {
                        Items=new MediaFormat[]
                        {
                            new MediaFormat
                            {
                                Name="Test17",
                                Key="Key17"
                            },
                            new MediaFormat
                            {
                                Name="Test18",
                                Key="Key18"
                            }
                        }
                    }
                }
            };
        }
    }
}
