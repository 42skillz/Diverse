﻿using System.ComponentModel;

namespace Diverse.Address.Geography
{
    /// <summary>
    /// The State/Province or Area.
    /// </summary>
    public enum StateProvinceArea
    {
        // France -------------------------------------
        
        /// <summary>
        /// Ile de France (France)
        /// </summary>
        [Description("Ile de France")]
        IleDeFrance,
        
        /// <summary>
        /// Bretagne (France)
        /// </summary>
        Bretagne,

        /// <summary>
        /// Auvergne Rhône Alpes (France)
        /// </summary>
        [Description("Auvergne-Rhône-Alpes")]
        AuvergneRhoneAlpes,
        
        /// <summary>
        /// Occitanie (France)
        /// </summary>
        Occitanie,

        /// <summary>
        /// Pays de la Loire (France)
        /// </summary>
        [Description("Pays de la Loire")]
        PaysDeLaLoire,
        
        /// <summary>
        /// Nouvelle Aquitaine (France)
        /// </summary>
        [Description("Nouvelle Aquitaine")]
        NouvelleAquitaine,
        
        /// <summary>
        /// Provence-Alpes-Côte d'Azure (France)
        /// </summary>
        [Description("Provence-Alpes-Côte d'Azure")]
        ProvenceAlpesCoteDAzur,

        // China --------------------------------------
        
        /// <summary>
        /// Autonomous region (China)
        /// </summary>
        ChineseAutonomous,
        
        /// <summary>
        /// Municipal (China)
        /// </summary>
        ChineseMunicipal,
        
        /// <summary>
        /// Yunnan (China)
        /// </summary>
        Yunnan,
        
        /// <summary>
        /// Hubei (China)
        /// </summary>
        Hubei,
        
        /// <summary>
        /// Hainan (China)
        /// </summary>
        Hainan,


        // USA ----------------------------------------

        /// <summary>
        /// California
        /// </summary>
        California,

        /// <summary>
        /// Colorado
        /// </summary>
        Colorado,

        /// <summary>
        /// Illinois
        /// </summary>
        Illinois,

        /// <summary>
        /// Wisconsin
        /// </summary>
        Wisconsin,

        /// <summary>
        /// Washington state
        /// </summary>
        Washington,

        /// <summary>
        /// District of Columbia (DC)
        /// </summary>
        [Description("District of Columbia")]
        DC,

        /// <summary>
        /// Florida
        /// </summary>
        Florida,

        /// <summary>
        /// Nevada
        /// </summary>
        Nevada,

        /// <summary>
        /// Louisiana
        /// </summary>
        Louisiana,
        
        /// <summary>
        /// Texas
        /// </summary>
        Texas,

        /// <summary>
        /// Pennsylvania
        /// </summary>
        Pennsylvania,

        /// <summary>
        /// Arizona
        /// </summary>
        Arizona,

        // India --------------------------------------

        /// <summary>
        /// Maharashtra (India)
        /// </summary>
        Maharashtra,
        
        /// <summary>
        /// Delhi (India)
        /// </summary>
        Delhi,
        
        /// <summary>
        /// Karnataka (India)
        /// </summary>
        Karnataka,

        // Africa --------------------------------------

        /// <summary>
        /// Bangui la douce region (Central African Republic).
        /// </summary>
        Bangui,

        /// <summary>
        /// Dakar region (Senegal)
        /// </summary>
        Dakar,

        // US ------------------------------------------

        /// <summary>
        /// New York City (NYC)
        /// </summary>
        [Description("NY")]
        NewYork,

        // England -------------------------------------
        /// <summary>
        ///  London
        /// </summary>
        London,
    }
}