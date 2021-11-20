<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BookStoreWebForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book Store Web Form</title>
</head>
<body>
    <form id="bookStoreWebForm" runat="server">
        <div>Just a simple web form</div>
        
         <p>Add Customer</p>
        Customer First Name
        <asp:TextBox ID="textBoxCustomerFirstName" runat="server" Style="margin-top: 10px"></asp:TextBox>
        <br />
        Customer Last Name
        <asp:TextBox ID="textBoxCustomerLastName" runat="server" Style="margin-top: 10px"></asp:TextBox>
        <br />
        <asp:Button ID="buttonAddCustomer" runat="server" Style="margin-top: 10px" Text="Add Customer" OnClick="ButtonAddCustomer_Click" />
        
        <div>Customers</div>

        <asp:GridView ID="gridViewCustomers" runat="server"
            AllowSorting="true"
            AutoGenerateColumns="false"
            ItemType="BookStoreCodeFirstFromDB.Customer"
            DataKeyName="CustomerID"
            SelectMethod="CustomersGetData"
            UpdateMethod="GridViewCustomer_UpdateItem"
            DeleteMethod="GridViewCustomer_DeleteItem">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="False" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True"
                    SortExpression="CustomerID" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName"/>
            </Columns>
        </asp:GridView>
           
    </form>
</body>
</html>
