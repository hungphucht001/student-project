const promotions = $$("#list-promotion .box-promption");
let i = 1;
promotions.forEach(promotion => {
    let row = promotion.lastElementChild.lastElementChild;
    i++;
    if(i%2==0){
        row.firstElementChild.style.order = "2";
        row.firstElementChild.lastElementChild.style.alignItems = "flex-end";
    }
});