
const toggleMenuAdmin = () =>{
    const iconToggle = document.querySelector("#toggle-menu");
    if(iconToggle){
        const sideBar = document.querySelector(".sidebar");
        const chenSidebar = document.querySelector(".chen-sidebar");
        const content = document.querySelector("#admin .content");

        iconToggle.addEventListener('click',()=>{
            content.classList.toggle("zoom-out");
            chenSidebar.classList.toggle("zoom-out");
            sideBar.classList.toggle("zoom-out");
        })
    }
}
toggleMenuAdmin();

const onTopAdd = ()=>{
    let on_Top = document.createElement('a')
    let attClass = document.createAttribute("class");
    attClass.value = "on-top";
    on_Top.setAttributeNode(attClass);
    let attId = document.createAttribute("id");
    attId.value = "on-top";
    on_Top.setAttributeNode(attId);
    let i = document.createElement('i')
    let attClassI = document.createAttribute("class");
    attClassI.value = "bi bi-chevron-up";
    i.setAttributeNode(attClassI);
    on_Top.appendChild(i)
    document.body.appendChild(on_Top)
}

onTopAdd()
const onTop = document.querySelector("#on-top");
if(onTop){
    onTop.addEventListener('click',() =>
        window.scrollTo(0, 0)
    )
    window.addEventListener("scroll",()=>{
        let x = pageYOffset;
        if(x > 300)onTop.classList.add('show-onTop')
        else onTop.classList.remove('show-onTop')
    })
}
const itemFlip = document.querySelectorAll(".item-flip")
itemFlip.forEach(e=>{
    e.childNodes[1].addEventListener('click',()=>{
        e.classList.toggle("show");
    })
})
const menu_mobile = document.querySelectorAll('.menu-mobile .navbar-nav .nav-item');
menu_mobile.forEach(e=>{
    try{
        e.childNodes[1].childNodes[3].addEventListener('click',()=>{
            e.childNodes[3].classList.toggle("show");
        })
    }
    catch (e){}
})

var prevScrollpos = window.pageYOffset;
const header = document.getElementById("header");
let chen_header = document.createElement("div")
let attrChenHeader = document.createAttribute("id");
attrChenHeader.value = "chen-header";
chen_header.setAttributeNode(attrChenHeader);
document.querySelector("#bd-wrapper").insertBefore(chen_header,header.nextSibling)
chen_header.style.height = `${header.clientHeight}px`;

window.onscroll = function() {

    var currentScrollPos = window.pageYOffset;
    if (prevScrollpos > currentScrollPos) {
        header.style.top = "0";
    } else {
        header.style.top = `-${header.clientHeight}px`;
    }
    prevScrollpos = currentScrollPos;
}
const cartTotal = () => {
    const itemCart = document.querySelectorAll("#list-cart .box-side")
    if(itemCart){
        let total = 0;
        itemCart.forEach(e=>{

            let price = e.querySelector(".name .price").innerHTML.replace(" đ","")
            let numberStr = e.querySelector(".item-update.number")
            let number = parseInt(numberStr.innerHTML.trim())
            const update = () => {
                numberStr.innerHTML = number
                let totalPrice = price * number
                total += totalPrice
                e.querySelector(".total .price").innerHTML = `${totalPrice}.000 đ`
                e.querySelector(".valNumber").value =  number
                updateTotal()
            }
            update()
            //cập nhật số lượng
            //trừ số lượng
            e.querySelector(".reduce").addEventListener('click',()=>{
                if(number <= 1) number = 0
                else number --
                update()
                updateTotal()
            })
            //cộng số lượng
            e.querySelector(".increase").addEventListener('click',()=>{
                number ++
                update()
                updateTotal()
            })
            //const removeItem = e.querySelector(".remove-item");
            //removeItem.addEventListener('click', () => {
            //    const id = removeItem.getAttribute("data-id");
            //    console.log(id)

            //})
        })
    }
}



const dropMenu = () => {
    const dropMenu = document.querySelectorAll(".drop_menu")
    dropMenu.forEach(e=>{
        e.style.cursor = "pointer"
        e.querySelector("i").addEventListener("click",()=>{
            if(!e.querySelector("div").classList.contains("d-block"))
                dropMenu.forEach(e=>{
                    e.querySelector("div").classList.remove("d-block")
                })
            e.querySelector("div").classList.toggle("d-block")
        })
    })
}

const updateTotal = () => {
    const itemCart = document.querySelectorAll("#list-cart .box-side")
    if(itemCart){
        const totalS = document.querySelector("#totalCart")
        let total = 0;
        itemCart.forEach(e=>{
            let item = e.querySelector(".total .price").innerHTML.replace(" đ","")
            total += parseInt(item)
        })
        totalS.innerHTML = `${total} đ`
    }
}
const itemProduct = () => {
    const itemProduct = document.querySelectorAll(".site-price")
    if(itemProduct){
        itemProduct.forEach(e => {
            if(e.querySelector(".sale")){
                e.querySelector(".price").classList.add("price-sale")
            }
        })
    }
}

const dropdownListOrder = () => {
    const listOrder = document.querySelectorAll("#list_order .box-side")
   if(listOrder){
       listOrder.forEach(e=>{
           e.querySelector(".icon-dropdow").addEventListener("click",()=>{
               e.querySelector(".content").classList.toggle("show")
           })
       })
   }
}

const myBtn = () =>{
    const myBtn = document.querySelectorAll(".my-btn")
    myBtn.forEach(btn => {
        btn.addEventListener("click",function (e){
            let x = e.clientX - e.target.offsetLeft;
            let y = e.clientY - e.target.offsetTop;
            let ripples = document.createElement('span');
            ripples.style.left = x+'px';
            ripples.style.top = y+'px';
            this.appendChild(ripples);
            setTimeout(()=>{
                ripples.remove()
            },1000)
        })
    })
}

const productColor = () => {
    const productCustom = document.querySelectorAll(".product-custom")
    if(productCustom){
        productCustom.forEach(item=>{
            const itmeColor = item.querySelectorAll(".item-color")
            itmeColor.forEach(e=>{
                e.addEventListener('click',()=>{
                    itmeColor.forEach(el=>{
                        el.classList.remove("present")
                    })
                    e.classList.add("present")
                })
            })
        })
    }
}

myBtn()
dropMenu()
itemProduct()
cartTotal()
dropdownListOrder()
productColor();