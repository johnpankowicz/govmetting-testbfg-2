﻿using Ardalis.Specification;

namespace GM.Application.AppCore.Entities.Govbodies
{
    public sealed class GovbodyWithMeetingsSpecification : Specification<Govbody>
    {
        public GovbodyWithMeetingsSpecification(int govbodyId)
        {
            Query
                .Where(b => b.Id == govbodyId)
                .Include(b => b.Meetings);
        }
    }
}