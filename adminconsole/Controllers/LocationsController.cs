﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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




        /// <summary>
        /// GET:
        /// 
        /// Locations objects with joins on Contacts, SpecialQualities, and HoursPerDayOfTheWeek.
        /// </summary>
        /// 
        /// 
        /// <returns> Index View with injected list of Locations objects </returns>
        public async Task<IActionResult> Index()
        {
            var results = await backend.IndexAsync().ConfigureAwait(false);
            return View(results);
        }






        /// <summary>
        /// GET:
        /// 
        /// Locations objects with joins on Contacts, SpecialQualities, and HoursPerDayOfTheWeek.
        /// </summary>
        /// 
        /// 
        /// 
        /// <returns> Deleted View with injected list of Locations objects </returns>
        public async Task<IActionResult> Deleted()
        {
            var results = await backend.IndexAsync(true).ConfigureAwait(false);
            return View(results);
        }






        /// <summary>
        /// GET: Locations/Details/5
        /// 
        /// Singular Locations object joined with Contacts, SpecialQualities, and HoursPerDayOfTheWeek.
        /// </summary>
        /// 
        ///
        /// <returns> Details View with injected list of Locations objects </returns>
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








        /// <summary>
        /// GET: Locations/Create
        /// 
        /// Displays the Create View with the intent of inserting into the Database.
        /// </summary>
        /// 
        /// 
        /// 
        /// <returns> Create View </returns>
        public IActionResult Create()
        {
            return View();
        }













        /// <summary>
        /// POST: 
        /// 
        /// 
        /// Receives a LocationsContactsSpecialQualitiesViewModel Object with the intent of inserting into the Database.
        /// </summary>
        /// 
        /// 
        /// 
        /// <param name="newLocation"> LocationsContactsSpecialQualitiesViewModel Object, instantiated with values provided by the user </param>
        /// 
        /// 
        /// 
        /// <returns> Either returns the existing view if there is an error, otherwise returns the Index View </returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("LocationId," +
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














        /// <summary>
        /// GET: Locations/Edit/5
        /// 
        /// Allows the user to edit the Location information of a given Locations Object.
        /// </summary>
        /// 
        /// 
        /// 
        ///
        /// <param name="id"> string ID of the Locations Object </param>
        /// 
        /// 
        /// 
        /// 
        /// <returns> Returns Not Found if the ID is null or does not exist in the Database, otherwise returns the Index View </returns>
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locations = await backend.EditAsync(id).ConfigureAwait(false);
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
















        /// <summary>
        /// POST: Locations/Edit/5
        /// 
        /// Creates the LocationsContactsSpecialQualitiesViewModel Object and attempts to insert into the Database.
        /// </summary>
        /// 
        /// 
        /// 
        /// 
        /// <param name="id"> The string ID of a Locations Object </param>
        /// 
        /// 
        /// <param name="location"> The Locations Object containing the edited Location data </param>
        /// 
        /// 
        /// <returns> 
        /// 
        /// Returns the current View if the ID is null or if there is a Database error when attempting to insert. 
        /// If the ID isn't found in the Database, return a Not Found. Otherwise, returns Index View.
        /// 
        /// </returns>
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


            // Get the Recrord to ensure it exists
            var updatedRecord = backend.GetLocationAsync(location.LocationId);
            if (updatedRecord == null)
            {
                return NotFound();
            }


            var result = await backend.EditPostAsync(location).ConfigureAwait(false);
          
            if (!result) // DB update error, retry
            {
                return View(location);
            }

            return RedirectToAction(nameof(Index));
        }










        /// <summary>
        /// GET: Locations/Delete/5
        /// 
        /// Gets the Locations Object that the user wants to Delete. This Locations Object is joined with all other tables.
        /// </summary>
        /// 
        /// 
        /// <param name="id"> The ID of the Locations record the user wants to Delete </param>
        /// 
        /// 
        /// <returns> Not Found if the ID is null or does not exist in the Database. Otherwise returns the Delete View</returns>
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locations = await backend.GetLocationAsync(id).ConfigureAwait(false);
            if (locations == null)
            {
                return NotFound();
            }

            return View(locations);
        }












        /// <summary>
        /// POST: Locations/Delete/5
        /// 
        /// Marks the Locations Object's SoftDelete field as True
        /// </summary>
        /// 
        /// 
        /// <param name="id"> The string ID of the Locations Object the user wants to Delete </param>
        /// 
        /// 
        /// <returns> The Delete View if there was a Database error for user to retry, otherwise returns the Index View </returns>
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














        /// <summary>
        /// GET: Locations/Deleted/5
        /// 
        /// Gets a previously Deleted Locations Object
        /// </summary>
        /// 
        /// 
        /// <param name="id"> The string ID of the Locations Object record the user wants to Recover </param>
        /// 
        /// 
        /// <returns> Deleted View if there was a Database error or if the ID is null, otherwise returns the Index View </returns>
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
    }
}

