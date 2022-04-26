
using System;

namespace solution2_1
{
    class Product
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                try
                {

                    if (String.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("Name cannot be null or empty.");
                    }
                    else
                    {
                        this.name = value;
                    }
                }
                catch (ArgumentException ex)
                { 
                    this.name = ex.Message;
                }
            }
        }
    }
}