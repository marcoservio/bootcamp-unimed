using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using ProjetoCsvHelper.Model;

namespace ProjetoCsvHelper.Mapping
{
    public class LivroMap : ClassMap<LivroMapping>
    {
        public LivroMap()
        {
            Map(x => x.Titulo).Name("titulo");
            Map(x => x.Preco)
                .Name("preco")
                .TypeConverterOption
                .CultureInfo(CultureInfo.GetCultureInfo("pt-BR"));
            Map(x => x.Autor).Name("autor");
            Map(x => x.Lancamento)
                .Name("lancamento")
                .TypeConverterOption
                .Format(new[] { "dd/MM/yyyy" });
        }
    }
}