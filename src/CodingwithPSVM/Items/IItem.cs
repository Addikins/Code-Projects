using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingwithPSVM
{
    public interface IItem
    {
        string Name { get; set; }
        int MinLevel { get; set; }
        double Weight { get; set; }
    }
}
