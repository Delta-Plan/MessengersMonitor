using PluginHandler.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkMonitor
{
    public class VkPlugin : IMessengerPlugin
    {
        #region Private properties

        private PluginConnectionStatus _currentStatus;

        #endregion

        #region Constructors

        public VkPlugin() { }

        #endregion

        #region IMessengerPlugin implementation

        public PluginConnectionStatus Connect()
        {
            throw new NotImplementedException();
        }

        public PluginConnectionStatus Disconnect()
        {
            throw new NotImplementedException();
        }

        public PluginConnectionStatus GetConnectionStatus()
        {
            return _currentStatus;
        }

        public PluginConnectionStatus SuspendConnection()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
