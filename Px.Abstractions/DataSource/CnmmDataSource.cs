﻿using PCAxis.Menu;
using PCAxis.Menu.Implementations;
using Px.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Px.Abstractions.DataSource
{
    public class CnmmDataSource : IDataSource
    {
        private readonly IItemSelectionResolver _itemSelectionResolver;

        public CnmmDataSource(IItemSelectionResolver itemSelectionResolver)
        {
            _itemSelectionResolver = itemSelectionResolver;
        }

        public PxMenuBase CreateMenu(string id, string language)
        {
            ItemSelection itmSel = _itemSelectionResolver.Resolve((id));

            //Create database object to return
            DatamodelMenu retMenu = ConfigDatamodelMenu.Create(
                language,
                PCAxis.Sql.DbConfig.SqlDbConfigsStatic.DataBases["ssd"],
                                        m =>
                                        {
                                            //m.RootSelection = string.IsNullOrEmpty(nodeId) ? new ItemSelection() : PathHandlerFactory.Create(PCAxis.Web.Core.Enums.DatabaseType.CNMM).GetSelection(nodeId);
                                            m.RootSelection = itmSel;
                                            m.AlterItemBeforeStorage = item =>
                                            {
                                                if (item is PCAxis.Menu.Url)
                                                {
                                                    PCAxis.Menu.Url url = (PCAxis.Menu.Url)item;
                                                }

                                                if (item is TableLink)
                                                {
                                                    TableLink tbl = (TableLink)item;
                                                    string tblId = tbl.ID.Selection;
                                                    //if (!string.IsNullOrEmpty(dbid))
                                                    //{
                                                    //    tbl.ID = new ItemSelection(item.ID.Menu, dbid + ":" + tbl.ID.Selection); // Hantering av flera databaser!
                                                    //}



                                                    if (tbl.Published.HasValue)
                                                    {
                                                        // Store date in the PC-Axis date format
                                                        tbl.SetAttribute("modified", tbl.Published.Value.ToString(PCAxis.Paxiom.PXConstant.PXDATEFORMAT));
                                                    }

                                                }

                                                if (String.IsNullOrEmpty(item.SortCode))
                                                {
                                                    item.SortCode = item.Text;
                                                }
                                            };
                                            m.Restriction = item =>
                                            {
                                                return true;
                                            };
                                        });
            retMenu.RootItem.Sort();

            return retMenu;
        }
    }
}
