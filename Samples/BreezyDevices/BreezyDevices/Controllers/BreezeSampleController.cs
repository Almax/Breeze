using System;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json.Linq;

using Breeze.WebApi;

using BreezyDevices.Models;
namespace BreezyDevices.Controllers {
  
    public class BreezeSampleController : ApiController {

        readonly EFContextProvider<BreezeSampleContext> _contextProvider =
            new EFContextProvider<BreezeSampleContext>();

        [AcceptVerbs("GET")]
        public string Metadata() {
            return _contextProvider.Metadata();
        }
        
        [AcceptVerbs("POST")]
        public SaveResult SaveChanges(JObject saveBundle) {
            return _contextProvider.SaveChanges(saveBundle);
        }
        
        [AcceptVerbs("GET")]
        public IQueryable<BreezeSampleItem> Samples() {
            return _contextProvider.Context.Samples;
        }

    }
}