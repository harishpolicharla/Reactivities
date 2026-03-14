using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController(IMediator mediator) : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            // return await context.Activities.ToListAsync();
            return await mediator.Send(new Application.Activities.Queries.GetActivityList.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivityDetail(string id)
        {
            // var activity = await context.Activities.FindAsync(id);

            // if (activity == null) return NotFound();

            // return activity;

            return await mediator.Send(new Application.Activities.Queries.GetActivityDetails.Query { Id = id });
        }
    }
}