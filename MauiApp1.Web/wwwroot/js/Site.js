$(document).ready(function () {
    $('#mobile_btn').on('click', function () {
        $('#mobile_menu').toggleClass('active');
        $('#mobile_btn').find('i').toggleClass('fa-x');


    });
});


window.addEventListener("scroll", function () {
    let footer = document.getElementById("developer-info");
    let scrollHeight = document.documentElement.scrollHeight;
    let scrollPosition = window.innerHeight + window.scrollY;

    if (scrollPosition >= scrollHeight - 60) {
        footer.style.bottom = "0"; // 
    } else {
        footer.style.bottom = "-100px"; 
    }
});

function redirecionarCadastro() {
    window.location.href = "/Cadastro";

}
