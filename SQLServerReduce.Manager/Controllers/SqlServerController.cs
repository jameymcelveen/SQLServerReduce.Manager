using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SQLServerReduce.Common;

namespace SQLServerReduce.Manager.Controllers
{
    public class SqlServerController : ApiController
    {
        public ISqlServerReduceQueue Queue { get; set; }
        public ISqlServerReduceData Data { get; set; }
        public SqlServerController()
        {
       
        }
    }
}