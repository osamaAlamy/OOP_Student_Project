using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenrecListWithClasses.BL
{
    internal class Major
    {
        #region Propirtes
        public int Id { get; set; }
        public string Name { get; }
        public string DoctorName { get;}
        #endregion

        #region Methods
        public Major(string name, string doctorName)
        {
            this.Name = name;
            this.DoctorName = doctorName;
        }

        public Major(Major myMajor)
        {
            this.Id = myMajor.Id;
            this.Name = myMajor.Name;
            this.DoctorName = myMajor.DoctorName;
        } 
        #endregion        

    }
}
