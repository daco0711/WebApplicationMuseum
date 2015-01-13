<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebApplicationMuseum._Default"  %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
<style type='text/css'>
        body { background-image: url(http://www.redorbit.com/media/uploads/2008/07/b516279c61183fb3a34ec382b97001f01-617x462.jpg); }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent"  >


        
    <h2>
        Welcome to the Jurassic Museum Web Application!!!
    </h2>
    
 
   
    <p>
    <img src="http://www.nhm.ac.uk/resources/kids-only/fun-games/screensavers/images/t-rex1024_4376_1.jpg" width = "100%" />
    
    </p>

     <h2>
          ABOUT OUER MUSEUM:
    </h2>
    
    
    <p>



    
    <asp:Table ID = "TableMuseum" runat = "server" ForeColor = "Red"  HorizontalAlign = "Center" BorderColor = "Red" Height = "3px">
    
    <asp:TableHeaderRow Width = "80%" BackColor = "Black" ForeColor = "Red"> 
    <asp:TableHeaderCell Width = "20%" > MuseumId</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > MuseumName</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > MuseumAddress</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > Established</asp:TableHeaderCell>

    
    
    </asp:TableHeaderRow> 
    
    </asp:Table>
    </p>
    
    <p>
    <asp:Label ID = "LblUpdMuseumNaslov" runat = "server" Text = "Update museum info" ForeColor = "Red" ></asp:Label>
    </p>

    <p>

    <asp:Button ID = "UpdateMuseum" runat = "server" OnClick = "updateMuseum" Text = "Update" />
    <asp:Label ID = "labelId" runat = "server" Text = "MuseumId"></asp:Label>
    <asp:TextBox ID = "TextMuseumId" runat = "server" Width = "20%"></asp:TextBox>
    <asp:Label ID = "labelMuseumName" runat = "server" Text = "MuseumName"></asp:Label>
    <asp:TextBox ID = "TextMuseumName" runat = "server"></asp:TextBox>
    <asp:Label ID = "labelMuseumAddress" runat = "server" Text = "MuseumAddress"></asp:Label>
    <asp:TextBox ID = "TextMuseumAddress" runat = "server"></asp:TextBox>
    <asp:Label ID = "labelEstablished" runat = "server" Text = "Established"></asp:Label>
    <asp:TextBox ID = "TextEstablished" runat = "server"></asp:TextBox>
     </p>
     <h2>
          LOCATIONS 
    </h2>


     
     <p>
     <img src="http://openwalls.com/image/6644/archaeological_discovery_1600x1200.jpg" width = "100%" />
     </p>
     <h2>
         LIST OF OUR LOCATIONS: 
    </h2>
     
     <p>


     <asp:Table ID = "TableLocations" runat = "server"  HorizontalAlign = "Center"  ForeColor = "Black" Font-Bold = "true" BorderColor = "Black" Height = "3px">
    
    <asp:TableHeaderRow Width = "70%" BackColor = "Black" ForeColor = "Red"> 
    <asp:TableHeaderCell Width = "20%" > LocationId</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > LocationName</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > Surface(m2)</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > State</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > LeasePrice</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > MuseumIdFK</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%"  > Country</asp:TableHeaderCell>
    
    </asp:TableHeaderRow> 
    
    </asp:Table>
    </p>

    <p>
    <asp:Label ID = "lblUpdLocationsNaslov" runat = "server" Text = "Update location info" ForeColor = "Red"></asp:Label>
    </p>

    <p>
    <asp:Button ID = "BtnUpdLocationId" runat = "server" OnClick = "updateLocations" Text = "Update" />
    <asp:Label ID = "lblUpdLocationId" runat = "server" Text = "LocationId"></asp:Label>
    <asp:TextBox ID = "TxtUpdLocationId" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdLocationName" runat = "server" Text = "LocationName"></asp:Label>
    <asp:TextBox ID = "TxtUpdLocationName" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdSurface" runat = "server" Text = "Surface(m2)"></asp:Label>
    <asp:TextBox ID = "TxtUpdSurface" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdState" runat = "server" Text = "State"></asp:Label>
    <asp:TextBox ID = "TxtUpdState" runat = "server"></asp:TextBox>
    <asp:Label ID = "LblUpdLeasePrice" runat = "server" Text = "LeasePrice"></asp:Label>
    <asp:TextBox ID = "TxtUpdLeasePrice" runat = "server"></asp:TextBox>
    <asp:Label ID = "LblUpdMuseumIdFK" runat = "server" Text = "MuseumID"></asp:Label>
    <asp:TextBox ID = "TxtUpdMuseumIdFK" runat = "server"></asp:TextBox>
    <asp:Label ID = "LblUpdCountry" runat = "server" Text = "Country"></asp:Label>
    <asp:TextBox ID = "TxtUpdCountry" runat = "server"></asp:TextBox>    
    </p>
    
    <p>
    <asp:Label ID = "lblDelLocationNaslov" runat = "server" Text = "Delete location" ForeColor = "Red"></asp:Label>
    </p>
    <p>
    <asp:Button ID = "BtnDelLocations" runat = "Server" OnClick = "deleteLocations" Text = "Delete" />
    <asp:Label ID = "lblDelLocations" runat = "server" Text = "Enter ID of the location to delete location"></asp:Label>
    <asp:TextBox ID = "TxtDelLocations" runat = "server"></asp:TextBox>
    </p>

    <p>
    <asp:Label ID = "lblFindLocationNaslov" runat = "server" Text = "Find Locations" ForeColor = "Red"></asp:Label>
    </p>
    
    <p>
    <asp:Button ID = "BtnUpdFind" runat= "server" Text = "Search" OnClick = "findLocations" />
    <asp:Label ID = "lnlFindLocations" runat = "server" Text = "Enter name of the location that you wish to find"></asp:Label>
    <asp:TextBox ID = "TxtUpdsearchLocations" runat = "server"></asp:TextBox>

     
     </p>

     <p>
     <asp:Label ID = "lblAddLocationNaslov" runat = "server" Text = "Add new location" ForeColor = "Red"></asp:Label>
     
     </p>

     <p>
     <asp:Button ID = "BtbAddLocations" runat = "server" OnClick="addLocations" Text = "Add" />
     <asp:Label ID = "lblAddLocationName" runat = "server" Text = "LocationName"></asp:Label>
     <asp:TextBox ID = "TxtAddLocationName" runat = "server"></asp:TextBox>
     <asp:Label ID = "LblAddSurface" runat = "server" Text = "Surface"></asp:Label>
     <asp:TextBox ID = "TxtAddSurface" runat = "server"></asp:TextBox>
     <asp:Label ID = "LblAddState" runat = "server" Text = "State"></asp:Label>
     <asp:TextBox ID = "TxtAddState" runat = "server"></asp:TextBox>
     <asp:Label ID = "LblAddLeasePrice" runat = "server" Text = "LeasePrice"></asp:Label>
     <asp:TextBox ID = "TxtAddLeasePrice" runat = "server"></asp:TextBox>
     <asp:Label ID = "LblAddMuseumIdFK" runat = "server" Text = "MuseumID"></asp:Label>
     <asp:TextBox ID = "TxtAddMuseumIdFK" runat = "server"></asp:TextBox>
     <asp:Label ID = "LblAddCountry" runat = "server" Text = "Country"></asp:Label>
     <asp:TextBox ID = "TxtCountry" runat = "server"></asp:TextBox>
     
     </p>

     <h2>
            EXHIBITS
    </h2>

    <p>
    
    <img src = "http://phenomena.nationalgeographic.com/files/2013/01/Utah-Museums-December-2011-323-990x664.jpg" width = "100%"  />
    </p>

     <h2>
     
     LIST OF OUR EXHIBITS:
     </h2>

     <p>
     
     <asp:Table ID = "TableExhibits" runat = "server"  HorizontalAlign = "Center" BorderColor = "Red" Height = "3px">
    
    <asp:TableHeaderRow Width = "60%" BackColor = "Black" ForeColor = "Red"> 
    <asp:TableHeaderCell Width = "20%" > ExhibitId</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > Type</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > Dimensions</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > HistoricPeriod</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > LocationIdFK</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > OrderFormIdFK</asp:TableHeaderCell>
    
    
    </asp:TableHeaderRow> 
    
    </asp:Table>
    
    </p>

    <p>
    
    <asp:Label ID = "lblFindExhibits" runat = "server" Text = "Find Exhibits" ForeColor = "Red"></asp:Label>
    </p>
    <p>
    <asp:Button ID = "BtnFindExhibits" runat= "server" Text = "Search" OnClick = "findExhibits" />
    <asp:Label ID = "LblExhFindType" runat = "server" Text = "Insert Type of Exhibit:"></asp:Label>
    <asp:TextBox ID = "TxtFindType" runat = "server"></asp:TextBox>
    <asp:Label ID = "LblExhFindHistPer" runat = "server" Text = "Insert Historic Period:"></asp:Label>
    <asp:TextBox ID = "TxtFindHisPer" runat = "server"></asp:TextBox>
    </p>

    <p>
    <asp:Label ID = "lblDeleteExhibits" runat = "server" Text = "Delete Exhibits" ForeColor = "Red"></asp:Label>
    </p>
    <p>
    <asp:Button ID = "btnDelExhibits" runat = "Server" Text = "Delete" OnClick = "deleteExhibits" />
    <asp:Label ID = "lblDelExhibit" runat = "server" Text = "Enter ID of the Exhibit that you wish to delete from the list"></asp:Label>
    <asp:TextBox ID = "TxtDelExhibits" runat = "server"></asp:TextBox>
    
    </p>

    <p>
    <asp:Label ID = "lblAddExhibits" runat = "server" Text = "Add new Exhibits" ForeColor = "Red"></asp:Label>
    
    </p>

    <p>
    <asp:Button ID = "BtnAddExhibits" runat = "Server" Text = "Add" OnClick = "addExhibits" />
    <asp:Label ID = "lblAddType" runat = "server" Text = "Type"></asp:Label>
    <asp:TextBox ID = "TxtAddType" runat = "server"></asp:TextBox>
    <asp:Label ID = "LblAddDimensions" runat = "server" Text = "Dimensions"></asp:Label>
    <asp:TextBox ID = "TxtAddDimensions" runat = "server"></asp:TextBox>
    <asp:Label ID = "LblAddHistoricPeriod" runat = "server" Text = "HistoricPeriod"></asp:Label>
    <asp:TextBox ID = "TxtAddHistoricPeriod" runat = "server"></asp:TextBox>
    <asp:Label ID = "LblAddLocationIdFK" runat = "server" Text = "LocationIdFK"></asp:Label>
    <asp:TextBox ID = "TxtLocationIdFK" runat = "server"></asp:TextBox>
    <asp:Label ID = "LblOrderFormIdFK" runat = "server" Text = "OrderFormIdFK"></asp:Label>
    <asp:TextBox ID = "TxtOrderFormIdFK" runat = "server"></asp:TextBox>
    
    
    </p>

    <p>
    <asp:Label ID = "lblUpdExhibits" runat = "server" Text = "Update exhibits info" ForeColor = "Red"></asp:Label>
    
    </p>

    <p>
    <asp:Button ID = "btnUpdExhibits" runat  = "server" Text = "Update" OnClick = "updateExhibits" />
    <asp:Label ID = "lblUpdExhID" runat = "server" Text = "ExhibitID"></asp:Label>
    <asp:TextBox ID = "txtUpdExhId" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdType" runat = "server" Text = "Type"></asp:Label>
    <asp:TextBox ID = "txtUpdType" runat = "server"></asp:TextBox>
    <asp:Label ID = "LblUpdDimensions" runat = "server" Text = "Dimensions"></asp:Label>
    <asp:TextBox ID = "txtUpdDimensions" runat = "server"></asp:TextBox>
    <asp:Label ID = "LblHistoricPeriod" runat = "server" Text = "HistoricPeriod"></asp:Label>
    <asp:TextBox ID = "txtUpdHistoricPeriod" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdLocationIdFK" runat = "server" Text = "LocationIdFK"></asp:Label>
    <asp:TextBox ID = "txtUpdLocationIdFK" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdOrderFormFK" runat = "server" Text = "OrderFormIdFK"></asp:Label>
    <asp:TextBox ID = "txtUpdOrderFormIdFK" runat = "server"></asp:TextBox>
    </p>


    <h2>
    
    ORDER FORMS
    </h2>

    <p>
    <asp:Table ID = "TableOrderForms" runat = "server"  HorizontalAlign = "Center" BorderColor = "Red" Height = "3px">
    
    <asp:TableHeaderRow Width = "80%" BackColor = "Black" ForeColor = "Red"> 
    <asp:TableHeaderCell Width = "20%" > OrderFormId</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > Date</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > BuyerAddress</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > BuyerIdFK</asp:TableHeaderCell>
    
    </asp:TableHeaderRow> 
    
    </asp:Table>
    </p>

    <p>
    
    <asp:Label ID = "lblDelOrderFormsNaslov" runat  = "server" Text = "Delete Order Forms" ForeColor = "Red"></asp:Label>
    </p>

    <p>
    <asp:Button ID = "btnDelOrderForms" runat = "server" Text = "Delete" OnClick = "deleteOrderForms" />
    <asp:Label ID = "lblDelOrderForms" Text = "Insert ID of the Order Form that you wish to delete:" runat = "server"></asp:Label>
    <asp:TextBox ID = "txtDelOrderForms" runat = "server"></asp:TextBox>
    
    </p>
    
    <p>
    <asp:Label ID = "lblAddOrderFormsNaslov" runat = "server" Text = "Add New Order Forms" ForeColor = "Red"></asp:Label>

    </p>

    <p>
    <asp:Button ID = "BtnAddOrderForms" runat = "server" Text = "Add" OnClick = "addOrderForms" />
    <asp:Label ID = "lblAddDate" Text = "Date" runat = "server"></asp:Label>
    <asp:TextBox ID = "txtAddDate" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblAddBuyerAdress" Text = "Buyer Address" runat = "server"></asp:Label>
    <asp:TextBox ID = "txtAddBuyerAddress" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblAddBuyerIdFK" Text = "BuyerIdFK" runat = "server"></asp:Label>
    <asp:TextBox ID = "txtBuyerIdFK" runat = "server"></asp:TextBox>
    
    </p>

    <p>
    <asp:Label ID = "lblUpdOrderFormsNaslov" runat = "server" Text = "Update Existing Order Forms" ForeColor = "Red"></asp:Label>
    </p>

    <p>
    <asp:Button ID = "btnUpdOrderForms" runat = "server" Text = "Update" OnClick = "updateOrderForms" />
    <asp:Label ID = "lblUpdOrderFormID" Text = "Order Form ID" runat = "server"></asp:Label>
    <asp:TextBox ID = "txtUpdOrderFormID" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdOrderFormDate" Text = "Date" runat = "server"></asp:Label>
    <asp:TextBox ID = "txtUpdOrderFormDate" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdOrderFormBuyerAddress" Text = "Buyer Address" runat = "server"></asp:Label>
    <asp:TextBox ID = "txtUpdOrderFormBuyerAddress" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdOrderFormsBuyerIdFk" Text = "Buyer IDFK" runat = "server"></asp:Label>
    <asp:TextBox ID = "txtUpdOrderFormsBuyerIdFK" runat = "server"></asp:TextBox>
    </p>
     
     <p>
     <asp:Label ID = "lblFindOrderForms" runat = "server" Text = "Search Order Forms" ForeColor = "Red"></asp:Label>

     
     </p>
     <p>
     <asp:Button ID = "btnFindOrderForms" runat = "server" Text = "Search" OnClick = "findOrderForms" />
    <asp:Label ID = "lblFindOrderFormsBuyerIDFK" Text = "Buyer IDFK" runat = "server"></asp:Label>
    <asp:TextBox ID = "txtFindOrderFormsBuyerIDFK" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblFindOrderFormsBuyersAdress" Text = "Buyers Address" runat = "server"></asp:Label>
    <asp:TextBox ID = "txtFindOrderFormsBuyerAdress" runat = "server"></asp:TextBox>
     
     </p>
     <h2>
     BUYERS
     
     </h2>
     <p>
     <asp:Label ID = "lblBuyersNaslov" runat = "server" Text = "List of buyers" ForeColor = "Red"></asp:Label>
     
     </p>
     <p>
     <asp:Table ID = "TableBuyers" runat = "server"  HorizontalAlign = "Center" BorderColor = "Red" Height = "3px">
    
    <asp:TableHeaderRow Width = "80%" BackColor = "Black" ForeColor = "Red"> 
    <asp:TableHeaderCell Width = "20%" > BuyerId</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > BuyersName</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > BuyersSurname</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > BuyersAddress</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > BuyersCountry</asp:TableHeaderCell>
    
    </asp:TableHeaderRow> 
    
    </asp:Table>
     
     
     </p>

     <p>
     <asp:Label ID = "lblDelBuyersNaslov" runat = "server" Text = "Delete buyers from the list" ForeColor = "Red"></asp:Label>
     </p>

     <p>
     <asp:Button ID = "btnDelBuyers" runat = "server" Text = "Delete" OnClick = "deleteBuyers" />
     <asp:Label ID = "lblDelbuyers" runat = "server" Text = "Enter ID of the buyer that you wish to delete:"></asp:Label>
     <asp:TextBox ID = "txtDelBuyers" runat = "server"></asp:TextBox>
     </p>

     <p>
     
     <asp:Label ID = "lblAddBuyersNaslov" runat = "server" Text = "Add new buyers" ForeColor = "Red"></asp:Label> 
     
     </p>

     <p>
     <asp:Button ID = "btnAddBuyers" runat = "server" Text = "Add" OnClick = "addBuyers" />
     <asp:Label ID = "lblAddBuyersName" runat = "server" Text = "Buyers Name"></asp:Label>
     <asp:TextBox ID = "txtAddBuyerName" runat = "server"></asp:TextBox>
     <asp:Label ID = "lblAddBuyersSurname" runat = "server" Text = "Buyers Surname"></asp:Label>
     <asp:TextBox ID = "txtAddBuyersSurname" runat = "server"></asp:TextBox>
     <asp:Label ID = "lblAddBuyersAddress" runat = "server" Text = "Buyers Address"></asp:Label>
     <asp:TextBox ID = "txtAddBuyersAddress" runat = "server"></asp:TextBox>
     <asp:Label ID = "lblAddBuyersCountry" runat = "server" Text = "Buyers Country"></asp:Label>
     <asp:TextBox ID = "txtAddBuyersCountry" runat = "server"></asp:TextBox>
     </p>

     <p>
     
     <asp:Label ID = "lblUpdBuyersNaslov" runat = "server" Text = "Update Buyers Info" ForeColor = "Red"></asp:Label>
     </p>
    
    <p>
    <asp:Button ID = "btnUpdBuyers" runat = "server" Text = "Update" OnClick = "updateBuyers" />
    <asp:Label ID = "lblUpdBuyersID" runat = "server" Text = "Buyers ID"></asp:Label>
     <asp:TextBox ID = "txtUpdBuyersID" runat = "server"></asp:TextBox>
     <asp:Label ID = "lblUpdBuyersName" runat = "server" Text = "Buyers Name"></asp:Label>
     <asp:TextBox ID = "txtUpdBuyersName" runat = "server"></asp:TextBox>
     <asp:Label ID = "lblUpdBuyersSurname" runat = "server" Text = "Buyers Surname"></asp:Label>
     <asp:TextBox ID = "txtUpdBuyersSurname" runat = "server"></asp:TextBox>
     <asp:Label ID = "lblUpdBuyersAddress" runat = "server" Text = "Buyers Address"></asp:Label>
     <asp:TextBox ID = "txtUpdBuyersAddress" runat = "server"></asp:TextBox>
     <asp:Label ID = "lblUpdBuyersCountry" runat = "server" Text = "Buyers Country"></asp:Label>
     <asp:TextBox ID = "txtUpdBuyersCountry" runat = "server"></asp:TextBox>
    
    </p>

    <p>
    <asp:Label ID = "lblFindBuyersNaslov" runat = "server" Text = "Find Buyers" ForeColor = "Red"></asp:Label>
    </p>

    <p>
    <asp:Button ID = "btnFindBuyers" runat = "server" Text = "Search" OnClick = "findBuyers" />
    <asp:Label ID = "lblFindBuyersName" runat = "server" Text = "Buyers Name"></asp:Label>
     <asp:TextBox ID = "txtFindBuyersName" runat = "server"></asp:TextBox>
     <asp:Label ID = "lblFindBuyersSurname" runat = "server" Text = "Buyers Surname"></asp:Label>
     <asp:TextBox ID = "txtFindBuyersSurname" runat = "server"></asp:TextBox>
    
    </p>

    <h2>
    USERS
    
    </h2>
    <p>
    <asp:Label ID  = "lblUsersListNaslov" runat = "server" Text = "LIST OF USERS" ForeColor = "Red"></asp:Label>
    </p>
    <p>
    
    <asp:Table ID = "TableUsers" runat = "server"  HorizontalAlign = "Center" BorderColor = "Red" Height = "3px">
    
    <asp:TableHeaderRow Width = "80%" BackColor = "Black" ForeColor = "Red"> 
    <asp:TableHeaderCell Width = "20%" > UserId</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > Name</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > UserName</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > Password</asp:TableHeaderCell>
    <asp:TableHeaderCell Width = "20%" > IsAdministrator</asp:TableHeaderCell>
    
    </asp:TableHeaderRow> 
    
    </asp:Table>
    
    
    
    </p>

    <p>
    <asp:Label ID = "lblDelUsersNaslov" runat = "server" Text = "Delete Users from the list" ForeColor = "Red"></asp:Label>
    
    </p>

    <p>
    <asp:Button ID = "btnDelUsers" runat = "server" Text = "Delete" OnClick = "deleteUsers" />
    <asp:Label ID = "lblDelUsers" runat = "server" Text = "Enter ID of the User that you wish to delete:"></asp:Label>
    <asp:TextBox ID = "txtDelUser" runat = "server"></asp:TextBox>
    
    </p>

    <p>
    <asp:Label ID = "lblFindUsersNaslov" runat = "server" Text = "Find Users from the list" ForeColor = "Red"></asp:Label>
    
    </p>

    <p>
    <asp:Button ID = "btnFindUsers" runat = "server" Text = "Search" OnClick = "findUsers" />
    <asp:Label ID = "lblFindUsersName" runat = "server" Text = "Name"></asp:Label>
    <asp:TextBox ID = "txtFindName" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblFindUserName" runat = "server" Text = "Username"></asp:Label>
    <asp:TextBox ID = "txtFindUserName" runat = "server"></asp:TextBox>
    </p>

    <p>
    <asp:Label ID = "lblAddUsersNaslov" runat = "server" Text = "Add new Users to the list" ForeColor = "Green"></asp:Label>
    
    
    </p>

    <p>
    <asp:Button ID = "btnAddUsers" runat = "server" Text = "Add" OnClick = "addUsers" />
    <asp:Label ID = "lblAddName" runat = "server" Text = "Name"></asp:Label>
    <asp:TextBox ID = "txtAddName" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblAddUserName" runat = "server" Text = "Username"></asp:Label>
    <asp:TextBox ID = "txtAddUseName" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblAddPassword" runat = "server" Text = "Password"></asp:Label>
    <asp:TextBox ID = "txtAddPassword" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblAddISAdministrator" runat = "server" Text = "ISAdministrator"></asp:Label>
    <asp:TextBox ID = "txtAddISAdministrator" runat = "server"></asp:TextBox>

    
    
    
    </p>

    <p>
    <asp:Label ID = "lblUpdateUsersNaslov" runat = "server" Text = "Update User Info" ForeColor = "Green"></asp:Label>
    
    </p>

    <p>
    <asp:Button ID = "btnUpdateUsers" runat = "server" Text = "Update" OnClick = "updateUsers" />
    <asp:Label ID = "lblUpdateUserID" runat = "server" Text = "User ID"></asp:Label>
    <asp:TextBox ID = "txtUpdateUserID" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdateName" runat = "server" Text = "Name"></asp:Label>
    <asp:TextBox ID = "txtUpdateName" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdateUsername" runat = "server" Text = "Username"></asp:Label>
    <asp:TextBox ID = "txtUpdateUsername" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdatePassword" runat = "server" Text = "Password"></asp:Label>
    <asp:TextBox ID = "txtUpdatePassword" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdateIsAdministrator" runat = "server" Text = "IsAdministrator"></asp:Label>
    <asp:TextBox ID = "txtUpdateIsAdministrator" runat = "server"></asp:TextBox>

    </p>
</asp:Content>
