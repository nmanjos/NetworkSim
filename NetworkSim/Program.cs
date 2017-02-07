using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkSim
{
    class Program
    {
        public static string Dec2bin(int dec)
            // returns an array of integers 
        {

                
            if (dec == 0)
            {
                return "";
            }
            else
            {
                int s = dec % 2;
                return s + Dec2bin(dec / 2);
            }
            
        }
        public static int Bin2dec(int[] bin)
        {
            int dec = 0;
            int j = 0;
            for (int i = 7; i < 0; i--)
            {
                dec = dec + bin[i] * (2 ^ j);
                j++;
            }



            //    para i de 7 ate 0 passo - 1
            //        decfinal<- decfinal + binfinal[i] * 2 ^ j
            //        j<- j + 1
            //    escrever "."    
            //    proximo

            return dec;


        }
        public static int[] encoder(int[] bin, int binstart, int binend)
            // where bin startt is always smaler than bin end
        {

            
            int clock = 1;
            int clockcount = 0;
            int[] bincoded = new int[8];
            for (int i = binstart; i < binend; i++)
            {
                clockcount = i * 2 - 1;
                if (i > 0)
                {
                    bincoded[clockcount] = clock;
                    if (clock == 1)
                    {
                        clock = 0;
                    }
                    else
                    {
                        clock = 1;
                    }
                }
                bincoded[clockcount + 1] = bin[i];
            }


            //    para i de 0 ate 3 passo 1
            //        j<- i* 2
            //        clockcount<- j - 1
            //        h<- i + 4
            //        se i> 0 entao
            //            bina[clockcount] <- clock
            //            escrever "\n a Enviar bit " , clockcount
            //            se clock = 1 entao
            //                clock<- 0
            //            senao
            //                clock<- 1
            //            fimse
            //        fimse
            //        bina[j] <- bin[i]
            //        escrever "\n a Enviar bit " , j


            return bincoded;
        }
        public static int decoder(int[] bin, int pos)
        {
            int bindecoded = 0;
            
            if (pos % 2 == 0)
            {
                bindecoded
            }



            for (int i = binstart; i < binend; i++)
            {
                bindecoded[i] = bin[i * 2];
            }
            return bindecoded;
            //    para i de 0 ate 3 passo 1
            //        j<- i* 2
            //        h<- i + 4
            //        binfinal[i] <- bina[j]
            //        binfinal[h] <- binb[j]
            //        escrever "."
            //    proximo

        }
        public static void Netsend()
        {
            
            Console.WriteLine("A enviar 16 bits Codificados");
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(100);

            }
            
        }
        public static void Netrecieve()
        {
            Console.WriteLine("A receber 16 bits Codificados");
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(100);

            }
        }
        public static string asciidecode(int dec)
        {
            string letrafinal;
            switch (dec)
            {
                case 65:
                    letrafinal = "A";
                    break;
                case 66:
                    letrafinal ="B";
                    break;
                case 67:
                    letrafinal ="C";
                    break;
                case 68:
                    letrafinal ="D";
                    break;
                case 69:
                    letrafinal ="E";
                    break;
                case 70:
                    letrafinal ="F";
                    break;
                case 71:
                    letrafinal ="G";
                    break;
                case 72:
                    letrafinal ="H";
                    break;
                case 73:
                    letrafinal ="I";
                    break;
                case 74:
                    letrafinal ="J";
                    break;
                case 75:
                    letrafinal ="K";
                    break;
                case 76:
                    letrafinal ="L";
                    break;
                case 77:
                    letrafinal ="M";
                    break;
                case 78:
                    letrafinal ="N";
                    break;
                case 79:
                    letrafinal ="O";
                    break;
                case 80:
                    letrafinal ="P";
                    break;
                case 81:
                    letrafinal ="Q";
                    break;
                case 82:
                    letrafinal ="R";
                    break;
                case 83:
                    letrafinal ="S";
                    break;
                case 84:
                    letrafinal ="T";
                    break;
                case 85:
                    letrafinal ="U";
                    break;
                case 86:
                    letrafinal ="V";
                    break;
                case 87:
                    letrafinal ="W";
                    break;
                case 88:
                    letrafinal ="X";
                    break;
                case 89:
                    letrafinal ="Y";
                    break;
                case 90:
                    letrafinal ="Z";
                    break;
                default:
                    letrafinal = " ";
                    break;
            }
            return letrafinal;
        }
        static void Main(string[] args)
        {
            int dec = 0; int decfinal = 0;
            int[] bin = new int[8]; int[] bina = new int[8]; int[] binb= new int[8]; int[] binfinal = new int[8]; int[] binaa = new int[8]; int[] binbb = new int[8];


            Console.WriteLine("introduza um numero decimal de 65 ate 90 para simular o envio de um caracter ASCII pela rede !");
            dec = int.Parse(Console.ReadLine());
            bin = Dec2bin(dec);
            Console.WriteLine("\nO binário de {0] é {1}", dec, bin);
            Console.WriteLine("A Iniciar encodificação dos bits");
            bina = encoder(bin, 0, 3);
            Console.WriteLine("8 de 16 codificados");
            binb = encoder(bin, 4, 7);
            Console.WriteLine("16 de 16 codificados");
            Netsend();
            Netrecieve();
            binaa = decoder(bina, 0, 7);
            foreach (int i in binfinal)
            {
                
                binfinal[i] = bina
            }
            


        }
    }
}

//variavel inteiro dec , h , i , clock , clockcount , decfinal , j , deci
//    variavel inteiro bin[8], bina[8], binb[8], binfinal[8]
//    variavel texto letrafinal

//    escrever "introduza um numero decimal de 65 ate 90 para simular o envio de um caracter ASCII pela rede !"
//    ler dec
//    escrever "\nO binário de " , dec , " é "
//    para i de 7 ate 0 passo - 1
        
//        deci<- dec % 2
//        bin[i] <- deci
//        dec<- dec / 2
//    proximo


//    escrever bin[0], bin[1], bin[2], bin[3], bin[4], bin[5], bin[6], bin[7], "\n\n"
//    clock<- 1
//    para i de 0 ate 3 passo 1
//        j<- i* 2
//        clockcount<- j - 1
//        h<- i + 4
//        se i> 0 entao
//            bina[clockcount] <- clock
//            escrever "\n a Enviar bit " , clockcount
//            se clock = 1 entao
//                clock<- 0
//            senao
//                clock<- 1
//            fimse
//        fimse
//        bina[j] <- bin[i]
//        escrever "\n a Enviar bit " , j


//    proximo
//    bina[7] <- 0
//    escrever "\n a Enviar bit 7 "
//    clock<- 1
//    para i de 0 ate 3 passo 1
//        j<- i* 2
//        clockcount<- j - 1
//        h<- i + 4
//        se i> 0 entao
//            binb[clockcount] <- clock
//            escrever "\n a Enviar bit " , clockcount + 8
//            se clock = 1 entao
//                clock<- 0
//            senao
//                clock<- 1
//            fimse
//        fimse
//        binb[j] <- bin[h]
//        escrever "\n a Enviar bit " , j + 8


//    proximo
//    binb[7] <- 0
//    escrever "\n a Enviar bit 15"
//    escrever "\n enviados 16 bits em dois octetos :"
//    para i de 0 ate 7 passo 1
//        escrever bina[i]
//    proximo
//    escrever "-"
//    para i de 0 ate 7 passo 1
//        escrever binb[i]
//    proximo
//    // variaveis bina e binb simulam o envio dos dados encapsulados para a rede

//    // inicio da recepção dos dados

//    escrever "\n A descodificar "
//    para i de 0 ate 3 passo 1
//        j<- i* 2
//        h<- i + 4
//        binfinal[i] <- bina[j]
//        binfinal[h] <- binb[j]
//        escrever "."
//    proximo



//    decfinal<- 0
//    j<- 0


//    para i de 7 ate 0 passo - 1
//        decfinal<- decfinal + binfinal[i] * 2 ^ j
//        j<- j + 1
//    escrever "."    
//    proximo


//    escolhe decfinal
//        caso 65:
//            letrafinal<- "A "
//        caso 66:
//            letrafinal<- "B"
//        caso 67:
//            letrafinal<- "C"
//        caso 68:
//            letrafinal<- "D"
//        caso 69:
//            letrafinal<- "E"
//        caso 70:
//            letrafinal<- "F"
//        caso 71:
//            letrafinal<- "G"
//        caso 72:
//            letrafinal<- "H"
//        caso 73:
//            letrafinal<- "I"
//        caso 74:
//            letrafinal<- "J"
//        caso 75:
//            letrafinal<- "K"
//        caso 76:
//            letrafinal<- "L"
//        caso 77:
//            letrafinal<- "M"
//        caso 78:
//            letrafinal<- "N"
//        caso 79:
//            letrafinal<- "O"
//        caso 80:
//            letrafinal<- "P"
//        caso 81:
//            letrafinal<- "Q"
//        caso 82:
//            letrafinal<- "R"
//        caso 83:
//            letrafinal<- "S"
//        caso 84:
//            letrafinal<- "T"
//        caso 85:
//            letrafinal<- "U"
//        caso 86:
//            letrafinal<- "V"
//        caso 87:
//            letrafinal<- "W"
//        caso 88:
//            letrafinal<- "X"
//        caso 89:
//            letrafinal<- "Y"
//        caso 90:
//            letrafinal<- "Z"
//        fim
//fimescolhe
//escrever "\n Valores Finais(binario-decimal-caracter):" , binfinal[0], binfinal[1], binfinal[2], binfinal[3], binfinal[4], binfinal[5], binfinal[6], binfinal[7], "-" , decfinal, "-" , letrafinal

