[![Build status](https://ci.appveyor.com/api/projects/status/ucxwgqb0ypj73tt9?svg=true)](https://ci.appveyor.com/project/adeildo-oliveira/consolegenericstrategy)

>## Pattern Strategy Generic
Este projeto tem como objetivo, propor a escrita do pattern stategy de forma genérica e dinâmica. Foi usado também, injeção de dependência do dotnet core.

### No projeto, entrando na pasta aonde está o arquivo **Dockerfile**, executar os comandos abaixo:

1. Buid da imagem:
    ```
    docker build -t consolestrategy-generic .
    ```
2. Criação do container a partir da imagem:
    ```
    docker run -i --name console-strategy consolestrategy-generic
    ```

### Após a execução, será exibido as mensagens abaixo:
* Cliente alteração
* Endereço alteração
* Telefone alteração
* Tipo produto alteração
