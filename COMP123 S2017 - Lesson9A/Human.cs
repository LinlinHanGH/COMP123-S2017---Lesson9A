using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name:
 * Date: 
 * Description:
 * Version: 0.1-class created
 */ 
 
namespace COMP123_S2017___Lesson9A
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Human
    {
        //PRIVATE FIELDS
        private string _name;

        //propertirs
        public string Name {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }

        }
            // CONS
        public Human(string name)
        {
            ///
            this.Name = name;
        } 
    }
}