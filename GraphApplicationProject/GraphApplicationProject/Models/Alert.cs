using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

namespace GraphApplicationProject.Models
{
    public class Alert
    {
        public const string AlertKey = "TempDataAlerts";
        public string Message { get; set; }
        public string Debug { get; set; }
    }
}
