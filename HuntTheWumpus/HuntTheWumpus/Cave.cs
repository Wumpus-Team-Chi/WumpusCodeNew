using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HuntTheWumpus;

namespace HuntTheWumups
{
    class Cave
    {
        //instance variables
        private Room[] myCave = new Room[30];
        //constructors
        public Cave(String fileName)
        {

            //read the file
            //depending on the number in the array, put a room object in the array
            //for the room object use the file to change the room identity. 
            //pick 2 rooms at random to have bats
            //pick 1 room at random to have a bottomless pit
            //pick 1 room at random to have a wumpus


        }
        //Probably gonna delete this constructor if I cant end up figuring it out. 
        public Cave()
        {

            //assign each element in the array some room object with some other number. Ensure each number is unique
            //pick 2 rooms at random to have bats
            //pick 1 room at random to have a bottomless pit
            //pick 1 room at random to have a wumpus


        }
        //mutators
        //cave will remain static throughout. 
        //accesors
        public int[] adjacentRooms()
        {
            int[] adjacentRooms = { 1, 2, 3, 4, 5, 6 }; // PLACEHOLDER 
            //top left, top, top right, bottom left, bottom, bottom right
            //    __
            //   /  \
            //   \__/ 
            return adjacentRooms;
        }
        public int[] accessibleRooms()
        {
            int[] accessibleRooms = { 0, 0, 3, 2, 0, 1 };
            //top left, top, top right, bottom left, bottom, bottom right
            //    __
            //   /  \
            //   \__/ 
            // 0 will be closed room
            // other values will indicate what room openings are available 
            return accessibleRooms;
        }
        public int[] getBatRooms()
        {
            int room1 = -1;
            int room2 = -2;
            int[] batRoomNumbers = new int[2];
            for (int i = 0; i < myCave.Length; i++)
            {
                int r = myCave[i].getRoomNum();
                if (myCave[i].isBatPresent(r))
                {
                    if (room1 != room2 && room1 < 0)
                    {
                        room1 = myCave[i].getRoomNum();
                    }
                    else if (room2 < 0)
                    {
                        room2 = myCave[i].getRoomNum();
                    }
                }

            }
            batRoomNumbers[0] = room1;
            batRoomNumbers[1] = room2;
            return batRoomNumbers;
        }
        public int getWumpusRoom()
        {

            for (int i = 0; i < myCave.Length; i++)
            {
                int r = myCave[i].getRoomNum();
                if (myCave[i].isWumpusPresent(r))
                {
                    return r;
                }
            }
            return -1;
        }
    }
}
