using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Vulnerabilites.Data.Context;
using Vulnerabilities.Services.Contracts;
using Vulnerabilities.Web.Models.Charts;

namespace Vulnerabilities.Web.Controllers
{
    public class ChartController:Controller
    {

        private readonly IVulnerabilityService vulnerabilities;
        private readonly VulnerabilityDBContext db;
        private readonly MpcDBContext mpcConfigDB;
        private readonly MPCMissingPatchDbContext mpcPatchDB;
        private readonly int currentMonth = DateTime.Now.Day <= 26 ? DateTime.Now.AddMonths(-1).Month : DateTime.Now.Month;

        public ChartController(IVulnerabilityService vulnerabilities, VulnerabilityDBContext db, MpcDBContext mpcConfigDB, MPCMissingPatchDbContext mpcPatchDB)
        {
            this.vulnerabilities = vulnerabilities;
            this.db = db;
            this.mpcConfigDB = mpcConfigDB;
            this.mpcPatchDB = mpcPatchDB;
        }

        [Route(nameof(ChartView))]
        public ActionResult ChartView(int?id)
        {

            List<DataPoint> dataPoints = new List<DataPoint>();

            var vulnerability = this.vulnerabilities.FindVulnerabilityById(id);

            Dictionary<string, int> values = this.vulnerabilities.AffectedServersCountPerMonth(id);


            int[] monthlyStats = new int[6];

            foreach (var item in values)
            {

                ViewData.Add(new KeyValuePair<string, object>(item.Key, item.Value));
            }

            for (int i = 0; i < values.Count; i++)
            {
                monthlyStats[i] = values.Values.ElementAt(i);
            }

           

            foreach (var item in values.Reverse())
            {
                dataPoints.Add(new DataPoint(item.Key, item.Value));
            }
            

            //dataPoints.Add(new DataPoint("Albert", 10));
            //dataPoints.Add(new DataPoint("Tim", 30));
            //dataPoints.Add(new DataPoint("Wilson", 17));
            //dataPoints.Add(new DataPoint("Joseph", 39));
            //dataPoints.Add(new DataPoint("Robert", 30));
            //dataPoints.Add(new DataPoint("Sophia", 25));
            //dataPoints.Add(new DataPoint("Emma", 15));

            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);

            return View();
        }
    }
}
