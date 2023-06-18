using System.Diagnostics;

namespace Fast_food_order_app
{
    [DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
    public class AddNewProductBase
    {
        public object AddNewProduct { get; private set; }
    }
}