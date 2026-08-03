using FileIOAndLINQ.Models;
using FileIOAndLINQ.Services.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elijah Hodge
 * CST - 250
 * 08/02/2026
 * File I/O and LINQ
 * Activity 6
 */

namespace FileIOAndLINQ.Services.BusinessLogicLayer
{
    internal class VerseLogic
    {
        // Class level variables
        private VerseDAO _verseDAO;

        /// <summary>
        /// Default constructor for VerseLogic
        /// </summary>
        public VerseLogic()
        {
            // Initialize the data access object
            _verseDAO = new VerseDAO();
        }

        /// <summary>
        /// Add a new verse to the inventory
        /// </summary>
        /// <param name="verse"></param>
        /// <returns></returns>
        public int AddVerse(VerseRequestModel verse)
        {
            // Return the DAO method
            return _verseDAO.AddVerse(verse);
        }

        /// <summary>
        /// Get a list of verses from the inventory
        /// </summary>
        /// <returns></returns>
        public List<VerseDisplayModel> GetAllVerses()
        {
            // Declare and initialize
            // Get the verses from the DAO
            List<VerseDataModel> dataVerses = _verseDAO.GetAllVerses();
            // Create a DisplayModel list
            List<VerseDisplayModel> displayVerses = new List<VerseDisplayModel>();
            string reference = "";

            // Loop through the dataVerses list
            foreach (VerseDataModel verse in dataVerses)
            {
                // Use the book, chapter, and verse to create the reference string
                reference = $"{verse.Book} {verse.Chapter}:{verse.Verse}";
                // Create a new DisplayModel
                VerseDisplayModel displayVerse = new VerseDisplayModel(reference, verse.Text, verse.Meaning, verse.Importance);
                // Add the DisplayModel to the displayVerses list
                displayVerses.Add(displayVerse);
            }
            // Return the display verses list
            return displayVerses;
        }
    }
}
