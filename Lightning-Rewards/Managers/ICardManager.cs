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
        IQueryable<CardLite> GetPendingCardDetails(long userId);

        IQueryable<CardLite> GetPendingApprovalsDetails(long userId);

        Card ClaimCard(long cardId);

        Card ApproveCard(long cardId);

        Card CreateCard(CardRequest request);

        string RedeemCards(long userId);

        List<Card> ApproveAllCards(long managerId);
    }
}
