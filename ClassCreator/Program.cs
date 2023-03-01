using ClassCreator.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassCreator
{
    internal static class Program
    {
        //public static AppDbContext DbContext;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DbContext = new AppDbContext();
            //// De lijn hieronder uncommenten om database opnieuw aan te maken
            //DbContext.Database.EnsureDeleted();
            //DbContext.Database.EnsureCreated();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            //DbContext?.Dispose();
            //DbContext = null;
        }
    }
}
