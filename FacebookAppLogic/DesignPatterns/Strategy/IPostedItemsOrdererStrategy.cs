using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic.Interfaces
{
    public interface IPostedItemsOrdererStrategy
    {
        IEnumerable<PostedItem> Order(IEnumerable<PostedItem> i_List);
    }
}
