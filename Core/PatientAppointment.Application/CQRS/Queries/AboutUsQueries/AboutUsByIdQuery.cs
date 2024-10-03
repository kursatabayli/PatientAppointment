﻿using MediatR;
using PatientAppointment.Application.CQRS.Results.AboutUsResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Queries.AboutUsQueries
{
    public class AboutUsByIdQuery : IRequest<AboutUsResult>
    {
        public int Id { get; set; }

        public AboutUsByIdQuery(int id)
        {
            Id = id;
        }
    }
}
