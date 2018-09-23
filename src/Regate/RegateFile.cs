using System;
using System.Net;

namespace Regate
{
    public static class RegateFile
    {
        public static string Build(string name) =>
            _Build(new Props(name));

        public static string Build(string name, bool isRequired) =>
            _Build(new Props(name, isRequired));

        public static string Build(string name, string value) =>
            _Build(new Props(name, value));

        public static string Build(string name, string value, bool isRequired) =>
            _Build(new Props(name, value, isRequired));

        private static string _Build(Props props)
        {
            const string html = @"
                <div data-role='RegateFile'>
                    <div class='input-group'>
                        <div class='input-group-prepend' data-role='uploadContainer'>
                            <button type='button'
                                    class='btn btn-secondary'
                                    data-role='upload'>
                                <i class='fa fa-search mr-1'></i> انتخاب فایل
                            </button>
                        </div>

                        <input type='text'
                               style='pointer-events: none;'
                               onfocus='this.blur();'
                               data-role='input'
                               class='form-control' />

                        <div class='input-group-append' data-role='assetContainer'>
                            <button type='button' class='btn btn-outline-secondary' data-role='remove'>
                                <i class='fa fa-fw fa-times'></i>
                            </button>
                            <a href='#' target='_blank' class='btn btn-outline-secondary' data-role='view'>
                                <i class='fa fa-fw fa-download'></i>
                            </a>
                        </div>
                    </div>
                </div>
            ";

            const string css = @"
                [data-role='RegateFile'] [data-role='assetContainer'] {
                    display: none;
                }

                [data-role='RegateFile'][data-hasvalue] [data-role='assetContainer'] {
                    display: flex;
                }

                [data-role='RegateFile'][data-hasvalue] [data-role='uploadContainer'] {
                    display: none;
                }
            ";

            const string js = @"
                function initRegateFile({
                    uniqueId,
                    name,
                    value,
                    isRequired,
                    uploaderUrl,
                    repositoryUrl,
                }) {
                    var popup = function (url, title, w, h) {
                        // Fixes dual-screen position                         Most browsers      Firefox
                        var dualScreenLeft = window.screenLeft != undefined ? window.screenLeft : screen.left;
                        var dualScreenTop = window.screenTop != undefined ? window.screenTop : screen.top;

                        var width = window.innerWidth ? window.innerWidth : document.documentElement.clientWidth ? document.documentElement.clientWidth : screen.width;
                        var height = window.innerHeight ? window.innerHeight : document.documentElement.clientHeight ? document.documentElement.clientHeight : screen.height;

                        var left = ((width / 2) - (w / 2)) + dualScreenLeft;
                        var top = ((height / 2) - (h / 2)) + dualScreenTop;
                        var newWindow = window.open(url, title, 'scrollbars=yes, width=' + w + ', height=' + h + ', top=' + top + ', left=' + left);

                        // Puts focus on the newWindow
                        if (window.focus) {
                            newWindow.focus();
                        }

                        return false;
                    }

                    var _container = document.getElementById(uniqueId);
                    var _regate = _container.querySelector('[data-role=RegateFile]');
                    var _input = _container.querySelector('[data-role=input]');
                    var _remove = _container.querySelector('[data-role=remove]');
                    var _view = _container.querySelector('[data-role=view]');
                    var _upload = _container.querySelector('[data-role=upload]');
                    
                    _input.name = name;

                    if (isRequired === true) {
                        _input.required = true;
                    }

                    _remove.onclick = function () {
                        _input.value = '';
                        delete _regate.dataset.hasvalue;
                        return false;
                    };

                    window['RegateFile__setterCallback'] = function (fieldName, fileName) {
                        var _container = document.getElementById(fieldName);
                        var _input = _container.querySelector('[data-role=input]');
                        var _regate = _container.querySelector('[data-role=RegateFile]');
                        var _view = _container.querySelector('[data-role=view]');

                        _input.value = fileName;
                        _regate.dataset.hasvalue = true;
                        _view.href = repositoryUrl + fileName;
                    };

                    _upload.onclick = function () {
                        popup(uploaderUrl + '?field=' + uniqueId, 'RegateFileUploader', 400, 600);
                        return false;
                    };

                    if (value !== undefined && value !== '') {
                        _input.value = value;
                        _regate.dataset.hasvalue = true;
                        _view.href = repositoryUrl + value;
                    }
                }
            ";

            var uniqueId = $"RegateFile__{props.Name}__{Guid.NewGuid().ToString().Replace("-", "")}";

            return $@"
                <div id='{uniqueId}'>{html}</div>
                <style>{css}</style>
                <script>{js}</script>

                <script>
                    initRegateFile({{
                        uniqueId: '{uniqueId}',
                        name: '{props.Name}',
                        value: '{props.Value}',
                        isRequired: {props.IsRequired.ToString().ToLower()},
                        uploaderUrl: '/Uploader/File',
                        repositoryUrl: '/repository/'
                    }});
                </script>
            ";
        }


        private class Props
        {
            public Props(string name)
            {
                Name = name;
            }

            public Props(string name, bool isRequired) : this(name)
            {
                IsRequired = isRequired;
            }

            public Props(string name, string value) : this(name)
            {
                Value = value;
            }

            public Props(string name, string value, bool isRequired) : this(name, value)
            {
                Value = value;
                IsRequired = isRequired;
            }

            public string Name { get; }
            public string Value { get; }
            public bool IsRequired { get; }
        }
    }

}
