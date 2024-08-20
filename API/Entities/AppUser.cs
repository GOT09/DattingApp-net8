using System;

namespace API.Entities;

public class AppUser //como num banco de dados, essa seria a tabela
{
    //Entity framework deve ser publico
    // OBJETCT RELATIONAL MAPPER (ORM)
    // Translates our coide into SQL commands that update our tables in the database
    public int Id { get; set; } // colunas, por padrao ID ja vira chave primaria, para especificar 
    //tem que colocar [Key]
    public required string UserName { get; set; } //colunas, required usado para nao permitir valores nulos
}
