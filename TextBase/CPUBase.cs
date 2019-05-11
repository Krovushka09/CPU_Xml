using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TextBase
{
    public class CPU
    {
        public static void RemoveItems(string name, bool x)
        {
            XmlDocument xDoc = new XmlDocument();
            if (x == true) xDoc.Load("XMLFileForCPU.xml");
            else xDoc.Load("XMLFileForArticle.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlElement xnode in xRoot)
            {
                    if (xnode.Name == name)
                    {
                    xRoot.RemoveChild(xnode);
                    if (x == true) xDoc.Save("XMLFileForCPU.xml");
                    else xDoc.Save("XMLFileForArticle.xml");
                }
            }
        }
        public static void CpuToXML(Vendor nameV, DateTime date, string nameCPU, string soket, int nCores, int nThreards, double nFrequency, string sc1, string sc2, string sc3)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("XMLFileForCPU.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            // создаем новый элемент user
            XmlElement cpuElem = xDoc.CreateElement(nameCPU);
            // создаем атрибут name
            XmlAttribute vendorCpu = xDoc.CreateAttribute("vendor");
            XmlAttribute dateRealased = xDoc.CreateAttribute("date");
            /*XmlAttribute nameCpu = xDoc.CreateAttribute("name");*/
            XmlAttribute nameSoket = xDoc.CreateAttribute("soket");
            XmlAttribute cores = xDoc.CreateAttribute("cores");
            XmlAttribute threads = xDoc.CreateAttribute("threads");
            XmlAttribute frequency = xDoc.CreateAttribute("Base_frequncy");
            XmlAttribute sc1Level = xDoc.CreateAttribute("Cash_1_level");
            XmlAttribute sc2Level = xDoc.CreateAttribute("Cash_2_level");
            XmlAttribute sc3Level = xDoc.CreateAttribute("Cash_3_level");
            // создаем текстовые значения для элементов и атрибута
            XmlText textVendor = xDoc.CreateTextNode(Convert.ToString(nameV));
            XmlText textDateRealased = xDoc.CreateTextNode(Convert.ToString(date));
            /*XmlText textNameCpu = xDoc.CreateTextNode(Convert.ToString(nameCPU));*/
            XmlText textNameSoket = xDoc.CreateTextNode(Convert.ToString(soket));
            XmlText textCores = xDoc.CreateTextNode(Convert.ToString(nCores));
            XmlText textThreads = xDoc.CreateTextNode(Convert.ToString(nThreards));
            XmlText textFrequency = xDoc.CreateTextNode(Convert.ToString(nFrequency));
            XmlText textLevel1 = xDoc.CreateTextNode(Convert.ToString(sc1));
            XmlText textLevel2 = xDoc.CreateTextNode(Convert.ToString(sc2));
            XmlText textLevel3 = xDoc.CreateTextNode(Convert.ToString(sc3));

            //добавляем узлы
            vendorCpu.AppendChild(textVendor);
            dateRealased.AppendChild(textDateRealased);
            /*nameCpu.AppendChild(textVendor);*/
            nameSoket.AppendChild(textNameSoket);
            cores.AppendChild(textCores);
            threads.AppendChild(textThreads);
            frequency.AppendChild(textFrequency);
            sc1Level.AppendChild(textLevel1);
            sc2Level.AppendChild(textLevel2);
            sc3Level.AppendChild(textLevel3);
            cpuElem.Attributes.Append(vendorCpu);
            cpuElem.Attributes.Append(dateRealased);
            cpuElem.Attributes.Append(nameSoket);
            cpuElem.Attributes.Append(cores);
            cpuElem.Attributes.Append(threads);
            cpuElem.Attributes.Append(frequency);
            cpuElem.Attributes.Append(sc1Level);
            cpuElem.Attributes.Append(sc2Level);
            cpuElem.Attributes.Append(sc3Level);
            xRoot.AppendChild(cpuElem);
            xDoc.Save("XMLFileForCPU.xml");
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        public CPU() {
            Name_of_vendor = 0;
            Release_date = DateTime.Now;
            Name_of_CPU = "";
            Soket = "";
            Numbers_of_cores = 0;
            Numbers_of_threads = 0;
            Base_frequency = 0.0;
            Size_of_cacheL1 = "";
            Size_of_cacheL2 = "";
            Size_of_cacheL3 = "";
        }
        /// <summary>
        /// характеристики процессора
        /// </summary>
            public Vendor Name_of_vendor { get; set; }
            public DateTime Release_date { get; set; }
            public string Name_of_CPU { get; set; }
            public string Soket { get; set; }
            public int Numbers_of_cores { get; set; }
            public int Numbers_of_threads { get; set; }
            public double Base_frequency { get; set; }
            public string Size_of_cacheL1 { get; set; }
            public string Size_of_cacheL2 { get; set; }
            public string Size_of_cacheL3 { get; set; }
        }

        /// <summary>
        /// Статьи
        /// </summary>
        public class Articles
        {
        public static void ArticlToXML(string head, DateTime date, Articles_Type typeArt, string text)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("XMLFileForArticle.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            // создаем новый элемент user
            XmlElement cpuElem = xDoc.CreateElement(head);
            // создаем атрибут name
            XmlAttribute datePublication = xDoc.CreateAttribute("date");
            /*XmlAttribute nameCpu = xDoc.CreateAttribute("name");*/
            XmlAttribute artType= xDoc.CreateAttribute("article_type");
            XmlAttribute textT = xDoc.CreateAttribute("text");
            // создаем текстовые значения для элементов и атрибута
            XmlText textDate = xDoc.CreateTextNode(Convert.ToString(date));
            XmlText textArtType = xDoc.CreateTextNode(Convert.ToString(typeArt));
            XmlText textText = xDoc.CreateTextNode(Convert.ToString(text));

            //добавляем узлы
            datePublication.AppendChild(textDate);
            artType.AppendChild(textArtType);
            textT.AppendChild(textText);
            cpuElem.Attributes.Append(datePublication);
            cpuElem.Attributes.Append(artType);
            cpuElem.Attributes.Append(textT);
            xRoot.AppendChild(cpuElem);
            xDoc.Save("XMLFileForArticle.xml");
        }
        /// <summary>
        /// Заголовок статьи
        /// </summary>
        public string Head_line { get; set; }

            /// <summary>
            /// Дата публикации статьи
            /// </summary>
            public DateTime Publication_date { get; set; }

            /// <summary>
            /// Тип статьи
            /// </summary>
            public Articles_Type Type_of_articles { get; set; }

            /// <summary>
            /// Прошла ли статья проверку
            /// </summary>
            public bool Articlec_check { get; set; }

            /// <summary>
            /// Текст статьи. Временная замена вместо ХМL
            /// </summary>
            public string Articlec_text { get; set; }
        }

        /// <summary>
        /// Продавец/изготавитель процессора
        /// </summary>
        public enum Vendor { AMD, Intel }

        /// <summary>
        /// Типы пользователей
        /// </summary>
        public enum UserType
        {
            /// <summary>
            /// Пользователь
            /// </summary>
            User,

            /// <summary>
            /// Админ
            /// </summary>
            Admin
        }

        /// <summary>
        /// Тип процессора
        /// </summary>
        public enum CPU_Type
        {
            /// <summary>
            /// Мобильный(ноутбук)
            /// </summary>
            Mobile,
            /// <summary>
            /// Десктопный
            /// </summary>
            Desktop,
            /// <summary>
            /// Серверный
            /// </summary>
            Server
        }

        /// <summary>
        /// Типы статей
        /// </summary>
        public enum Articles_Type
        {
            /// <summary>
            /// Новинки
            /// </summary>
            New,
            /// <summary>
            /// Старые мощные процессоры
            /// </summary>
            Old_but_powerful,
            /// <summary>
            /// Бюджетные
            /// </summary>
            Budgetary,
            /// <summary>
            /// Среднего класса
            /// </summary>
            Midddle_price,
            /// <summary>
            /// Дорогие
            /// </summary>
            Over_price,
        }
    }
