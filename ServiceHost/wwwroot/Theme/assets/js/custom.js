const cookieName = "cart-items";

function addToCart(id, name, price, picture) {

    let products = $.cookie(cookieName);

    if (products === undefined) {
        products = [];
    } else {
        products = JSON.parse(products);
    }

    const count = 1;
    const currentProduct = products.find(x => x.id === id);
    if (currentProduct !== undefined) {
        products.find(x => x.id === id).count = currentProduct.count + 1;
    } else {
        const product = {
            id, name, price, picture, count
        }

        products.push(product);
    }

    $.cookie(cookieName, JSON.stringify(products), { expires: 2, path: "/" });
    updateCart();
}

function updateCart() {

    let products = $.cookie(cookieName);
    products = JSON.parse(products);

    let cartItemList = $("#cart_item_list");
    cartItemList.html('');
    products.forEach(item => {
        const product = `<li class="m_cart_li1">
                                <a href="#" class="m_cart-item" onclick="removeCartItem('${item.id}')">
                                    <i class="fa fa-times" aria-hidden="true"></i>
                                    <div class="m_cart-item-content">
                                        <div class="m_cart-item-image">
                                            <img src="/Upload/${item.picture}" />
                                        </div>
                                        <div class="m_cart-item-details">
                                            <div class="m_cart-item-title">
                                                ${item.name.length > 20 ? item.name.substring(0, 20) + '...' : item.name}
                                            </div>
                                            <div class="m_cart-item-params">
                                                <div class="m_cart-item-props">
                                                    <span>تعداد : ${item.count}</span>
                                                    <span>قیمت واحد : ${item.price}</span>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                  </a>
                         </li>`;
        cartItemList.append(product);
    });
}

function removeCartItem(id) {

    let products = $.cookie(cookieName);
    products = JSON.parse(products);

    const item = products.findIndex(x => x.id === id);
    products.splice(item, 1);

    $.cookie(cookieName, JSON.stringify(products), { expires: 2, path: "/" });
    updateCart();

}