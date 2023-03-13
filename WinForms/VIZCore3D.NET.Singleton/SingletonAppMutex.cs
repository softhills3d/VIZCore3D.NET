using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIZCore3D.NET.Singleton
{
    /// <summary>
    /// Restore Singleton Window Event Handler
    /// </summary>
    /// <param name="sender">Sender</param>
    /// <param name="e">Event Args</param>
    public delegate void RestoreSingletonWindowEventHandler(object sender, EventArgs e);

    /// <summary>
    /// Singleton Application By Mutex Technology
    /// </summary>
    public class SingletonAppMutex
    {
        private System.Threading.EventWaitHandle eventWaitHandle;
        private bool IsRunStatus = false;

        /// <summary>
        /// Restore Singleton Window Event
        /// </summary>
        public event RestoreSingletonWindowEventHandler OnRestoreSingletonWindowEvent;

        /// <summary>
        /// Construction
        /// </summary>
        public SingletonAppMutex()
        {
        }

        /// <summary>
        /// Get Status
        /// </summary>
        /// <param name="EventName">Event Name</param>
        /// <returns>Status</returns>
        public bool IsRunning(string EventName)
        {
            try
            {
                eventWaitHandle = System.Threading.EventWaitHandle.OpenExisting(EventName);
                if (eventWaitHandle != null)
                {
                    eventWaitHandle.Set();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Set New Application(Event)
        /// </summary>
        /// <param name="EventName">Event Name</param>
        public void SetEvent(string EventName)
        {
            if (eventWaitHandle == null)
            {
                eventWaitHandle = new System.Threading.EventWaitHandle(false, System.Threading.EventResetMode.AutoReset, EventName);
            }

            System.Threading.Thread thread = new System.Threading.Thread(WaitInstanceEvent);
            thread.IsBackground = true;
            thread.Start();
        }

        /// <summary>
        /// Initialize Event
        /// </summary>
        public void InitEvent()
        {
            IsRunStatus = false;
            eventWaitHandle.Set();
        }

        /// <summary>
        /// Wait Instance Event
        /// </summary>
        /// <param name="state">State Object</param>
        private void WaitInstanceEvent(object state)
        {
            while (IsRunStatus)
            {
                eventWaitHandle.WaitOne();

                // 윈도우 복원      
                if (OnRestoreSingletonWindowEvent != null)
                {
                    OnRestoreSingletonWindowEvent(this, new EventArgs());
                }
            }
        }
    }
}
