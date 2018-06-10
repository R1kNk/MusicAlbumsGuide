using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAlbumsGuide.SharedFormsMethods
{
    static class FilterAndSearchConfig
    {
        static string filterGenre = "";
        static string filterReleaseYear = "";
        static bool filterReleaseYearAsc = false;
        static bool filterReleaseYearDesc = false;
       
        static string filterCarrier = "";
        static string filterType = "";
        static string filterAuthor = "";
        static string filterTrackCount = "";
        static bool filterTrackCountAsc = false;
        static bool filterTrackCountDesc = false;
        static string filterReleasingLabel = "";

         static string unsavedFilterGenre = "";
        static string unsavedFilterReleaseYear = "";
        static bool unsavedFilterReleaseYearAsc = false;
        static bool unsavedFilterReleaseYearDesc = false;
        static string unsavedFilterCarrier = "";
        static string unsavedFilterType = "";
        static string unsavedFilterAuthor = "";
        static string unsavedFilterTrackCount = "";
        static bool unsavedFilterTrackCountAsc = false;
        static bool unsavedFilterTrackCountDesc = false;
        static string unsavedFilterReleasingLabel = "";

        public static string FilterGenre { get => filterGenre; private set => filterGenre = value; }
        public static string FilterReleaseYear { get => filterReleaseYear; private set => filterReleaseYear = value; }
       
        public static string FilterCarrier { get => filterCarrier; private set => filterCarrier = value; }
        public static string FilterType { get => filterType; private set => filterType = value; }
        public static string FilterAuthor { get => filterAuthor; private set => filterAuthor = value; }
        public static string FilterTrackCount { get => filterTrackCount; private set => filterTrackCount = value; }
        public static bool FilterTrackCountAsc { get => filterTrackCountAsc; private set => filterTrackCountAsc = value; }
        public static bool FilterTrackCountDesc { get => filterTrackCountDesc;  set => filterTrackCountDesc = value; }
        public static string FilterReleasingLabel { get => filterReleasingLabel; private set => filterReleasingLabel = value; }
        public static bool FilterReleaseYearAsc { get => filterReleaseYearAsc; private set => filterReleaseYearAsc = value; }
        public static bool FilterReleaseYearDesc { get => filterReleaseYearDesc; private set => filterReleaseYearDesc = value; }

        public static string UnsavedFilterGenre { get => unsavedFilterGenre;  set => unsavedFilterGenre = value; }
        public static string UnsavedFilterReleaseYear { get => unsavedFilterReleaseYear;  set => unsavedFilterReleaseYear = value; }
      
        public static string UnsavedFilterCarrier { get => unsavedFilterCarrier;  set => unsavedFilterCarrier = value; }
        public static string UnsavedFilterType { get => unsavedFilterType;  set =>unsavedFilterType = value; }
        public static string UnsavedFilterAuthor { get => unsavedFilterAuthor;  set => unsavedFilterAuthor = value; }
        public static string UnsavedFilterTrackCount { get => unsavedFilterTrackCount;  set => unsavedFilterTrackCount = value; }
        public static bool UnsavedFilterTrackCountAsc { get =>unsavedFilterTrackCountAsc;  set => unsavedFilterTrackCountAsc = value; }
        public static bool UnsavedFilterTrackCountDesc { get => unsavedFilterTrackCountDesc;  set => unsavedFilterTrackCountDesc = value; }
        public static string UnsavedFilterReleasingLabel { get => unsavedFilterReleasingLabel;  set => unsavedFilterReleasingLabel = value; }
        public static bool UnsavedFilterReleaseYearAsc { get => unsavedFilterReleaseYearAsc; set => unsavedFilterReleaseYearAsc = value; }
        public static bool UnsavedFilterReleaseYearDesc { get => unsavedFilterReleaseYearDesc; set => unsavedFilterReleaseYearDesc = value; }
        //
        public static void SaveFilter()
        {
             FilterGenre = UnsavedFilterGenre;
             FilterReleaseYear = UnsavedFilterReleaseYear;
             FilterCarrier = UnsavedFilterCarrier;
             FilterType = UnsavedFilterType;
             FilterAuthor = UnsavedFilterAuthor;
             FilterReleaseYearDesc = UnsavedFilterReleaseYearDesc;
             FilterReleasingLabel = UnsavedFilterReleasingLabel;
           

        }
        //
        public static void SaveSort()
        {
            FilterReleaseYearAsc = UnsavedFilterReleaseYearAsc;
            FilterReleaseYearDesc = UnsavedFilterReleaseYearDesc;
            FilterTrackCountAsc = UnsavedFilterTrackCountAsc;
            FilterTrackCountDesc = UnsavedFilterTrackCountDesc;
         
        }
        public static void SetFilterTrackCountSortFalse()
        {
            UnsavedFilterTrackCountAsc = false;
            UnsavedFilterTrackCountDesc = false;
        }
        //
        public static void SetFilterReleaseYearSortFalse()
        {
            UnsavedFilterReleaseYearAsc = false;
            UnsavedFilterReleaseYearDesc = false;
        }
        //Clear Methods
        static void clearUnsavedGenre()
        {
            UnsavedFilterGenre = "";
        }
        //
        static void clearUnsavedReleaseYear()
        {
            UnsavedFilterReleaseYear = "";
        }
        //
        static void clearUnsavedCarrier()
        {
            UnsavedFilterCarrier = "";
        }
        //
        static void clearUnsavedType()
        {
            UnsavedFilterType = "";
        }
        //
        static void clearUnsavedAuthor()
        {
            UnsavedFilterAuthor = "";
        }
        //
        static void clearUnsavedTrackCount()
        {
            UnsavedFilterTrackCount = "";
        }
        //
        static void clearUnsavedReleasingLabel()
        {
            UnsavedFilterReleasingLabel = "";
        }
        //
        public static void ClearUnsavedAll()
        {
            clearUnsavedGenre();
            clearUnsavedReleaseYear();
            clearUnsavedCarrier();
            clearUnsavedType();
            clearUnsavedAuthor();
            clearUnsavedTrackCount();
            clearUnsavedReleasingLabel();
        }

        //
        static void clearGenre()
        {
            FilterGenre = "";
        }
        //
        static void clearReleaseYear()
        {
            FilterReleaseYear = "";
        }
        //
        static void clearCarrier()
        {
            FilterCarrier = "";
        }
        //
        static void clearType()
        {
            FilterType = "";
        }
        //
        static void clearAuthor()
        {
            FilterAuthor = "";
        }
        //
        static void clearTrackCount()
        {
            FilterTrackCount = "";
        }
        //
        static void clearReleasingLabel()
        {
            FilterReleasingLabel = "";
        }
        //
        public static void ClearAll()
        {
            clearGenre();
            clearReleaseYear();
            clearCarrier();
            clearType();
            clearAuthor();
            clearTrackCount();
            clearReleasingLabel();
        }
        //
        //Add methods
        public static void AddUnsavedFilterGenre(string newGenre)
        {
            if (UnsavedFilterGenre.Contains(newGenre)) return;
            UnsavedFilterGenre += newGenre.Semicolon();
        }
        public static void AddFilterUnsavedReleaseYear(string newYear)
        {
            if (UnsavedFilterReleaseYear.Contains(newYear))  return;
            UnsavedFilterReleaseYear += newYear.Semicolon();
        }
       

        public static void AddFilterUnsavedCarrier(string newUnsavedCarrier)
        {
            if (UnsavedFilterCarrier.Contains(newUnsavedCarrier)) return;
            UnsavedFilterCarrier += newUnsavedCarrier.Semicolon();
        }

        public static void AddFilterUnsavedType(string newUnsavedType)
        {
            if (UnsavedFilterType.Contains(newUnsavedType)) return;
            UnsavedFilterType += newUnsavedType.Semicolon();
        }

        public static void AddFilterUnsavedAuthor(string newUnsavedAuthor)
        {
            if (UnsavedFilterAuthor.Contains(newUnsavedAuthor)) return;
            UnsavedFilterAuthor += newUnsavedAuthor.Semicolon();
        }

        public static void AddFilterUnsavedTrackCount(string newUnsavedTrackCount)
        {
            if (UnsavedFilterTrackCount.Contains(newUnsavedTrackCount)) return;
            UnsavedFilterTrackCount += newUnsavedTrackCount.Semicolon();
        }
       

       
        public static void AddFilterUnsavedReleasingLabel(string newLabel)
        {
            if (UnsavedFilterReleasingLabel.Contains(newLabel)) return;
            UnsavedFilterReleasingLabel += newLabel.Semicolon();
        }

        //Delete methods
        public static void DeleteUnsavedFilterGenre(string newGenre)
        {
            if (!UnsavedFilterGenre.Contains(newGenre.Semicolon())) return;
            int index =  UnsavedFilterGenre.IndexOf(newGenre.Semicolon());
            UnsavedFilterGenre = UnsavedFilterGenre.Remove(index, newGenre.Semicolon().Length);
        }
        public static void DeleteFilterUnsavedReleaseYear(string newYear)
        {
            if (!UnsavedFilterReleaseYear.Contains(newYear.Semicolon())) return;
            int index = UnsavedFilterReleaseYear.IndexOf(newYear.Semicolon());
            UnsavedFilterReleaseYear = UnsavedFilterReleaseYear.Remove(index, newYear.Semicolon().Length);
        }


        public static void DeleteFilterUnsavedCarrier(string newUnsavedCarrier)
        {
            if (!UnsavedFilterCarrier.Contains(newUnsavedCarrier.Semicolon())) return;
            int index = UnsavedFilterCarrier.IndexOf(newUnsavedCarrier.Semicolon());
            UnsavedFilterCarrier = UnsavedFilterCarrier.Remove(index, newUnsavedCarrier.Semicolon().Length);
        }

        public static void DeleteFilterUnsavedType(string newUnsavedType)
        {
            if (!UnsavedFilterType.Contains(newUnsavedType.Semicolon())) return;
            int index = UnsavedFilterType.IndexOf(newUnsavedType.Semicolon());
            UnsavedFilterType = UnsavedFilterType.Remove(index, newUnsavedType.Semicolon().Length);
        }

        public static void DeleteFilterUnsavedAuthor(string newUnsavedAuthor)
        {
            if (!UnsavedFilterAuthor.Contains(newUnsavedAuthor.Semicolon())) return;
            int index = UnsavedFilterAuthor.IndexOf(newUnsavedAuthor.Semicolon());
            UnsavedFilterAuthor = UnsavedFilterAuthor.Remove(index, newUnsavedAuthor.Semicolon().Length);
        }

        public static void DeleteFilterUnsavedTrackCount(string newUnsavedTrackCount)
        {
            if (!UnsavedFilterTrackCount.Contains(newUnsavedTrackCount.Semicolon())) return;
            int index = UnsavedFilterTrackCount.IndexOf(newUnsavedTrackCount.Semicolon());
            UnsavedFilterTrackCount = UnsavedFilterTrackCount.Remove(index, newUnsavedTrackCount.Semicolon().Length);
        }

        public static void DeleteFilterUnsavedReleasingLabel(string newLabel)
        {
            if (!UnsavedFilterReleasingLabel.Contains(newLabel.Semicolon())) return;
            int index = UnsavedFilterReleasingLabel.IndexOf(newLabel.Semicolon());
            UnsavedFilterReleasingLabel = UnsavedFilterReleasingLabel.Remove(index, newLabel.Semicolon().Length);
        }
        
        //Set methods for Sort
        public static void SetFilterTrackCountAsc(bool trackAsc)
        {
            if (UnsavedFilterTrackCountAsc == trackAsc) return;
            UnsavedFilterTrackCountAsc = trackAsc;
            UnsavedFilterTrackCountDesc = !trackAsc;
        }

        public static void SetFilterTrackCountDesc(bool trackDesc)
        {
            if (UnsavedFilterTrackCountDesc == trackDesc) return;
            UnsavedFilterTrackCountDesc = trackDesc;
            UnsavedFilterTrackCountAsc = !trackDesc;
        }

        public static void SetReleasingYearAsc(bool yearAsc)
        {
            if (UnsavedFilterReleaseYearAsc == yearAsc) return;
            UnsavedFilterReleaseYearAsc = yearAsc;
            UnsavedFilterReleaseYearDesc = !yearAsc;
        }

        public static void SetReleasingYearDesc(bool yearDesc)
        {
            if (UnsavedFilterReleaseYearDesc == yearDesc) return;
            UnsavedFilterReleaseYearDesc = yearDesc;
            UnsavedFilterReleaseYearAsc = !yearDesc;
        }


        //GET Data
        static public List<String> GetGenres()
        {
           return FilterGenre.Split(';').ToList();
        }
        //
        static public List<String> GetReleaseYears()
        {
            return FilterReleaseYear.Split(';').ToList();
        }
        //
        static public List<String> GetCarriers()
        {
            return FilterCarrier.Split(';').ToList();
        }
        //
        static public List<String> GetTypes()
        {
            return FilterType.Split(';').ToList();
        }
        //
        static public List<String> GetAuthors()
        {
            return FilterAuthor.Split(';').ToList();
        }
        //
        static public List<String> GetTrackCounts()
        {
            return FilterTrackCount.Split(';').ToList();
        }
        //
        static public List<String> GetReleasingLabels()
        {
            return FilterReleasingLabel.Split(';').ToList();
        }

        //
        public static string Semicolon(this string String)
        {
            return String += ";";
        }
        //
        
    }

}
