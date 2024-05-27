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

* Nesse trecho de código foi feita uma verificação e alterado a cor na classe conforme seu status.
# ![image](https://github.com/luizmarcelolm/Lista-de-tarefas-Asp.net-MVC/assets/109484017/efa12ade-252e-4ac6-9de4-648f33272c1e)
-------------------------------------------
* No botão deletar tarefas completas, exclui todas as atividades que estão verdes.
# ![image](https://github.com/luizmarcelolm/Lista-de-tarefas-Asp.net-MVC/assets/109484017/27c2e4f3-e3b0-43fd-874f-aed227f58f8b)

* Na controller foi criado um IActionResult com nome de DeletarCompletos, onde percorre a lista no banco e todas as atividades que estiverem completas são exclidas do banco.
#![image](https://github.com/luizmarcelolm/Lista-de-tarefas-Asp.net-MVC/assets/109484017/92de9027-c726-49b4-8d82-33759a5d7418)
--------------------------------------------

* No botão adicionar tarefa, abre um formulário para ser inserido novas dados.
* Caso não queira adicionar nova tarefa o botão cancelar retorna a Index. 
# ![image](https://github.com/luizmarcelolm/Lista-de-tarefas-Asp.net-MVC/assets/109484017/02b6024d-004e-4328-bc26-fa6ab5ac4612)
--------------------------------------------

* Do lado esquerdo superior foi colocado 3 select para filtrar as informações que deseja obter do banco de dados.
* Categoria:
    - Todos
    - Academia
    - casa
    - Compras
    - Academia
    - Trabalho
* Data de Vencimento
    - Todos
    - Futuro
    - Passado
    - Hoje
* Situação
    - Aberto
    - Completo
* Após selecionar as opções no botão filtrar faz a pesquisa.
* Botão limpar deixa todos como padrão.
# ![image](https://github.com/luizmarcelolm/Lista-de-tarefas-Asp.net-MVC/assets/109484017/26670082-c204-4a23-9db7-ca1f967c5b4b)
----------------------------------------------





 

