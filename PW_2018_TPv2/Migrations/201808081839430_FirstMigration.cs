namespace PW_2018_TPv2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AvaliaCarro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Consumo = c.Int(nullable: false),
                        Espaco = c.Int(nullable: false),
                        Avarias = c.Boolean(nullable: false),
                        Limpeza = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Carros",
                c => new
                    {
                        CarroId = c.Int(nullable: false, identity: true),
                        AvalcarroId = c.Int(nullable: false),
                        CondAlugarId = c.Int(nullable: false),
                        Modelo = c.String(nullable: false),
                        Marca = c.String(nullable: false),
                        Matricula = c.String(nullable: false),
                        Combustivél = c.Int(nullable: false),
                        Ano = c.Int(nullable: false),
                        PreçoDia = c.Int(name: "Preço/Dia", nullable: false),
                        PreçoMes = c.Int(name: "Preço/Mes", nullable: false),
                        Particular_ParticularId = c.Int(),
                        Particular_ParticularId1 = c.Int(),
                        Profissional_ProfissionalId = c.Int(),
                    })
                .PrimaryKey(t => t.CarroId)
                .ForeignKey("dbo.AvaliaCarro", t => t.AvalcarroId, cascadeDelete: true)
                .ForeignKey("dbo.CondicoesdeAluguer", t => t.CondAlugarId, cascadeDelete: true)
                .ForeignKey("dbo.Particulares", t => t.Particular_ParticularId)
                .ForeignKey("dbo.Particulares", t => t.Particular_ParticularId1)
                .ForeignKey("dbo.Profissionais", t => t.Profissional_ProfissionalId)
                .Index(t => t.AvalcarroId)
                .Index(t => t.CondAlugarId)
                .Index(t => t.Particular_ParticularId)
                .Index(t => t.Particular_ParticularId1)
                .Index(t => t.Profissional_ProfissionalId);
            
            CreateTable(
                "dbo.CondicoesdeAluguer",
                c => new
                    {
                        CondAlugaId = c.Int(nullable: false, identity: true),
                        ZonaId = c.Int(nullable: false),
                        DataInicial = c.DateTime(nullable: false),
                        DataFinal = c.DateTime(nullable: false),
                        Seguro = c.String(nullable: false),
                        PrePagamento = c.Boolean(nullable: false),
                        IdadeMinima = c.Int(nullable: false),
                        TempodeCartaMeses = c.Int(name: "TempodeCarta (Meses)", nullable: false),
                        ClassificacaoMinimaRequerida = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CondAlugaId)
                .ForeignKey("dbo.Zonas", t => t.ZonaId, cascadeDelete: true)
                .Index(t => t.ZonaId);
            
            CreateTable(
                "dbo.Zonas",
                c => new
                    {
                        ZonasId = c.Int(nullable: false, identity: true),
                        ZonadeAluger = c.String(nullable: false),
                        Particular_ParticularId = c.Int(),
                        Profissional_ProfissionalId = c.Int(),
                    })
                .PrimaryKey(t => t.ZonasId)
                .ForeignKey("dbo.Particulares", t => t.Particular_ParticularId)
                .ForeignKey("dbo.Profissionais", t => t.Profissional_ProfissionalId)
                .Index(t => t.Particular_ParticularId)
                .Index(t => t.Profissional_ProfissionalId);
            
            CreateTable(
                "dbo.Servicos",
                c => new
                    {
                        ServicosId = c.Int(nullable: false, identity: true),
                        CarroId = c.Int(nullable: false),
                        ProfissionalId = c.Int(),
                        DataInicial = c.DateTime(nullable: false),
                        DataFinal = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ServicosId)
                .ForeignKey("dbo.Carros", t => t.CarroId, cascadeDelete: true)
                .ForeignKey("dbo.Profissionais", t => t.ProfissionalId)
                .Index(t => t.CarroId)
                .Index(t => t.ProfissionalId);
            
            CreateTable(
                "dbo.Particulares",
                c => new
                    {
                        ParticularId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Identificacao = c.Int(nullable: false),
                        Morada = c.String(nullable: false),
                        DatadeNascimento = c.DateTime(nullable: false),
                        CartadeConducao = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Telefone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ParticularId);
            
            CreateTable(
                "dbo.ClassificaCliente",
                c => new
                    {
                        ClassifClienteId = c.Int(nullable: false, identity: true),
                        CritclienteId = c.Int(nullable: false),
                        Particular_ParticularId = c.Int(),
                    })
                .PrimaryKey(t => t.ClassifClienteId)
                .ForeignKey("dbo.CriteriosCliente", t => t.CritclienteId, cascadeDelete: true)
                .ForeignKey("dbo.Particulares", t => t.Particular_ParticularId)
                .Index(t => t.CritclienteId)
                .Index(t => t.Particular_ParticularId);
            
            CreateTable(
                "dbo.CriteriosCliente",
                c => new
                    {
                        CritclienteId = c.Int(nullable: false, identity: true),
                        Simpatia = c.Int(nullable: false),
                        EstadoVeiculo = c.Int(nullable: false),
                        DataEntrega = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CritclienteId);
            
            CreateTable(
                "dbo.ClassificaFornecedor",
                c => new
                    {
                        ClassificaFornecedorId = c.Int(nullable: false, identity: true),
                        CritFornecedorId = c.Int(nullable: false),
                        Particular_ParticularId = c.Int(),
                        Profissional_ProfissionalId = c.Int(),
                    })
                .PrimaryKey(t => t.ClassificaFornecedorId)
                .ForeignKey("dbo.CriteriosFornecedor", t => t.CritFornecedorId, cascadeDelete: true)
                .ForeignKey("dbo.Particulares", t => t.Particular_ParticularId)
                .ForeignKey("dbo.Profissionais", t => t.Profissional_ProfissionalId)
                .Index(t => t.CritFornecedorId)
                .Index(t => t.Particular_ParticularId)
                .Index(t => t.Profissional_ProfissionalId);
            
            CreateTable(
                "dbo.CriteriosFornecedor",
                c => new
                    {
                        CritFornecedorId = c.Int(nullable: false, identity: true),
                        Simpatia = c.Int(nullable: false),
                        EstadodoVeículo = c.Int(name: "Estado do Veículo", nullable: false),
                        DatadeEntrega = c.Boolean(name: "Data de Entrega", nullable: false),
                        Responsividade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CritFornecedorId);
            
            CreateTable(
                "dbo.Mensagens",
                c => new
                    {
                        MensagemId = c.Int(nullable: false, identity: true),
                        Mensagem = c.String(nullable: false),
                        Vista = c.Boolean(nullable: false),
                        Particular_ParticularId = c.Int(),
                        Profissional_ProfissionalId = c.Int(),
                    })
                .PrimaryKey(t => t.MensagemId)
                .ForeignKey("dbo.Particulares", t => t.Particular_ParticularId)
                .ForeignKey("dbo.Profissionais", t => t.Profissional_ProfissionalId)
                .Index(t => t.Particular_ParticularId)
                .Index(t => t.Profissional_ProfissionalId);
            
            CreateTable(
                "dbo.Profissionais",
                c => new
                    {
                        ProfissionalId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        DenominacaoSocial = c.String(nullable: false),
                        Morada = c.String(nullable: false),
                        DatadeFundacao = c.DateTime(nullable: false),
                        Email = c.String(nullable: false),
                        Telefone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProfissionalId);
            
            CreateTable(
                "dbo.Fotos",
                c => new
                    {
                        FotosdoCarroId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.FotosdoCarroId);
            
            CreateTable(
                "dbo.ParticularServicos",
                c => new
                    {
                        Particular_ParticularId = c.Int(nullable: false),
                        Servicos_ServicosId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Particular_ParticularId, t.Servicos_ServicosId })
                .ForeignKey("dbo.Particulares", t => t.Particular_ParticularId, cascadeDelete: true)
                .ForeignKey("dbo.Servicos", t => t.Servicos_ServicosId, cascadeDelete: true)
                .Index(t => t.Particular_ParticularId)
                .Index(t => t.Servicos_ServicosId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Servicos", "ProfissionalId", "dbo.Profissionais");
            DropForeignKey("dbo.Zonas", "Profissional_ProfissionalId", "dbo.Profissionais");
            DropForeignKey("dbo.Mensagens", "Profissional_ProfissionalId", "dbo.Profissionais");
            DropForeignKey("dbo.ClassificaFornecedor", "Profissional_ProfissionalId", "dbo.Profissionais");
            DropForeignKey("dbo.Carros", "Profissional_ProfissionalId", "dbo.Profissionais");
            DropForeignKey("dbo.Zonas", "Particular_ParticularId", "dbo.Particulares");
            DropForeignKey("dbo.ParticularServicos", "Servicos_ServicosId", "dbo.Servicos");
            DropForeignKey("dbo.ParticularServicos", "Particular_ParticularId", "dbo.Particulares");
            DropForeignKey("dbo.Mensagens", "Particular_ParticularId", "dbo.Particulares");
            DropForeignKey("dbo.ClassificaFornecedor", "Particular_ParticularId", "dbo.Particulares");
            DropForeignKey("dbo.ClassificaFornecedor", "CritFornecedorId", "dbo.CriteriosFornecedor");
            DropForeignKey("dbo.ClassificaCliente", "Particular_ParticularId", "dbo.Particulares");
            DropForeignKey("dbo.ClassificaCliente", "CritclienteId", "dbo.CriteriosCliente");
            DropForeignKey("dbo.Carros", "Particular_ParticularId1", "dbo.Particulares");
            DropForeignKey("dbo.Carros", "Particular_ParticularId", "dbo.Particulares");
            DropForeignKey("dbo.Servicos", "CarroId", "dbo.Carros");
            DropForeignKey("dbo.Carros", "CondAlugarId", "dbo.CondicoesdeAluguer");
            DropForeignKey("dbo.CondicoesdeAluguer", "ZonaId", "dbo.Zonas");
            DropForeignKey("dbo.Carros", "AvalcarroId", "dbo.AvaliaCarro");
            DropIndex("dbo.ParticularServicos", new[] { "Servicos_ServicosId" });
            DropIndex("dbo.ParticularServicos", new[] { "Particular_ParticularId" });
            DropIndex("dbo.Mensagens", new[] { "Profissional_ProfissionalId" });
            DropIndex("dbo.Mensagens", new[] { "Particular_ParticularId" });
            DropIndex("dbo.ClassificaFornecedor", new[] { "Profissional_ProfissionalId" });
            DropIndex("dbo.ClassificaFornecedor", new[] { "Particular_ParticularId" });
            DropIndex("dbo.ClassificaFornecedor", new[] { "CritFornecedorId" });
            DropIndex("dbo.ClassificaCliente", new[] { "Particular_ParticularId" });
            DropIndex("dbo.ClassificaCliente", new[] { "CritclienteId" });
            DropIndex("dbo.Servicos", new[] { "ProfissionalId" });
            DropIndex("dbo.Servicos", new[] { "CarroId" });
            DropIndex("dbo.Zonas", new[] { "Profissional_ProfissionalId" });
            DropIndex("dbo.Zonas", new[] { "Particular_ParticularId" });
            DropIndex("dbo.CondicoesdeAluguer", new[] { "ZonaId" });
            DropIndex("dbo.Carros", new[] { "Profissional_ProfissionalId" });
            DropIndex("dbo.Carros", new[] { "Particular_ParticularId1" });
            DropIndex("dbo.Carros", new[] { "Particular_ParticularId" });
            DropIndex("dbo.Carros", new[] { "CondAlugarId" });
            DropIndex("dbo.Carros", new[] { "AvalcarroId" });
            DropTable("dbo.ParticularServicos");
            DropTable("dbo.Fotos");
            DropTable("dbo.Profissionais");
            DropTable("dbo.Mensagens");
            DropTable("dbo.CriteriosFornecedor");
            DropTable("dbo.ClassificaFornecedor");
            DropTable("dbo.CriteriosCliente");
            DropTable("dbo.ClassificaCliente");
            DropTable("dbo.Particulares");
            DropTable("dbo.Servicos");
            DropTable("dbo.Zonas");
            DropTable("dbo.CondicoesdeAluguer");
            DropTable("dbo.Carros");
            DropTable("dbo.AvaliaCarro");
        }
    }
}
