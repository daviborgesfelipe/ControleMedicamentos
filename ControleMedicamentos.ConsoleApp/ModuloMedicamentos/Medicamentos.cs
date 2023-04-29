﻿using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;

namespace ControleMedicamentos.ConsoleApp.ModuloRemedio
{
    internal class Medicamentos : EntidadeBase
    {
        public string nome;
        public string descricaco;
        public string lote;
        public DateTime validade;
        public int quantidade;
        public Fornecedor fornecedor;

        public int quantidadeRequisicoesSaida;

        public Medicamentos(string nome, string descricaco, string lote, DateTime validade, Fornecedor fornecedor)
        {
            this.nome = nome;
            this.descricaco = descricaco;
            this.lote = lote;
            this.validade = validade;
            this.fornecedor = fornecedor;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Medicamentos medicamentoAtualizado = (Medicamentos)registroAtualizado;

            this.nome = medicamentoAtualizado.nome;
            this.descricaco = medicamentoAtualizado.descricaco;
            this.lote = medicamentoAtualizado.lote;
            this.validade = medicamentoAtualizado.validade;
            this.fornecedor = medicamentoAtualizado.fornecedor;
        }

        public void AdicionarQuantidade(int qtd)
        {
            this.quantidade += qtd;
        }

        public void RemoverQuantidade(int qtd)
        {
            quantidadeRequisicoesSaida++;
            this.quantidade -= qtd;
        }
    }
}
