<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebTable.aspx.cs" Inherits="ClassWork_Login.WebTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Style.css" />
</head>
<body>
   <h2>Гости</h2>
    <table>
        <thead>
            <tr>
                <th>Имя</th>
                <th>Логин</th>
                <th>Пароль</th>
                 <th>Телефон</th>
                <th>Email</th>
                <th>Номер Машины</th>
                 <th>Причина поломки</th>
            </tr>
        </thead>
        <tbody>
           <%=GetPageData() %>
        </tbody>
    </table>
</body>
</html>
