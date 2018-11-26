using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    [AttributeUsage(AttributeTargets.Class)]
    public class IsBlock : Attribute
    {
        public bool block;
        public IsBlock(bool block)
        {
            this.block = block;
        }
    }
}
