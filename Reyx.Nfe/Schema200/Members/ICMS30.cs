﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Reyx.Nfe.Schema200.Members
{
    /// <summary>
	/// 
	/// </summary>
	public class ICMS30
    {
        /// <summary>
        /// Origem da mercadoria
        /// <para>0 - Nacional</para>
        /// <para>1 - Estrangeira - Importação direta</para>
        /// <para>2 - Estrangeira - Adquirida no meracado interno</para>
        /// </summary>
        [XmlElement]
        public string orig { get; set; }

        /// <summary>
        /// Tributação do ICMS:
        /// <para>
        ///     30 - Isenta ou não tributada e com cobrança do 
        ///     ICMS por substituição tributária
        /// </para>
        /// </summary>
        [XmlElement]
        public string CST { get; set; }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS
        /// <para>0 - Margem Valor Agregado (%)</para>
        /// <para>1 - Pauta (Valor)</para>
        /// <para>2 - Preço Tabelado Máx. (valor)</para>
        /// <para>3 - valor da operação</para>
        /// </summary>
        [XmlElement]
        public string modBCST { get; set; }

        /// <summary>
        /// Percentual da margem de valor Adicionado do ICMS ST
        /// </summary>
        [XmlElement]
        public string pMVAST { get; set; }

        /// <summary>
        /// Percentual da Redução de BC do ICMS ST
        /// </summary>
        [XmlElement]
        public string pRedBCST { get; set; }

        /// <summary>
        /// Valor da BC do ICMS ST
        /// </summary>
        [XmlElement]
        public string vBCST { get; set; }

        /// <summary>
        /// Alíquota do imposto do ICMS ST
        /// </summary>
        [XmlElement]
        public string pICMSST { get; set; }

        /// <summary>
        /// Valor do ICMS ST retido
        /// </summary>
        [XmlElement]
        public string vICMSST { get; set; }
    }
}
