﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lightning_Rewards.Models;

namespace Lightning_Rewards.Managers
{
    public interface ICardManager
    {
        IQueryable<Card> GetPendingCardDetails(long userId);

        IQueryable<Card> GetPendingApprovalsDetails(long userId);

        void ClaimCard(long cardId);

        void ApproveCard(long cardId);

        Card CreateCard(CardRequest request);

        string RedeemCards(long userId);
    }
}
