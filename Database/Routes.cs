using System.Collections;
using System.Linq;

namespace iCycle.Database
{
    partial class RoutesDataContext
    {

		#region Methods (4) 


		// Public Methods (3) 

       public void AddRoute(Route route)
       {
           Routes.InsertOnSubmit(route);
           SubmitChanges();
       }

       public void Edit(Route route)
       {
           UpdateRoute(route);
       }

      public IEnumerable GetRoutes()
      {
          var routes = from r in Routes select r;
          return routes;
      }



		// Internal Methods (1) 

       internal int GetNextRouteId()
       {
           var routes = from r in Routes select r.Id;
           int id = 0;

           foreach (var rid in routes)
           {
               if (rid > id)
               {
                   id = rid;
               }
           }

           return id+1;
       }


		#endregion Methods 

    }
}


