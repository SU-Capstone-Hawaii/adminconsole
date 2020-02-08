namespace adminconsole.Models
{
    
    public interface IMaphawksDatabaseTable 
    {

        //public Tables 

        /// <summary>
        /// Will be used to determine if all properties are null in Table Classes
        /// </summary>
        /// 
        /// 
        /// <returns> True if all are null, otherwise False </returns>
        public abstract bool AllPropertiesAreNull();


        
  
    }
}


public enum Table
{
    none = 0,

    location = 1,

    contact = 2,

    special_qualities = 3,

    daily_hours = 4
}
