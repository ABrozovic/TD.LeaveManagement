using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD.LeaveManaged.Application.Responses
{
    public abstract class BaseCommandResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public List<string> Errors { get; set; }
    }
}
