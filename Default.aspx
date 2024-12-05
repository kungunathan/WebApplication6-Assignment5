<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmailSenderApp.Default" %>
<!DOCTYPE html>
<html>
<head>
    <title>Email Sender</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center;">
            <h2>Send Email</h2>
            <label for="txtSender">Sender Email (ANU):</label><br />
            <asp:TextBox ID="txtSender" runat="server"></asp:TextBox><br /><br />

            <label for="txtReceiver">Receiver Email (ANU):</label><br />
            <asp:TextBox ID="txtReceiver" runat="server"></asp:TextBox><br /><br />

            <label for="txtSubject">Subject:</label><br />
            <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox><br /><br />

            <label for="txtMessage">Message:</label><br />
            <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" Rows="5" Columns="30"></asp:TextBox><br /><br />

            <asp:Button ID="btnSend" runat="server" Text="Send Email" OnClick="btnSend_Click" />
            <asp:Label ID="lblStatus" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
