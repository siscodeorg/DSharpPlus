﻿using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using DSharpPlus.EventArgs;

namespace DSharpPlus
{
    public sealed partial class DiscordShardedClient
    {
        #region WebSocket

        /// <summary>
        /// Fired whenever a WebSocket error occurs within the client.
        /// </summary>
        public event AsyncEventHandler<SocketErrorEventArgs> SocketErrored
        {
            add => this._socketErrored.Register(value);
            remove => this._socketErrored.Unregister(value);
        }
        private AsyncEvent<SocketErrorEventArgs> _socketErrored;

        /// <summary>
        /// Fired whenever WebSocket connection is established.
        /// </summary>
        public event AsyncEventHandler SocketOpened
        {
            add => this._socketOpened.Register(value);
            remove => this._socketOpened.Unregister(value);
        }
        private AsyncEvent _socketOpened;

        /// <summary>
        /// Fired whenever WebSocket connection is terminated.
        /// </summary>
        public event AsyncEventHandler<SocketCloseEventArgs> SocketClosed
        {
            add => this._socketClosed.Register(value);
            remove => this._socketClosed.Unregister(value);
        }
        private AsyncEvent<SocketCloseEventArgs> _socketClosed;

        /// <summary>
        /// Fired when the client enters ready state.
        /// </summary>
        public event AsyncEventHandler<ReadyEventArgs> Ready
        {
            add => this._ready.Register(value);
            remove => this._ready.Unregister(value);
        }
        private AsyncEvent<ReadyEventArgs> _ready;

        /// <summary>
        /// Fired whenever a session is resumed.
        /// </summary>
        public event AsyncEventHandler<ReadyEventArgs> Resumed
        {
            add => this._resumed.Register(value);
            remove => this._resumed.Unregister(value);
        }
        private AsyncEvent<ReadyEventArgs> _resumed;

        /// <summary>
        /// Fired on received heartbeat ACK.
        /// </summary>
        public event AsyncEventHandler<HeartbeatEventArgs> Heartbeated
        {
            add => this._heartbeated.Register(value);
            remove => this._heartbeated.Unregister(value);
        }
        private AsyncEvent<HeartbeatEventArgs> _heartbeated;

        #endregion

        #region Channel

        /// <summary>
        /// Fired when a new channel is created.
        /// </summary>
        public event AsyncEventHandler<ChannelCreateEventArgs> ChannelCreated
        {
            add => this._channelCreated.Register(value);
            remove => this._channelCreated.Unregister(value);
        }
        private AsyncEvent<ChannelCreateEventArgs> _channelCreated;

        /// <summary>
        /// Fired when a new direct message channel is created.
        /// </summary>
        public event AsyncEventHandler<DmChannelCreateEventArgs> DmChannelCreated
        {
            add => this._dmChannelCreated.Register(value);
            remove => this._dmChannelCreated.Unregister(value);
        }
        private AsyncEvent<DmChannelCreateEventArgs> _dmChannelCreated;

        /// <summary>
        /// Fired when a channel is updated.
        /// </summary>
        public event AsyncEventHandler<ChannelUpdateEventArgs> ChannelUpdated
        {
            add => this._channelUpdated.Register(value);
            remove => this._channelUpdated.Unregister(value);
        }
        private AsyncEvent<ChannelUpdateEventArgs> _channelUpdated;

        /// <summary>
        /// Fired when a channel is deleted
        /// </summary>
        public event AsyncEventHandler<ChannelDeleteEventArgs> ChannelDeleted
        {
            add => this._channelDeleted.Register(value);
            remove => this._channelDeleted.Unregister(value);
        }
        private AsyncEvent<ChannelDeleteEventArgs> _channelDeleted;

        /// <summary>
        /// Fired when a dm channel is deleted
        /// </summary>
        public event AsyncEventHandler<DmChannelDeleteEventArgs> DmChannelDeleted
        {
            add => this._dmChannelDeleted.Register(value);
            remove => this._dmChannelDeleted.Unregister(value);
        }
        private AsyncEvent<DmChannelDeleteEventArgs> _dmChannelDeleted;

        /// <summary>
        /// Fired whenever a channel's pinned message list is updated.
        /// </summary>
        public event AsyncEventHandler<ChannelPinsUpdateEventArgs> ChannelPinsUpdated
        {
            add => this._channelPinsUpdated.Register(value);
            remove => this._channelPinsUpdated.Unregister(value);
        }
        private AsyncEvent<ChannelPinsUpdateEventArgs> _channelPinsUpdated;

        #endregion

        #region Guild

        /// <summary>
        /// Fired when the user joins a new guild.
        /// </summary>
        /// <remarks>[alias="GuildJoined"][alias="JoinedGuild"]</remarks>
        public event AsyncEventHandler<GuildCreateEventArgs> GuildCreated
        {
            add => this._guildCreated.Register(value);
            remove => this._guildCreated.Unregister(value);
        }
        private AsyncEvent<GuildCreateEventArgs> _guildCreated;

        /// <summary>
        /// Fired when a guild is becoming available.
        /// </summary>
        public event AsyncEventHandler<GuildCreateEventArgs> GuildAvailable
        {
            add => this._guildAvailable.Register(value);
            remove => this._guildAvailable.Unregister(value);
        }
        private AsyncEvent<GuildCreateEventArgs> _guildAvailable;

        /// <summary>
        /// Fired when a guild is updated.
        /// </summary>
        public event AsyncEventHandler<GuildUpdateEventArgs> GuildUpdated
        {
            add => this._guildUpdated.Register(value);
            remove => this._guildUpdated.Unregister(value);
        }
        private AsyncEvent<GuildUpdateEventArgs> _guildUpdated;

        /// <summary>
        /// Fired when the user leaves or is removed from a guild.
        /// </summary>
        public event AsyncEventHandler<GuildDeleteEventArgs> GuildDeleted
        {
            add => this._guildDeleted.Register(value);
            remove => this._guildDeleted.Unregister(value);
        }
        private AsyncEvent<GuildDeleteEventArgs> _guildDeleted;

        /// <summary>
        /// Fired when a guild becomes unavailable.
        /// </summary>
        public event AsyncEventHandler<GuildDeleteEventArgs> GuildUnavailable
        {
            add => this._guildUnavailable.Register(value);
            remove => this._guildUnavailable.Unregister(value);
        }
        private AsyncEvent<GuildDeleteEventArgs> _guildUnavailable;

        /// <summary>
        /// Fired when all guilds finish streaming from Discord.
        /// </summary>
        public event AsyncEventHandler<GuildDownloadCompletedEventArgs> GuildDownloadCompleted
        {
            add => this._guildDownloadCompleted.Register(value);
            remove => this._guildDownloadCompleted.Unregister(value);
        }
        private AsyncEvent<GuildDownloadCompletedEventArgs> _guildDownloadCompleted;

        /// <summary>
        /// Fired when a guilds emojis get updated
        /// </summary>
        public event AsyncEventHandler<GuildEmojisUpdateEventArgs> GuildEmojisUpdated
        {
            add => this._guildEmojisUpdated.Register(value);
            remove => this._guildEmojisUpdated.Unregister(value);
        }
        private AsyncEvent<GuildEmojisUpdateEventArgs> _guildEmojisUpdated;

        /// <summary>
        /// Fired when a guild integration is updated.
        /// </summary>
        public event AsyncEventHandler<GuildIntegrationsUpdateEventArgs> GuildIntegrationsUpdated
        {
            add => this._guildIntegrationsUpdated.Register(value);
            remove => this._guildIntegrationsUpdated.Unregister(value);
        }
        private AsyncEvent<GuildIntegrationsUpdateEventArgs> _guildIntegrationsUpdated;

        #endregion

        #region Guild Ban

        /// <summary>
        /// Fired when a guild ban gets added
        /// </summary>
        public event AsyncEventHandler<GuildBanAddEventArgs> GuildBanAdded
        {
            add => this._guildBanAdded.Register(value);
            remove => this._guildBanAdded.Unregister(value);
        }
        private AsyncEvent<GuildBanAddEventArgs> _guildBanAdded;

        /// <summary>
        /// Fired when a guild ban gets removed
        /// </summary>
        public event AsyncEventHandler<GuildBanRemoveEventArgs> GuildBanRemoved
        {
            add => this._guildBanRemoved.Register(value);
            remove => this._guildBanRemoved.Unregister(value);
        }
        private AsyncEvent<GuildBanRemoveEventArgs> _guildBanRemoved;

        #endregion

        #region Guild Member

        /// <summary>
        /// Fired when a new user joins a guild.
        /// </summary>
        public event AsyncEventHandler<GuildMemberAddEventArgs> GuildMemberAdded
        {
            add => this._guildMemberAdded.Register(value);
            remove => this._guildMemberAdded.Unregister(value);
        }
        private AsyncEvent<GuildMemberAddEventArgs> _guildMemberAdded;

        /// <summary>
        /// Fired when a user is removed from a guild (leave/kick/ban).
        /// </summary>
        public event AsyncEventHandler<GuildMemberRemoveEventArgs> GuildMemberRemoved
        {
            add => this._guildMemberRemoved.Register(value);
            remove => this._guildMemberRemoved.Unregister(value);
        }
        private AsyncEvent<GuildMemberRemoveEventArgs> _guildMemberRemoved;

        /// <summary>
        /// Fired when a guild member is updated.
        /// </summary>
        public event AsyncEventHandler<GuildMemberUpdateEventArgs> GuildMemberUpdated
        {
            add => this._guildMemberUpdated.Register(value);
            remove => this._guildMemberUpdated.Unregister(value);
        }
        private AsyncEvent<GuildMemberUpdateEventArgs> _guildMemberUpdated;

        /// <summary>
        /// Fired in response to Gateway Request Guild Members.
        /// </summary>
        public event AsyncEventHandler<GuildMembersChunkEventArgs> GuildMembersChunked
        {
            add => this._guildMembersChunk.Register(value);
            remove => this._guildMembersChunk.Unregister(value);
        }
        private AsyncEvent<GuildMembersChunkEventArgs> _guildMembersChunk;

        #endregion

        #region Guild Role

        /// <summary>
        /// Fired when a guild role is created.
        /// </summary>
        public event AsyncEventHandler<GuildRoleCreateEventArgs> GuildRoleCreated
        {
            add => this._guildRoleCreated.Register(value);
            remove => this._guildRoleCreated.Unregister(value);
        }
        private AsyncEvent<GuildRoleCreateEventArgs> _guildRoleCreated;

        /// <summary>
        /// Fired when a guild role is updated.
        /// </summary>
        public event AsyncEventHandler<GuildRoleUpdateEventArgs> GuildRoleUpdated
        {
            add => this._guildRoleUpdated.Register(value);
            remove => this._guildRoleUpdated.Unregister(value);
        }
        private AsyncEvent<GuildRoleUpdateEventArgs> _guildRoleUpdated;

        /// <summary>
        /// Fired when a guild role is updated.
        /// </summary>
        public event AsyncEventHandler<GuildRoleDeleteEventArgs> GuildRoleDeleted
        {
            add => this._guildRoleDeleted.Register(value);
            remove => this._guildRoleDeleted.Unregister(value);
        }
        private AsyncEvent<GuildRoleDeleteEventArgs> _guildRoleDeleted;

        #endregion

        #region Invite

        /// <summary>
        /// Fired when an invite is created.
        /// </summary>
        public event AsyncEventHandler<InviteCreateEventArgs> InviteCreated
        {
            add => this._inviteCreated.Register(value);
            remove => this._inviteCreated.Unregister(value);
        }
        private AsyncEvent<InviteCreateEventArgs> _inviteCreated;

        /// <summary>
        /// Fired when an invite is deleted.
        /// </summary>
        public event AsyncEventHandler<InviteDeleteEventArgs> InviteDeleted
        {
            add => this._inviteDeleted.Register(value);
            remove => this._inviteDeleted.Unregister(value);
        }
        private AsyncEvent<InviteDeleteEventArgs> _inviteDeleted;

        #endregion

        #region Message

        /// <summary>
        /// Fired when a message is created.
        /// </summary>
        public event AsyncEventHandler<MessageCreateEventArgs> MessageCreated
        {
            add => this._messageCreated.Register(value);
            remove => this._messageCreated.Unregister(value);
        }
        private AsyncEvent<MessageCreateEventArgs> _messageCreated;

        /// <summary>
        /// Fired when a message is updated.
        /// </summary>
        public event AsyncEventHandler<MessageUpdateEventArgs> MessageUpdated
        {
            add => this._messageUpdated.Register(value);
            remove => this._messageUpdated.Unregister(value);
        }
        private AsyncEvent<MessageUpdateEventArgs> _messageUpdated;

        /// <summary>
        /// Fired when a message is deleted.
        /// </summary>
        public event AsyncEventHandler<MessageDeleteEventArgs> MessageDeleted
        {
            add => this._messageDeleted.Register(value);
            remove => this._messageDeleted.Unregister(value);
        }
        private AsyncEvent<MessageDeleteEventArgs> _messageDeleted;

        /// <summary>
        /// Fired when multiple messages are deleted at once.
        /// </summary>
        public event AsyncEventHandler<MessageBulkDeleteEventArgs> MessagesBulkDeleted
        {
            add => this._messageBulkDeleted.Register(value);
            remove => this._messageBulkDeleted.Unregister(value);
        }
        private AsyncEvent<MessageBulkDeleteEventArgs> _messageBulkDeleted;

        #endregion

        #region Message Reaction

        /// <summary>
        /// Fired when a reaction gets added to a message.
        /// </summary>
        public event AsyncEventHandler<MessageReactionAddEventArgs> MessageReactionAdded
        {
            add => this._messageReactionAdded.Register(value);
            remove => this._messageReactionAdded.Unregister(value);
        }
        private AsyncEvent<MessageReactionAddEventArgs> _messageReactionAdded;

        /// <summary>
        /// Fired when a reaction gets removed from a message.
        /// </summary>
        public event AsyncEventHandler<MessageReactionRemoveEventArgs> MessageReactionRemoved
        {
            add => this._messageReactionRemoved.Register(value);
            remove => this._messageReactionRemoved.Unregister(value);
        }
        private AsyncEvent<MessageReactionRemoveEventArgs> _messageReactionRemoved;

        /// <summary>
        /// Fired when all reactions get removed from a message.
        /// </summary>
        public event AsyncEventHandler<MessageReactionsClearEventArgs> MessageReactionsCleared
        {
            add => this._messageReactionsCleared.Register(value);
            remove => this._messageReactionsCleared.Unregister(value);
        }
        private AsyncEvent<MessageReactionsClearEventArgs> _messageReactionsCleared;

        /// <summary>
        /// Fired when all reactions of a specific reaction are removed from a message.
        /// </summary>
        public event AsyncEventHandler<MessageReactionRemoveEmojiEventArgs> MessageReactionRemovedEmoji
        {
            add => this._messageReactionRemovedEmoji.Register(value);
            remove => this._messageReactionRemovedEmoji.Unregister(value);
        }
        private AsyncEvent<MessageReactionRemoveEmojiEventArgs> _messageReactionRemovedEmoji;

        #endregion

        #region User/Presence Update

        /// <summary>
        /// Fired when a presence has been updated.
        /// </summary>
        public event AsyncEventHandler<PresenceUpdateEventArgs> PresenceUpdated
        {
            add => this._presenceUpdated.Register(value);
            remove => this._presenceUpdated.Unregister(value);
        }
        private AsyncEvent<PresenceUpdateEventArgs> _presenceUpdated;


        /// <summary>
        /// Fired when the current user updates their settings.
        /// </summary>
        public event AsyncEventHandler<UserSettingsUpdateEventArgs> UserSettingsUpdated
        {
            add => this._userSettingsUpdated.Register(value);
            remove => this._userSettingsUpdated.Unregister(value);
        }
        private AsyncEvent<UserSettingsUpdateEventArgs> _userSettingsUpdated;

        /// <summary>
        /// Fired when properties about the current user change.
        /// </summary>
        /// <remarks>
        /// NB: This event only applies for changes to the <b>current user</b>, the client that is connected to Discord.
        /// </remarks>
        public event AsyncEventHandler<UserUpdateEventArgs> UserUpdated
        {
            add => this._userUpdated.Register(value);
            remove => this._userUpdated.Unregister(value);
        }
        private AsyncEvent<UserUpdateEventArgs> _userUpdated;

        #endregion

        #region Voice

        /// <summary>
        /// Fired when someone joins/leaves/moves voice channels.
        /// </summary>
        public event AsyncEventHandler<VoiceStateUpdateEventArgs> VoiceStateUpdated
        {
            add => this._voiceStateUpdated.Register(value);
            remove => this._voiceStateUpdated.Unregister(value);
        }
        private AsyncEvent<VoiceStateUpdateEventArgs> _voiceStateUpdated;

        /// <summary>
        /// Fired when a guild's voice server is updated.
        /// </summary>
        public event AsyncEventHandler<VoiceServerUpdateEventArgs> VoiceServerUpdated
        {
            add => this._voiceServerUpdated.Register(value);
            remove => this._voiceServerUpdated.Unregister(value);
        }
        private AsyncEvent<VoiceServerUpdateEventArgs> _voiceServerUpdated;

        #endregion

        #region Misc

        /// <summary>
        /// Fired when a user starts typing in a channel.
        /// </summary>
        public event AsyncEventHandler<TypingStartEventArgs> TypingStarted
        {
            add => this._typingStarted.Register(value);
            remove => this._typingStarted.Unregister(value);
        }
        private AsyncEvent<TypingStartEventArgs> _typingStarted;

        /// <summary>
        /// Fired when an unknown event gets received.
        /// </summary>
        public event AsyncEventHandler<UnknownEventArgs> UnknownEvent
        {
            add => this._unknownEvent.Register(value);
            remove => this._unknownEvent.Unregister(value);
        }
        private AsyncEvent<UnknownEventArgs> _unknownEvent;

        /// <summary>
        /// Fired whenever webhooks update.
        /// </summary>
        public event AsyncEventHandler<WebhooksUpdateEventArgs> WebhooksUpdated
        {
            add => this._webhooksUpdated.Register(value);
            remove => this._webhooksUpdated.Unregister(value);
        }
        private AsyncEvent<WebhooksUpdateEventArgs> _webhooksUpdated;

        /// <summary>
        /// Fired whenever an error occurs within an event handler.
        /// </summary>
        public event AsyncEventHandler<ClientErrorEventArgs> ClientErrored
        {
            add => this._clientErrored.Register(value);
            remove => this._clientErrored.Unregister(value);
        }
        private AsyncEvent<ClientErrorEventArgs> _clientErrored;

        #endregion

        #region Error Handling

        internal void EventErrorHandler(string evname, Exception ex)
        {
            this.Logger.LogError(LoggerEvents.EventHandlerException, ex, "Exception occurred while handling {0}", evname);

            this._clientErrored.InvokeAsync(new ClientErrorEventArgs(null) { EventName = evname, Exception = ex }).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        private void Goof(string evname, Exception ex)
        {
            this.Logger.LogCritical(LoggerEvents.EventHandlerException, ex, "Exception occurred while handling another exception");
        }

        #endregion

        #region Event Dispatchers

        private Task Client_ClientError(ClientErrorEventArgs e)
            => this._clientErrored.InvokeAsync(e);

        private Task Client_SocketError(SocketErrorEventArgs e)
            => this._socketErrored.InvokeAsync(e);

        private Task Client_SocketOpened()
            => this._socketOpened.InvokeAsync();

        private Task Client_SocketClosed(SocketCloseEventArgs e)
            => this._socketClosed.InvokeAsync(e);

        private Task Client_Ready(ReadyEventArgs e)
            => this._ready.InvokeAsync(e);

        private Task Client_Resumed(ReadyEventArgs e)
            => this._resumed.InvokeAsync(e);

        private Task Client_ChannelCreated(ChannelCreateEventArgs e)
            => this._channelCreated.InvokeAsync(e);

        private Task Client_DMChannelCreated(DmChannelCreateEventArgs e)
            => this._dmChannelCreated.InvokeAsync(e);

        private Task Client_ChannelUpdated(ChannelUpdateEventArgs e)
            => this._channelUpdated.InvokeAsync(e);

        private Task Client_ChannelDeleted(ChannelDeleteEventArgs e)
            => this._channelDeleted.InvokeAsync(e);

        private Task Client_DMChannelDeleted(DmChannelDeleteEventArgs e)
            => this._dmChannelDeleted.InvokeAsync(e);

        private Task Client_ChannelPinsUpdated(ChannelPinsUpdateEventArgs e)
            => this._channelPinsUpdated.InvokeAsync(e);

        private Task Client_GuildCreated(GuildCreateEventArgs e)
            => this._guildCreated.InvokeAsync(e);

        private Task Client_GuildAvailable(GuildCreateEventArgs e)
            => this._guildAvailable.InvokeAsync(e);

        private Task Client_GuildUpdated(GuildUpdateEventArgs e)
            => this._guildUpdated.InvokeAsync(e);

        private Task Client_GuildDeleted(GuildDeleteEventArgs e)
            => this._guildDeleted.InvokeAsync(e);

        private Task Client_GuildUnavailable(GuildDeleteEventArgs e)
            => this._guildUnavailable.InvokeAsync(e);

        private Task Client_GuildDownloadCompleted(GuildDownloadCompletedEventArgs e)
            => this._guildDownloadCompleted.InvokeAsync(e);

        private Task Client_MessageCreated(MessageCreateEventArgs e)
            => this._messageCreated.InvokeAsync(e);

        private Task Client_InviteCreated(InviteCreateEventArgs e)
            => this._inviteCreated.InvokeAsync(e);

        private Task Client_InviteDeleted(InviteDeleteEventArgs e)
            => this._inviteDeleted.InvokeAsync(e);

        private Task Client_PresenceUpdate(PresenceUpdateEventArgs e)
            => this._presenceUpdated.InvokeAsync(e);

        private Task Client_GuildBanAdd(GuildBanAddEventArgs e)
            => this._guildBanAdded.InvokeAsync(e);

        private Task Client_GuildBanRemove(GuildBanRemoveEventArgs e)
            => this._guildBanRemoved.InvokeAsync(e);

        private Task Client_GuildEmojisUpdate(GuildEmojisUpdateEventArgs e)
            => this._guildEmojisUpdated.InvokeAsync(e);

        private Task Client_GuildIntegrationsUpdate(GuildIntegrationsUpdateEventArgs e)
            => this._guildIntegrationsUpdated.InvokeAsync(e);

        private Task Client_GuildMemberAdd(GuildMemberAddEventArgs e)
            => this._guildMemberAdded.InvokeAsync(e);

        private Task Client_GuildMemberRemove(GuildMemberRemoveEventArgs e)
            => this._guildMemberRemoved.InvokeAsync(e);

        private Task Client_GuildMemberUpdate(GuildMemberUpdateEventArgs e)
            => this._guildMemberUpdated.InvokeAsync(e);

        private Task Client_GuildRoleCreate(GuildRoleCreateEventArgs e)
            => this._guildRoleCreated.InvokeAsync(e);

        private Task Client_GuildRoleUpdate(GuildRoleUpdateEventArgs e)
            => this._guildRoleUpdated.InvokeAsync(e);

        private Task Client_GuildRoleDelete(GuildRoleDeleteEventArgs e)
            => this._guildRoleDeleted.InvokeAsync(e);

        private Task Client_MessageUpdate(MessageUpdateEventArgs e)
            => this._messageUpdated.InvokeAsync(e);

        private Task Client_MessageDelete(MessageDeleteEventArgs e)
            => this._messageDeleted.InvokeAsync(e);

        private Task Client_MessageBulkDelete(MessageBulkDeleteEventArgs e)
            => this._messageBulkDeleted.InvokeAsync(e);

        private Task Client_TypingStart(TypingStartEventArgs e)
            => this._typingStarted.InvokeAsync(e);

        private Task Client_UserSettingsUpdate(UserSettingsUpdateEventArgs e)
            => this._userSettingsUpdated.InvokeAsync(e);

        private Task Client_UserUpdate(UserUpdateEventArgs e)
            => this._userUpdated.InvokeAsync(e);

        private Task Client_VoiceStateUpdate(VoiceStateUpdateEventArgs e)
            => this._voiceStateUpdated.InvokeAsync(e);

        private Task Client_VoiceServerUpdate(VoiceServerUpdateEventArgs e)
            => this._voiceServerUpdated.InvokeAsync(e);

        private Task Client_GuildMembersChunk(GuildMembersChunkEventArgs e)
            => this._guildMembersChunk.InvokeAsync(e);

        private Task Client_UnknownEvent(UnknownEventArgs e)
            => this._unknownEvent.InvokeAsync(e);

        private Task Client_MessageReactionAdd(MessageReactionAddEventArgs e)
            => this._messageReactionAdded.InvokeAsync(e);

        private Task Client_MessageReactionRemove(MessageReactionRemoveEventArgs e)
            => this._messageReactionRemoved.InvokeAsync(e);

        private Task Client_MessageReactionRemoveAll(MessageReactionsClearEventArgs e)
            => this._messageReactionsCleared.InvokeAsync(e);

        private Task Client_MessageReactionRemovedEmoji(MessageReactionRemoveEmojiEventArgs e)
            => this._messageReactionRemovedEmoji.InvokeAsync(e);

        private Task Client_WebhooksUpdate(WebhooksUpdateEventArgs e)
            => this._webhooksUpdated.InvokeAsync(e);

        private Task Client_HeartBeated(HeartbeatEventArgs e)
            => this._heartbeated.InvokeAsync(e);
        
        #endregion
    }
}