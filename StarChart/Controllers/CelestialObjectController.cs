using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    private readonly ApplicationDbContext _context;

    public Context ApplicationDbContext
    {
        Context = _context;
    }

    public class CelestialObjectController : ControllerBase
    {
        RouteAttribute("");
        ApiControllerAttribute();
    }
}
