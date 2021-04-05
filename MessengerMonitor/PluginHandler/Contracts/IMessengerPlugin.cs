using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginHandler.Contracts
{
    public interface IMessengerPlugin
    {
        PluginConnectionStatus GetConnectionStatus();

        PluginConnectionStatus Connect();

        PluginConnectionStatus Disconnect();

        PluginConnectionStatus SuspendConnection();


    }
}
