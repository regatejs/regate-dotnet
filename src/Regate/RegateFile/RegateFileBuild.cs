using System;
using System.Net;
using System.Text.Encodings.Web;

namespace Regate
{
    public static partial class RegateFile
    {
        private static string _Build(Props props)
        {
            var uniqueId = $"RegateFile__{props.Name}__{Guid.NewGuid().ToString().Replace("-", "")}";

            var value = string.IsNullOrWhiteSpace(props.Value) ? "" : props.Value;
            var uploaderUrl = string.IsNullOrWhiteSpace(props.UploaderUrl) ? "" : props.UploaderUrl;
            var repositoryUrl = string.IsNullOrWhiteSpace(props.RepositoryUrl) ? "" : props.RepositoryUrl;

            value = JavaScriptEncoder.Default.Encode(value);
            uploaderUrl = JavaScriptEncoder.Default.Encode(uploaderUrl);
            repositoryUrl = JavaScriptEncoder.Default.Encode(repositoryUrl);


            return $@"
                <script>document.write(Regate.RegateFile.markup('{uniqueId}'))</script>

                <script>
                    Regate.RegateFile.init({{
                        id: '{uniqueId}',
                        name: '{props.Name}',
                        value: '{value}',
                        uploaderUrl: '{uploaderUrl}',
                        repositoryUrl: '{repositoryUrl}',
                        isRequired: {props.IsRequired.ToString().ToLower()},
                    }});
                </script>
            ";
        }

    }

}
