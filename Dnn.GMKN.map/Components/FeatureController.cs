/*
' Copyright (c) 2023 kristof pinter
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

//using System.Xml;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;
using System.Collections.Generic;

namespace GMKN.Dnn.Dnn.GMKN.map.Components
{
    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Controller class for Dnn.GMKN.map
    /// 
    /// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
    /// DotNetNuke will poll this class to find out which Interfaces the class implements. 
    /// 
    /// The IPortable interface is used to import/export content from a DNN module
    /// 
    /// The ISearchable interface is used by DNN to index the content of a module
    /// 
    /// The IUpgradeable interface allows module developers to execute code during the upgrade 
    /// process for a module.
    /// 
    /// Below you will find stubbed out implementations of each, uncomment and populate with your own data
    /// </summary>
    /// -----------------------------------------------------------------------------

    //uncomment the interfaces to add the support.
    public class FeatureController //: IPortable, ISearchable, IUpgradeable
    {


        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ExportModule implements the IPortable ExportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be exported</param>
        /// -----------------------------------------------------------------------------
        //public string ExportModule(int ModuleID)
        //{
        //string strXML = "";

        //List<Dnn.GMKN.mapInfo> colDnn.GMKN.maps = GetDnn.GMKN.maps(ModuleID);
        //if (colDnn.GMKN.maps.Count != 0)
        //{
        //    strXML += "<Dnn.GMKN.maps>";

        //    foreach (Dnn.GMKN.mapInfo objDnn.GMKN.map in colDnn.GMKN.maps)
        //    {
        //        strXML += "<Dnn.GMKN.map>";
        //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objDnn.GMKN.map.Content) + "</content>";
        //        strXML += "</Dnn.GMKN.map>";
        //    }
        //    strXML += "</Dnn.GMKN.maps>";
        //}

        //return strXML;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ImportModule implements the IPortable ImportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be imported</param>
        /// <param name="Content">The content to be imported</param>
        /// <param name="Version">The version of the module to be imported</param>
        /// <param name="UserId">The Id of the user performing the import</param>
        /// -----------------------------------------------------------------------------
        //public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        //{
        //XmlNode xmlDnn.GMKN.maps = DotNetNuke.Common.Globals.GetContent(Content, "Dnn.GMKN.maps");
        //foreach (XmlNode xmlDnn.GMKN.map in xmlDnn.GMKN.maps.SelectNodes("Dnn.GMKN.map"))
        //{
        //    Dnn.GMKN.mapInfo objDnn.GMKN.map = new Dnn.GMKN.mapInfo();
        //    objDnn.GMKN.map.ModuleId = ModuleID;
        //    objDnn.GMKN.map.Content = xmlDnn.GMKN.map.SelectSingleNode("content").InnerText;
        //    objDnn.GMKN.map.CreatedByUser = UserID;
        //    AddDnn.GMKN.map(objDnn.GMKN.map);
        //}

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// GetSearchItems implements the ISearchable Interface
        /// </summary>
        /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        /// -----------------------------------------------------------------------------
        //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        //{
        //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

        //List<Dnn.GMKN.mapInfo> colDnn.GMKN.maps = GetDnn.GMKN.maps(ModInfo.ModuleID);

        //foreach (Dnn.GMKN.mapInfo objDnn.GMKN.map in colDnn.GMKN.maps)
        //{
        //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objDnn.GMKN.map.Content, objDnn.GMKN.map.CreatedByUser, objDnn.GMKN.map.CreatedDate, ModInfo.ModuleID, objDnn.GMKN.map.ItemId.ToString(), objDnn.GMKN.map.Content, "ItemId=" + objDnn.GMKN.map.ItemId.ToString());
        //    SearchItemCollection.Add(SearchItem);
        //}

        //return SearchItemCollection;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        //public string UpgradeModule(string Version)
        //{
        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        #endregion

    }

}
