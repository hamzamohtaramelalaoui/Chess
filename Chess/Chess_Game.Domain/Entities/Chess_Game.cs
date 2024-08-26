namespace Chess_Game.Domain.Entities
{
    public class Game
    {
        public int id_Game { get; set; }
        public string victory_status { get; set; }

        public string rated { get; set; }

        public string winner { get; set; }

        public string opening_name { get; set; }

        public int TurnsG { get; set; }

        public int the_white_rating { get; set; }

        public int the_black_rating { get; set; }

    }

    public class WLthis
    {
        public string open { get; set; }

        public float WwinP { get; set; }

        public float tieP { get; set; }

        public float BwinP { get; set; }

        public int Wwin { get; set; }

        public int tie { get; set; }

        public int Bwin { get; set; }


    }



    public class turnG
    {
        public string openG { get; set; }

        public int meanturns { get; set; }
    }



    public class pers
    {
        public string p_op { get; set; }

        public int countw { get; set; }

        public float pourcentage { get; set; }
    }


    public class top_game
    {
        public string op_nom { get; set; }

        public int CWW { get; set; }

        public int CBW { get; set; }
    }


    public class smallgame
    {
        public int Black_rating { get; set; }

        public int White_rating { get; set; }

        public string winner { get; set; }
    }




    public class op
    {
        public string op_name { get; set; }

        public int op_count { get; set; }
    }




}
