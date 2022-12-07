function ListarDisciplina(){
    $.get('https://localhost:5001/Disciplina/Listar')
        .done(function(resposta) { 
            for(i = 0; i < resposta.length; i++) {
                $('#DisciplinaSelect').append($('<option></option>').val(i+1).html(resposta[i]));
            }
        })
        .fail(function(erro, mensagem, excecao) { 
            alert(mensagem + ': ' + excecao);
        });
}



// $(document).ready(function() {
//     grid();
//     listarDisciplina();
//     $('#salvarBtn').prop('disabled', true);
//     $('#candidatoSelect').prop('disabled', true);
// });


// function listarDisciplina(){
//     $.get('https://localhost:5001/Disciplina/Listar')
//         .done(function(resposta) { 
//             for(i = 0; i < resposta.length; i++) {
//                 $('#candidatoSelect').append($('<option></option>').val(resposta[i].nCodDisci).html(resposta[i].cNomeDisci));
//             }
//         })
//         .fail(function(erro, mensagem, excecao) { 
//             alert(mensagem + ': ' + excecao);
//         });
// }
// function validaCandidato(){

//     candidatoSelecionado = $('#candidatoSelect').val();

//     if(candidatoSelecionado != "0")
//     {
//         $('#salvarBtn').prop('disabled', false);
//     }
//     else
//     {
//         $('#salvarBtn').prop('disabled', true);
//     }
// }