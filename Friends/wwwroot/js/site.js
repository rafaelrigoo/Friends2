var dropdownElementList = [].slice.call(document.querySelectorAll('.dropdown-toggle'))
var dropdownList = dropdownElementList.map(function (dropdownToggleEl) {
    return new bootstrap.Dropdown(dropdownToggleEl)
})


function confirmacao(Id, Nome) {

    var resposta = confirm(`Deseja remover ${Nome}?`);
    if (resposta == true) {
        window.location.href = "GerenciarElenco/ExcluirElenco/" + Id;
    }
}

function confirmacaoepisodio(Id, Nome) {

    var resposta = confirm(`Deseja remover ${Nome}?`);
    if (resposta == true) {
        window.location.href = "GerenciarEpisodio/ExcluirEpisodio/" + Id;
    }
}

