using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR5.BuilderBurger;
using PR5.DBCon;

namespace PR5.BuilderBurger
{
    public interface IBurgerBuilder
    {
        IBurgerBuilder AddCheese();
    
        IBurgerBuilder AddBacon();
        
        
        IBurgerBuilder AddLetuce();
        
        
        IBurgerBuilder AddTomato();
        
        IBurgerBuilder AddPickles();
       
        Burgers GetBurgers();
        
    }
}
