function validateForm() {
    let x = document.forms["myForm"]["number"].value;
    if (x === "" || x.length !== 10) {
        const modal = document.querySelector(".modal")
        modal.style.display = "block"
        modal.querySelector('.my-btn').addEventListener('click',()=>{
            modal.style.display = "none"
        })
        return false;
    }
}
function validateFormAddToCart() {
    let a = document.forms["myForm2"]["quantity"].value;
    if (parseInt(a) > 0) {
        openModal("Thêm vào giỏ hàng thành công")
        return true;
    }
    else
    {
        openModal("Số lượng phải lớn hơn 0")
        return false;
    }
}
function openModal(title){
    const modal = document.querySelector(".modal")
    modal.querySelector(".modal-body p").innerHTML = title
    modal.style.display = "block"
    modal.querySelector('.my-btn').addEventListener('click',()=>{
        modal.style.display = "none"
    })
}