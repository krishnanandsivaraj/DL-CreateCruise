using DreamLines.Core.Domain.Entities;
using DreamLines.Infrastructure.Data.EntityFramework.Repositories;
using DreamLines.Infrastructure.IntegrationTests.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace DreamLines.Infrastructure.Tests
{
    public class CruiseRepositoryTests
    {
        [Fact]
        public async void Insert_CruiseLine_And_Return_OK()
        {
            List<CruiseLine> items = new List<CruiseLine>();
            using (StreamReader r = new StreamReader("cruise-lines.json")) { items = JsonConvert.DeserializeObject<List<CruiseLine>>(r.ReadToEnd()); }
            CruiseRepository cruise = new CruiseRepository();
            bool result=await cruise.InsertCruise(items);
            Assert.True(result);
        }

        [Fact]
        public async void Insert_Ports_And_Return_OK()
        {
            List<Port> items = new List<Port>();
            using (StreamReader r = new StreamReader("ports.json")) { items = JsonConvert.DeserializeObject<List<Port>>(r.ReadToEnd()); }
            CruiseRepository cruise = new CruiseRepository();
            bool result = await cruise.InsertPorts(items);
            Assert.True(result);
        }

        [Fact]
        public async void Insert_Ships_And_Return_OK()
        {
            List<Ships> items = new List<Ships>();

            List<Ship> ships = new List<Ship>();
            using (StreamReader r = new StreamReader("ships.json")) { items = JsonConvert.DeserializeObject<List<Ships>>(r.ReadToEnd()); }
            CruiseRepository cruise = new CruiseRepository();
            foreach (Ships item in items)
            {
                foreach (var itemType in item.cabinTypes)
                {
                    ships.Add(new Ship { ship_id = item.ship_id, title = item.title, company_id = item.company_id });
                }
            }
            bool result = await cruise.InsertShip(ships);
            Assert.True(result);
        }

        [Fact]
        public async void Insert_Catagories_And_Return_OK()
        {
            List<Ships> items = new List<Ships>();

            List<Cabintype> cabinType = new List<Cabintype>();
            using (StreamReader r = new StreamReader("ships.json")) { items = JsonConvert.DeserializeObject<List<Ships>>(r.ReadToEnd()); }
            CruiseRepository cruise = new CruiseRepository();
            foreach (Ships item in items)
            {
                foreach (var itemType in item.cabinTypes)
                {
                    cabinType.Add(new Cabintype { nid=itemType.nid, company_id=item.company_id, ship_id=item.ship_id, title=itemType.title });
                }
            }
            bool result = await cruise.InsertCabinTypes(cabinType);
            Assert.True(result);
        }
    }
}
