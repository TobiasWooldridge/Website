// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Daniel15.Web.Controllers
{
    public partial class BlogController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected BlogController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Category()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Category);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Tag()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Tag);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Archive()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Archive);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult View()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.View);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult ShortUrl()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ShortUrl);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public BlogController Actions { get { return MVC.Blog; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Blog";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Blog";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Category = "Category";
            public readonly string Tag = "Tag";
            public readonly string Archive = "Archive";
            public readonly string View = "View";
            public readonly string ShortUrl = "ShortUrl";
            public readonly string Feed = "Feed";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Category = "Category";
            public const string Tag = "Tag";
            public const string Archive = "Archive";
            public const string View = "View";
            public const string ShortUrl = "ShortUrl";
            public const string Feed = "Feed";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string page = "page";
        }
        static readonly ActionParamsClass_Category s_params_Category = new ActionParamsClass_Category();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Category CategoryParams { get { return s_params_Category; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Category
        {
            public readonly string slug = "slug";
            public readonly string page = "page";
        }
        static readonly ActionParamsClass_Tag s_params_Tag = new ActionParamsClass_Tag();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Tag TagParams { get { return s_params_Tag; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Tag
        {
            public readonly string slug = "slug";
            public readonly string page = "page";
        }
        static readonly ActionParamsClass_Archive s_params_Archive = new ActionParamsClass_Archive();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Archive ArchiveParams { get { return s_params_Archive; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Archive
        {
            public readonly string year = "year";
            public readonly string month = "month";
            public readonly string page = "page";
        }
        static readonly ActionParamsClass_View s_params_View = new ActionParamsClass_View();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_View ViewParams { get { return s_params_View; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_View
        {
            public readonly string month = "month";
            public readonly string year = "year";
            public readonly string slug = "slug";
        }
        static readonly ActionParamsClass_ShortUrl s_params_ShortUrl = new ActionParamsClass_ShortUrl();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ShortUrl ShortUrlParams { get { return s_params_ShortUrl; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ShortUrl
        {
            public readonly string alias = "alias";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _Comments = "_Comments";
                public readonly string _DisqusCount = "_DisqusCount";
                public readonly string _Layout = "_Layout";
                public readonly string _PostBrief = "_PostBrief";
                public readonly string _PostFull = "_PostFull";
                public readonly string _PostHeader = "_PostHeader";
                public readonly string _Posts = "_Posts";
                public readonly string _ShareLinks = "_ShareLinks";
                public readonly string _ViewStart = "_ViewStart";
                public readonly string Category = "Category";
                public readonly string Feed = "Feed";
                public readonly string Index = "Index";
                public readonly string Tag = "Tag";
                public readonly string View = "View";
            }
            public readonly string _Comments = "~/Views/Blog/_Comments.cshtml";
            public readonly string _DisqusCount = "~/Views/Blog/_DisqusCount.cshtml";
            public readonly string _Layout = "~/Views/Blog/_Layout.cshtml";
            public readonly string _PostBrief = "~/Views/Blog/_PostBrief.cshtml";
            public readonly string _PostFull = "~/Views/Blog/_PostFull.cshtml";
            public readonly string _PostHeader = "~/Views/Blog/_PostHeader.cshtml";
            public readonly string _Posts = "~/Views/Blog/_Posts.cshtml";
            public readonly string _ShareLinks = "~/Views/Blog/_ShareLinks.cshtml";
            public readonly string _ViewStart = "~/Views/Blog/_ViewStart.cshtml";
            public readonly string Category = "~/Views/Blog/Category.cshtml";
            public readonly string Feed = "~/Views/Blog/Feed.cshtml";
            public readonly string Index = "~/Views/Blog/Index.cshtml";
            public readonly string Tag = "~/Views/Blog/Tag.cshtml";
            public readonly string View = "~/Views/Blog/View.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_BlogController : Daniel15.Web.Controllers.BlogController
    {
        public T4MVC_BlogController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Index(int page)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "page", page);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Category(string slug, int page)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Category);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "slug", slug);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "page", page);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Tag(string slug, int page)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Tag);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "slug", slug);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "page", page);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Archive(int year, int month, int page)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Archive);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "year", year);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "month", month);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "page", page);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult View(int month, int year, string slug)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.View);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "month", month);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "year", year);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "slug", slug);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ShortUrl(string alias)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ShortUrl);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "alias", alias);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Feed()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Feed);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
