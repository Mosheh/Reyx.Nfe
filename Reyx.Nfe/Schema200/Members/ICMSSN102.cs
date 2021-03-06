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
	public class ICMSSN102
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
        /// Código de Situação da Operação – Simples Nacional
        /// <para>
        ///     102- Tributada pelo Simples Nacional sem permissão 
        ///     de crédito.
        /// </para>
        /// <para>
        ///     103 – Isenção do ICMS no Simples Nacional para faixa 
        ///     de receita bruta.
        /// </para>
        /// <para>300 – Imune.</para>
        /// <para>
        ///     400 – Não tributada pelo Simples Nacional (v.2.0)
        /// </para>
        /// </summary>
        [XmlElement]
        public string CSOSN { get; set; }
    }
}
