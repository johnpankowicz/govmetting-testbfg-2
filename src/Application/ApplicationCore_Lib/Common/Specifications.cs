﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using GM.ApplicationCore.Entities.Govbodies;

// Experiment with specification pattern - (not yet used)

namespace GM.DatabaseAccess
{
    public abstract class Specification<T>
    {
        public abstract Expression<Func<T, bool>> ToExpression();

        public bool IsSatisfiedBy(T entity)
        {
            Func<T, bool> predicate = ToExpression().Compile();
            return predicate(entity);
        }
    }

    public class HasScheduledMeetings_Spec : Specification<Govbody>
    {
        public override Expression<Func<Govbody, bool>> ToExpression()
        {
            return gb => gb.ScheduledMeetings.Count > 0;
        }
    }
}
