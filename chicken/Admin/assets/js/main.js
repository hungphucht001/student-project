const $ = document.querySelector.bind(document)
const $$ = document.querySelectorAll.bind(document)

const listMenu = $$(".nav-sidebar .sub .item")

listMenu.forEach(item=>{
    item.onclick = ()=>{
        listMenu.forEach(item => {
        item.classList.remove("present")
    });
        item.classList.add("present")
    }
});


const header = $('.site .header')
const boxInsertHeader = $('.site .box-insert-header')
const sidebar = $('.sidebar')

const h_header = header.offsetHeight



boxInsertHeader.style.height = `${h_header}px`

sidebar.style.height = `calc(100vh - ${h_header}px)`
sidebar.style.top = `${h_header}px`