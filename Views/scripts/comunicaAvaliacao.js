$(document).ready(function() {
    ListarAvalicao();
});


function ListarAvalicao(){
    $.get('https://localhost:5001/Avaliacao/ListarAvaliacao')
        .done(function(resposta) { 
            for(i = 0; i < resposta.length; i++) {
                $('#AvaliacaoSelect').append($('<option></option>').val(i+1).html(resposta[i]));
            }
        })
        .fail(function(erro, mensagem, excecao) { 
            alert(mensagem + ': ' + excecao);
        });
}


function Avaliar() {
    
    let avaliacao = {
        CNomeDisci:formulario.NomeDisci.value,
        CMsg: formulario.MsgInput.value,
        iINota:formulario.INotaInput.value
    };

    console.log(avaliacao);

    $.ajax({
        type: 'POST',
        url: 'https://localhost:5001/Avaliacao/novaAvaliacao',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(avaliacao),
        success: function() {
            alert("Avaliação registrada com sucesso!");
            limpar();
            location.reload(true);
        },
        error: function() {
            alert("Erro ao realizar a avaliação!");
        }
    });
}

