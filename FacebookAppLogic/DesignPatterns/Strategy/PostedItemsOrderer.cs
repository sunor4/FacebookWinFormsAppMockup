using System.Collections.Generic;
using FacebookAppLogic.Interfaces;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic.DesignPatterns
{
    public enum eOrderStrategyType
    {
        DATE = 0,
        TEXT = 1
    }

    public class PostedItemsOrderer
    {
        private IPostedItemsOrdererStrategy m_PostedItemsOrdererStrategy;

        public void SetOrderStrategy(eOrderStrategyType i_OrderStrategyType)
        {
            switch (i_OrderStrategyType)
            {
                case eOrderStrategyType.DATE:
                    m_PostedItemsOrdererStrategy = new DateTimePostedItemsOrdererStrategy();
                    break;
                case eOrderStrategyType.TEXT:
                    m_PostedItemsOrdererStrategy = new TextPostedItemsOrdererStrategy();
                    break;
            }
        }

        public IEnumerable<PostedItem> Order(IEnumerable<PostedItem> i_Items)
        {
            return m_PostedItemsOrdererStrategy.Order(i_Items);
        }

    }
}
