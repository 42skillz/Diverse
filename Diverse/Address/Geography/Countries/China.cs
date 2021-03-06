﻿namespace Diverse.Address.Geography.Countries
{
    /// <summary>
    /// Provides samples of what could be find in <see cref="Country.China"/>.
    /// </summary>
    public static class China
    {
        /// <summary>
        /// Gets the list of <see cref="CityWithRelatedInformation"/> one can find in <see cref="Country.China"/>.
        /// </summary>
        public static CityWithRelatedInformation[] Cities = new[]
        {
            new CityWithRelatedInformation("Wuhan", StateProvinceArea.Hubei, Country.China, Continent.Asia, zipCodeFormat:"4300##"),
            new CityWithRelatedInformation("Beijing", StateProvinceArea.ChineseMunicipal, Country.China, Continent.Asia, zipCodeFormat:"1000##"),
            new CityWithRelatedInformation("Shanghai", StateProvinceArea.ChineseMunicipal, Country.China, Continent.Asia, zipCodeFormat:"2000##"),
            new CityWithRelatedInformation("Tianjin", StateProvinceArea.ChineseMunicipal, Country.China, Continent.Asia, zipCodeFormat:"300###"),
            new CityWithRelatedInformation("Chongqing",StateProvinceArea.ChineseMunicipal, Country.China, Continent.Asia, zipCodeFormat:"4000##"),
            new CityWithRelatedInformation("Danzhou", StateProvinceArea.Hainan, Country.China, Continent.Asia, zipCodeFormat:"5717##"),
            new CityWithRelatedInformation("Kunming", StateProvinceArea.Yunnan, Country.China, Continent.Asia, zipCodeFormat: "650###"),
            new CityWithRelatedInformation("Lijiang", StateProvinceArea.Yunnan, Country.China, Continent.Asia, zipCodeFormat: "6741##"),
            new CityWithRelatedInformation("Shangri-La", StateProvinceArea.Yunnan, Country.China, Continent.Asia, zipCodeFormat:"674400"),
        };


        /// <summary>
        /// Gets samples of street names one could find in <see cref="Country.China"/>.
        /// </summary>
        public static string[] StreetNames = new[]
        {
            "Shuangshiduan, Xinhua Street, Dayan Street",
            "Zhonghe Rd,Shuhe Ancient Town",
            "Xiangjiang Road, Gucheng District",
            "Guangbi Alley Guangyi Street",
            "DongSanHuan Middle Road, Chao-Yang",
            "Jinyu Hutong Wangfujing, Dongcheng",
            "North Dongsanhua Road, Chao-Yang",
            "Yong An Dong Li, Jian Guo Men Wai Avenue, Chao-Yang",
            "Hong Hua Qiao, Wuhua District",
            "Qianxing Road, Xishan District, Xishan District",
            "Zhong Shan San Lu, Yu Zhong",
            "Changjiang Binjiang Road，Yuzhong District, Yu Zhong",
            "Chicika Street, Jiantang Town",
            "Biesailang, the ancient city of dukezong",
            "Binjiang Ave, Hanyang District",
            "Zhongshan Avenue, Qiaokou District, Hankou (CapitaMall Wusheng Road), Qiaokou District",
            "Guosheng Road",
            "E Man Town",
            "Chifeng Road, Intersection of Nanjing Road and Harbin Road, Heping District",
            "Phoenix Shopping Mall, East Haihe Road, Hebei",
            "Zhong Shan Dong Yi Road, Huangpu",
            "Middle Yan'an Road, Jing'an",
        };

        /*
                5-15 Jinyu Hutong Wangfujing, Dongcheng, 100006 Pékin, Chine

         */
    }
}