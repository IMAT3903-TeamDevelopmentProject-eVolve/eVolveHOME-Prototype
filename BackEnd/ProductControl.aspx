<%@ Page Title="Product Control" Language="C#" MasterPageFile="~/BackEndStyle.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="content-area">
        <section class="page-title">
            <h2>Product Control</h2>
            <h4>Logged In:  <span>Admin Name</span></h4>
        </section>
        <section class="obj-control">
            <aside>
                <h3>Product Management</h3>
                <article class="obj-add">
                    <h4>Add a New Product</h4>
                    <table id="add-product-form">
                        <tr>
                            <td>Product Name</td>
                            <td>
                                <input type="text" value="" placeholder="Product Name" />
                            </td>
                        </tr>
                        <tr>
                            <td>Product Price</td>
                            <td>
                                <input type="text" value="" placeholder="Price(&pound;)" />
                            </td>
                        </tr>
                        <tr>
                            <td>Product Type</td>
                            <td>
                                <select>
                                    <option value="" selected="selected">select product type</option>
                                    <option value="">Sofa</option>
                                    <option value="">Chair</option>
                                    <option value="">Fridge</option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td>Product Collection</td>
                            <td>
                                <select>
                                    <option value="" selected="selected">select product collection</option>
                                    <option value="">Living Space</option>
                                    <option value="">Bedroom</option>
                                    <option value="">Office</option>
                                    <option value="">Garden</option>
                                    <option value="">Kitchen</option>
                                    <option value="">Bathroom</option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td>Description</td>
                            <td>
                                <textarea name="" cols="30" rows="5"></textarea>
                            </td>
                        </tr>
                        <tr>
                            <td>Dimentions</td>
                            <td>
                                <input type="text" value="" placeholder="height(cm)" />
                                <input type="text" value="" placeholder="width(cm)" />
                                <input type="text" value="" placeholder="depth(cm)" />
                            </td>
                        </tr>
                        
                    </table>
                    <input type="submit" value="Add New" />
                    <p class="error">Error Display</p>
                </article>
                <article class="obj-edit">
                    <h4>Edit a Current Product</h4>
                </article>
                <article class="obj-del">
                    <h4>Remove a Current Product</h4>
                </article>
            </aside>
            <aside>
                <!-- Jquery HERE for table filtering -->
                <h3>All Products</h3>
                <input type="search" id="search" placeholder="Filter by Product Name" />
                <!-- *** Insert table loop here to display data *** -->
                <table class="all-products">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Product Name</th>
                            <th>Price (&pound;)</th>
                            <th>Type</th>
                            <th>Collection</th>
                            <th>Description</th>
                            <th>Dimentions</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>1</td>
                            <td class="title">Sofa 1</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Chair</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td class="title">Fridge</td>
                            <td>360</td>
                            <td>Sofa</td>
                            <td>Living Space</td>
                            <td>A large 3 seating sofa...</td>
                            <td>25cm, 58cm, 200cm</td>
                        </tr>
                    </tbody>
                </table>
            </aside>
        </section>
    </section>
</asp:Content>
