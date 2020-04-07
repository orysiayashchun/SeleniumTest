using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Framework
{
   public static class Settings
    {
        public static readonly string url = "http://automationpractice.com/index.php";
        public static readonly TimeSpan implicitWait = TimeSpan.FromMilliseconds(3000);
    }
}
