
using Lesson2;
using System.ComponentModel;

class Program
{
    static async Task Main(string[] args)
    {
        ETicaretDbContext context = new ETicaretDbContext();


        #region AsNoTracking
        {

        }
        #endregion

        #region AsNoTrackingWithIdentityResolution
        {

        }
        #endregion

        #region AsTracking
        {

        }
        #endregion

        #region UseQueryTrackingBehavior 
        {

        }
        #endregion
    }
}

