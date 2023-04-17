using Progetto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Progetto.Services
{
    public class CalcolaCodiceFiscale
    {
        //public string CodiceFiscale { get; private set; }
        private ConsonantiVocali Elabora(string testo)
        {
            testo = testo.Replace(" ", string.Empty).ToLower();
            string consonanti = "";
            string vocali = "";

            for (int i = 0; i < testo.Length; i++)
            {
                if (testo[i] >= 'a' && testo[i] <= 'z')
                {
                    if (testo[i] == 'a' || testo[i] == 'e' || testo[i] == 'i' || testo[i] == 'o' || testo[i] == 'u')
                    {
                        vocali += testo[i];
                    }
                    else
                    {
                        consonanti += testo[i];
                    }
                }
            }

            return new ConsonantiVocali { Consonanti = consonanti, Vocali = vocali };
        }

        private static bool isEven(int x)
        {
            if ((x + 1) % 2 == 0)
            {
                return true;
            }

            return false;
        }

        private string CalcolaCognome(string cognome)
        {
            cognome = cognome.ToLower();
            ConsonantiVocali cv = Elabora(cognome);
            string consonantiCognome = cv.Consonanti;
            string vocaliCognome = cv.Vocali;

            var result = (consonantiCognome + vocaliCognome + "X").Substring(0, 3);

            return result.ToLower();
        }

        private string CalcolaNome(string nome)
        {
            nome = nome.ToLower();
            ConsonantiVocali cv = Elabora(nome);
            string consonantiNome = cv.Consonanti;
            string vocaliNome = cv.Vocali;

            var result = (consonantiNome + vocaliNome + "X").Substring(0, 3);

            return result.ToLower();
        }

        private string CalcolaAnno(DateTime anno)
        {
            var result = anno.Year.ToString();

            return result.ToLower();
        }

        private string CalcolaMese(DateTime mese)
        {
            var controllo = mese.Month.ToString();
            string result;

            switch (controllo)
            {
                case "1":
                    result = "A";
                    break;
                case "2":
                    result = "B";
                    break;
                case "3":
                    result = "C";
                    break;
                case "4":
                    result = "D";
                    break;
                case "5":
                    result = "E";
                    break;
                case "6":
                    result = "H";
                    break;
                case "7":
                    result = "L";
                    break;
                case "8":
                    result = "M";
                    break;
                case "9":
                    result = "P";
                    break;
                case "10":
                    result = "R";
                    break;
                case "11":
                    result = "S";
                    break;
                case "12":
                    result = "T";
                    break;
                default:
                    return "Inserire un mese valido";
            }

            return result.ToLower();
        }

        private string CalcolaGiorno(DateTime giorno, char gender)
        {
            var sesso = gender;
            var day = giorno.Day;

            switch (sesso)
            {
                case 'm':
                    sesso = 'm';
                    break;
                case 'f':
                    sesso = 'f';
                    break;
                default:
                    return "Sesso non valido!";
            }

            if (sesso == 'f')
            {
                day += 40;
            }

            return day.ToString();
        }

        private string CalcolaComune(string comune)
        {
            comune = comune.ToLower();
            var codice = comune;

            return codice.ToLower();
        }

        public string CalcolaCF(string nome, string cognome, DateTime data, string comune, char sesso)
        {
            string carattereControllo;
            int contoPari = 0;
            int contoDispari = 0;
            var calcolo = CalcolaCognome(cognome) +
                CalcolaNome(nome) + 
                CalcolaAnno(data) + 
                CalcolaMese(data) + 
                CalcolaGiorno(data, sesso) + 
                CalcolaComune(comune);          

            for (int i = 0; i < calcolo.Length; i++)
            {
                //conto indici pari
                if (isEven(i))
                {
                    switch (calcolo[i])
                    {
                        case '0':
                        case 'a':
                            contoPari += 0;
                            break;
                        case '1':
                        case 'b':
                            contoPari += 1;
                            break;
                        case '2':
                        case 'c':
                            contoPari += 2;
                            break;
                        case '3':
                        case 'd':
                            contoPari += 3;
                            break;
                        case '4':
                        case 'e':
                            contoPari += 4;
                            break;
                        case '5':
                        case 'f':
                            contoPari += 5;
                            break;
                        case '6':
                        case 'g':
                            contoPari += 6;
                            break;
                        case '7':
                        case 'h':
                            contoPari += 7;
                            break;
                        case '8':
                        case 'i':
                            contoPari += 8;
                            break;
                        case '9':
                        case 'j':
                            contoPari += 9;
                            break;
                        case 'k':
                            contoPari += 10;
                            break;
                        case 'l':
                            contoPari += 11;
                            break;
                        case 'm':
                            contoPari += 12;
                            break;
                        case 'n':
                            contoPari += 13;
                            break;
                        case 'o':
                            contoPari += 14;
                            break;
                        case 'p':
                            contoPari += 15;
                            break;
                        case 'q':
                            contoPari += 16;
                            break;
                        case 'r':
                            contoPari += 17;
                            break;
                        case 's':
                            contoPari += 18;
                            break;
                        case 't':
                            contoPari += 19;
                            break;
                        case 'u':
                            contoPari += 20;
                            break;
                        case 'v':
                            contoPari += 21;
                            break;
                        case 'w':
                            contoPari += 22;
                            break;
                        case 'x':
                            contoPari += 23;
                            break;
                        case 'y':
                            contoPari += 24;
                            break;
                        case 'z':
                            contoPari += 25;
                            break;
                        default:
                            contoPari += 0;
                            break;
                    }
                }
                //conto indici dispari
                else
                {
                    switch (calcolo[i])
                    {
                        case '0':
                        case 'a':
                            contoDispari += 1;
                            break;
                        case '1':
                        case 'b':
                            contoDispari += 0;
                            break;
                        case '2':
                        case 'c':
                            contoDispari += 5;
                            break;
                        case '3':
                        case 'd':
                            contoDispari += 7;
                            break;
                        case '4':
                        case 'e':
                            contoDispari += 9;
                            break;
                        case '5':
                        case 'f':
                            contoDispari += 13;
                            break;
                        case '6':
                        case 'g':
                            contoDispari += 15;
                            break;
                        case '7':
                        case 'h':
                            contoDispari += 17;
                            break;
                        case '8':
                        case 'i':
                            contoDispari += 19;
                            break;
                        case '9':
                        case 'j':
                            contoDispari += 21;
                            break;
                        case 'k':
                            contoDispari += 2;
                            break;
                        case 'l':
                            contoDispari += 4;
                            break;
                        case 'm':
                            contoDispari += 18;
                            break;
                        case 'n':
                            contoDispari += 20;
                            break;
                        case 'o':
                            contoDispari += 11;
                            break;
                        case 'p':
                            contoDispari += 3;
                            break;
                        case 'q':
                            contoDispari += 6;
                            break;
                        case 'r':
                            contoDispari += 8;
                            break;
                        case 's':
                            contoDispari += 12;
                            break;
                        case 't':
                            contoDispari += 14;
                            break;
                        case 'u':
                            contoDispari += 16;
                            break;
                        case 'v':
                            contoDispari += 10;
                            break;
                        case 'w':
                            contoDispari += 22;
                            break;
                        case 'x':
                            contoDispari += 25;
                            break;
                        case 'y':
                            contoDispari += 24;
                            break;
                        case 'z':
                            contoDispari += 23;
                            break;
                        default:
                            contoDispari += 0;
                            break;
                    }
                }
            }

            int contoTotale = contoPari + contoDispari;

            int codiceLettera = contoTotale % 26;

            switch (codiceLettera)
            {
                case 0:
                    carattereControllo = "A";
                    break;
                case 1:
                    carattereControllo = "B";
                    break;
                case 2:
                    carattereControllo = "C";
                    break;
                case 3:
                    carattereControllo = "D";
                    break;
                case 4:
                    carattereControllo = "E";
                    break;
                case 5:
                    carattereControllo = "F";
                    break;
                case 6:
                    carattereControllo = "G";
                    break;
                case 7:
                    carattereControllo = "H";
                    break;
                case 8:
                    carattereControllo = "I";
                    break;
                case 9:
                    carattereControllo = "J";
                    break;
                case 10:
                    carattereControllo = "K";
                    break;
                case 11:
                    carattereControllo = "L";
                    break;
                case 12:
                    carattereControllo = "M";
                    break;
                case 13:
                    carattereControllo = "N";
                    break;
                case 14:
                    carattereControllo = "O";
                    break;
                case 15:
                    carattereControllo = "P";
                    break;
                case 16:
                    carattereControllo = "Q";
                    break;
                case 17:
                    carattereControllo = "R";
                    break;
                case 18:
                    carattereControllo = "S";
                    break;
                case 19:
                    carattereControllo = "T";
                    break;
                case 20:
                    carattereControllo = "U";
                    break;
                case 21:
                    carattereControllo = "V";
                    break;
                case 22:
                    carattereControllo = "W";
                    break;
                case 23:
                    carattereControllo = "X";
                    break;
                case 24:
                    carattereControllo = "Y";
                    break;
                case 25:
                    carattereControllo = "Z";
                    break;
                default:
                    throw new Exception("Qualcosa e' andato storto!");
            }

            return (calcolo + carattereControllo).ToUpper();
        }
    }
}