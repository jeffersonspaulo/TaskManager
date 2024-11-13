# GerenciadorDeTarefas - API construída para gerenciar suas tarefas diárias

## Desenvolvimento: 
- Projeto feito em .NET 8

## Arquitetura: 
- Clean Architecture

## Componentes:
- FluentValidation: validação de dados e tratamento de exceções
- Automapper: mapeamento automático entre entidades e DTOs
- Entity Framework Core com Migrations: facilitar a persistência e controle de versões do banco de dados
- xUnit: realização dos testes unitários

## Banco de dados: 
- SQL Server


### Para realizar a execução do projeto no Docker, é necessário executar o seguinte comando na pasta raiz da Solution:

```
docker-compose up
```


---

# Fase 2: Refinamento
- Gostaria de obter mais informações sobre os sistemas externos que farão as requisições para a API de Gerenciamento de Tarefas, a fim de monitorar fluxos problemáticos, otimizar a integração de autenticação e gestão de usuários, além de aprimorar a experiência dos clientes.

- Quais são os planos de longo prazo para escalar a aplicação e a infraestrutura?

- Há alguma funcionalidade ou fluxo que poderia ser simplificado ou que está causando frustração para os usuários?

- Existe uma expectativa de um aumento significativo de tráfego? Devemos focar em otimizar a performance da API para lidar com essa demanda crescente?

---

# Fase 3: Final
- Aprimorar os testes unitários e de integração, garantindo maior cobertura de casos de uso e maior confiabilidade no sistema.

- Otimizar a integração com sistemas externos, com o objetivo de melhorar as validações, o tratamento de usuários e enriquecer as regras de negócio da API, incorporando informações adicionais dos usuários.

- Expandir os relatórios e funcionalidades disponíveis para os usuários, oferecendo mais opções de análise e personalização.

- Adicionar novos endpoints necessários, visando tornar a API mais flexível e adaptável a futuras necessidades.

- Focar em otimização de performance e monitoramento, garantindo que a API seja eficiente, escalável e facilmente monitorada em produção.