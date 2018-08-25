namespace GestaoTerapeutica.Migrations
{
    using GestaoTerapeutica.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GestaoTerapeutica.Models.MedsLarDb>
    {
        
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GestaoTerapeutica.Models.MedsLarDb context)
        {
            IList<Farmacia> Farmacias = new List<Farmacia>();
            Farmacias.Add(new Farmacia() { FarmId = 55601, NomeFarm = "Farmacia Velha", MoradaRua = "Rua da Cascalheira", MoradaAndar = "R/C", MoradaCodPost = "2589-414 Milhafres", ContactoTelefone = 288547866, ContactoMail = "farmaciavelha@farmacia.pt" });
            Farmacias.Add(new Farmacia() { FarmId = 74789, NomeFarm = "Farmacia Moreira", MoradaRua = "Rua Nova ", MoradaAndar = "R/C", MoradaCodPost = "2488-789 Portinhola", ContactoTelefone = 266698474, ContactoMail = "farmaciamoreira@farmacia.pt" });
            context.Farmacias.AddRange(Farmacias);

            IList<Funcionario> Funcionarios = new List<Funcionario>();
            Funcionarios.Add(new Funcionario() { FuncId = 1, NomeFunc = "Jucelinda", ContactoTelef = 985231458, ContactoMail = "jucelinda@func.pt" });
            Funcionarios.Add(new Funcionario() { FuncId = 2, NomeFunc = "Anjeolinda", ContactoTelef = 975631478, ContactoMail = "anjeolinda@func.pt" });
            Funcionarios.Add(new Funcionario() { FuncId = 3, NomeFunc = "Jocineide", ContactoTelef = 956321478, ContactoMail = "jocineide@func.pt" });
            Funcionarios.Add(new Funcionario() { FuncId = 4, NomeFunc = "Albertina", ContactoTelef = 979623257, ContactoMail = "albertina@func.pt" });
            Funcionarios.Add(new Funcionario() { FuncId = 5, NomeFunc = "Catia Vanessa", ContactoTelef = 983311486, ContactoMail = "katVanessa@func.pt" });
            context.Funcionarios.AddRange(Funcionarios);

            IList<Medico> Medicos = new List<Medico>();
            Medicos.Add(new Medico() { NumOrdem = 32589, NomeDoc = "Cordeiro e Mello", Especialidade = "Cardiologia", ContactoTelef = 985231478, ContactoMail = "cordeiroMello@xotor.pt" });
            Medicos.Add(new Medico() { NumOrdem = 52154, NomeDoc = "Ferreira Leite", Especialidade = "Pneumologia", ContactoTelef = 942136978, ContactoMail = "ferreiraLeite@xotor.pt" });
            Medicos.Add(new Medico() { NumOrdem = 95524, NomeDoc = "Mercedes Ferreira", Especialidade = "Medicina Geral e Familiar", ContactoTelef = 993247931, ContactoMail = "mercedesFerreira@xotor.pt" });
            Medicos.Add(new Medico() { NumOrdem = 53017, NomeDoc = "Alegria Pranto", Especialidade = "Neurologia", ContactoTelef = 985146314, ContactoMail = "alegriaPranto@xotor.pt" });
            Medicos.Add(new Medico() { NumOrdem = 96214, NomeDoc = "Carlota Joaquina", Especialidade = "Psiquiatria", ContactoTelef = 904515492, ContactoMail = "carlotaJoaquina@xotor.pt" });
            context.Medicos.AddRange(Medicos);

            IList<Patologia> Patologias = new List<Patologia>();
            Patologias.Add(new Patologia() { PatId = 1, Nome = "DPOC", Especialidade = "Pneumologia" });
            Patologias.Add(new Patologia() { PatId = 2, Nome = "Hipercolestrolemia", Especialidade = "Medicina Interna" });
            Patologias.Add(new Patologia() { PatId = 3, Nome = "Hipertensão", Especialidade = "Cardiologia" });
            Patologias.Add(new Patologia() { PatId = 4, Nome = "Psoriase ", Especialidade = "Dermatologia" });
            Patologias.Add(new Patologia() { PatId = 5, Nome = "Cataratas", Especialidade = "Oftalmologia" });
            Patologias.Add(new Patologia() { PatId = 6, Nome = "Glaucoma", Especialidade = "Oftalmologia" });
            Patologias.Add(new Patologia() { PatId = 7, Nome = "Asma", Especialidade = "Pneumologia" });
            Patologias.Add(new Patologia() { PatId = 8, Nome = "Diabetes I", Especialidade = "Endocrinologia" });
            Patologias.Add(new Patologia() { PatId = 9, Nome = "Diabetes II", Especialidade = "Endocrinologia" });
            Patologias.Add(new Patologia() { PatId = 10, Nome = "Esquizofrenia", Especialidade = "Psiquiatria" });
            Patologias.Add(new Patologia() { PatId = 11, Nome = "Perturbação Afectiva Bipolar", Especialidade = "Psiquiatria" });
            Patologias.Add(new Patologia() { PatId = 12, Nome = "Demencia", Especialidade = "Neurologia" });
            Patologias.Add(new Patologia() { PatId = 13, Nome = "Neoplasia", Especialidade = "Oncologia" });
            Patologias.Add(new Patologia() { PatId = 14, Nome = "Candidiase Vaginal", Especialidade = "Ginecologia" });
            context.Patologias.AddRange(Patologias);

            IList<ReservaFarmaco> Reservas = new List<ReservaFarmaco>();
            Reservas.Add(new ReservaFarmaco() { ReservaId = 1, CNP = 999900, SubstAct = "Varfarina", FormaFarm = "Comprimido", Dose = "5", LinkRCM = "http://http://app7.infarmed.pt/infomed/xxx&tipo_doc=rcm", PosologiaDia = 1, PosologiaSemana = 0, PosologiaMes = 0, CompExistentes = 60, UtenteId = 1, FarmaciaId = 2 });
            Reservas.Add(new ReservaFarmaco() { ReservaId = 2, CNP = 999901, SubstAct = "Amlodipina + Valsartan", FormaFarm = "Comprimido Revestido", Dose = "5+160", LinkRCM = "http://http://app7.infarmed.pt/infomed/xxx&tipo_doc=rcm", PosologiaDia = 1, PosologiaSemana = 0, PosologiaMes = 0, CompExistentes = 30, UtenteId = 1, FarmaciaId = 2 });
            Reservas.Add(new ReservaFarmaco() { ReservaId = 3, CNP = 999902, SubstAct = "Gingko Biloba", FormaFarm = "Comprimido", Dose = "40", LinkRCM = "http://http://app7.infarmed.pt/infomed/xxx&tipo_doc=rcm", PosologiaDia = 2, PosologiaSemana = 0, PosologiaMes = 0, CompExistentes = 3, UtenteId = 1, FarmaciaId = 2 });
            Reservas.Add(new ReservaFarmaco() { ReservaId = 4, CNP = 999903, SubstAct = "Eutirox", FormaFarm = "Comprimido", Dose = "0,05", LinkRCM = "http://http://app7.infarmed.pt/infomed/xxx&tipo_doc=rcm", PosologiaDia = 1, PosologiaSemana = 0, PosologiaMes = 0, CompExistentes = 50, UtenteId = 1, FarmaciaId = 2 });
            Reservas.Add(new ReservaFarmaco() { ReservaId = 5, CNP = 999904, SubstAct = "Sinvastatina", FormaFarm = "Comprimido Revestido", Dose = "20", LinkRCM = "http://http://app7.infarmed.pt/infomed/xxx&tipo_doc=rcm", PosologiaDia = 1, PosologiaSemana = 0, PosologiaMes = 0, CompExistentes = 40, UtenteId = 1, FarmaciaId = 2 });
            Reservas.Add(new ReservaFarmaco() { ReservaId = 6, CNP = 999905, SubstAct = "Bomazepam", FormaFarm = "Comprimido", Dose = "1,5", LinkRCM = "http://http://app7.infarmed.pt/infomed/xxx&tipo_doc=rcm", PosologiaDia = 1, PosologiaSemana = 0, PosologiaMes = 0, CompExistentes = 10, UtenteId = 1, FarmaciaId = 2 });
            Reservas.Add(new ReservaFarmaco() { ReservaId = 7, CNP = 999906, SubstAct = "Lorazepam", FormaFarm = "Comprimido", Dose = "2,5", LinkRCM = "http://http://app7.infarmed.pt/infomed/xxx&tipo_doc=rcm", PosologiaDia = 1, PosologiaSemana = 0, PosologiaMes = 0, CompExistentes = 5, UtenteId = 2, FarmaciaId = 2 });
            Reservas.Add(new ReservaFarmaco() { ReservaId = 8, CNP = 999907, SubstAct = "Tramadol+Paracetamol", FormaFarm = "Comprimido", Dose = "37,5+325", LinkRCM = "http://http://app7.infarmed.pt/infomed/xxx&tipo_doc=rcm", PosologiaDia = 3, PosologiaSemana = 0, PosologiaMes = 0, CompExistentes = 9, UtenteId = 2, FarmaciaId = 2 });
            Reservas.Add(new ReservaFarmaco() { ReservaId = 9, CNP = 999908, SubstAct = "Acido Alendronico", FormaFarm = "Comprimido", Dose = "70", LinkRCM = "http://http://app7.infarmed.pt/infomed/xxx&tipo_doc=rcm", PosologiaDia = 0, PosologiaSemana = 1, PosologiaMes = 0, CompExistentes = 2, UtenteId = 2, FarmaciaId = 2 });
            Reservas.Add(new ReservaFarmaco() { ReservaId = 10, CNP = 999909, SubstAct = "Desloratadina", FormaFarm = "Comprimido Orodispersível", Dose = "5", LinkRCM = "http://http://app7.infarmed.pt/infomed/xxx&tipo_doc=rcm", PosologiaDia = 1, PosologiaSemana = 0, PosologiaMes = 0, CompExistentes = 0, UtenteId = 2, FarmaciaId = 1 });
            Reservas.Add(new ReservaFarmaco() { ReservaId = 11, CNP = 999910, SubstAct = "Colecalciferol", FormaFarm = "Comprimido Revestido", Dose = "22400", LinkRCM = "http://http://app7.infarmed.pt/infomed/xxx&tipo_doc=rcm", PosologiaDia = 0, PosologiaSemana = 0, PosologiaMes = 1, CompExistentes = 1, UtenteId = 2, FarmaciaId = 1 });
            context.Reservas.AddRange(Reservas);

            IList<Utente> Utentes = new List<Utente>();
            Utentes.Add(new Utente() { UtenteId = 1, Nome = "Antonieta", DataNascimento = new DateTime(1948, 2, 1) });
            Utentes.Add(new Utente() { UtenteId = 2, Nome = "Jose", DataNascimento = new DateTime(1950, 3, 2) });
            context.Utentes.AddRange(Utentes);

            IList<Administracao> Administracoes = new List<Administracao>();
            Administracoes.Add(new Administracao() { AdminId = 1, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 1, ReservaFk = 1 });
            Administracoes.Add(new Administracao() { AdminId = 2, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 2, ReservaFk = 5 });
            Administracoes.Add(new Administracao() { AdminId = 3, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 3, ReservaFk = 6 });
            Administracoes.Add(new Administracao() { AdminId = 4, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 4, ReservaFk = 3 });
            Administracoes.Add(new Administracao() { AdminId = 5, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 5, ReservaFk = 1 });
            Administracoes.Add(new Administracao() { AdminId = 6, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 1, ReservaFk = 8 });
            Administracoes.Add(new Administracao() { AdminId = 7, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 2, ReservaFk = 10 });
            Administracoes.Add(new Administracao() { AdminId = 8, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 3, ReservaFk = 11 });
            Administracoes.Add(new Administracao() { AdminId = 9, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 4, ReservaFk = 8 });
            Administracoes.Add(new Administracao() { AdminId = 10, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 5, ReservaFk = 5 });
            Administracoes.Add(new Administracao() { AdminId = 11, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 1, ReservaFk = 2 });
            Administracoes.Add(new Administracao() { AdminId = 12, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 2, ReservaFk = 3 });
            Administracoes.Add(new Administracao() { AdminId = 13, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 3, ReservaFk = 4 });
            Administracoes.Add(new Administracao() { AdminId = 14, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 4, ReservaFk = 7 });
            Administracoes.Add(new Administracao() { AdminId = 15, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 5, ReservaFk = 8 });
            Administracoes.Add(new Administracao() { AdminId = 16, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 1, ReservaFk = 9 });
            Administracoes.Add(new Administracao() { AdminId = 17, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 2, ReservaFk = 11 });
            Administracoes.Add(new Administracao() { AdminId = 18, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 3, ReservaFk = 1 });
            Administracoes.Add(new Administracao() { AdminId = 19, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 4, ReservaFk = 4 });
            Administracoes.Add(new Administracao() { AdminId = 20, DataAdmin = new DateTime(2017, 1, 1), FuncFk = 5, ReservaFk = 6 });
            context.Administracoes.AddRange(Administracoes);
            base.Seed(context);

        }
    }
}
