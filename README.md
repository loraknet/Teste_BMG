# BIG E-COMMERCE – Desafio Técnico (.NET)

Você é o desenvolvedor responsável por viabilizar todo o back-end de um E-COMMERCE.  
O sistema deve conter funcionalidades de autenticação de usuários, gestão de produtos, criação e acompanhamento de pedidos.

## Requisitos
1. **Autenticação de usuários:** permitir login e manter sessões autenticadas (clientes e administradores) com distinção de permissões.  
2. **Catálogo de produtos:** permitir ao administrador criar, atualizar, listar e excluir produtos.  
3. **Pedidos/carrinho:** permitir ao cliente definir a quantidade do item, incluir um ou mais produtos e atualizar automaticamente o estoque.  
4. **Pagamento:** o pedido será confirmado após a conclusão do pagamento via pix ou cartão.  
5. **Histórico de pedidos:** clientes poderão visualizar e acompanhar a situação dos seus pedidos.

## Promoção Black Friday
O BIG E-COMMERCE irá lançar uma grande campanha de inauguração do site na promoção Black Friday.  
A cada 1 hora, será disponibilizada uma oferta de 100 iPhones por apenas **R$ 1,00**.  

- 0h → 100 iPhones por R$ 1,00  
- 1h → +100 iPhones por R$ 1,00  
- 2h → +100 iPhones por R$ 1,00  
...  
- 23h → +100 iPhones por R$ 1,00  

**Importante:** nunca pode ser vendido mais de 100 iPhones por hora, mesmo com compras simultâneas.

## Entrega esperada
- Código em .NET implementando os requisitos.  
- Pode usar banco em memória ou SQLite.  
- Documentar como rodar o projeto (exemplo: via Swagger).  

## O que será avaliado
- Organização do código  
- Qualidade técnica (transações, controle de concorrência, autenticação)  
- Clareza na explicação das decisões  
