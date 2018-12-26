using System;
using System.Net;

namespace Regate
{
    public static partial class RegateFile
    {
        public static string Build(string name) =>
            _Build(new Props(name));

        public static string Build(string name, string value) =>
            _Build(new Props(name, value));

        public static string Build(
              string name
            , string value = null
            , bool isRequired = false
            , string uploaderUrl = DefaultUploaderUrl
            , string repositoryUrl = DefaultRepositoryUrl
        ) =>
            _Build(new Props(name, value)
            {
                IsRequired = isRequired,
                UploaderUrl = uploaderUrl,
                RepositoryUrl = repositoryUrl,
            });
    }

}
