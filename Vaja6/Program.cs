using System.IO;

namespace vaja6 {

  
    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

  public int x = 666;

	// Razred za igralce 
    class Igralec {
        public int id; // id od igralca 
        public string u_ime; // ime igralca
        public string u_geslo; // geslo
        public static int stIg = 1; 

        public Igralec() { // privzetni konstrukor ki dodeli id novim igralcom
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }

        public int Id { // samo za branje ki. Lastnost ki vrne ID igralca
            get
            {
                return id;
            }
        }

        public string U_ime {
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }

        public string U_geslo // lastnost, ki vrne ali nastavi geslo 
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }

        public static int StIg // vrne skupno st igralcev
        {
            get { return stIg; }
        }
    }
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}
