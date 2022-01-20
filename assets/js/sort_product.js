const boxItemProduct = (ob, asc = true) => {
    const  object =  _.sortBy(ob, ['price'])
    if(!asc) object.reverse()
    let litItem = ""
    object.forEach(e =>{
        litItem += item(e);
    })
const list_product = document.querySelector("#list_product");
    list_product.innerHTML = litItem;
}
const item = (e) => {
    return `<div class="col-lg-4">
                <div class="item-product">
                    <div class="item-top">
                        <div class="single-image">
                            <img src="${e.urlHinh}" alt="">
                        </div>
                        <a href="#" class="see-detail nav-link btn rounded-0">Xem chi tiết</a>
                    </div>
                    <div class="text">
                        <span>${e.name}</span>
                        <h6>Realme 8</h6>
                        <div class="site-price">
                            <span class="sale">${e.sale}</span>
                            <span class="price price-sale">${e.price}</span>
                        </div>
                    </div>
                    <div class="box-zindex">
                        <span>New</span>
                    </div>
                </div>
            </div>`;
}
const fillJson = ()=>{
    let arrProduct = [];
    const list_product = document.querySelectorAll("#list_product .item-product");
    list_product.forEach(e =>{
        const urlHinh = e.querySelector("img").src
        const name = e.querySelector(".text>span").innerHTML
        const price = e.querySelector(".text .price").innerHTML
        const sale = e.querySelector(".text .sale").innerHTML
        const ob = {
            urlHinh: urlHinh,
            name: name,
            price: price,
            sale: sale,
        }
        arrProduct.push(ob);
    })
    return arrProduct;
}

function x2(){
    const asc_product = document.querySelector("#asc_product");
    const desc_product = document.querySelector("#desc_product");
    const navbarDropdown4 = document.querySelector("#navbarDropdown4");

   if (navbarDropdown4){
       asc_product.addEventListener('click',()=>{
           boxItemProduct(fillJson(),true);
           navbarDropdown4.innerHTML = asc_product.innerHTML;
       })
       desc_product.addEventListener('click',()=>{
           boxItemProduct(fillJson(),false);
           navbarDropdown4.innerHTML = desc_product.innerHTML;
       })
   }
}
x2();
