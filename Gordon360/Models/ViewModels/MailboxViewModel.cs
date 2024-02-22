﻿using Gordon360.Models.Gordon360;

namespace Gordon360.Models.ViewModels;

public class MailboxViewModel
{
    public string Combination { get; set; }

    public static implicit operator MailboxViewModel(Mailboxes req)
    {
        return new MailboxViewModel
        {
            Combination = req?.Combination ?? "",
        };
    }
}
