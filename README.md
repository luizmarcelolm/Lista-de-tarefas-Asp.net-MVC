# Aplicação para armazenar uma lista de atividades de forma prática

# Esse projeto foi criado com asp.net mvc c#, com o objetivo de mostrar o desenvolvimento de um CRUD para o armazenamento de informações no banco de dados, podendo ser acessada a qualquer momento.

* Para a criação do projeto foi utilizado:
* ASP.NET MVC
* C#
* BANCO DE DADOS SQL SERVER
* JQUERY PARA VALIDAÇÃO DOS CAMPOS
* BOOTSTRAP
* GITHUB
-------------------------------------------
* As atividades ficam com status amarelo automaticamente quando elas estão vencidas.
* Ficam verde quando estão completas.
* Sem cor quando estão aguardando ser concluídas.
# ![image](https://github.com/luizmarcelolm/Lista-de-tarefas-Asp.net-MVC/assets/109484017/e3e4bdfe-31ac-4941-8224-d3b974b1b4d8)
-------------------------------------------
* Nesse trecho de código foi feita uma verificação e alterado a cor na classe conforme seu status.
# ![image](https://github.com/luizmarcelolm/Lista-de-tarefas-Asp.net-MVC/assets/109484017/efa12ade-252e-4ac6-9de4-648f33272c1e)
-------------------------------------------
* No botão deletar tarefas completas, exclui todas as atividades que estão verdes.
# ![image](https://github.com/luizmarcelolm/Lista-de-tarefas-Asp.net-MVC/assets/109484017/27c2e4f3-e3b0-43fd-874f-aed227f58f8b)
-------------------------------------------
* Na controller foi criado um IActionResult com nome de DeletarCompletos, onde percorre a lista no banco e todas as atividades que estiverem completas são exclidas do banco.
#![image](https://github.com/luizmarcelolm/Lista-de-tarefas-Asp.net-MVC/assets/109484017/92de9027-c726-49b4-8d82-33759a5d7418)

 

