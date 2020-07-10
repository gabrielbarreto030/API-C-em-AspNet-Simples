# API-C-em-AspNet-Simples
Uma Api simples de ApsNet 3.0 com Entity Framework


Cadastro de Produtos
Cadastro de Categorias
Visualização dos Produtos e Categorias

Asp Net 3.0 com Entity Framework

POST

# /categories
{
"title":"value"
}
# /products
{
 "title":"value",
 "description":"value",
 "price":100,
 "categoryid":1
}

GET

# /categories

todas categorias
# /products
todos os produtos
# /products/categories/{id}
produto especifico de uma categoria
# /products/{id}
produto especifico de um determinado ID


