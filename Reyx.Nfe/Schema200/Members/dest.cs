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
	public class dest
    {
        /// <summary>
        /// CNPJ do destinatário
        /// </summary>
        [XmlElement]
        public string CNPJ { get; set; }

        /// <summary>
        /// CPF do destinatário CE
        /// </summary>
        [XmlElement]
        public string CPF { get; set; }

        /// <summary>
        /// Razão Social ou nome do destinatário
        /// </summary>
        [XmlElement]
        public string xNome { get; set; }

        /// <summary>
        /// Grupo de endereço do Destinatário da NF-e
        /// </summary>
        [XmlElement]
        public endereco enderDest { get; set; }

        /// <summary>
        /// Inscrição Estadual
        /// <para>
        ///     Informar a IE quando o destinatário for 
        ///     contribuinte do ICMS.
        /// </para>
        /// <para>
        ///     Informar ISENTO quando o destinatário for 
        ///     contribuinte do ICMS, mas não estiver obrigado
        ///     à inscrição no cadastro de contribuintes do ICMS.
        /// </para>
        /// <para>
        ///     Não informar o conteúdo da TAG se o destinatário 
        ///     não for contribuinte do ICMS.
        /// </para>
        /// <para>
        ///     Esta tag aceita apenas:
        /// </para>
        /// <para>
        ///     . ausência de conteúdo (<IE></IE> ou <IE/>) para
        ///     destinatários não contribuintes do ICMS
        /// </para>
        /// <para>
        ///     . algarismos para destinatários
        ///     contribuintes do ICMS, sem caracteres de formatação
        ///     (ponto, barra, hífen, etc.)
        /// </para>
        /// <para>
        ///     . literal “ISENTO” para destinatários contribuintes 
        ///     do ICMS que são isentos de inscrição no cadastro de
        ///     contribuintes do ICMS
        /// </para>
        /// </summary>
        [XmlElement]
        public string IE { get; set; }

        /// <summary>
        /// Inscrição na SUFRAMA
        /// <para>
        ///     Obrigatório, nas operações que se beneficiam de 
        ///     incentivos fiscais existentes nas áreas sob
        ///     controle da SUFRAMA. A omissão da Inscrição
        ///     SUFRAMA impede o processamento da operação
        ///     pelo Sistema de Mercadoria Nacional da SUFRAMA e 
        ///     a liberação da Declaração de Ingresso, prejudicando a
        ///     comprovação do ingresso/internamento da mercadoria nas 
        ///     áreas sob controle da SUFRAMA. (v2.0)
        /// </para>
        /// </summary>
        [XmlElement]
        public string ISUF { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [XmlElement]
        public string email { get; set; }
    }
}
