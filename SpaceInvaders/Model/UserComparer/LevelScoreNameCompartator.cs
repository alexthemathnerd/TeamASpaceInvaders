﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Model.UserComparer
{
    public class LevelScoreNameComparer : IComparer<User>
    {
        public int Compare(User user1, User user2)
        {
            if (user1 == null)
            {
                throw new ArgumentException();
            }
            if (user2 == null)
            {
                throw new ArgumentException();
            }

            if (user1.CompletedLevel.CompareTo(user2.CompletedLevel) != 0)
            {
                return -1 * user1.CompletedLevel.CompareTo(user2.CompletedLevel);
            }

            if (user1.Score.CompareTo(user2.Score) != 0)
            {
                return -1 * user1.Score.CompareTo(user2.Score);
            }
            return user1.Name.CompareTo(user2.Name);
        }
    }
}