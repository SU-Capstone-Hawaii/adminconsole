using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using adminconsole.Models;
using adminconsole.Backend;

namespace adminconsole.Controllers
{
    public class LocationsController : Controller
    {
        private readonly MaphawksContext _context;
        private LocationsContactSpecialQualitiesBackend backend;

        public LocationsController(MaphawksContext context)
        {
            _context = context;
            backend = new LocationsContactSpecialQualitiesBackend(context);
        }

        // GET: Locations
        public async Task<IActionResult> Index()
        {
            var results = await backend.IndexAsync().ConfigureAwait(false);
            return View(results);
        }

        // GET: Locations
        public async Task<IActionResult> Deleted()
        {
            var results = await backend.IndexAsync(true).ConfigureAwait(false);
            return View(results);
        }

        // GET: Locations/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var result = await backend.DetailsAsync(id).ConfigureAwait(false);

            if (result == null)
            {
                return NotFound();
            }

            return View(result);
        }

        // GET: Locations/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LocationId," +
            "CoopLocationId," +
            "TakeCoopData," +
            "SoftDelete," +
            "Name," +
            "Address," +
            "City," +
            "County," +
            "State," +
            "PostalCode," +
            "Country," +
            "Latitude," +
            "Longitude," +
            "Hours," +
            "RetailOutlet," +
            "LocationType," +
            "Phone," +
            "Fax," +
            "WebAddress," +
            "RestrictedAccess," +
            "AcceptDeposit," +
            "AcceptCash," +
            "EnvelopeRequired," +
            "OnMilitaryBase," +
            "OnPremise," +
            "Surcharge," +
            "Access," +
            "AccessNotes," +
            "InstallationType," +
            "HandicapAccess," +
            "Cashless," +
            "DriveThruOnly," +
            "LimitedTransactions," +
            "MilitaryIdRequired," +
            "SelfServiceDevice," +
            "SelfServiceOnly," +
            "HoursMonOpen," +
            "HoursMonClose," +
            "HoursTueOpen," +
            "HoursTueClose," +
            "HoursWedOpen," +
            "HoursWedClose," +
            "HoursThuOpen," +
            "HoursThuClose," +
            "HoursFriOpen," +
            "HoursFriClose," +
            "HoursSatOpen," +
            "HoursSatClose," +
            "HoursSunOpen," +
            "HoursSunClose," +
            "HoursDtmonOpen," +
            "HoursDtmonClose," +
            "HoursDttueOpen," +
            "HoursDttueClose," +
            "HoursDtwedOpen," +
            "HoursDtwedClose," +
            "HoursDtthuOpen," +
            "HoursDtthuClose," +
            "HoursDtfriOpen," +
            "HoursDtfriClose," +
            "HoursDtsatOpen," +
            "HoursDtsatClose," +
            "HoursDtsunOpen," +
            "HoursDtsunClose")] LocationsContactSpecialQualitiesViewModel newLocation)
        {
            if (!ModelState.IsValid)
            {
                return View(newLocation);
            }
            var result = backend.Create(newLocation);
            return RedirectToAction(nameof(Index));
        }

        // GET: Locations/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locations = await backend.Edit(id).ConfigureAwait(false);
            // If error in DB query
            if (locations == null)
            {
                return NotFound();
            }

            // If no location found
            if (locations.locations == null)
            {
                return NotFound();
            }
            return View(locations);
        }

        // POST: Locations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("LocationId," +
            "CoopLocationId," +
            "TakeCoopData," +
            "SoftDelete," +
            "Name," +
            "Address," +
            "City," +
            "County," +
            "State," +
            "PostalCode," +
            "Country," +
            "Latitude," +
            "Longitude," +
            "Hours," +
            "RetailOutlet," +
            "LocationType," +
            "Phone," +
            "Fax," +
            "WebAddress," +
            "RestrictedAccess," +
            "AcceptDeposit," +
            "AcceptCash," +
            "EnvelopeRequired," +
            "OnMilitaryBase," +
            "OnPremise," +
            "Surcharge," +
            "Access," +
            "AccessNotes," +
            "InstallationType," +
            "HandicapAccess," +
            "Cashless," +
            "DriveThruOnly," +
            "LimitedTransactions," +
            "MilitaryIdRequired," +
            "SelfServiceDevice," +
            "SelfServiceOnly," +
            "HoursMonOpen," +
            "HoursMonClose," +
            "HoursTueOpen," +
            "HoursTueClose," +
            "HoursWedOpen," +
            "HoursWedClose," +
            "HoursThuOpen," +
            "HoursThuClose," +
            "HoursFriOpen," +
            "HoursFriClose," +
            "HoursSatOpen," +
            "HoursSatClose," +
            "HoursSunOpen," +
            "HoursSunClose," +
            "HoursDtmonOpen," +
            "HoursDtmonClose," +
            "HoursDttueOpen," +
            "HoursDttueClose," +
            "HoursDtwedOpen," +
            "HoursDtwedClose," +
            "HoursDtthuOpen," +
            "HoursDtthuClose," +
            "HoursDtfriOpen," +
            "HoursDtfriClose," +
            "HoursDtsatOpen," +
            "HoursDtsatClose," +
            "HoursDtsunOpen," +
            "HoursDtsunClose")] LocationsContactSpecialQualitiesViewModel location)
        {
            if (location == null) // Edit submit error
            {
                return View(location);
            }

            if (id != location.LocationId) // IDs don't match
            {
                return NotFound();
            }

            if (!ModelState.IsValid) // Invalid model state
            {
                return View(location);
            }

            var result = await backend.EditPostAsync(location).ConfigureAwait(false);
          
            if (!result) // DB update error, retry
            {
                return View(location);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Locations/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locations = backend.GetLocation(id);
            if (locations == null)
            {
                return NotFound();
            }

            return View(locations);
        }

        // POST: Locations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var result = await backend.DeleteConfirmedAsync(id).ConfigureAwait(false);
            
            if (!result)
            {
                return RedirectToAction(nameof(Delete));
            }
                
           return RedirectToAction(nameof(Index));
        }

        // GET: Locations/Deleted/5
        [ActionName("Recover")]
        public async Task<IActionResult> Recover(string id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Deleted));
            }
            var result = await backend.RecoverAsync(id).ConfigureAwait(false);

            if (!result)
            {
                return RedirectToAction(nameof(Deleted));
            }

            return RedirectToAction(nameof(Index));
        }

        private bool LocationsExists(string id)
        {
            return _context.Locations.Any(e => e.LocationId == id);
        }
    }
}

