//TopOfertas

function Produto(id, nome, preco, imagem, loja, link) {
    this.nome = nome;
    this.preco = moeda(preco, 2, ',', '.');
    this.imagem = imagem;
    this.loja = loja;
    this.link = link;
    this.id = id;
}



