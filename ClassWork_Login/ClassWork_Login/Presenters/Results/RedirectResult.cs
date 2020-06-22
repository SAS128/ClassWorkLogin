﻿namespace ClassWork_Login.Presenters.Results
{
    public class RedirectResult : IResult
    {
        private string url;

        public RedirectResult(string url)
        {
            this.url = url;
        }
        public string Url
        {
            get { return url; }
        }
    }
}