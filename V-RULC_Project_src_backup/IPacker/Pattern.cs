using System;
using System.Collections.Generic;
using System.Text;

namespace IPacker
{
    public class Pattern
    {
        public Item itemPatern;
        public List<int> pos_x;
        public List<int> pos_y;

        public Pattern()
        {
            itemPatern = new Item();
            pos_x = new List<int>();
            pos_y = new List<int>();
        }
        
    }
}
