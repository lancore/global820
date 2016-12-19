using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace global820
{
    public enum eChatChannel
    {
        Unknown,
        Local,
        Global,
        Party,
        Whispers,
        Trade,
        Guild
    }
    /// <summary>
    /// Small helper utility class for eChatChannel
    /// </summary>
    public static class ChatChannelHelper
    {
        public static eChatChannel CharToEnum(char key)
        {
            switch (key)
            {
                case '@':
                    return eChatChannel.Whispers;
                case '#':
                    return eChatChannel.Global;
                case '&':
                    return eChatChannel.Guild;
                case '$':
                    return eChatChannel.Trade;
                case '%':
                    return eChatChannel.Party;
                default:
                    return eChatChannel.Local;
            }
        }
        public static char EnumToChar(eChatChannel var)
        {
            switch (var)
            {
                case eChatChannel.Whispers:
                    return '@';
                case eChatChannel.Global:
                    return '#';
                case eChatChannel.Guild:
                    return '&';
                case eChatChannel.Trade:
                    return '$';
                case eChatChannel.Party:
                    return '%';
                case eChatChannel.Local:
                    return '\0';
                default: //eChatChannel.Local
                    return '\0';
            }
        }
    }
}
