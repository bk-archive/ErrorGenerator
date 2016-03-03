using System;
using System.Threading;

namespace ErrorGenerator
{
    public partial class Default : System.Web.UI.Page
    {
        Random r = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {
            int cointoss = r.Next(5);

            TimeSpan ts = new TimeSpan(1, 0, 0, 0);
            


            switch (cointoss)
            {
                case 1:
                Thread.Sleep(ts);
                    break;
                case 2:
                    System.Diagnostics.Trace.TraceError("Generating 502");
                    Response.StatusCode = 502;
                    
                    break;
                case 3:
                    System.Diagnostics.Trace.TraceError("Generating 503");
                    Response.StatusCode = 503;
                    break;
                default:
                    System.Diagnostics.Trace.TraceInformation("Generating 200-OK");
                    Response.StatusCode = 200;
                    break;
            }
        }
    }
}