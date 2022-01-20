const $ = document.querySelector.bind(document);
const $$ = document.querySelectorAll.bind(document);

const special = $$("#special-tab ul li");
const present = $("#special-tab ul .present");
const tabContent = $$("#tab-content .tab-item");

for (let i = 0; i < tabContent.length; i++) {
    tabContent[i].classList.remove("present")
}

present.style.width = `${special[0].offsetWidth}px`;
tabContent[0].classList.add("present")

for(let i = 0; i < special.length; i++){
    special[i].onclick = () => {
        present.style.left = `${special[i].offsetLeft}px`;
        present.style.width = `${special[i].offsetWidth}px`;
        for (let i = 0; i < tabContent.length; i++) {
            tabContent[i].classList.remove("present")
        }
        tabContent[i].classList.add("present")
    }
}