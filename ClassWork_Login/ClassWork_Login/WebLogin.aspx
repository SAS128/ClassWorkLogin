<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebLogin.aspx.cs" Inherits="ClassWork_Login.WebLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="Style.css" />
</head>

<body>
    <form id="responsesform" runat="server">
        <div>
            <h1>Регестрация</h1>
        </div>
        <asp:ValidationSummary ID="validationSummary" runat="server" ShowModelStateErrors="true" />
          <div>
            <label>Имя заказчика:</label><input type="text" id="name" runat="server"/>
        </div>
        <div>
            <label>Логин:</label><input type="text" id="login" runat="server"/>
        </div>
        <div>
            <label>Пароль:</label><input type="text" id="password" runat="server"/>
        </div>
        <div>
            <label>Телефон:</label><input type="text" id="phone" runat="server"/>
        </div>
        <div>
            <label>Email:</label><input type="text" id="email" runat="server"/>
        </div>
          <div>
            <label>Номер машины:</label><input type="text" id="carnumber" runat="server"/>
        </div>
          <div>
            <label>Причина поломки:</label><input type="text" id="сarеrable" runat="server"/>
        </div>
        <div>
              <label>Выберете мастера</label>
            <select id="willattend" runat="server">
                <option value="">Вася</option>
                <option value="true">Бобр</option>
                <option value="false">Стена</option>
            </select>
        </div>
        <div>
            <button type="submit">Подтвердить</button>
        </div>
    </form>
</body>
</html>
