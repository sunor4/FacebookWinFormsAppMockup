namespace FacebookAppLogic.ObjectClasses
{
    using System;

    // This class is used for many purposes regarding handling the current time of day.
    internal class TimeOfDayGreeter
    {
        private TimeSpan m_MorningStart = new TimeSpan(5, 0, 0);
        private TimeSpan m_NoonStart = new TimeSpan(12, 0, 0);
        private TimeSpan m_EveningStart = new TimeSpan(18, 0, 0);
        private TimeSpan m_NightStart = new TimeSpan(22, 0, 0);
        private TimeSpan m_Midnight = new TimeSpan(0, 0, 0);

        public string GetGreetingByTimeOfDay()
        {
            
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            string greetingText = "";

            if ((currentTime >= m_NightStart && currentTime <= m_Midnight) || (currentTime >= m_Midnight && currentTime < m_MorningStart))
            {
                greetingText = "night";
            }
            else if (currentTime >= m_MorningStart && currentTime < m_NoonStart)
            {
                greetingText = "morning";
            }
            else if (currentTime >= m_NoonStart && currentTime < m_EveningStart)
            {
                greetingText = "afternoon";
            }
            else if (currentTime >= m_EveningStart && currentTime < m_NightStart)
            {
                greetingText = "evening";
            }

            return greetingText;
        }
    }
}