using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoPulauV01.Models.Interface
{
    internal interface IUpdateCreate
    {
        int CreatedUserId { get; set; }
        DateTime CreatedDateTime { get; set; }

        int ModifiedUserId { get; set; }

        DateTime ModifiedDateTime { get; set; }
    }
}