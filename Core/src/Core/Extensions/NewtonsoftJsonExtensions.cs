using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class NewtonsoftJsonExtensions
    {
        public static ActionResult ToJsonResult(this object obj, ReferenceLoopHandling HandleLoopReference = ReferenceLoopHandling.Error)
        {
            var content = new ContentResult();
            content.Content = JsonConvert.SerializeObject(obj, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, ReferenceLoopHandling = HandleLoopReference });
            content.ContentType = "application/json";
            return content;
        }
        public static string ToJsonString(this object obj, ReferenceLoopHandling HandleLoopReference = ReferenceLoopHandling.Error)
        {
            return JsonConvert.SerializeObject(obj, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, ReferenceLoopHandling = HandleLoopReference });
        }
    }
}
