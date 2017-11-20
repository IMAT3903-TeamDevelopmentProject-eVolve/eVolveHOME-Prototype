<%@ Page Title="Checkout" Language="C#" MasterPageFile="~/StylePage.master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <section id="Orderreview">
        <section>
            <h3>Review Your Order</h3>
            <table>
                <tr>
                    <th>OrderID</th>
                    <th>Products</th>
                    <th>Delivery Type</th>
                    <th>Delivery Price</th>
                </tr>
                <tr>
                    <td>01</td>
                    <td>
                        <ul>
                            <li>Zara Cuddle Chair</li>
                        </ul>
                    </td>
                    <td>Standard Delivery</td>
                    <td>Free</td>
                </tr>
            </table>
        </section>
        <section>
            <h3>Payment</h3>
            <div>
                <aside id="pay-title">
                    Payment Details
                    <img src="media/img/icons/cards.png" alt="" />
                </aside>
                <article id="CardNumber">
                    Card Number<br /> 
                    <input type="text" value="" placeholder="Valid Card Number" id="cardNumber" />
                </article>
                <article id="ExpirDate">
                    Expiration Date<br />
                    <input type="text" value="" placeholder="Expiration Date" />
                </article>
                <article id="CVcode">
                    CV Code<br />
                    <input type="text" value="" placeholder="CVC Code"/><br />
                </article>
                <input type="submit" value="Pay" id="SubmitPay" />
            </div>
        </section>
        

    </section>
</asp:Content>

