﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial10_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //the showanimalinfo method accepts an animal
        //object as an argument. it displays the objects
        //species and calls its makesound method.
        private void ShowAnimalInfo(Animal animal)
        {
            MessageBox.Show("Species: " + animal.Species);
            animal.MakeSound();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            Animal myAnimal = new Animal("Regular animal");
            ShowAnimalInfo(myAnimal);
        }

        private void createDogButton_Click(object sender, EventArgs e)
        {
            Dog myDog = new Dog("Fido");
            MessageBox.Show("The dog's name is " + myDog.Name);
            ShowAnimalInfo(myDog);
        }

        private void createCatButton_Click(object sender, EventArgs e)
        {
            Cat myCat = new Cat("Kitty");
            MessageBox.Show("The cat's name is " + myCat.Name);
            ShowAnimalInfo(myCat);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
