﻿using System.IO;
using System.Xml.Linq;
using Microsoft.AspNetCore.Hosting;
using PCAxis.Menu;
using PCAxis.Menu.Implementations;
using Px.Abstractions.Interfaces;

namespace PxWeb.Code.Api2.DataSource.PxFile
{
    public class PxFileDataSource : IDataSource
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public PxFileDataSource(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        
        public PxMenuBase CreateMenu(string id, string language)
        {
            ////Get menu-file
            //DatabaseInfo currentdb = PXWeb.Settings.Current.General.Databases.GetPxDatabase(dbid);

            //if (currentdb != null)
            //{
            //    StringBuilder sb = new StringBuilder(PXWeb.Settings.Current.General.Paths.PxDatabasesPath);
            //    sb.Append("/");
            //    sb.Append(currentdb.Id);
            //    sb.Append("/");
            //    sb.Append(PXWeb.Settings.Current.General.Databases.PxDatabaseFilename);
            //    //string _xmlFile = HttpContext.Current.Server.MapPath(sb.ToString());

            //TODO: get path to database from appsetting
            //string _xmlFile = @"C:\dev\Github\PxWeb\PXWeb\Resources\PX\Databases\Example\Menu.xml";
            //string contentRootPath = _hostingEnvironment.ContentRootPath;
            string webRootPath = _hostingEnvironment.WebRootPath;
            string xmlFilePath = Path.Combine(_hostingEnvironment.WebRootPath, "Database", "Menu.xml");


            XmlMenu menu = new XmlMenu(XDocument.Load(xmlFilePath), language,
                    m =>
                    {
                        m.Restriction = item =>
                        {
                            return true;
                        };
                    });

            //ItemSelection cid = PathHandlerFactory.Create(PCAxis.Web.Core.Enums.DatabaseType.PX).GetSelection(nodeId);
            //menu.SetCurrentItemBySelection(cid.Menu, cid.Selection);
            //currentItem = menu.CurrentItem;
            return menu;
            //}
            //currentItem = null;
            //return null;
        }
    }
}