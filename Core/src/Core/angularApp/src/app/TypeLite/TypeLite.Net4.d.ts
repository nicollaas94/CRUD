/// <reference path="Enums.ts" />

declare module DTO {
	interface Candidato {
		CandidatoId: number
		Banco: Banco
		Conhecimento: Conhecimento
		Email: string
		Nome: string
		Skype: string
		Telefone: string
		Linkedin: string
		Cidade: string
		Estado: string
		Portifolio: string
		Disponibilidade: number
		Periodo: number
		Salario: string
		InformacaoBancaria: Number
	}
	interface Banco {
		BancoId: number
		NomeBanco: string
		Agencia: string
		Titular: string
		Cpf: string
		TipoConta: number
		NumeroConta: string
	}
	interface Conhecimento {
		ConhecimentoId: number
		Ionic: number
		Android: number
		IOS: number
		HTML: number
		CSS: number
		Bootstrap: number
		Jquery: number
		AngularJs: number
		Java: number
		AspMvc: number
		C: number
		Cpp: number
		Cake: number
		Django: number
		Majento: number
		PHP: number
		Wordpress: number
		Phyton: number
		Ruby: number
		MySqlServer: number
		MySql: number
		Salesforce: number
		Photoshop: number
		Illustrator: number
		SEO: number
		Others: string
		CrudProjectLink: string
	}
}


