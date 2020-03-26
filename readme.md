[![Build status](https://ci.appveyor.com/api/projects/status/ucxwgqb0ypj73tt9?svg=true)](https://ci.appveyor.com/project/adeildo-oliveira/consolegenericstrategy)

>## Pattern Strategy Generic
Este projeto tem como objetivo, propor o patter stategy de forma genérica e dinâmica.

Neste projeto, foi usado também a injeção de dependência do dotnet core.

### No projeto, entrando na pasta aonde está o arquivo **Dockerfile**, executar os comandos abaixo:

1. Buid da imagem:
    ```
    docker build -t consolestrategy-generic .
    ```
2. Criação do container a partir da imagem:
    ```
    docker run -i --name console-strategy consolestrategy-generic
    ```

### Após a exeução será exibido as mensagens abaixo:
* Cliente alteração
* Endereço alteração
* Telefone alteração
* Tipo produto alteração