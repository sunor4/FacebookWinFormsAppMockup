using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookAppLogic.Interfaces;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic.DesignPatterns
{
    public class TextPostedItemsOrdererStrategy : IPostedItemsOrdererStrategy
    {
        public IEnumerable<PostedItem> Order(IEnumerable<PostedItem> i_List)
        {
            return i_List.OrderBy(item => item.Message);
        }
    }
}
