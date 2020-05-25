# REST-API-Exemplo
Exemplo de REST API em .net core

Requisitos:
- ter o Visual Studio instalado;
- ter o SDK do net core 2.1 instalado;
- ter um software para fazer requisições HTTP (Postman, Talend API Tester);

# Abrir o arquivo da solution (API REST Exemplo.sln) com o Visual Studio e rodar a aplicação. #


## Objetos
### Jogo
#### Métodos
##### GET
###### Descrição: Retorna a lista de todos os jogos
###### URI: http://localhost:52080/api/Jogo/

##### GET
###### Descrição: Retorna um jogo específico
###### URI: http://localhost:52080/api/Jogo/{ID_DO_JOGO}

##### POST
###### Descrição: Cria um jogo
###### URI: http://localhost:52080/api/Jogo/
###### Parâmetros: nome {string}

##### PUT
###### Descrição: Atualiza um jogo
###### URI: http://localhost:52080/api/Jogo/{ID_DO_JOGO}
###### Parâmetros: nome {string}

##### DELETE
###### Descrição: Remove um jogo
###### URI: http://localhost:52080/api/Jogo/{ID_DO_JOGO}
