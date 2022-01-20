
//var api = `https://localhost:44360/api/product/getphone/${window.location.search.substring(6, window.location.search.length)}`
//fetch(api)
//    .then(function (res) {
//        return res.json();
//    })
//    .then(function (posts) {
//        console.log(posts)
//        boxItemProduct(posts)
//    })

//const boxItemProduct = (posts, asc = true) => {
//    //const object = _.sortBy(ob, ['price'])
//    //if (!asc) object.reverse()
//    let litItem = ""
//    posts.forEach(e => {
//        litItem += item(e);
//    })
//    const list_product = document.querySelector("#list_product");
//    list_product.innerHTML = litItem;
//}
////<div class="site-price">
////    <span class="sale">${e.sale}</span>
////    <span class="price price-sale">${e.price}</span>
////</div>
//const item = (e) => {
//    return `<div class="col-lg-4 col-md-6">
//                <div class="item-product">
//                    <div class="item-top">
//                        <div class="single-image">
//                            <img src="/Assets/img/img_downloaded/${e.UrlHinh}" alt="">
//                        </div>
//                        <a href="/san-pham/${conver(e.TenSP)}/${e.ID}" class="see-detail nav-link btn rounded-0">Xem chi tiết</a>
//                    </div>

//                    <div class="text">
//                        <span>Smartphone</span>
//                        <h6>${e.TenSP}</h6>
//                        <div class="site-price">
//                            <span class="price">@sp.GiaNiemYet đ</span>
//                        </div>
//                    </div>
//                    <div class="box-zindex">
//                        <span>New</span>
//                    </div>
//                </div>
//            </div>`

//        ;
//}
//function conver(str) {
//    const newStr = str.normalize("NFD").replace("|", "-").replace(/[\u0300-\u036f]/g, "").replace("/", "-").replace("", "-");
//    return newStr;
//}
//function x2() {
//    const asc_product = document.querySelector("#asc_product");
//    const desc_product = document.querySelector("#desc_product");
//    const navbarDropdown4 = document.querySelector("#navbarDropdown4");

//    if (navbarDropdown4) {
//        asc_product.addEventListener('click', () => {
//            boxItemProduct(fillJson(), true);
//            navbarDropdown4.innerHTML = asc_product.innerHTML;
//        })
//        desc_product.addEventListener('click', () => {
//            boxItemProduct(fillJson(), false);
//            navbarDropdown4.innerHTML = desc_product.innerHTML;
//        })
//    }
//}
//x2();
