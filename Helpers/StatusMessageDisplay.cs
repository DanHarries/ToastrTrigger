using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToastrTest.Helpers
{
    public class StatusMessageDisplay
    {
        public string Message { get; set; }
    }

    public static class DisplayMessageHelper
    {
        public static StatusMessageDisplay DisplayTempData(string Message)
        {
            StatusMessageDisplay _StatusMessage = new StatusMessageDisplay()
            {
                Message = Message
            };
            return _StatusMessage;
        }
    }

}
