using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoPulauV01.Models.Interface
{
    internal interface IUpdateCreate
    {
        string CreatedUserName { get; set; }
        string CreatedDateTime { get; set; }

        string ModifiedUserName { get; set; }

        string ModifiedDateTime { get; set; }
    }
}