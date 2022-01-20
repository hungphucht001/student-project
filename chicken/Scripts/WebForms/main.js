const showSearch = $("#show-search");
const search = $("#search");

var isShowSearch;
const toggleAccount = $(".toggle-account");
const subAccount = $(".sub-account");

var isShowAccount;

if(showSearch){
    showSearch.onclick = ()=>{
        if(!isShowSearch){
            search.style.transform = "translateY(30px)";
            isShowSearch = true;
            subAccount.style.display = "none";
            isShowAccount = false;
        }
        else{
            search.style.transform = "translateY(-400px)";
            isShowSearch = false;
        }
    }
    
}

if (toggleAccount || subAccount) {
    toggleAccount.onclick = () => {
        if (!isShowAccount) {
            subAccount.style.display = "block";
            isShowAccount = true;
            search.style.transform = "translateY(-400px)";
            isShowSearch = false;
        }
        else {
            subAccount.style.display = "none";
            isShowAccount = false;
        }
    }

}