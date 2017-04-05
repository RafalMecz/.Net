using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dom_ZabawaWChowanego
{
    public partial class Form1 : Form
    {
        int Moves;

        Location currentLocation;

        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;

        Opponent opponent;

        public Form1()
        {
            InitializeComponent();
            CreateObject();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }

        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm();
        }

        private void RedrawForm()
        {
            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                exits.Items.Add(currentLocation.Exits[i].Name);
            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description + "\r\n(ruch numer " + Moves + ")";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                check.Text = "Sprawdź " + hidingPlace.HidingPlaceName;
                check.Visible = true;
            }
            else
            {
                check.Visible = false;
                if (currentLocation is IHasExteriorDoor)
                    goThroughtTheDoor.Visible = true;
                else
                    goThroughtTheDoor.Visible = false;
            }
        }
        private void CreateObject()
        {
            livingRoom = new RoomWithDoor("Salon", "antyczny dywan", " w szafie ściennej", "dębowe drzwi z mosiężną klamką");
            diningRoom = new Room("Jadalnia", "kryształowy żyrandol");
            kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztućce", " w szafce", "rozuswane drzwi");
            stairs = new Room("Schody", "drewniana poręcz");
            hallway = new RoomWithHidingPlace("Korytarz na górze", "Obrazek z psem", "W szafie ściennej");
            bathroom = new RoomWithHidingPlace("Łazienka", "umywalka i toaleta", "pod prysznicem");
            masterBedroom = new RoomWithHidingPlace("Duża sypialnia", "duże łóżko", "pod łóżkiem");
            secondBedroom = new RoomWithHidingPlace("Druga sypialnia", "Małe łózko", "podłóżkiem");

            frontYard = new OutsideWithDoor("Podwórko przed domem", false, "dębowe drzwi z mosiężną klamką");
            backYard = new OutsideWithDoor("Podwórka za domem", true, "rozsuwane drzwi");
            garden = new OutsideWithHidingPlace("Ogród", false, "w szopie");
            driveway = new OutsideWithHidingPlace("Droga dojazdowa", true, "w garażu");

            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };
            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { backYard, frontYard };
            driveway.Exits = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

        }

        private void ResetGame(bool displayMessage)
        {
            if(displayMessage)
            {
                MessageBox.Show("Odnalazłeś mnie w " + Moves + " ruchach!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                description.Text = "Znalazłem przeciwnika w " + Moves + " ruchach! Ukrywał się " + foundLocation.HidingPlaceName + ".";

            }
            Moves = 0;
            hiden.Visible = true;
            goHere.Visible = false;
            check.Visible = false;
            goThroughtTheDoor.Visible = false;
            exits.Visible = false;
        }



      /*  private void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;

            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                exits.Items.Add(currentLocation.Exits[i].Name);
            exits.SelectedIndex = 0;

            description.Text = currentLocation.Description;

            if (currentLocation is IHasExteriorDoor)
                goThroughtTheDoor.Visible = true;
            else
                goThroughtTheDoor.Visible = false;
        } */

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughtTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        private void check_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Chcek(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }

        private void hiden_Click(object sender, EventArgs e)
        {
            hiden.Visible = true;

            for(int i=1; i<=10;i++)
            {
                opponent.Move();
                description.Text = i + "...";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }

            description.Text = "Gotowy czy nie - nadchodzę! ";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            goHere.Visible = true;
            exits.Visible = true;
            MoveToANewLocation(livingRoom);
        }
    }
}
