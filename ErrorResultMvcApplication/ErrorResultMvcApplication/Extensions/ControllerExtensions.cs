using System.Net;
using System.Text;
using System.Web.Mvc;

namespace MvcHelpers.Extensions
{
    /// <summary>
    /// Class for all that nice controller tweaks of yours.
    /// </summary>
    public static class ControllerExtensions
    {
        /// <summary>
        /// Creates System.Web.Mvc.JsonResult object that serializes the specified object to JavaScript Object Notation (JSON) format using the specified JSON requested behaviour + sends Status Code for error.
        /// </summary>
        /// <param name="currentController">The current controller.</param>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public static JsonResult JsonError(this Controller currentController, object data)
        {
            currentController.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return JsonError(data, null /* contentType */, null /* contentEncoding */, JsonRequestBehavior.DenyGet, currentController);
        }

        /// <summary>
        /// Creates System.Web.Mvc.JsonResult object that serializes the specified object to JavaScript Object Notation (JSON) format using the specified JSON requested behaviour + sends Status Code for error.
        /// </summary>
        /// <param name="currentController">The current controller.</param>
        /// <param name="data">The data.</param>
        /// <param name="contentType">Type of the content.</param>
        /// <returns></returns>
        public static JsonResult JsonError(this Controller currentController, object data, string contentType)
        {
            currentController.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return JsonError(data, contentType, null /* contentEncoding */, JsonRequestBehavior.DenyGet, currentController);
        }

        /// <summary>
        /// Creates System.Web.Mvc.JsonResult object that serializes the specified object to JavaScript Object Notation (JSON) format using the specified JSON requested behaviour + sends Status Code for error.
        /// </summary>
        /// <param name="currentController">The current controller.</param>
        /// <param name="data">The data.</param>
        /// <param name="contentType">Type of the content.</param>
        /// <param name="contentEncoding">The content encoding.</param>
        /// <returns></returns>
        public static JsonResult JsonError(this Controller currentController, object data, string contentType, Encoding contentEncoding)
        {
            currentController.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return JsonError(data, contentType, contentEncoding, JsonRequestBehavior.DenyGet, currentController);
        }

        /// <summary>
        /// Creates System.Web.Mvc.JsonResult object that serializes the specified object to JavaScript Object Notation (JSON) format using the specified JSON requested behaviour + sends Status Code for error.
        /// </summary>
        /// <param name="currentController">The current controller.</param>
        /// <param name="data">The data.</param>
        /// <param name="behavior">The behavior.</param>
        /// <returns></returns>
        public static JsonResult JsonError(this Controller currentController, object data, JsonRequestBehavior behavior)
        {
            currentController.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return JsonError(data, null /* contentType */, null /* contentEncoding */, behavior, currentController);
        }

        /// <summary>
        /// Creates System.Web.Mvc.JsonResult object that serializes the specified object to JavaScript Object Notation (JSON) format using the specified JSON requested behaviour + sends Status Code for error.
        /// </summary>
        /// <param name="currentController">The current controller.</param>
        /// <param name="data">The data.</param>
        /// <param name="contentType">Type of the content.</param>
        /// <param name="behavior">The behavior.</param>
        /// <returns></returns>
        public static JsonResult JsonError(this Controller currentController, object data, string contentType, JsonRequestBehavior behavior)
        {
            return JsonError(data, contentType, null /* contentEncoding */, behavior, currentController);
        }

        /// <summary>
        /// Creates System.Web.Mvc.JsonResult object that serializes the specified object to JavaScript Object Notation (JSON) format using the specified JSON requested behaviour + sends Status Code for error.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="contentType">Type of the content.</param>
        /// <param name="contentEncoding">The content encoding.</param>
        /// <param name="behavior">The behavior.</param>
        /// <param name="currentController">The current controller.</param>
        /// <returns></returns>
        internal static JsonResult JsonError(object data, string contentType, Encoding contentEncoding, JsonRequestBehavior behavior, Controller currentController)
        {
            currentController.Response.StatusCode = (int)HttpStatusCode.BadRequest;

            return new JsonResult
            {
                Data = data,
                ContentType = contentType,
                ContentEncoding = contentEncoding,
                JsonRequestBehavior = behavior
            };
        }
    }
}