using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCImageUpload_0.Models.Context;

namespace MVCImageUpload_0.DesignPatterns.SingletonPattern
{
    public class DBTool
    {


        DBTool() { }

        static MyContext _dbInstance;

        public static MyContext DBInstance
        {
            get
            {
                if (_dbInstance == null)
                {
                    _dbInstance = new MyContext();
                }

                return _dbInstance;


            }


        }





    }
}