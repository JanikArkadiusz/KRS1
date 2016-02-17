using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Models
{
    public class Breed:IRepository
    {
        public string BreedId { get; set; }
        public string Name { get; set; }

        protected Dictionary<string, string> CattleBreedList = new Dictionary<string, string>();
        public string Info { get; set; }
        public string Comments { get; set; }

        public void Create() { throw new NotImplementedException(); }
        public void Remove() { throw new NotImplementedException(); }
        public void Update() { throw new NotImplementedException(); }
        public void Delete() { throw new NotImplementedException(); }


        
        private void CattleBreedListSeed()
        {
            CattleBreedList.Add("AB", "abondance");
            CattleBreedList.Add("AL", "tyrol grey");
            CattleBreedList.Add("AN", "angus czarny");
            CattleBreedList.Add("AR", "angus czerwony");
            CattleBreedList.Add("AU", "aubrac");
            CattleBreedList.Add("AY", "ayrshire");
            CattleBreedList.Add("BB", "belgian blue");
            CattleBreedList.Add("BD", "blond d’aquitaine");
            CattleBreedList.Add("BF", "bawół (Bubalus bubalis)");
            CattleBreedList.Add("BG", "bydło białogrzbiete");
            CattleBreedList.Add("BI", "bizon (Bison bison)");
            CattleBreedList.Add("BM", "beefmaster");
            CattleBreedList.Add("BO", "braford ");
            CattleBreedList.Add("BR", "brahman");
            CattleBreedList.Add("BS", "brown swiss");
            CattleBreedList.Add("CA", "chianina");
            CattleBreedList.Add("CH", "charolaise");
            CattleBreedList.Add("DR", "dexter");
            CattleBreedList.Add("GA", "galloway");
            CattleBreedList.Add("GR", "groninger blaarkop");
            CattleBreedList.Add("GU", "guernsey");
            CattleBreedList.Add("GV", "gelbvieh");
            CattleBreedList.Add("HH", "hereford");
            CattleBreedList.Add("HI", "highland cattle");
            CattleBreedList.Add("HO", "polska holsztyńskofryzyjska odmiana czarno – biała*");
            CattleBreedList.Add("IN", "inne***");
            CattleBreedList.Add("JE", "jersey");
            CattleBreedList.Add("LM", "limousine");
            CattleBreedList.Add("LO", "longhorn");
            CattleBreedList.Add("LU", "luing");
            CattleBreedList.Add("LV", "lakenvelder");
            CattleBreedList.Add("MA", "maine - anjou");
            CattleBreedList.Add("MG", "murray - grey");
            CattleBreedList.Add("MM", "krzyżówki z rasami mięsnymi");
            CattleBreedList.Add("MO", "montbeliarde");
            CattleBreedList.Add("MR", "marchigiana");
            CattleBreedList.Add("MS", "krzyżówka bez ras mięsnych");
            CattleBreedList.Add("NO", "normandy");
            CattleBreedList.Add("NR", "norweskie bydło czerwone");
            CattleBreedList.Add("PI", "piemontese (piemont)");
            CattleBreedList.Add("PT", "parthenaise");
            CattleBreedList.Add("PZ", "pinzgau");
            CattleBreedList.Add("RE", "europejskie bydło czerwone (pozostałe odmiany rasy)");
            CattleBreedList.Add("RG", "rubia gallega");
            CattleBreedList.Add("RN", "romagnola");
            CattleBreedList.Add("RP", "polska czerwona");
            CattleBreedList.Add("RW", "polska holsztyńskofryzyjska odmiana czerwono – biała**");
            CattleBreedList.Add("SD", "south devon");
            CattleBreedList.Add("SG", "santa gertrudis");
            CattleBreedList.Add("SL", "salers SH shorthorn BN brangus");
            CattleBreedList.Add("SM", "simental");
            CattleBreedList.Add("SR", "szwedzkie bydło czerwono-białe");
            CattleBreedList.Add("SW", "sahiwa");
            CattleBreedList.Add("TA", "tarentaise");
            CattleBreedList.Add("UK", "uckermärker");
            CattleBreedList.Add("WA", "wagyu");
            CattleBreedList.Add("WB", "welsh black");
            CattleBreedList.Add("WS", "węgierskie bydło stepowe");
            CattleBreedList.Add("ZR", "polska czerwono - biała");
        }
    }

    
       
}