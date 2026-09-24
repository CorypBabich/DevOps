<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DevOps._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            
        </section>

        <div class="row">
            <table>
                <tr>
                    <td>
                        <asp:Label Text="1d4" runat="server" style="margin-left:23px" />
                        <asp:Label Text="1d6" runat="server" style="margin-left:94px"/>
                        <asp:Label Text="1d8" runat="server" style="margin-left:94px"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnD4" Text="Roll" style="margin-left:18px" runat="server" OnClick="btn1d4Roll_Click"/> 
                        <asp:Button ID="btnD6" Text="Roll" style="margin-left:83px" runat="server" OnClick="btn1d6Roll_Click"/> 
                        <asp:Button ID="btND8" Text="Roll" style="margin-left:83px" runat="server" OnClick="btn1d8Roll_Click"/> 
                    </td>           
                </tr>
                <tr>
                    <td>
                        <asp:Label name="d4Input" Style="border:groove" runat="server" size="6" id="d4Input"/>
                        <asp:Label name="d6Input" style="border:groove;margin-left:49px" runat="server" size="6" id="d6Input"/>
                        <asp:Label name="d8Input" style="border:groove;margin-left:49px" runat="server" size="6" id="d8Input"/>
                    </td>
                </tr>
            </table>

            <hr style="margin-top:50px">
            <table>
                <tr>
                    <td style="font-weight: bold">
                        <asp:Label ID="lbl_tot" Text="totals" runat="server" style="margin-left:15px"/>
                        <asp:Label ID="lbl_1" Text="1" runat="server" style="margin-left:35px"/>
                        <asp:Label ID="lbl_2" Text="2" runat="server" style="margin-left:35px"/>
                        <asp:Label ID="lbl_3" Text="3" runat="server" style="margin-left:35px"/>
                        <asp:Label ID="lbl_4" Text="4" runat="server" style="margin-left:35px"/>
                        <asp:Label ID="lbl_5" Text="5" runat="server" style="margin-left:35px"/>
                        <asp:Label ID="lbl_6" Text="6" runat="server" style="margin-left:35px"/>
                        <asp:Label ID="lbl_7" Text="7" runat="server" style="margin-left:35px"/>
                        <asp:Label ID="lbl_8" Text="8" runat="server" style="margin-left:35px"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbl_D8_tot" Text="0" runat="server" style="margin-left:15px"/>
                        <asp:Label ID="lbl_D8_1" Text="0" runat="server" style="margin-left:15px" />
                        <asp:Label ID="lbl_D8_2" Text="0" runat="server" style="margin-left:36px"/>
                        <asp:Label ID="lbl_D8_3" Text="0" runat="server" style="margin-left:36px"/>
                        <asp:Label ID="lbl_D8_4" Text="0" runat="server" style="margin-left:36px"/>
                        <asp:Label ID="lbl_D8_5" Text="0" runat="server" style="margin-left:36px"/>
                        <asp:Label ID="lbl_D8_6" Text="0" runat="server" style="margin-left:36px"/>
                        <asp:Label ID="lbl_D8_7" Text="0" runat="server" style="margin-left:36px"/>
                        <asp:Label ID="lbl_D8_8" Text="0" runat="server" style="margin-left:36px"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbl_D6_tot" Text="0" runat="server" style="margin-left:15px"/>
                        <asp:Label ID="lbl_D6_1" Text="0" runat="server" style="margin-left:35px" />
                        <asp:Label ID="lbl_D6_2" Text="0" runat="server" style="margin-left:36px"/>
                        <asp:Label ID="lbl_D6_3" Text="0" runat="server" style="margin-left:36px"/>
                        <asp:Label ID="lbl_D6_4" Text="0" runat="server" style="margin-left:36px"/>
                        <asp:Label ID="lbl_D6_5" Text="0" runat="server" style="margin-left:36px"/>
                        <asp:Label ID="lbl_D6_6" Text="0" runat="server" style="margin-left:36px"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbl_D4_tot" Text="0" runat="server" style="margin-left:15px"/>
                        <asp:Label ID="lbl_D4_1" Text="0" runat="server" style="margin-left:36px" />
                        <asp:Label ID="lbl_D4_2" Text="0" runat="server" style="margin-left:36px"/>
                        <asp:Label ID="lbl_D4_3" Text="0" runat="server" style="margin-left:36px"/>
                        <asp:Label ID="lbl_D4_4" Text="0" runat="server" style="margin-left:36px"/>
                    </td>
                </tr>
            </table>
            <asp:Label ID="lblError" Text="" runat="server" style="margin-left:36px"/>
        </div>
    </main>

</asp:Content>
