﻿using Labb3.API.Services;
using Labb3.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinksController : ControllerBase
    {
        private ILabbTreRepository<Link> _linkRepo;

        public LinksController(ILabbTreRepository<Link> linkRepo)
        {
            _linkRepo = linkRepo;
        }

        //Fungerar
        [HttpGet]
        public async Task<IActionResult> GetAllLinks()
        {
            try
            {
                return Ok(await _linkRepo.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error to GetAllLinks data from Database...");
            }
        }

        //Fungerar
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLink(int id)
        {
            try
            {
                var single = await _linkRepo.GetSingle(id);
                if (single == null)
                {
                    return NotFound($"Could not find Link with ID {id} in database");
                }
                return Ok(single);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error to GetLink data from Database...");
            }
        }

        //Fungerar
        [HttpPost]
        public async Task<ActionResult<Link>> AddLink(Link newLink)
        {
            try
            {
                if (newLink == null)
                {
                    return BadRequest();
                }
                var newLinkToAdd = await _linkRepo.Add(newLink);
                return CreatedAtAction(nameof(GetLink),
                    new { id = newLinkToAdd.LinkId }, newLinkToAdd);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error, failed to Create a new object to Database...");
            }
        }
    }
}
