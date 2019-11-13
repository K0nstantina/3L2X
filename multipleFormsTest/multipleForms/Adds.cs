using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleForms
{
    class Adds
    {
        #region variables
        private string adID,  adOwner, adObj, adDesc, adCreation, adModification, adImages, adTitle, adCategory;
        #endregion

        #region Constructors
        public Adds()
        {

        }
        /// <summary>
        /// Custom constructor
        /// </summary>
        /// <param name="adOwner">String passed from main form</param>
        public Adds(string adID, string adOwner, string adCategory, string adObj, string adDesc, string adCreation, string adModification, string adImages, string adTitle)
        {
            this.adCategory = adCategory;
            this.adCreation = adCreation;
            this.adDesc = adDesc;
            this.adID = adID;
            this.adImages = adImages;
            this.adModification = adModification;
            this.adObj = adObj;
            this.adOwner = adOwner;
            this.adTitle = adTitle;
        }
        #endregion

        #region getters
        public string getAdID()
        {
            return adID.ToString();
        }
        public string getAdCategory()
        {
            return adCategory.ToString();
        }
        public string getAdOwner()
        {
            return adOwner.ToString();
        }
        public string getAdObj()
        {
            return adObj.ToString();
        }
        public string getAdDesc()
        {
            return adDesc.ToString();
        }
        public string getAdCreation()
        {
            return adCreation.ToString();
        }
        public string getAdModification()
        {
            return adModification.ToString();
        }
        public string getAdImages()
        {
            return adImages.ToString();
        }
        public string getAdTitle()
        {
            return adTitle.ToString();
        }
        #endregion
    }
}
