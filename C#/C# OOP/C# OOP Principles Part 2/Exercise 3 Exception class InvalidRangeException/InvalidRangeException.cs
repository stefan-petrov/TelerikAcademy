using System;

namespace Exercise3
{
    class  InvalidRangeException<T> : Exception
    {
        private string message;          

        public override string Message
        {
            get { return this.message; }          
        }

        public InvalidRangeException() : base()
        {          
        }  
        
        public InvalidRangeException(string message) : base(message)
        {
            this.message = message;
        }
       
    }
}
