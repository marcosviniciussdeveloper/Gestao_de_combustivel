document.addEventListener("DOMContentLoaded", function () {
    const mobileBtn = document.getElementById("mobile_btn");
    const mobileMenu = document.getElementById("mobile_menu");

    if (mobileBtn && mobileMenu) {
        mobileBtn.addEventListener("click", function () {
            mobileMenu.classList.toggle("active");

            // Alternar ícone entre "fa-bars" e "fa-times"
            const icon = mobileBtn.querySelector("i");
            if (icon) {
                icon.classList.toggle("fa-bars");
                icon.classList.toggle("fa-times");
            }
        });

        // Fecha o menu ao clicar em qualquer link dentro dele
        document.querySelectorAll("#mobile_menu a").forEach(link => {
            link.addEventListener("click", function () {
                mobileMenu.classList.remove("active");
                mobileBtn.querySelector("i").classList.add("fa-bars");
                mobileBtn.querySelector("i").classList.remove("fa-times");
            });
        });
    } else {
        console.error("Erro: Botão ou menu mobile não encontrado no DOM.");
    }
});
