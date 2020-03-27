using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Id4UI.Models
{
    public class ErrorViewModel
    {
        private  string Error { get; set; }
        public string _RequestId;
        public ErrorViewModel()
        {
        }

        public ErrorViewModel(string RequestId,string error)
        {
            _RequestId = RequestId;
            Error = error;
        }

       
    }
}
