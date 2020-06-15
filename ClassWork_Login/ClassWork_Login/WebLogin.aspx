<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebLogin.aspx.cs" Inherits="ClassWork_Login.WebLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
            <h1>Hello world!</h1>
            <p>Регайся!</p>
        </div>
        <asp:ValidationSummary ID="validationSummary" runat="server" ShowModelStateErrors="true" />
        <div>
            <label>Ваше имя:</label><input type="text" id="name" runat="server"/>
        </div>
        <div>
            <label>Ваше email:</label><input type="text" id="email" runat="server"/>
        </div>
        <div>
            <label>Ваш телефон:</label><input type="text" id="phone" runat="server"/>
        </div>
        <div>
            <label>Собираетесь быть?</label>
            <select id="willattend" runat="server">
                <option value="">Не знаю точно</option>
                <option value="true">Да</option>
                <option value="false">Нет</option>
            </select>
        </div>
        <div>
            <button type="submit">Подтвердить</button>
        </div>
    </form>
</body>
</html>
