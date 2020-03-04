using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HuntTheWumpus
{
    class Trivia
    {
        private Trivia _Trivia;

        public int BottomlessPit()
        {
            Random gen = new Random(); // I still do not know the C++ version of this
            int wins = 0;
            int losses = 0;
            int roomNumber = 0;
            for(int i = 0; i < 3; i++){
                int question = AskQuestion();
                if(question == 1){
                    wins++;
                }else{
                    losses++;
                }
            }
            if(wins < losses){
                roomNumber = -1;
            }else if(wins > losses){
                //int roomNumber = gen.nextInt();
            }
            return roomNumber;
        }

        public int WumpusRoom(){
            // Random gen = new Random(); // I still do not know the C++ version of this
            int wins = 0;
            int losses = 0;
            int roomNumber = 0;
            for (int i = 0; i < 5; i++){
                int question = AskQuestion();
                if(question == 1){
                    wins++;
                }else{
                    losses++;
                }
            }
            if(wins > losses){
                roomNumber = -1;
            }else if(wins < losses){
                //roomNumber = gen.nextInt();
            }
            return roomNumber;
        }
        
        public int AskQuestion(){
            int answer = 0;
            return answer;
        }
    }
}
