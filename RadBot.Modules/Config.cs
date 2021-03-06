﻿#region

using RadLibrary.Configuration.Scheme;

#endregion

namespace RadBot
{
    public class Config
    {
        [SchemeParameter(Comment = "The bot token")]
        public string Token;

        [SchemeParameter(Comment = "The bot prefix")]
        public string Prefix;

        [SchemeParameter(Comment = "The embed builder's color (hex format)")]
        public string BuilderColor;

        [SchemeParameter(Comment = "The bullet symbol (•)")]
        public string BulletSymbol;

        [SchemeParameter("youtube-dl", Comment = "The bot token")]
        public string YoutubeDl;

        [SchemeParameter(Comment = "The path to SoundPad's library")]
        public string SoundPadPath;

        [SchemeParameter(Comment = "The volume multiplier for SoundPad")]
        public string SoundPadVolume;
    }
}