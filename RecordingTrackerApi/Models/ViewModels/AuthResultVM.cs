﻿using System;
namespace RecordingTrackerApi.Models.ViewModels
{
    public class AuthResultVM
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public DateTime ExpiresAt { get; set; }

    }
}

