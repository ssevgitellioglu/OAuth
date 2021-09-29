using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }

//    {
//    "access_token": "c8rhcc1ZrUtqPO0LF7ht6F8Lw7hmgRV-BRIscVBp_h-5znP_8nLY44iKS0u4bPnBqCDYPax31qTTUtkQ7wJx9uOs4gJSTfCmzGYbZVRhBZLolMbSLI6gkGvKWtq2-zDIUjf-0qaIQlToo3au91LvGzQWgogYXsctQ4jlmjMa6g19AD7Inbcj0nX7RNslspgw9sj2n5jtCvtDBnw_zae8sOxqfFZVjDFUcmfnRXKebNejBCbTwXEmI_b0tB6qL4t8ulDCzLjon8i5njjeqvwXZVzBBui-6kHBKQb3y4I8o-jic8sMzPSrenOBVzLUh_YM37ywrqV1NwVIBkuZ5vCHaELXAL3oUh_VE-Sdeoh6_HTwMXYQ-VBPJhinpBzioVAggOg9ZmftL4OQ4zhaAC3II_D1xRK5mrZcIaPQbtFnPxYNnhC2JEzWR-a92hdTr1TZ1L_3zbgQgowWS3kHOJdtruMTgnzNyHoHL-8BCsGLGxrrdQDRx2oYcFVVn081QXh8",
//    "token_type": "bearer",
//    "expires_in": 1209599,
//    "userName": "sevgitellioglu1@gmail.com",
//    ".issued": "Mon, 06 Jul 2020 07:49:21 GMT",
//    ".expires": "Mon, 20 Jul 2020 07:49:21 GMT"
//}
}
