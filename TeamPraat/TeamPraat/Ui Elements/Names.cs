﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPraat.Ui_Elements
{
    class Names
    {
        public List<String> names = new List<string>();
        Random r = new Random();
        public Names(){
            names.Add("Delorse");
            names.Add("Kattie");
            names.Add("Leah");
            names.Add("Bronwyn");
            names.Add("Omer");
            names.Add("Gisela");
            names.Add("Forest");
            names.Add("Cheryll");
            names.Add("Tu");
            names.Add("Gaylene");
            names.Add("Julee");
            names.Add("Heather");
            names.Add("Lorena");
            names.Add("Eveline");
            names.Add("Edward");
            names.Add("Jonas");
            names.Add("Xiomara");
            names.Add("Flossie");
            names.Add("Harvey");
            names.Add("Wilber");
            names.Add("Heidi");
            names.Add("Josh");
            names.Add("Mara");
            names.Add("Ona");
            names.Add("Wonda");
            names.Add("Breanne");
            names.Add("Deirdre");
            names.Add("Precious");
            names.Add("Pearl");
            names.Add("Cristie");
            names.Add("Vonda");
            names.Add("Debora");
            names.Add("Lasandra");
            names.Add("Randell");
            names.Add("Floyd");
            names.Add("Thi");
            names.Add("Valentin");
            names.Add("Reva");
            names.Add("Patsy");
            names.Add("Ashly");
            names.Add("Nakita");
            names.Add("Benton");
            names.Add("Jay");
            names.Add("Caterina");
            names.Add("Karin");
            names.Add("Clarisa");
            names.Add("Beata");
            names.Add("Chantelle");
            names.Add("Simonne");
            names.Add("Aubrey");
            names.Add("Sherman");
            names.Add("Arron");
            names.Add("Mitsuko");
            names.Add("Josiah");
            names.Add("Karma");
            names.Add("Adella");
            names.Add("Marcia");
            names.Add("Larae");
            names.Add("Leena");
            names.Add("Lydia");
            names.Add("Lisandra");
            names.Add("Dannielle");
            names.Add("Alleen");
            names.Add("Janiece");
            names.Add("Anh");
            names.Add("Valrie");
            names.Add("Flor");
            names.Add("Franklyn");
            names.Add("Eugenie");
            names.Add("Janetta");
            names.Add("Hilde");
            names.Add("Faith");
            names.Add("Wanetta");
            names.Add("Marisela");
            names.Add("Glynis");
            names.Add("Delia");
            names.Add("Lesa");
            names.Add("Joel");
            names.Add("Zita");
            names.Add("Chong");
            names.Add("Nicola");
            names.Add("Millie");
            names.Add("Corey");
            names.Add("Billi");
            names.Add("Cathern");
            names.Add("Laurine");
            names.Add("Lorinda");
            names.Add("Olin");
            names.Add("Celine");
            names.Add("Dalton");
            names.Add("Wendi");
            names.Add("Verline");
            names.Add("Maribel");
            names.Add("Carmella");
            names.Add("Venita");
            names.Add("Audry");
            names.Add("Ludivina");
            names.Add("Jodie");
            names.Add("Gregoria");
            names.Add("Catherina");
        }

        public String RandomName(){
            
            int i = r.Next(names.Count);
            String name = names[i];
            return name;
        }
    }
}
