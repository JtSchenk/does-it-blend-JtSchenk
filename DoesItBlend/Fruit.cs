using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// A base class representing fruit
    /// </summary>
        public class Fruit : IBlendable //, ICloneable, ICompareable
        {
        public abstract string Blend();

        // virtual has an implementation, abstract doesn't

        }
     
    }
}
