Japa Refeições - Sistema de Cadastro para Restaurante
Bem-vindo ao projeto Japa Refeições! Este repositório contém um sistema de cadastro desenvolvido para um restaurante, como parte de um projeto avaliativo do Técnico de Informática em 2020.2 no Colégio Mercúrio.

Apresentação do Projeto
O Japa Refeições é um sistema de cadastro que visa facilitar a gestão de informações importantes para o funcionamento de um restaurante. Ele permite o cadastro de produtos, fornecedores, clientes e pedidos, oferecendo uma solução simples e eficiente para auxiliar na administração do estabelecimento.

Como Configurar o Banco de Dados
Para executar o sistema em sua máquina local usando o XAMPP ou WAMP, siga as etapas abaixo para configurar o banco de dados:

Certifique-se de ter o XAMPP ou WAMP instalado em sua máquina. Ambos fornecem um ambiente de desenvolvimento local com suporte a servidor web e banco de dados.

Inicie o XAMPP ou WAMP e certifique-se de que os serviços Apache e MySQL estejam em execução.

Abra o painel de controle do MySQL (phpMyAdmin) em seu navegador, geralmente acessível em http://localhost/phpmyadmin.

Crie um novo banco de dados chamado "bdjapapito2".

No diretório raiz do projeto Japa Refeições, localize o arquivo "database.sql". Abra-o em um editor de texto e substitua todas as ocorrências de "bdjapapito2" pelo nome correto do banco de dados, nesse caso, "bdjapapito2".

No painel de controle do MySQL, selecione o banco de dados "bdjapapito2" recém-criado e clique na opção "Importar". Selecione o arquivo "bdjapapito2" modificado e clique em "Executar" para importar a estrutura do banco de dados e os dados iniciais.

Abra o projeto Japa Refeições em um editor de código ou ambiente de desenvolvimento C#.

No diretório do projeto, localize o arquivo "Banco.cs". Verifique as configurações de conexão com o banco de dados nesse arquivo e certifique-se de que o nome do banco de dados esteja configurado corretamente como "bdjapapito2" e o servidor como "localhost".

Após configurar o banco de dados, você estará pronto para executar o sistema. Inicie o servidor web do XAMPP ou WAMP e acesse o projeto através de um navegador web, digitando a URL correspondente (por exemplo, http://localhost/japa-refeicoes).
