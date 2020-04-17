using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    abstract class Item: IComparable
    {
        protected long invNumber;  
        protected bool taken; 
        public bool IsAvailable()           
        {           
            if (taken == true)               
                return true;           
            else               
                return false;       
        }    
        public long GetInvNumber()          
        {           
            return invNumber;       
        }   
        protected void Take()               
        {             
            taken = false;         
        }
        public abstract void Return();
        public abstract void TakeItem();
        
        public virtual void Print() 
        { 
            Console.WriteLine("Состояние единицы хранения:\n " +
                "Инвентарный номер: {0}\n Наличие: {1}", invNumber, taken); 
        }
        public Item(long invNumber, bool taken) 
        { 
            this.invNumber = invNumber; 
            this.taken = taken; 
        }
        public Item() 
        { 
            this.taken = true; 
        }
        int IComparable.CompareTo(object obj) 
        { 
            Item it = (Item)obj; 
            if (this.invNumber == it.invNumber) 
                return 0; 
            else if (this.invNumber > it.invNumber) 
                return 1; 
            else 
                return -1; 
        }
    }
}
