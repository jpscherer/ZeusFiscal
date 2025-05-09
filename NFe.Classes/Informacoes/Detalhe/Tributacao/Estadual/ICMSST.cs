using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos;
using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual
{
    public class ICMSST : ICMSBasico
    {
        private decimal _vBcstRet;
        private decimal _vIcmsstRet;
        private decimal _vBcstDest;
        private decimal _vIcmsstDest;
        private decimal? _vIcmsSubstituto;
        private decimal? _pST;
        private decimal? _vBcfcpstRet;
        private decimal? _pFcpstRet;
        private decimal? _vFcpstRet;
        private decimal? _pRedBCEfet;
        private decimal? _vBCEfet;
        private decimal? _pICMSEfet;
        private decimal? _vICMSEfet;

        /// <summary>
        ///     N11 - Origem da Mercadoria
        /// </summary>
        [XmlElement(Order = 1)]
        public OrigemMercadoria orig { get; set; }

        /// <summary>
        ///     N12- Situação Tributária
        /// </summary>
        [XmlElement(Order = 2)]
        public Csticms CST { get; set; }

        /// <summary>
        ///     N26 - Valor da BC do ICMS ST retido
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal vBCSTRet
        {
            get { return _vBcstRet; }
            set { _vBcstRet = value.Arredondar(2); }
        }

        [XmlElement(Order = 4)]
        public decimal? pST
        {
            get { return _pST.Arredondar(4); }
            set { _pST = value.Arredondar(4); }
        }

        public bool ShouldSerializepST()
        {
            return pST.HasValue;
        }

        [XmlElement(Order = 5)]
        public decimal? vICMSSubstituto
        {
            get { return _vIcmsSubstituto.Arredondar(2); }
            set { _vIcmsSubstituto = value.Arredondar(2); }
        }

        public bool ShouldSerializevICMSSubstituto()
        {
            return _vIcmsSubstituto.HasValue;
        }

        /// <summary>
        ///     N27 - Valor do ICMS ST retido
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal vICMSSTRet
        {
            get { return _vIcmsstRet; }
            set { _vIcmsstRet = value.Arredondar(2); }
        }

        [XmlElement(Order = 7)]
        public decimal? vBCFCPSTRet
        {
            get { return _vBcfcpstRet.Arredondar(2); }
            set { _vBcfcpstRet = value.Arredondar(2); }
        }

        public bool vBCFCPSTRetSpecified
        {
            get { { return vBCFCPSTRet.HasValue; } }
        }

        /// <summary>
        /// N27b - Percentual do FCP retido anteriormente por Substituição Tributária
        /// Versão 4.00
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal? pFCPSTRet
        {
            get { return _pFcpstRet.Arredondar(4); }
            set { _pFcpstRet = value.Arredondar(4); }
        }

        public bool pFCPSTRetSpecified
        {
            get { return pFCPSTRet.HasValue; }
        }


        /// <summary>
        /// N27d - Valor do FCP retido por Substituição Tributária
        /// Versão 4.00
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal? vFCPSTRet
        {
            get { return _vFcpstRet.Arredondar(2); }
            set { _vFcpstRet = value.Arredondar(2); }
        }

        public bool vFCPSTRetSpecified
        {
            get { return vFCPSTRet.HasValue; }
        }

        /// <summary>
        ///     N31 - Valor da BC do ICMS ST da UF destino
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal vBCSTDest
        {
            get { return _vBcstDest; }
            set { _vBcstDest = value.Arredondar(2); }
        }

        /// <summary>
        ///     N32 - Valor do ICMS ST da UF destino
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal vICMSSTDest
        {
            get { return _vIcmsstDest; }
            set { _vIcmsstDest = value.Arredondar(2); }
        }

        [XmlElement(Order = 12)]
        public decimal? pRedBCEfet
        {
            get { return _pRedBCEfet.Arredondar(4); }
            set { _pRedBCEfet = value.Arredondar(4); }
        }

        public bool ShouldSerializepRedBCEfet()
        {
            return pRedBCEfet.HasValue;
        }

        /// <summary>
        ///     N35 - Valor da base de cálculo efetiva 
        /// </summary>
        [XmlElement(Order = 13)]
        public decimal? vBCEfet
        {
            get { return _vBCEfet.Arredondar(2); }
            set { _vBCEfet = value.Arredondar(2); }
        }

        public bool ShouldSerializevBCEfet()
        {
            return vBCEfet.HasValue;
        }

        /// <summary>
        ///     N36 - Alíquota do ICMS efetiva 
        /// </summary>
        [XmlElement(Order = 14)]
        public decimal? pICMSEfet
        {
            get { return _pICMSEfet.Arredondar(4); }
            set { _pICMSEfet = value.Arredondar(4); }
        }

        public bool ShouldSerializepICMSEfet()
        {
            return pICMSEfet.HasValue;
        }

        /// <summary>
        ///     N37 - Valor do ICMS efetivo 
        /// </summary>
        [XmlElement(Order = 15)]
        public decimal? vICMSEfet
        {
            get { return _vICMSEfet.Arredondar(2); }
            set { _vICMSEfet = value.Arredondar(2); }
        }

        public bool ShouldSerializevICMSEfet()
        {
            return vICMSEfet.HasValue;
        }
    }
}