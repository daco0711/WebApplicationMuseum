using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationMuseum
{
    public partial class _Default : System.Web.UI.Page
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        //ServiceReference1.Service1Client klient = new ServiceReference1.Service1Client();

        protected void updateMuseum(Object sender, EventArgs e)
        {
            String museumName = TextMuseumName.Text;
            String museumAddress = TextMuseumAddress.Text;
            String established = TextEstablished.Text;
            String museumId = TextMuseumId.Text;

            DateTime MusEst = DateTime.Now;
            if (established !="" && museumId !="")
                try
                {
                    MusEst = Convert.ToDateTime(established);
                    Int32 musId = Convert.ToInt32(museumId);
                    client.updateMuseum(musId, museumName, museumAddress, MusEst);
                }

           
                catch (Exception exc)
                {
                    
                }

           
           

           

           
            TextMuseumAddress.Text = "";
            TextMuseumName.Text = "";
            TextEstablished.Text = "";

            Response.Redirect(Request.RawUrl);

        }

        protected void updateBuyers(Object sender, EventArgs e)
        {
            String buyersId = txtUpdBuyersID.Text.Trim();
            String buyersName = txtUpdBuyersName.Text.Trim();
            String buyersSurname = txtUpdBuyersSurname.Text.Trim();
            String buyersAddress = txtUpdBuyersAddress.Text.Trim();
            String buyersCountry = txtUpdBuyersCountry.Text.Trim();
            if (buyersId != "")
            {
                Int32 buyID = Convert.ToInt32(buyersId);
                client.updateBuyers(buyID, buyersName, buyersSurname, buyersAddress, buyersCountry);

            }
            txtUpdBuyersID.Text = "";
            txtUpdBuyersName.Text = "";
            txtUpdBuyersSurname.Text = "";
            txtUpdBuyersAddress.Text = "";
            txtUpdBuyersCountry.Text = "";

            Response.Redirect(Request.RawUrl);


        }

        protected void updateUsers(object sender, EventArgs e)
        {

            String userID = txtUpdateUserID.Text;
            String name = txtUpdateName.Text;
            String userName = txtUpdateUsername.Text;
            String password = txtUpdatePassword.Text;
            String isAdministrator = txtUpdateIsAdministrator.Text;
            if (userID != "")
            {
                
                
                    Int32 UserID = Convert.ToInt32(userID);
                    Boolean IsAdm = Convert.ToBoolean(isAdministrator);
                    client.updateUsers(UserID, name, userName, password, IsAdm);

          }
            Response.Redirect(Request.RawUrl);
        }

        protected void updateLocations(Object sender, EventArgs e)
        {
            String locationId = TxtUpdLocationId.Text;
            String locationName = TxtUpdLocationName.Text;
            String surface = TxtUpdSurface.Text;
            String state = TxtUpdState.Text;
            String leasePrice = TxtUpdLeasePrice.Text;
            String museumId = TxtUpdMuseumIdFK.Text;
            String country = TxtUpdCountry.Text;

            if (locationId != "" && museumId != "")
            {
                try
                {
                    Int32 locId = Convert.ToInt32(locationId);
                    Int32 musId = Convert.ToInt32(museumId);
                    client.updateLocations(locId, locationName, surface, state, leasePrice, musId, country);
                }
                catch (Exception exc)
                {
                    TxtUpdLocationId.Text = "ERROR";
                }
                TxtUpdLocationId.Text = "";
                TxtUpdLocationName.Text = "";
                TxtUpdSurface.Text = "";
                TxtUpdState.Text = "";
                TxtUpdLeasePrice.Text = "";
                TxtUpdMuseumIdFK.Text = "";
                TxtUpdCountry.Text = "";

                Response.Redirect(Request.RawUrl);

            }
            else
            {
                Console.WriteLine("ELSE");
            }
        }

        protected void updateExhibits(Object sender,EventArgs e)
        {
            String exhibitId = txtUpdExhId.Text;
            String type = txtUpdType.Text;
            String dimensions = txtUpdDimensions.Text;
            String historicPeriod = txtUpdHistoricPeriod.Text;
            String locationIdFK = txtUpdLocationIdFK.Text;
            String orderFormIdFK = txtUpdOrderFormIdFK.Text;

            if (exhibitId != "" && locationIdFK != "" && orderFormIdFK !="")
            {
                try
                {
                    Int32 exhId = Convert.ToInt32(exhibitId);
                    Int32 locId = Convert.ToInt32(locationIdFK);
                    Int32 orderFFK = Convert.ToInt32(orderFormIdFK);
                    client.updateExhibits(exhId,type,dimensions,historicPeriod,locId,orderFFK);
                }
                catch (Exception exc)
                {
                    TxtUpdLocationId.Text = "ERROR";
                }
            
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                Console.WriteLine("ELSE");
            }
        }

        protected void updateOrderForms(Object sender, EventArgs e)
        {
            String orderFormId = txtUpdOrderFormID.Text;
            String date = txtUpdOrderFormDate.Text;
            String buyerAddress = txtUpdOrderFormBuyerAddress.Text;
            String buyerIdFk = txtUpdOrderFormsBuyerIdFK.Text;

            if (buyerIdFk != "" && buyerIdFk != "")
            {
                Int32 OrdFrmID = Convert.ToInt32(orderFormId);
                DateTime Date = Convert.ToDateTime(date);
                Int32 buyerIDFK = Convert.ToInt32(buyerIdFk);
                client.updateOrderForms(OrdFrmID,Date, buyerAddress, buyerIDFK);


            }

          

            txtUpdOrderFormID.Text = "";
            txtUpdOrderFormDate.Text = "";
            txtUpdOrderFormBuyerAddress.Text = "";
            txtUpdOrderFormsBuyerIdFK.Text = "";

            Response.Redirect(Request.RawUrl);


        }

        protected void findLocations(Object sender, EventArgs e)
        {

            String locationName = TxtUpdsearchLocations.Text;
            if (!locationName.Equals(""))
            {
                try
                {
                    ServiceReference1.Locations[] location = client.findLocations(locationName);
                    List<ServiceReference1.Locations> LocationList = new List<ServiceReference1.Locations>(location);
                    TableLocations.Rows.Clear();
                    foreach (ServiceReference1.Locations loc in LocationList)
                        if (locationName != null)
                        {
                            TableRow row = new TableRow();
                            TableCell cellLocationID = new TableCell();
                            TableCell cellLocationName = new TableCell();
                            TableCell cellSurface = new TableCell();
                            TableCell cellState = new TableCell();
                            TableCell cellLeasePrice = new TableCell();
                            TableCell cellMuseumIdFK = new TableCell();
                            TableCell cellCountry = new TableCell();

                            cellLocationID.Text = loc.LocationId.ToString();
                            cellLocationName.Text = loc.LocationName;
                            cellSurface.Text = loc.Surface;
                            cellState.Text = loc.State;
                            cellLeasePrice.Text = loc.LeasePrice;
                            cellMuseumIdFK.Text = loc.MuseumIdFK.ToString();
                            cellCountry.Text = loc.Country;

                            row.Controls.Add(cellLocationID);
                            row.Controls.Add(cellLocationName);
                            row.Controls.Add(cellSurface);
                            row.Controls.Add(cellState);
                            row.Controls.Add(cellLeasePrice);
                            row.Controls.Add(cellMuseumIdFK);
                            row.Controls.Add(cellCountry);

                            TableLocations.Rows.Add(row);
                        }
                    
                }
                catch (FormatException fe)
                {
                }
                
            }
            TxtUpdsearchLocations.Text = "";
        }
        protected void findOrderForms(Object sender, EventArgs e)
        {
            String buyersIDFK = txtFindOrderFormsBuyerIDFK.Text.Trim();
            String buyerAdress = txtFindOrderFormsBuyerAdress.Text.Trim();

            if (buyersIDFK != "" || buyerAdress != "")
            {
                try
                {

                    Int32 buyIDFK = -1;
                    if (buyersIDFK != "")
                    {
                        buyIDFK = Convert.ToInt32(buyersIDFK);
                    }
                    ServiceReference1.OrderForms[] orderForm = client.findOrderForms(buyIDFK, buyerAdress);
                    List<ServiceReference1.OrderForms> OrderFormsList = new List<ServiceReference1.OrderForms>(orderForm);
                    TableOrderForms.Rows.Clear();
                    foreach (ServiceReference1.OrderForms ord in OrderFormsList) 
                    {
                            TableRow row = new TableRow();
                            TableCell cellOrderFormID = new TableCell();
                            TableCell cellDate = new TableCell();
                            TableCell cellBuyerAddress = new TableCell();
                            TableCell cellBuyerIdFK = new TableCell();

                            cellOrderFormID.Text = ord.OrderFormId.ToString();
                            cellDate.Text = ord.Date.ToString();
                            cellBuyerAddress.Text = ord.BuyerAddress;
                            cellBuyerIdFK.Text = ord.BuyerIdFK.ToString();

                            row.Controls.Add(cellOrderFormID);
                            row.Controls.Add(cellDate);
                            row.Controls.Add(cellBuyerAddress);
                            row.Controls.Add(cellBuyerIdFK);

                            TableOrderForms.Rows.Add(row);
                        }
                }
                catch (FormatException exc)
                {
                    
                }
                txtFindOrderFormsBuyerAdress.Text = "";
                txtFindOrderFormsBuyerIDFK.Text = "";
            }
        }
            

        

        protected void findExhibits(Object sender, EventArgs e)
        {
            String type = TxtFindType.Text;
            String historicPeriod = TxtFindHisPer.Text;

            if (!type.Equals("") || !historicPeriod.Equals(""))
            {
                try
                {
                    ServiceReference1.Exhibits[] exhibit = client.findExhibits(type, historicPeriod);
                    List<ServiceReference1.Exhibits> ExhibitsList = new List<ServiceReference1.Exhibits>(exhibit);
                    TableExhibits.Rows.Clear();
                    foreach (ServiceReference1.Exhibits exh in ExhibitsList)
                        if (type != null || historicPeriod != null)
                        {
                            TableRow row = new TableRow();
                            TableCell cellEhibitsID = new TableCell();
                            TableCell cellType = new TableCell();
                            TableCell cellDimensions = new TableCell();
                            TableCell cellHistoricPeriod = new TableCell();
                            TableCell cellLocationIdFK = new TableCell();
                            TableCell cellOrderFormIdFK = new TableCell();


                            cellEhibitsID.Text = exh.ExhibitId.ToString();
                            cellType.Text = exh.Type;
                            cellDimensions.Text = exh.Dimensions;
                            cellHistoricPeriod.Text = exh.HistoricPeriod;
                            cellLocationIdFK.Text = exh.LocationIdFK.ToString();
                            cellOrderFormIdFK.Text = exh.OrderFormIdFK.ToString();


                            row.Controls.Add(cellEhibitsID);
                            row.Controls.Add(cellType);
                            row.Controls.Add(cellDimensions);
                            row.Controls.Add(cellHistoricPeriod);
                            row.Controls.Add(cellLocationIdFK);
                            row.Controls.Add(cellOrderFormIdFK);


                            TableExhibits.Rows.Add(row);
                        }

                }
                catch (FormatException fe)
                {
                }

                TxtFindHisPer.Text = "";
                TxtFindType.Text = "";




            }
        }
        protected void findBuyers(Object sender, EventArgs e)
        {
            String buyersName = txtFindBuyersName.Text.Trim();
            String buyersSurname = txtFindBuyersSurname.Text.Trim();
            if (buyersName != "" || buyersSurname != "")
            {
                try
                {
                    ServiceReference1.Buyers[] buyer = client.findBuyers(buyersName, buyersSurname);
                    List<ServiceReference1.Buyers> BuyersList = new List<ServiceReference1.Buyers>(buyer);
                    TableBuyers.Rows.Clear();
                    foreach (ServiceReference1.Buyers buy in BuyersList)
                        if (!buyersName.Equals("") || !buyersSurname.Equals(""))
                        {

                            TableRow row = new TableRow();
                            TableCell cellBuyerID = new TableCell();
                            TableCell cellbuyersName = new TableCell();
                            TableCell cellBuyersSurname = new TableCell();
                            TableCell cellBuyersAddress = new TableCell();
                            TableCell cellBuyersCountry = new TableCell();

                            cellBuyerID.Text = buy.BuyersId.ToString();
                            cellbuyersName.Text = buy.BuyersName.ToString();
                            cellBuyersSurname.Text = buy.BuyersSurname;
                            cellBuyersAddress.Text = buy.BuyersAddress.ToString();
                            cellBuyersCountry.Text = buy.BuyersCountry.ToString();



                            row.Controls.Add(cellBuyerID);
                            row.Controls.Add(cellbuyersName);
                            row.Controls.Add(cellBuyersSurname);
                            row.Controls.Add(cellBuyersAddress);
                            row.Controls.Add(cellBuyersCountry);

                            TableBuyers.Rows.Add(row);
                        }
                }
                catch (FormatException fe)
                {
                }
                txtFindBuyersName.Text = "";
                txtFindBuyersSurname.Text = "";

                
            }
        }

        protected void findUsers(Object sender, EventArgs e)
        {

            String name = txtFindName.Text.Trim();
            String userName = txtFindUserName.Text.Trim();
            if (name != "" || userName != "")
            {
                try
                {
                    ServiceReference1.Users[] user = client.findUsers(name, userName);
                    List<ServiceReference1.Users> UsersList = new List<ServiceReference1.Users>(user);
                    TableUsers.Rows.Clear();
                    foreach (ServiceReference1.Users us in UsersList)
                        if (!name.Equals("") || !userName.Equals(""))
                        {

                            TableRow row = new TableRow();
                            TableCell cellUserId = new TableCell();
                            TableCell cellName = new TableCell();
                            TableCell cellUserName = new TableCell();
                            TableCell cellPassword = new TableCell();
                            TableCell cellIsAdministrator = new TableCell();



                            cellUserId.Text = us.UserId.ToString();
                            cellName.Text = us.Name;
                            cellUserName.Text = us.UserName;
                            cellPassword.Text = us.Password;
                            cellIsAdministrator.Text = us.IsAdministrator.ToString();



                            row.Controls.Add(cellUserId);
                            row.Controls.Add(cellName);
                            row.Controls.Add(cellUserName);
                            row.Controls.Add(cellPassword);
                            row.Controls.Add(cellIsAdministrator);



                            TableUsers.Rows.Add(row);
                        }
                }
                catch (FormatException fe)
                {
                }
                txtFindName.Text = "";
                txtFindUserName.Text = "";

                
            }

        }
        protected void addLocations(Object sender, EventArgs e)
        {
            String locationName = TxtAddLocationName.Text;
            String surface = TxtAddSurface.Text;
            String state = TxtAddState.Text;
            String leasePrice = TxtAddLeasePrice.Text;
            String museumIdFK = TxtAddMuseumIdFK.Text;
            String country = TxtCountry.Text;

            if (locationName != "" && museumIdFK != "")
            {
                try
                {
                    Int32 musId = Convert.ToInt32(museumIdFK);
                    client.addLocations(locationName, surface, state, leasePrice, musId, country);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Niste uneli obavezna polja.')", true);
            }
            TxtAddLocationName.Text = "";
            TxtAddLeasePrice.Text = "";
            TxtAddMuseumIdFK.Text = "";
            TxtAddState.Text = "";
            TxtAddSurface.Text = "";

            Response.Redirect(Request.RawUrl);
        }

        protected void addUsers(Object sender, EventArgs e)
        {

            String name = txtAddName.Text.Trim();
            String userName = txtAddUseName.Text.Trim();
            String password = txtAddPassword.Text.Trim();
            String isAdministrator = txtAddISAdministrator.Text.Trim();
            if (name != "" && userName != "" && password != "" && isAdministrator != "")
            {
                try
                {
                    Boolean IsAdministrator = Convert.ToBoolean(isAdministrator);
                    client.addUsers(name, userName, password, IsAdministrator);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);

                }
            }
            Response.Redirect(Request.RawUrl);
        }

        protected void addBuyers(Object sender, EventArgs e)
        {

            String buyersName = txtAddBuyerName.Text.Trim();
            String buyersSurname = txtAddBuyersSurname.Text.Trim();
            String buyersAddress = txtAddBuyersAddress.Text.Trim();
            String buyersCountry = txtAddBuyersCountry.Text.Trim();

            if (buyersName != "" && buyersSurname != "")
            {

                client.addBuyers(buyersName, buyersSurname, buyersAddress, buyersCountry);
            }
            txtAddBuyerName.Text = "";
            txtAddBuyersSurname.Text = "";
            txtAddBuyersAddress.Text = "";
            txtAddBuyersCountry.Text = "";

            Response.Redirect(Request.RawUrl);
        }

        protected void addExhibits(Object sender, EventArgs e)
        {
            String type = TxtAddType.Text;
            String dimensions = TxtAddDimensions.Text;
            String historicPeriod = TxtAddHistoricPeriod.Text;
            String locationIdFk = TxtLocationIdFK.Text;
            String orderFormIdFK = TxtOrderFormIdFK.Text;
            if (locationIdFk != "" && orderFormIdFK != "")
            {
                try
                {
                    Int32 locIdFK = Convert.ToInt32(locationIdFk);
                    Int32 orderFIdFK = Convert.ToInt32(orderFormIdFK);
                    client.addExhibits(type, dimensions, historicPeriod, locIdFK, orderFIdFK);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);

                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Niste uneli obavezna polja.')", true);
            }
            Response.Redirect(Request.RawUrl);
            TxtAddType.Text = "";
            TxtAddDimensions.Text = "";
            TxtAddHistoricPeriod.Text = "";
            TxtLocationIdFK.Text = "";
            TxtOrderFormIdFK.Text = "";



        }

        protected void addOrderForms(Object sender, EventArgs e)
        {
            String date = txtAddDate.Text;
            String buyerAddress = txtAddBuyerAddress.Text;
            String buyerIdFk = txtBuyerIdFK.Text;

            if (buyerIdFk != "")
            {

                DateTime Date = Convert.ToDateTime(date);
                Int32 buyerIDFK = Convert.ToInt32(buyerIdFk);
                client.addOrderForms(Date, buyerAddress, buyerIDFK);


            }

            txtAddDate.Text = "";
            txtAddBuyerAddress.Text = "";
            txtBuyerIdFK.Text = "";

            Response.Redirect(Request.RawUrl);



        }

        

        private static TableRow createTableRow(ServiceReference1.Locations location)
        {
            TableRow row = new TableRow();
            TableCell cellLocationID = new TableCell();
            TableCell cellLocationName = new TableCell();
            TableCell cellSurface = new TableCell();
            TableCell cellState = new TableCell();
            TableCell cellLeasePrice = new TableCell();
            TableCell cellMuseumIdFK = new TableCell();
            TableCell cellCountry = new TableCell();

            cellLocationID.Text = location.LocationId.ToString();
            cellLocationName.Text = location.LocationName;
            cellSurface.Text = location.Surface;
            cellState.Text = location.State;
            cellLeasePrice.Text = location.LeasePrice;
            cellMuseumIdFK.Text = location.MuseumIdFK.ToString();
            cellCountry.Text = location.Country;

            row.Controls.Add(cellLocationID);
            row.Controls.Add(cellLocationName);
            row.Controls.Add(cellSurface);
            row.Controls.Add(cellState);
            row.Controls.Add(cellLeasePrice);
            row.Controls.Add(cellMuseumIdFK);
            row.Controls.Add(cellCountry);

            return row;
        }

        private static TableRow createTableRowExhibits(ServiceReference1.Exhibits exhibit)
        {
            TableRow row = new TableRow();
                TableCell cellEhibitsID = new TableCell();
                TableCell cellType = new TableCell();
                TableCell cellDimensions = new TableCell();
                TableCell cellHistoricPeriod = new TableCell();
                TableCell cellLocationIdFK = new TableCell();
                TableCell cellOrderFormIdFK = new TableCell();
                

                cellEhibitsID.Text = exhibit.ExhibitId.ToString();
                cellType.Text = exhibit.Type;
                cellDimensions.Text = exhibit.Dimensions;
                cellHistoricPeriod.Text = exhibit.HistoricPeriod;
                cellLocationIdFK.Text = exhibit.LocationIdFK.ToString();
                cellOrderFormIdFK.Text = exhibit.OrderFormIdFK.ToString();
                

                row.Controls.Add(cellEhibitsID);
                row.Controls.Add(cellType);
                row.Controls.Add(cellDimensions);
                row.Controls.Add(cellHistoricPeriod);
                row.Controls.Add(cellLocationIdFK);
                row.Controls.Add(cellOrderFormIdFK);

            return row;

            
        }

        

        protected void deleteLocations(Object sender, EventArgs e)
        {
            String locationId = TxtDelLocations.Text;
            if (! locationId.Equals(""))
                
                {
                    Int32 locId = Convert.ToInt32(locationId);
                    client.deleteLocation(locId);
                }
            Response.Redirect(Request.RawUrl);
            TxtDelLocations.Text = "";
            
        }

        protected void deleteExhibits(Object sender, EventArgs e)
        {

            String exhibitId = TxtDelExhibits.Text;
            if (!exhibitId.Equals(""))
            {
                Int32 exhId = Convert.ToInt32(exhibitId);
                client.deleteExhibits(exhId);
            }
            TxtDelExhibits.Text = "";
            Response.Redirect(Request.RawUrl);


        }

        protected void deleteOrderForms(Object sender, EventArgs e)
        {

            String orderFormId = txtDelOrderForms.Text;

            if (orderFormId != "")
               
                {

                    Int32 orderFid = Convert.ToInt32(orderFormId);
                    client.deleteOrderForms(orderFid);
                }
            txtDelOrderForms.Text = "";
            Response.Redirect(Request.RawUrl);

        }

        protected void deleteUsers(Object sender, EventArgs e)
        {
            String userID = txtDelUser.Text.Trim();
            if (userID != "")
            {
                Int32 UserID = Convert.ToInt32(userID);
                client.deleteUsers(UserID);

            }
            txtDelUser.Text = "";
            Response.Redirect(Request.RawUrl);

        }

        protected void deleteBuyers(Object sender, EventArgs e)
        {
            String buyerId = txtDelBuyers.Text.Trim();
            if (buyerId != "")
            {

                Int32 buyID = Convert.ToInt32(buyerId);
                client.deleteBuyers(buyID);
            }

            txtDelBuyers.Text = "";
            Response.Redirect(Request.RawUrl);

        }
       
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Museum[] museum = client.getMuseum();
            List<ServiceReference1.Museum> MuseumList = new List<ServiceReference1.Museum>(museum);
            foreach (ServiceReference1.Museum muzej in MuseumList)
            {
                TableRow row = new TableRow();
                TableCell cellMuseumID = new TableCell();
                TableCell cellMuseumName = new TableCell();
                TableCell cellMuseumAddress = new TableCell();
                TableCell cellEstablished = new TableCell();

                cellMuseumName.Text = muzej.MuseumName;
                cellMuseumID.Text = muzej.MuseumId.ToString();
                cellMuseumAddress.Text = muzej.MuseumAddress;
                cellEstablished.Text = muzej.Established.ToString();

                row.Controls.Add(cellMuseumID);
                row.Controls.Add(cellMuseumName);
                row.Controls.Add(cellMuseumAddress);
                row.Controls.Add(cellEstablished);

                TableMuseum.Rows.Add(row);
            }
            ServiceReference1.Locations[] locations = client.getLocations();
            List<ServiceReference1.Locations> LocationsList = new List<ServiceReference1.Locations>(locations);
            foreach (ServiceReference1.Locations lok in LocationsList)
            {
                TableRow row = new TableRow();
                TableCell cellLocationID = new TableCell();
                TableCell cellLocationName = new TableCell();
                TableCell cellSurface = new TableCell();
                TableCell cellState = new TableCell();
                TableCell cellLeasePrice = new TableCell();
                TableCell cellMuseumIdFK = new TableCell();
                TableCell cellCountry = new TableCell();

                cellLocationID.Text = lok.LocationId.ToString();
                cellLocationName.Text = lok.LocationName;
                cellSurface.Text = lok.Surface;
                cellState.Text = lok.State;
                cellLeasePrice.Text = lok.LeasePrice;
                cellMuseumIdFK.Text = lok.MuseumIdFK.ToString();
                cellCountry.Text = lok.Country;

                row.Controls.Add(cellLocationID);
                row.Controls.Add(cellLocationName);
                row.Controls.Add(cellSurface);
                row.Controls.Add(cellState);
                row.Controls.Add(cellLeasePrice);
                row.Controls.Add(cellMuseumIdFK);
                row.Controls.Add(cellCountry);

                

                TableLocations.Rows.Add(row);
            }

            ServiceReference1.Exhibits[] exhibits = client.getExhibits();
            List<ServiceReference1.Exhibits> ExhibitsList = new List<ServiceReference1.Exhibits>(exhibits);
            foreach (ServiceReference1.Exhibits exh in ExhibitsList)
            {
                TableRow row = new TableRow();
                TableCell cellEhibitsID = new TableCell();
                TableCell cellType = new TableCell();
                TableCell cellDimensions = new TableCell();
                TableCell cellHistoricPeriod = new TableCell();
                TableCell cellLocationIdFK = new TableCell();
                TableCell cellOrderFormIdFK = new TableCell();
                

                cellEhibitsID.Text = exh.ExhibitId.ToString();
                cellType.Text = exh.Type;
                cellDimensions.Text = exh.Dimensions;
                cellHistoricPeriod.Text = exh.HistoricPeriod;
                cellLocationIdFK.Text = exh.LocationIdFK.ToString();
                cellOrderFormIdFK.Text = exh.OrderFormIdFK.ToString();
                

                row.Controls.Add(cellEhibitsID);
                row.Controls.Add(cellType);
                row.Controls.Add(cellDimensions);
                row.Controls.Add(cellHistoricPeriod);
                row.Controls.Add(cellLocationIdFK);
                row.Controls.Add(cellOrderFormIdFK);
                

                TableExhibits.Rows.Add(row);
            }

            ServiceReference1.OrderForms[] orderForm = client.getOrderForms();
            List<ServiceReference1.OrderForms> OrderFormsList = new List<ServiceReference1.OrderForms>(orderForm);
            foreach (ServiceReference1.OrderForms ordForm in OrderFormsList)
            {
                TableRow row = new TableRow();
                TableCell cellOrderFormID = new TableCell();
                TableCell cellDate = new TableCell();
                TableCell cellBuyerAddress = new TableCell();
                TableCell cellBuyerIdFK = new TableCell();

                cellOrderFormID.Text = ordForm.OrderFormId.ToString();
                cellDate.Text = ordForm.Date.ToString();
                cellBuyerAddress.Text = ordForm.BuyerAddress;
                cellBuyerIdFK.Text = ordForm.BuyerIdFK.ToString();

                


                row.Controls.Add(cellOrderFormID);
                row.Controls.Add(cellDate);
                row.Controls.Add(cellBuyerAddress);
                row.Controls.Add(cellBuyerIdFK);

                TableOrderForms.Rows.Add(row);
            }

            ServiceReference1.Buyers[] buyer = client.getBuyers();
            List<ServiceReference1.Buyers> BuyerList = new List<ServiceReference1.Buyers>(buyer);
            foreach (ServiceReference1.Buyers buy in BuyerList)
            {
                TableRow row = new TableRow();
                TableCell cellBuyerID = new TableCell();
                TableCell cellbuyersName = new TableCell();
                TableCell cellBuyersSurname = new TableCell();
                TableCell cellBuyersAddress = new TableCell();
                TableCell cellBuyersCountry = new TableCell();

                cellBuyerID.Text = buy.BuyersId.ToString();
                cellbuyersName.Text = buy.BuyersName.ToString();
                cellBuyersSurname.Text = buy.BuyersSurname;
                cellBuyersAddress.Text = buy.BuyersAddress.ToString();
                cellBuyersCountry.Text = buy.BuyersCountry.ToString();



                row.Controls.Add(cellBuyerID);
                row.Controls.Add(cellbuyersName);
                row.Controls.Add(cellBuyersSurname);
                row.Controls.Add(cellBuyersAddress);
                row.Controls.Add(cellBuyersCountry);

                TableBuyers.Rows.Add(row);
            }
            ServiceReference1.Users[] users = client.getUsers();
            List<ServiceReference1.Users> UsersList = new List<ServiceReference1.Users>(users);
            foreach (ServiceReference1.Users use in UsersList)
            {
                TableRow row = new TableRow();
                TableCell cellUserId = new TableCell();
                TableCell cellName = new TableCell();
                TableCell cellUserName = new TableCell();
                TableCell cellPassword = new TableCell();
                TableCell cellIsAdministrator = new TableCell();
                


                cellUserId.Text = use.UserId.ToString();
                cellName.Text = use.Name;
                cellUserName.Text = use.UserName;
                cellPassword.Text = use.Password;
                cellIsAdministrator.Text = use.IsAdministrator.ToString();
                


                row.Controls.Add(cellUserId);
                row.Controls.Add(cellName);
                row.Controls.Add(cellUserName);
                row.Controls.Add(cellPassword);
                row.Controls.Add(cellIsAdministrator);
                


                TableUsers.Rows.Add(row);
            }


        }
    }
}
