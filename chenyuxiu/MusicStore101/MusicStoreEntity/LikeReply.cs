﻿using MusicStoreEntity.UserAndRole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreEntity
{
    /// <summary>
    /// 保存点赞和踩
    /// </summary>
    public class LikeReply
    {

        public Guid ID { get; set; }

        public Reply Reply { get; set; }

        public bool IsNotLike { get; set; } //LIKE保存true hatw促false

        public virtual Person person { get; set; }

        public DateTime CreateDateTime { get; set; }

        public LikeReply()
        {
            ID = Guid.NewGuid();
            CreateDateTime = DateTime.Now;
        }
    }
}