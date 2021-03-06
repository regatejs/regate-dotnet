﻿namespace Regate
{
    public static partial class RegateColor
    {
        public static string Init()
        {
            return $@"
                <script>{JavaScriptDependency()}</script>
                <style>{CssDependency()}</style>
                <script>{_GetJs()}</script>
            ";
        }

        public static string JavaScriptDependency()
        {
            var content = @"

! function(t, e) {
    ""object"" == typeof exports && ""object"" == typeof module ? module.exports = e() : ""function"" == typeof define && define.amd ? define([], e) : ""object"" == typeof exports ? exports.Pickr = e() : t.Pickr = e()
}(window, function() {
    return function(t) {
        var e = {};

        function n(o) {
            if (e[o]) return e[o].exports;
            var r = e[o] = {
                i: o,
                l: !1,
                exports: {}
            };
            return t[o].call(r.exports, r, r.exports, n), r.l = !0, r.exports
        }
        return n.m = t, n.c = e, n.d = function(t, e, o) {
            n.o(t, e) || Object.defineProperty(t, e, {
                enumerable: !0,
                get: o
            })
        }, n.r = function(t) {
            ""undefined"" != typeof Symbol && Symbol.toStringTag && Object.defineProperty(t, Symbol.toStringTag, {
                value: ""Module""
            }), Object.defineProperty(t, ""__esModule"", {
                value: !0
            })
        }, n.t = function(t, e) {
            if (1 & e && (t = n(t)), 8 & e) return t;
            if (4 & e && ""object"" == typeof t && t && t.__esModule) return t;
            var o = Object.create(null);
            if (n.r(o), Object.defineProperty(o, ""default"", {
                    enumerable: !0,
                    value: t
                }), 2 & e && ""string"" != typeof t)
                for (var r in t) n.d(o, r, function(e) {
                    return t[e]
                }.bind(null, r));
            return o
        }, n.n = function(t) {
            var e = t && t.__esModule ? function() {
                return t.default
            } : function() {
                return t
            };
            return n.d(e, ""a"", e), e
        }, n.o = function(t, e) {
            return Object.prototype.hasOwnProperty.call(t, e)
        }, n.p = ""dist/"", n(n.s = 1)
    }([function(t, e, n) {}, function(t, e, n) {
        ""use strict"";
        n.r(e);
        var o = {};
        n.r(o), n.d(o, ""once"", function() {
            return a
        }), n.d(o, ""on"", function() {
            return c
        }), n.d(o, ""off"", function() {
            return s
        }), n.d(o, ""createElementFromString"", function() {
            return l
        }), n.d(o, ""removeAttribute"", function() {
            return p
        }), n.d(o, ""createFromTemplate"", function() {
            return d
        }), n.d(o, ""eventPath"", function() {
            return h
        }), n.d(o, ""adjustableInputNumbers"", function() {
            return f
        });
        var r = {};
        n.r(r), n.d(r, ""hsvToRgb"", function() {
            return b
        }), n.d(r, ""hsvToHex"", function() {
            return _
        }), n.d(r, ""hsvToCmyk"", function() {
            return w
        }), n.d(r, ""hsvToHsl"", function() {
            return k
        }), n.d(r, ""parseToHSV"", function() {
            return j
        });
        n(0);

        function i(t, e, n) {
            return e in t ? Object.defineProperty(t, e, {
                value: n,
                enumerable: !0,
                configurable: !0,
                writable: !0
            }) : t[e] = n, t
        }
        var a = function(t, e, n, o) {
                return c(t, e, function t() {
                    n.apply(this, arguments), this.removeEventListener(e, t)
                }, o)
            },
            c = u.bind(null, ""addEventListener""),
            s = u.bind(null, ""removeEventListener"");

        function u(t, e, n, o) {
            var r = arguments.length > 4 && void 0 !== arguments[4] ? arguments[4] : {};
            return e instanceof HTMLCollection || e instanceof NodeList ? e = Array.from(e) : Array.isArray(e) || (e = [e]), Array.isArray(n) || (n = [n]), e.forEach(function(e) {
                return n.forEach(function(n) {
                    return e[t](n, o, function(t) {
                        for (var e = 1; e < arguments.length; e++) {
                            var n = null != arguments[e] ? arguments[e] : {},
                                o = Object.keys(n);
                            ""function"" == typeof Object.getOwnPropertySymbols && (o = o.concat(Object.getOwnPropertySymbols(n).filter(function(t) {
                                return Object.getOwnPropertyDescriptor(n, t).enumerable
                            }))), o.forEach(function(e) {
                                i(t, e, n[e])
                            })
                        }
                        return t
                    }({
                        capture: !1
                    }, r))
                })
            }), Array.prototype.slice.call(arguments, 1)
        }

        function l(t) {
            var e = document.createElement(""div"");
            return e.innerHTML = t.trim(), e.firstElementChild
        }

        function p(t, e) {
            var n = t.getAttribute(e);
            return t.removeAttribute(e), n
        }

        function d(t) {
            return function t(e) {
                var n = arguments.length > 1 && void 0 !== arguments[1] ? arguments[1] : {},
                    o = p(e, ""data-con""),
                    r = p(e, ""data-key"");
                r && (n[r] = e);
                for (var i = Array.from(e.children), a = o ? n[o] = {} : n, c = 0; c < i.length; c++) {
                    var s = i[c],
                        u = p(s, ""data-arr"");
                    u ? (a[u] || (a[u] = [])).push(s) : t(s, a)
                }
                return n
            }(l(t))
        }

        function h(t) {
            var e = t.path || t.composedPath && t.composedPath();
            if (e) return e;
            var n = t.target.parentElement;
            for (e = [t.target, n]; n = n.parentElement;) e.push(n);
            return e.push(document, window), e
        }

        function f(t) {
            var e = !(arguments.length > 1 && void 0 !== arguments[1]) || arguments[1],
                n = function(t) {
                    return t >= ""0"" && t <= ""9"" || ""-"" === t || ""."" === t
                };

            function o(o) {
                for (var r = t.value, i = t.selectionStart, a = i, c = """", s = i - 1; s > 0 && n(r[s]); s--) c = r[s] + c, a--;
                for (var u = i, l = r.length; u < l && n(r[u]); u++) c += r[u];
                if (c.length > 0 && !isNaN(c) && isFinite(c)) {
                    var p = o.deltaY < 0 ? 1 : -1,
                        d = o.ctrlKey ? 5 * p : p,
                        h = Number(c) + d;
                    !e && h < 0 && (h = 0);
                    var f = r.substr(0, a) + h + r.substring(a + c.length, r.length),
                        v = a + String(h).length;
                    t.value = f, t.focus(), t.setSelectionRange(v, v)
                }
                o.preventDefault(), t.dispatchEvent(new Event(""input""))
            }
            c(t, ""focus"", function() {
                return c(window, ""wheel"", o)
            }), c(t, ""blur"", function() {
                return s(window, ""wheel"", o)
            })
        }

        function v(t, e) {
            return function(t) {
                if (Array.isArray(t)) return t
            }(t) || function(t, e) {
                var n = [],
                    o = !0,
                    r = !1,
                    i = void 0;
                try {
                    for (var a, c = t[Symbol.iterator](); !(o = (a = c.next()).done) && (n.push(a.value), !e || n.length !== e); o = !0);
                } catch (t) {
                    r = !0, i = t
                } finally {
                    try {
                        o || null == c.return || c.return()
                    } finally {
                        if (r) throw i
                    }
                }
                return n
            }(t, e) || function() {
                throw new TypeError(""Invalid attempt to destructure non-iterable instance"")
            }()
        }

        function y(t) {
            return function(t) {
                if (Array.isArray(t)) {
                    for (var e = 0, n = new Array(t.length); e < t.length; e++) n[e] = t[e];
                    return n
                }
            }(t) || function(t) {
                if (Symbol.iterator in Object(t) || ""[object Arguments]"" === Object.prototype.toString.call(t)) return Array.from(t)
            }(t) || function() {
                throw new TypeError(""Invalid attempt to spread non-iterable instance"")
            }()
        }
        var g = Math.min,
            m = Math.max;

        function b(t, e, n) {
            t = t / 360 * 6, e /= 100, n /= 100;
            var o = Math.floor(t),
                r = t - o,
                i = n * (1 - e),
                a = n * (1 - r * e),
                c = n * (1 - (1 - r) * e),
                s = o % 6;
            return [255 * [n, a, i, i, c, n][s], 255 * [c, n, n, a, i, i][s], 255 * [i, i, c, n, n, a][s]]
        }

        function _(t, e, n) {
            return b(t, e, n).map(function(t) {
                return Math.round(t).toString(16).padStart(2, ""0"")
            })
        }

        function w(t, e, n) {
            var o, r = b(t, e, n),
                i = r[0] / 255,
                a = r[1] / 255,
                c = r[2] / 255;
            return [100 * (1 === (o = g(1 - i, 1 - a, 1 - c)) ? 0 : (1 - i - o) / (1 - o)), 100 * (1 === o ? 0 : (1 - a - o) / (1 - o)), 100 * (1 === o ? 0 : (1 - c - o) / (1 - o)), 100 * o]
        }

        function k(t, e, n) {
            var o = (2 - (e /= 100)) * (n /= 100) / 2;
            return 0 !== o && (e = 1 === o ? 0 : o < .5 ? e * n / (2 * o) : e * n / (2 - 2 * o)), [t, 100 * e, 100 * o]
        }

        function A(t, e, n) {
            var o, r, i, a = g(t /= 255, e /= 255, n /= 255),
                c = m(t, e, n),
                s = c - a;
            if (i = c, 0 === s) o = r = 0;
            else {
                r = s / c;
                var u = ((c - t) / 6 + s / 2) / s,
                    l = ((c - e) / 6 + s / 2) / s,
                    p = ((c - n) / 6 + s / 2) / s;
                t === c ? o = p - l : e === c ? o = 1 / 3 + u - p : n === c && (o = 2 / 3 + l - u), o < 0 ? o += 1 : o > 1 && (o -= 1)
            }
            return [360 * o, 100 * r, 100 * i]
        }

        function C(t, e, n, o) {
            return e /= 100, n /= 100, y(A(255 * (1 - g(1, (t /= 100) * (1 - (o /= 100)) + o)), 255 * (1 - g(1, e * (1 - o) + o)), 255 * (1 - g(1, n * (1 - o) + o))))
        }

        function S(t, e, n) {
            return e /= 100, [t, 2 * (e *= (n /= 100) < .5 ? n : 1 - n) / (n + e) * 100, 100 * (n + e)]
        }

        function O(t) {
            return A.apply(void 0, y(t.match(/.{2}/g).map(function(t) {
                return parseInt(t, 16)
            })))
        }

        function j(t) {
            var e, n = {
                    cmyk: /^cmyk[\D]+(\d+)[\D]+(\d+)[\D]+(\d+)[\D]+(\d+)/i,
                    rgba: /^(rgb|rgba)[\D]+(\d+)[\D]+(\d+)[\D]+(\d+)[\D]*?([\d.]+|$)/i,
                    hsla: /^(hsl|hsla)[\D]+(\d+)[\D]+(\d+)[\D]+(\d+)[\D]*?([\d.]+|$)/i,
                    hsva: /^(hsv|hsva)[\D]+(\d+)[\D]+(\d+)[\D]+(\d+)[\D]*?([\d.]+|$)/i,
                    hex: /^#?(([\dA-Fa-f]{3,4})|([\dA-Fa-f]{6})|([\dA-Fa-f]{8}))$/i
                },
                o = function(t) {
                    return t.map(function(t) {
                        return /^(|\d+)\.\d+|\d+$/.test(t) ? Number(t) : void 0
                    })
                };
            for (var r in n)
                if (e = n[r].exec(t)) switch (r) {
                    case ""cmyk"":
                        var i = v(o(e), 5),
                            a = i[1],
                            c = i[2],
                            s = i[3],
                            u = i[4];
                        if (a > 100 || c > 100 || s > 100 || u > 100) break;
                        return {
                            values: y(C(a, c, s, u)).concat([1]),
                            type: r
                        };
                    case ""rgba"":
                        var l = v(o(e), 6),
                            p = l[2],
                            d = l[3],
                            h = l[4],
                            f = l[5],
                            g = void 0 === f ? 1 : f;
                        if (p > 255 || d > 255 || h > 255 || g < 0 || g > 1) break;
                        return {
                            values: y(A(p, d, h)).concat([g]),
                            type: r
                        };
                    case ""hex"":
                        var m = function(t, e) {
                                return [t.substring(0, e), t.substring(e, t.length)]
                            },
                            b = v(e, 2)[1];
                        3 === b.length ? b += ""F"" : 6 === b.length && (b += ""FF"");
                        var _ = void 0;
                        if (4 === b.length) {
                            var w = v(m(b, 3).map(function(t) {
                                return t + t
                            }), 2);
                            b = w[0], _ = w[1]
                        } else if (8 === b.length) {
                            var k = v(m(b, 6), 2);
                            b = k[0], _ = k[1]
                        }
                        return _ = parseInt(_, 16) / 255, {
                            values: y(O(b)).concat([_]),
                            type: r
                        };
                    case ""hsla"":
                        var j = v(o(e), 6),
                            x = j[2],
                            E = j[3],
                            H = j[4],
                            R = j[5],
                            B = void 0 === R ? 1 : R;
                        if (x > 360 || E > 100 || H > 100 || B < 0 || B > 1) break;
                        return {
                            values: y(S(x, E, H)).concat([B]),
                            type: r
                        };
                    case ""hsva"":
                        var P = v(o(e), 6),
                            L = P[2],
                            D = P[3],
                            T = P[4],
                            F = P[5],
                            M = void 0 === F ? 1 : F;
                        if (L > 360 || D > 100 || T > 100 || M < 0 || M > 1) break;
                        return {
                            values: [L, D, T, M],
                            type: r
                        }
                }
                return {
                    values: null,
                    type: null
                }
        }

        function x() {
            var t = arguments.length > 0 && void 0 !== arguments[0] ? arguments[0] : 0,
                e = arguments.length > 1 && void 0 !== arguments[1] ? arguments[1] : 0,
                n = arguments.length > 2 && void 0 !== arguments[2] ? arguments[2] : 0,
                o = arguments.length > 3 && void 0 !== arguments[3] ? arguments[3] : 1,
                i = Math.ceil,
                a = {
                    h: t,
                    s: e,
                    v: n,
                    a: o,
                    toHSVA: function() {
                        var t = [a.h, a.s, a.v],
                            e = t.map(i);
                        return t.toString = function() {
                            return ""hsva("".concat(e[0], "", "").concat(e[1], ""%, "").concat(e[2], ""%, "").concat(a.a.toFixed(1), "")"")
                        }, t
                    },
                    toHSLA: function() {
                        var t = k(a.h, a.s, a.v),
                            e = t.map(i);
                        return t.toString = function() {
                            return ""hsla("".concat(e[0], "", "").concat(e[1], ""%, "").concat(e[2], ""%, "").concat(a.a.toFixed(1), "")"")
                        }, t
                    },
                    toRGBA: function() {
                        var t = b(a.h, a.s, a.v),
                            e = t.map(i);
                        return t.toString = function() {
                            return ""rgba("".concat(e[0], "", "").concat(e[1], "", "").concat(e[2], "", "").concat(a.a.toFixed(1), "")"")
                        }, t
                    },
                    toCMYK: function() {
                        var t = w(a.h, a.s, a.v),
                            e = t.map(i);
                        return t.toString = function() {
                            return ""cmyk("".concat(e[0], ""%, "").concat(e[1], ""%, "").concat(e[2], ""%, "").concat(e[3], ""%)"")
                        }, t
                    },
                    toHEX: function() {
                        var t = _.apply(r, [a.h, a.s, a.v]);
                        return t.toString = function() {
                            var e = a.a >= 1 ? """" : Number((255 * a.a).toFixed(0)).toString(16).toUpperCase().padStart(2, ""0"");
                            return ""#"".concat(t.join("""").toUpperCase() + e)
                        }, t
                    },
                    clone: function() {
                        return x(a.h, a.s, a.v, a.a)
                    }
                };
            return a
        }

        function E(t) {
            var e = {
                options: Object.assign({
                    lockX: !1,
                    lockY: !1,
                    onchange: function() {
                        return 0
                    }
                }, t),
                _tapstart: function(t) {
                    c(document, [""mouseup"", ""touchend"", ""touchcancel""], e._tapstop), c(document, [""mousemove"", ""touchmove""], e._tapmove), t.preventDefault(), e.wrapperRect = e.options.wrapper.getBoundingClientRect(), e._tapmove(t)
                },
                _tapmove: function(t) {
                    var n = e.options,
                        o = e.cache,
                        r = n.element,
                        i = e.wrapperRect,
                        a = 0,
                        c = 0;
                    if (t) {
                        var s = t && t.touches && t.touches[0];
                        a = t ? (s || t).clientX : 0, c = t ? (s || t).clientY : 0, a < i.left ? a = i.left : a > i.left + i.width && (a = i.left + i.width), c < i.top ? c = i.top : c > i.top + i.height && (c = i.top + i.height), a -= i.left, c -= i.top
                    } else o && (a = o.x, c = o.y);
                    n.lockX || (r.style.left = a - r.offsetWidth / 2 + ""px""), n.lockY || (r.style.top = c - r.offsetHeight / 2 + ""px""), e.cache = {
                        x: a,
                        y: c
                    }, n.onchange(a, c)
                },
                _tapstop: function() {
                    s(document, [""mouseup"", ""touchend"", ""touchcancel""], e._tapstop), s(document, [""mousemove"", ""touchmove""], e._tapmove)
                },
                trigger: function() {
                    e.wrapperRect = e.options.wrapper.getBoundingClientRect(), e._tapmove()
                },
                update: function() {
                    var t = arguments.length > 0 && void 0 !== arguments[0] ? arguments[0] : 0,
                        n = arguments.length > 1 && void 0 !== arguments[1] ? arguments[1] : 0;
                    e.wrapperRect = e.options.wrapper.getBoundingClientRect(), e._tapmove({
                        clientX: e.wrapperRect.left + t,
                        clientY: e.wrapperRect.top + n
                    })
                },
                destroy: function() {
                    var t = e.options,
                        n = e._tapstart;
                    s([t.wrapper, t.element], ""mousedown"", n), s([t.wrapper, t.element], ""touchstart"", n, {
                        passive: !1
                    })
                }
            };
            e.wrapperRect = e.options.wrapper.getBoundingClientRect();
            var n = e.options,
                o = e._tapstart;
            return c([n.wrapper, n.element], ""mousedown"", o), c([n.wrapper, n.element], ""touchstart"", o, {
                passive: !1
            }), e
        }

        function H(t) {
            return function(t) {
                if (Array.isArray(t)) {
                    for (var e = 0, n = new Array(t.length); e < t.length; e++) n[e] = t[e];
                    return n
                }
            }(t) || function(t) {
                if (Symbol.iterator in Object(t) || ""[object Arguments]"" === Object.prototype.toString.call(t)) return Array.from(t)
            }(t) || function() {
                throw new TypeError(""Invalid attempt to spread non-iterable instance"")
            }()
        }

        function R(t, e) {
            for (var n = 0; n < e.length; n++) {
                var o = e[n];
                o.enumerable = o.enumerable || !1, o.configurable = !0, ""value"" in o && (o.writable = !0), Object.defineProperty(t, o.key, o)
            }
        }
        var B = function() {
            function t(e) {
                ! function(t, e) {
                    if (!(t instanceof e)) throw new TypeError(""Cannot call a class as a function"")
                }(this, t), this.options = Object.assign({
                    useAsButton: !1,
                    disabled: !1,
                    comparison: !0,
                    components: {
                        interaction: {}
                    },
                    strings: {},
                    default: ""fff"",
                    defaultRepresentation: ""HEX"",
                    position: ""middle"",
                    adjustableNumbers: !0,
                    showAlways: !1,
                    parent: void 0,
                    closeWithKey: ""Escape"",
                    onChange: function() {
                        return 0
                    },
                    onSave: function() {
                        return 0
                    },
                    onClear: function() {
                        return 0
                    }
                }, e), this.options.components.interaction || (this.options.components.interaction = {}), this._initializingActive = !0, this._recalc = !0, this._color = new x, this._lastColor = new x, this._preBuild(), this._buildComponents(), this._bindEvents(), this.setColor(this.options.default), this._representation = this.options.defaultRepresentation, this.setColorRepresentation(this._representation), this._initializingActive = !1, this._finalBuild(), this._rePositioningPicker()
            }
            return function(t, e, n) {
                e && R(t.prototype, e), n && R(t, n)
            }(t, [{
                key: ""_preBuild"",
                value: function() {
                    var t = this.options;
                    ""string"" == typeof t.el && (t.el = document.querySelector(t.el)), this._root = function(t) {
                        var e = t.components,
                            n = t.strings,
                            o = t.useAsButton,
                            r = function(t) {
                                return t ? """" : 'style=""display:none"" hidden'
                            },
                            i = d('\n        <div data-key=""root"" class=""pickr"">\n        \n            '.concat(o ? """" : '<div data-key=""button"" class=""pcr-button""></div>', '\n\n            <div data-key=""app"" class=""pcr-app"">\n                <div class=""pcr-selection"">\n                    <div data-con=""preview"" class=""pcr-color-preview"" ').concat(r(e.preview), '>\n                        <div data-key=""lastColor"" class=""pcr-last-color""></div>\n                        <div data-key=""currentColor"" class=""pcr-current-color""></div>\n                    </div>\n\n                    <div data-con=""palette"" class=""pcr-color-palette"">\n                        <div data-key=""picker"" class=""pcr-picker""></div>\n                        <div data-key=""palette"" class=""pcr-palette""></div>\n                    </div>\n\n                    <div data-con=""hue"" class=""pcr-color-chooser"" ').concat(r(e.hue), '>\n                        <div data-key=""picker"" class=""pcr-picker""></div>\n                        <div data-key=""slider"" class=""pcr-hue pcr-slider""></div>\n                    </div>\n\n                    <div data-con=""opacity"" class=""pcr-color-opacity"" ').concat(r(e.opacity), '>\n                        <div data-key=""picker"" class=""pcr-picker""></div>\n                        <div data-key=""slider"" class=""pcr-opacity pcr-slider""></div>\n                    </div>\n                </div>\n\n                <div data-con=""interaction"" class=""pcr-interaction"" ').concat(r(Object.keys(e.interaction).length), '>\n                    <input data-key=""result"" class=""pcr-result"" type=""text"" spellcheck=""false"" ').concat(r(e.interaction.input), '>\n\n                    <input data-arr=""options"" class=""pcr-type"" data-type=""HEX"" value=""HEX"" type=""button"" ').concat(r(e.interaction.hex), '>\n                    <input data-arr=""options"" class=""pcr-type"" data-type=""RGBA"" value=""RGBa"" type=""button"" ').concat(r(e.interaction.rgba), '>\n                    <input data-arr=""options"" class=""pcr-type"" data-type=""HSLA"" value=""HSLa"" type=""button"" ').concat(r(e.interaction.hsla), '>\n                    <input data-arr=""options"" class=""pcr-type"" data-type=""HSVA"" value=""HSVa"" type=""button"" ').concat(r(e.interaction.hsva), '>\n                    <input data-arr=""options"" class=""pcr-type"" data-type=""CMYK"" value=""CMYK"" type=""button"" ').concat(r(e.interaction.cmyk), '>\n\n                    <input data-key=""save"" class=""pcr-save"" value=""').concat(n.save || ""Save"", '"" type=""button"" ').concat(r(e.interaction.save), '>\n                    <input data-key=""clear"" class=""pcr-clear"" value=""').concat(n.clear || ""Clear"", '"" type=""button"" ').concat(r(e.interaction.clear), "">\n                </div>\n            </div>\n        </div>\n    "")),
                            a = i.interaction;
                        return a.options.find(function(t) {
                            return !t.hidden && !t.classList.add(""active"")
                        }), a.type = function() {
                            return a.options.find(function(t) {
                                return t.classList.contains(""active"")
                            })
                        }, i
                    }(t), t.useAsButton && (t.parent || (t.parent = ""body""), this._root.button = t.el), document.body.appendChild(this._root.root)
                }
            }, {
                key: ""_finalBuild"",
                value: function() {
                    var t = this.options,
                        e = this._root;
                    document.body.removeChild(e.root), t.parent && (""string"" == typeof t.parent && (t.parent = document.querySelector(t.parent)), t.parent.appendChild(e.app)), t.useAsButton || t.el.parentElement.replaceChild(e.root, t.el), t.disabled && this.disable(), t.comparison || (e.button.style.transition = ""none"", t.useAsButton || (e.preview.lastColor.style.transition = ""none"")), t.showAlways ? e.app.classList.add(""visible"") : this.hide()
                }
            }, {
                key: ""_buildComponents"",
                value: function() {
                    var t = this,
                        e = this.options.components,
                        n = {
                            palette: E({
                                element: t._root.palette.picker,
                                wrapper: t._root.palette.palette,
                                onchange: function(e, n) {
                                    var o = t._color,
                                        r = t._root,
                                        i = t.options;
                                    o.s = e / this.wrapper.offsetWidth * 100, o.v = 100 - n / this.wrapper.offsetHeight * 100, o.v < 0 && (o.v = 0);
                                    var a = o.toRGBA().toString();
                                    this.element.style.background = a, this.wrapper.style.background = ""\n                        linear-gradient(to top, rgba(0, 0, 0, "".concat(o.a, ""), transparent), \n                        linear-gradient(to left, hsla("").concat(o.h, "", 100%, 50%, "").concat(o.a, ""), rgba(255, 255, 255, "").concat(o.a, ""))\n                    ""), i.comparison || (r.button.style.background = a, i.useAsButton || (r.preview.lastColor.style.background = a)), r.preview.currentColor.style.background = a, t._recalc && t._updateOutput(), r.button.classList.remove(""clear"")
                                }
                            }),
                            hue: E({
                                lockX: !0,
                                element: t._root.hue.picker,
                                wrapper: t._root.hue.slider,
                                onchange: function(o, r) {
                                    e.hue && (t._color.h = r / this.wrapper.offsetHeight * 360, this.element.style.backgroundColor = ""hsl("".concat(t._color.h, "", 100%, 50%)""), n.palette.trigger())
                                }
                            }),
                            opacity: E({
                                lockX: !0,
                                element: t._root.opacity.picker,
                                wrapper: t._root.opacity.slider,
                                onchange: function(n, o) {
                                    e.opacity && (t._color.a = Math.round(o / this.wrapper.offsetHeight * 100) / 100, this.element.style.background = ""rgba(0, 0, 0, "".concat(t._color.a, "")""), t.components.palette.trigger())
                                }
                            }),
                            selectable: function() {
                                var t = arguments.length > 0 && void 0 !== arguments[0] ? arguments[0] : {},
                                    e = {
                                        options: Object.assign({
                                            onchange: function() {
                                                return 0
                                            },
                                            className: """",
                                            elements: []
                                        }, t),
                                        _ontap: function(t) {
                                            var n = e.options;
                                            n.elements.forEach(function(e) {
                                                return e.classList[t.target === e ? ""add"" : ""remove""](n.className)
                                            }), n.onchange(t)
                                        },
                                        destroy: function() {
                                            s(e.options.elements, ""click"", this._ontap)
                                        }
                                    };
                                return c(e.options.elements, ""click"", e._ontap), e
                            }({
                                elements: t._root.interaction.options,
                                className: ""active"",
                                onchange: function(e) {
                                    t._representation = e.target.getAttribute(""data-type"").toUpperCase(), t._updateOutput()
                                }
                            })
                        };
                    this.components = n
                }
            }, {
                key: ""_bindEvents"",
                value: function() {
                    var t = this,
                        e = this._root,
                        n = this.options,
                        o = [c(e.interaction.clear, ""click"", function() {
                            return t._clearColor()
                        }), c(e.preview.lastColor, ""click"", function() {
                            return t.setHSVA.apply(t, H(t._lastColor.toHSVA()))
                        }), c(e.interaction.save, ""click"", function() {
                            !t._saveColor() && !n.showAlways && t.hide()
                        }), c(e.interaction.result, [""keyup"", ""input""], function(e) {
                            t._recalc = !1, t.setColor(e.target.value, !0) && !t._initializingActive && t.options.onChange(t._color, t), e.stopImmediatePropagation()
                        }), c([e.palette.palette, e.palette.picker, e.hue.slider, e.hue.picker, e.opacity.slider, e.opacity.picker], [""mousedown"", ""touchstart""], function() {
                            return t._recalc = !0
                        }), c(window, ""resize"", function() {
                            return t._rePositioningPicker
                        })];
                    if (!n.showAlways) {
                        o.push(c(e.button, ""click"", function() {
                            return t.isOpen() ? t.hide() : t.show()
                        }));
                        var r = n.closeWithKey;
                        o.push(c(document, ""keyup"", function(e) {
                            return t.isOpen() && (e.key === r || e.code === r) && t.hide()
                        })), o.push(c(document, [""touchstart"", ""mousedown""], function(n) {
                            t.isOpen() && !h(n).some(function(t) {
                                return t === e.app || t === e.button
                            }) && t.hide()
                        }, {
                            capture: !0
                        }))
                    }
                    n.adjustableNumbers && f(e.interaction.result, !1), this._eventBindings = o
                }
            }, {
                key: ""_rePositioningPicker"",
                value: function() {
                    var t = this._root,
                        e = this._root.app;
                    if (this.options.parent) {
                        var n = t.button.getBoundingClientRect();
                        e.style.position = ""fixed"", e.style.marginLeft = """".concat(n.left, ""px""), e.style.marginTop = """".concat(n.top, ""px"")
                    }
                    var o = t.button.getBoundingClientRect(),
                        r = e.getBoundingClientRect(),
                        i = e.style;
                    r.bottom > window.innerHeight ? i.top = """".concat(-r.height - 5, ""px"") : o.bottom + r.height < window.innerHeight && (i.top = """".concat(o.height + 5, ""px""));
                    var a = {
                            left: -r.width + o.width,
                            middle: -r.width / 2 + o.width / 2,
                            right: 0
                        },
                        c = parseInt(getComputedStyle(e).left, 10),
                        s = a[this.options.position],
                        u = r.left - c + s,
                        l = r.left - c + s + r.width;
                    ""middle"" !== this.options.position && (u < 0 && -u < r.width / 2 || l > window.innerWidth && l - window.innerWidth < r.width / 2) ? s = a.middle : u < 0 ? s = a.right : l > window.innerWidth && (s = a.left), i.left = """".concat(s, ""px"")
                }
            }, {
                key: ""_updateOutput"",
                value: function() {
                    var t = this;
                    this._root.interaction.type() && (this._root.interaction.result.value = function() {
                        var e = ""to"" + t._root.interaction.type().getAttribute(""data-type"");
                        return ""function"" == typeof t._color[e] ? t._color[e]().toString() : """"
                    }()), this._initializingActive || this.options.onChange(this._color, this)
                }
            }, {
                key: ""_saveColor"",
                value: function() {
                    var t = this._root,
                        e = t.preview,
                        n = t.button,
                        o = this._color.toRGBA().toString();
                    e.lastColor.style.background = o, this.options.useAsButton || (n.style.background = o), n.classList.remove(""clear""), this._lastColor = this._color.clone(), this._initializingActive || this.options.onSave(this._color, this)
                }
            }, {
                key: ""_clearColor"",
                value: function() {
                    var t = this._root,
                        e = this.options;
                    e.useAsButton || (t.button.style.background = ""rgba(255, 255, 255, 0.4)""), t.button.classList.add(""clear""), e.showAlways || this.hide(), e.onSave(null, this)
                }
            }, {
                key: ""destroy"",
                value: function() {
                    var t = this;
                    this._eventBindings.forEach(function(t) {
                        return s.apply(o, H(t))
                    }), Object.keys(this.components).forEach(function(e) {
                        return t.components[e].destroy()
                    })
                }
            }, {
                key: ""destroyAndRemove"",
                value: function() {
                    this.destroy();
                    var t = this._root.root;
                    t.parentElement.removeChild(t)
                }
            }, {
                key: ""hide"",
                value: function() {
                    return this._root.app.classList.remove(""visible""), this
                }
            }, {
                key: ""show"",
                value: function() {
                    if (!this.options.disabled) return this._root.app.classList.add(""visible""), this._rePositioningPicker(), this
                }
            }, {
                key: ""isOpen"",
                value: function() {
                    return this._root.app.classList.contains(""visible"")
                }
            }, {
                key: ""setHSVA"",
                value: function() {
                    var t = arguments.length > 0 && void 0 !== arguments[0] ? arguments[0] : 360,
                        e = arguments.length > 1 && void 0 !== arguments[1] ? arguments[1] : 0,
                        n = arguments.length > 2 && void 0 !== arguments[2] ? arguments[2] : 0,
                        o = arguments.length > 3 && void 0 !== arguments[3] ? arguments[3] : 1,
                        r = arguments.length > 4 && void 0 !== arguments[4] && arguments[4],
                        i = this._recalc;
                    if (this._recalc = !1, t < 0 || t > 360 || e < 0 || e > 100 || n < 0 || n > 100 || o < 0 || o > 1) return !1;
                    var a = this.components,
                        c = a.hue,
                        s = a.opacity,
                        u = a.palette,
                        l = c.options.wrapper.offsetHeight * (t / 360);
                    c.update(0, l);
                    var p = s.options.wrapper.offsetHeight * o;
                    s.update(0, p);
                    var d = u.options.wrapper,
                        h = d.offsetWidth * (e / 100),
                        f = d.offsetHeight * (1 - n / 100);
                    return u.update(h, f), this._color = new x(t, e, n, o), this._recalc = i, this._recalc && this._updateOutput(), r || this._saveColor(), !0
                }
            }, {
                key: ""setColor"",
                value: function(t) {
                    var e = arguments.length > 1 && void 0 !== arguments[1] && arguments[1];
                    if (null === t) return this._clearColor(), !0;
                    var n = j(t),
                        o = n.values,
                        r = n.type;
                    if (o) {
                        var i = r.toUpperCase(),
                            a = this._root.interaction.options,
                            c = a.find(function(t) {
                                return t.getAttribute(""data-type"") === i
                            });
                        if (!c.hidden) {
                            var s = !0,
                                u = !1,
                                l = void 0;
                            try {
                                for (var p, d = a[Symbol.iterator](); !(s = (p = d.next()).done); s = !0) {
                                    var h = p.value;
                                    h.classList[h === c ? ""add"" : ""remove""](""active"")
                                }
                            } catch (t) {
                                u = !0, l = t
                            } finally {
                                try {
                                    s || null == d.return || d.return()
                                } finally {
                                    if (u) throw l
                                }
                            }
                        }
                        return this.setHSVA.apply(this, H(o).concat([e]))
                    }
                }
            }, {
                key: ""setColorRepresentation"",
                value: function(t) {
                    return t = t.toUpperCase(), !!this._root.interaction.options.find(function(e) {
                        return e.getAttribute(""data-type"") === t && !e.click()
                    })
                }
            }, {
                key: ""getColorRepresentation"",
                value: function() {
                    return this._representation
                }
            }, {
                key: ""getColor"",
                value: function() {
                    return this._color
                }
            }, {
                key: ""getRoot"",
                value: function() {
                    return this._root
                }
            }, {
                key: ""disable"",
                value: function() {
                    return this.hide(), this.options.disabled = !0, this._root.button.classList.add(""disabled""), this
                }
            }, {
                key: ""enable"",
                value: function() {
                    return this.options.disabled = !1, this._root.button.classList.remove(""disabled""), this
                }
            }]), t
        }();
        B.utils = {
            once: a,
            on: c,
            off: s,
            eventPath: h,
            createElementFromString: l,
            adjustableInputNumbers: f,
            removeAttribute: p,
            createFromTemplate: d
        }, B.create = function(t) {
            return new B(t)
        }, B.version = ""0.3.2"";
        e.default = B
    }]).default
});

            ";
            return content;
        }

        public static string CssDependency()
        {
            var content = @"

.pickr{position:relative;overflow:visible;z-index:1}
.pickr *{box-sizing:border-box}
.pickr .pcr-button{position:relative;height:2em;width:2em;padding:.5em;border-radius:.15em;cursor:pointer;background:transparent;transition:background-color .3s;font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Helvetica Neue,Arial,sans-serif}
.pickr .pcr-button:before{background:url('data:image/svg+xml;utf8, <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 2 2""><path fill=""white"" d=""M1,0H2V1H1V0ZM0,1H1V2H0V1Z""/><path fill=""gray"" d=""M0,0H1V1H0V0ZM1,1H2V2H1V1Z""/></svg>');background-size:.5em;border-radius:.15em;z-index:-1}
.pickr .pcr-button:after,.pickr .pcr-button:before{position:absolute;content:"""";top:0;left:0;width:100%;height:100%}
.pickr .pcr-button:after{background:url('data:image/svg+xml;utf8, <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 50 50"" stroke=""%2342445A"" stroke-width=""5px"" stroke-linecap=""round""><path d=""M45,45L5,5""></path><path d=""M45,5L5,45""></path></svg>') no-repeat 50%;background-size:70%;opacity:0}
.pickr .pcr-button.clear:after{opacity:1}
.pickr .pcr-button.disabled{cursor:not-allowed}
.pcr-app{position:absolute;display:flex;flex-direction:column;z-index:10000;font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Helvetica Neue,Arial,sans-serif;box-shadow:0 .2em 1.5em 0 rgba(0,0,0,.1),0 0 1em 0 rgba(0,0,0,.02);top:5px;height:15em;width:28em;max-width:95vw;padding:.8em;border-radius:.1em;background:#fff;opacity:0;visibility:hidden;transition:opacity .3s}
.pcr-app.visible{visibility:visible;opacity:1}
.pcr-app .pcr-interaction{display:flex;align-items:center;margin:1em -.2em 0}
.pcr-app .pcr-interaction>*{margin:0 .2em}
.pcr-app .pcr-interaction input{padding:.5em .6em;border:none;outline:none;letter-spacing:.07em;font-size:.75em;text-align:center;cursor:pointer;color:#c4c4c4;background:#f8f8f8;border-radius:.15em;transition:all .15s}
.pcr-app .pcr-interaction input:hover{color:grey}
.pcr-app .pcr-interaction .pcr-result{color:grey;text-align:left;flex-grow:1;min-width:1em;transition:all .2s;border-radius:.15em;background:#f8f8f8;cursor:text;padding-left:.8em}
.pcr-app .pcr-interaction .pcr-result:focus{color:#4285f4}
.pcr-app .pcr-interaction .pcr-result::selection{background:#4285f4;color:#fff}
.pcr-app .pcr-interaction .pcr-type.active{color:#fff;background:#4285f4}
.pcr-app .pcr-interaction .pcr-clear,.pcr-app .pcr-interaction .pcr-save{color:#fff;width:auto}
.pcr-app .pcr-interaction .pcr-save{background:#4285f4}
.pcr-app .pcr-interaction .pcr-save:hover{background:#4370f4;color:#fff}
.pcr-app .pcr-interaction .pcr-clear{background:#f44250}
.pcr-app .pcr-interaction .pcr-clear:hover{background:#db3d49;color:#fff}
.pcr-app .pcr-selection{display:flex;justify-content:space-between;flex-grow:1}
.pcr-app .pcr-selection .pcr-picker{position:absolute;height:18px;width:18px;border:2px solid #fff;border-radius:100%;user-select:none;cursor:-moz-grab;cursor:-webkit-grabbing}
.pcr-app .pcr-selection .pcr-color-preview{position:relative;z-index:1;width:2em;display:flex;flex-direction:column;justify-content:space-between;margin-right:.75em}
.pcr-app .pcr-selection .pcr-color-preview:before{position:absolute;content:"""";top:0;left:0;width:100%;height:100%;background:url('data:image/svg+xml;utf8, <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 2 2""><path fill=""white"" d=""M1,0H2V1H1V0ZM0,1H1V2H0V1Z""/><path fill=""gray"" d=""M0,0H1V1H0V0ZM1,1H2V2H1V1Z""/></svg>');background-size:.5em;border-radius:.15em;z-index:-1}
.pcr-app .pcr-selection .pcr-color-preview .pcr-last-color{cursor:pointer;transition:background-color .3s;border-radius:.15em .15em 0 0}
.pcr-app .pcr-selection .pcr-color-preview .pcr-current-color{border-radius:0 0 .15em .15em}
.pcr-app .pcr-selection .pcr-color-preview .pcr-current-color,.pcr-app .pcr-selection .pcr-color-preview .pcr-last-color{background:transparent;width:100%;height:50%}
.pcr-app .pcr-selection .pcr-color-chooser,.pcr-app .pcr-selection .pcr-color-opacity,.pcr-app .pcr-selection .pcr-color-palette{position:relative;user-select:none;display:flex;flex-direction:column}
.pcr-app .pcr-selection .pcr-color-palette{width:100%;z-index:1}
.pcr-app .pcr-selection .pcr-color-palette .pcr-palette{height:100%;border-radius:.15em}
.pcr-app .pcr-selection .pcr-color-palette .pcr-palette:before{position:absolute;content:"""";top:0;left:0;width:100%;height:100%;background:url('data:image/svg+xml;utf8, <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 2 2""><path fill=""white"" d=""M1,0H2V1H1V0ZM0,1H1V2H0V1Z""/><path fill=""gray"" d=""M0,0H1V1H0V0ZM1,1H2V2H1V1Z""/></svg>');background-size:.5em;border-radius:.15em;z-index:-1}
.pcr-app .pcr-selection .pcr-color-chooser,.pcr-app .pcr-selection .pcr-color-opacity{margin-left:.75em}
.pcr-app .pcr-selection .pcr-color-chooser .pcr-picker,.pcr-app .pcr-selection .pcr-color-opacity .pcr-picker{left:50%;transform:translateX(-50%)}
.pcr-app .pcr-selection .pcr-color-chooser .pcr-slider,.pcr-app .pcr-selection .pcr-color-opacity .pcr-slider{width:8px;height:100%;border-radius:50em}
.pcr-app .pcr-selection .pcr-color-chooser .pcr-slider{background:linear-gradient(180deg,red,#ff0,#0f0,#0ff,#00f,#f0f,red)}
.pcr-app .pcr-selection .pcr-color-opacity .pcr-slider{background:linear-gradient(180deg,transparent,#000),url('data:image/svg+xml;utf8, <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 2 2""><path fill=""white"" d=""M1,0H2V1H1V0ZM0,1H1V2H0V1Z""/><path fill=""gray"" d=""M0,0H1V1H0V0ZM1,1H2V2H1V1Z""/></svg>');background-size:100%,50%}


            ";

            return content;
        }
    }
}
  