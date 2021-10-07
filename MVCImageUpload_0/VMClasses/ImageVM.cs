using MVCImageUpload_0.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCImageUpload_0.VMClasses
{
    public class ImageVM
    {
        public TestClass TestClass { get; set; }
        public List<TestClass> TestClasses { get; set; }


    }
}