﻿using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public NotificationType NotificationType { get; set; }
        public DateTime? OriginalDateTime { get; set; }

        [Required]
        public Gig Gig { get; set; }
    }
}