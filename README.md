MVC JsonError Helper
====================

Helps to easily send error in JSON format from your controller.

Whole helper is infact in ControllerExtensions.cs in Extensions subfolder. You just need to copy this file to your solution and don't forget to put also using MvcHelpers.Extensions; in your controller to use this.

How to use helper
-----------------

[HttpPost] <br/>
        public ActionResult RequestTest(int? id) <br/>
        { <br/>
            if (id != null) <br/>
            { <br/>
                return Json(new { responseText = "you entered : " + id }); <br/>
            } <br/>
            else <br/>
            { <br/>
                return this.JsonError(new { responseText = "error orrucured, sry" }); <br/>
            } <br/>
        } <br/>

This snippet is from HomeController.cs file. <br/>
If you are sending JSON data with Http response 200 use Json built in helper, if you want to respond with same JSON object, but with Http response 400 (can be changed in helper) just use this.JsonError.

Sources
-------
http://stackoverflow.com/questions/6010368/how-does-json-determine-a-success-from-an-error <br/>
http://stackoverflow.com/questions/3908605/return-json-error-from-asp-net-mvc <br/>
https://aspnet.codeplex.com/releases/view/58781

Feel free to bug fix, fork and happily use.