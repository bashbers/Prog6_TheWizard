using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizard
{
    public class Tovenaar
    {
        private Kookpot _kookpot { get; set; }

        private Toverstaf _staf { get; set; }

        public Tovenaar()
        {
            this._kookpot = new Kookpot("zwart");
            this._staf = new Toverstaf();

        }

        public Tovenaar(Toverstaf pStaf )
        {
            this._kookpot = new Kookpot("zwart");
            this._staf = pStaf;

        }

        public String Toverspreuk(List<String> ing, List<String> words)
        {
            Boolean ingredientenGoed = false;
            Boolean spreukGoed = false;

            if (ing == null || ing.Count == 0)
            {
                throw new GeenIngredientenException();
            }
            else if (words.Count == 3)
            {
                //Fora mis Forameur
                if(words[0] == "Fora" && words[1] == "mis" && words[2] == "Forameur"){
                    if(ing.Count == 3 && ing.Contains("spinneweb") && ing.Contains("oorlel") && ing.Contains("slangegif"))
                    {
                        return "doe open die poort";
                    }
                    else{throw new VerkeerdeIngredientenException();}
                }
                else{throw new VerkeerdeWoordenException();}

             
            }
            else if (ing.Count == 4){
                if (words.Count == 3){

                    //Ban Da Ladik
                    if (words[0] == "Ban" && words[0] == "da" && words[0] == "ladik"){
                        if (ing.Contains("Kikkerbil") && ing.Contains("oorlel") &&ing.Contains("rattenstaart") && ing.Contains("slangegif")){
                            _staf.Omhoog();
                            _staf.Omlaag();
                            return "best friends for life";
                        }
                        else { throw new VerkeerdeIngredientenException(); }
                    }
                    else { throw new VerkeerdeWoordenException(); }

                    //Flim Flam Fluister
                    if (words[0] == "Flim" && words[0] == "Flam" && words[0] == "Fluister")
                    {
                        if (ing.Contains("Kikkerbil") && ing.Contains("oorlel") && ing.Contains("rattenstaart") && ing.Contains("krokodillenoog"))
                        {
                            _staf.Links();
                            _staf.Rechts();
                            return "Er was licht, en hij zag dat het goed was!";
                        }
                        else { throw new VerkeerdeIngredientenException(); }
                    }
                    else { throw new VerkeerdeWoordenException(); }
                }
                else if (words.Count == 4)
                {
                    //Bal Sam Sala Bond
                    if (words[0] == "Bal" && words[0] == "sam" && words[0] == "sala" && words[0] == "bond")
                    {
                        if (ing.Contains("Kikkerbil") && ing.Contains("spinneweb") && ing.Contains("mensenhaar") && ing.Contains("krokodillenoog"))
                        {
                            _staf.Links();
                            _staf.Omhoog();
                            _staf.Rechts();
                            _staf.Omlaag();
                            return "Je bent genezen met " + _staf.HoeveelheidEnergie + " energie punten!";
                        }
                        else { throw new VerkeerdeIngredientenException(); }
                    }
                    else { throw new VerkeerdeWoordenException(); }
                }
                else
                {
                    throw new GeenToverspreukException("Er is geen toverspreuk met 4 ingredienten, met deze spreuk");
                }

            }
            else if (ing.Count == 7){
                if (words.Count == 3)
                {
                    if (words[0] == "-" && words[0] == "kro" && words[0] == "dilt")
                    {
                        if (ing.Contains("Kikkerbil") && ing.Contains("spinneweb") && ing.Contains("oorlel") &&
                            ing.Contains("rattenstaart") && ing.Contains("slangegif") && ing.Contains("mensenhaar") && ing.Contains("krokodillenoog")) 
                        {
                            if (_kookpot.Kleur == "zilver")
                            {
                                return "upgrades";
                            }
                            else
                            {
                                //Als het geen zilvere ketel is ontploft het!
                                return "BOOM!";
                            }
                        }
                        else { throw new VerkeerdeIngredientenException(); }
                    }
                    else { throw new VerkeerdeWoordenException(); }
                }
                else
                {
                    throw new GeenToverspreukException("Er is geen toverspreuk met 7 ingredienten, met deze spreuk");
                }
              
            }

         
            return "Toverspreuk mislukt";
        }

        public String Spreuk()
        {
            _staf.Links();
            _staf.Rechts();
            return "Abracadabra";
        }
    }
}
