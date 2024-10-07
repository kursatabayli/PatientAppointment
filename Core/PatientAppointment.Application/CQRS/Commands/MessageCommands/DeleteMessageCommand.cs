﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.MessageCommands
{
    public class DeleteMessageCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteMessageCommand(int id)
        {
            Id = id;
        }
    }
}
