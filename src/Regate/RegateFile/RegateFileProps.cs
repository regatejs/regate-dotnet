using System;
using System.Net;

namespace Regate
{
    public static partial class RegateFile
    {

        public const string DefaultUploaderUrl = "/uploader/file/";
        public const string DefaultRepositoryUrl = "/repository/";

        private class Props
        {
            public Props(string name)
            {
                Name = name;
            }

            public Props(string name, string value) : this(name)
            {
                Value = value;
            }

            public string Name { get; }
            public string Value { get; }
            public string UploaderUrl { get; set; } = DefaultUploaderUrl;
            public string RepositoryUrl { get; set; } = DefaultRepositoryUrl;
            public bool IsRequired { get; set; }
        }
    }

}
