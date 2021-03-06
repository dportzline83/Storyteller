﻿using HtmlTags;
using ST.Docs.Html;
using ST.Docs.Topics;

namespace ST.Docs.Transformation
{
    public class StylesheetTransformHandler : ITransformHandler
    {
        private readonly IUrlResolver _urls;

        public StylesheetTransformHandler(IUrlResolver urls)
        {
            _urls = urls;
        }

        public string Key
        {
            get { return "css"; }
        }
        public string Transform(Topic current, string data)
        {
            var url = _urls.ToUrl(current, data);

            return new HtmlTag("link")
                .Attr("href", url)
                .Attr("rel", "stylesheet")
                .Attr("type", "text/css")
                .ToString();
        }
    }
}