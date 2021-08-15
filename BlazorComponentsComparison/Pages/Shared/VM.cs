using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponentsComparison.Pages.Shared
{
    public class VM : IndexModel
    {
        public VM(ILogger<IndexModel> logger) : base(logger)
        {

        }
    }
}
