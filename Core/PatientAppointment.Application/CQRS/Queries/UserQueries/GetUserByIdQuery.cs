﻿using MediatR;
using PatientAppointment.Application.CQRS.Results.UserResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Queries.UserQueries
{
    public class GetUserByIdQuery:IRequest<UserResult>
    {
        public int Id { get; set; }

        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
    }
}
