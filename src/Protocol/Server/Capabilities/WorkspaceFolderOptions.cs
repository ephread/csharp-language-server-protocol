using OmniSharp.Extensions.LanguageServer.Protocol.Models;
using OmniSharp.Extensions.LanguageServer.Protocol.Serialization;

namespace OmniSharp.Extensions.LanguageServer.Protocol.Server.Capabilities
{
    public class WorkspaceFolderOptions : IWorkspaceFolderOptions
    {
        /// <summary>
        /// The server has support for workspace folders
        /// </summary>
        [Optional]
        public bool Supported { get; set; }

        /// <summary>
        /// Whether the server wants to receive workspace folder
        /// change notifications.
        ///
        /// If a strings is provided the string is treated as a ID
        /// under which the notification is registed on the client
        /// side. The ID can be used to unregister for these events
        /// using the `client/unregisterCapability` request.
        /// </summary>
        [Optional]
        public BooleanString ChangeNotifications { get; set; }
    }
}
