using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    /// <summary>
    /// Class holds the property for the medicine details of the instance of <see cref="MedicineDetails"/>
    /// </summary>
    public class MedicineDetails
    {
        /// <summary>
        /// Static field for auto incrementation of the medicine id of the instance of <see cref="MedicineDetails"/>
        /// </summary>
        private static int s_medicineID=100;
        /// <summary>
        /// Read only property holds the medicine ID of the instance of <see cref="MedicineDetails"/>
        /// </summary>
        /// <value></value>
        public string MedicineID { get; }
        /// <summary>
        /// Property holds the name of the medicine of the instance of <see cref="MedicineDetails"/>
        /// </summary>
        /// <value></value>
        public string MedicineName { get; set; }
        /// <summary>
        /// Property holds the count of the medicine of the instance of <see cref="MedicineDetails"/>
        /// </summary>
        public int AvailableCount { get; set; }
        /// <summary>
        /// Property holds the price of the medicine of the instance of <see cref="MedicineDetails"/>
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Property holds the expiry date of the medicine of the instance of <see cref="MedicineDetails"/>
        /// </summary>
        public DateTime DateOfExpiry { get; set; }
        /// <summary>
        /// For initializing the value for the property of the instance of <see cref="MedicineDetails"/>
        /// </summary>
        /// <param name="medicineName"></param>
        /// <param name="availableCount"></param>
        /// <param name="price"></param>
        /// <param name="dateOfExpiry"></param>
        public MedicineDetails(string medicineName,int availableCount,double price,DateTime dateOfExpiry)
        {
            s_medicineID++;
            MedicineID="MD"+s_medicineID;
            MedicineName=medicineName;
            AvailableCount=availableCount;
            Price=price;
            DateOfExpiry=dateOfExpiry;
        }
        /// <summary>
        /// For initializing the value for the property of the instance of <see cref="MedicineDetails"/>
        /// </summary>
        public MedicineDetails(string medicine)
        {
            string[] values=medicine.Split(',');
            s_medicineID=int.Parse(values[0].Remove(0,2));
            MedicineID=values[0];
            MedicineName=values[1];
            AvailableCount=int.Parse(values[2]);
            Price=double.Parse(values[3]);
            DateOfExpiry=DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
        }
    }
}