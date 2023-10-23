namespace AccessModifiersTask.Models
{
    internal class Product
    {
        private int _count;
        private int _price;

        public int Count
        {
            get
            {
                if (_count == null)
                {
                    Console.WriteLine("Nothing entered");
                }
                return _count;
            }
            set
            {
                if (value < 3 && value > 30)
                {
                    Console.WriteLine("The brand name you enter cannot be less than 3 characters and more than 30 characters");
                }
                else
                {
                    _count = value;
                }
            }

        }

        public void SetCount(int count)
        {

            if (count < 3 && count > 30)
            {
                Console.WriteLine("The brand name you enter cannot be less than 3 characters and more than 30 characters");
            }
            else
            {
                _count = count;
            }
        }

        public int Price
        {
            get
            {
                if (_price == null)
                {
                    Console.WriteLine("Nothing entered");
                }
                return _price;
            }
            set
            {
                _price = value;
            }

        }
        public int GetPrice() => _price;

        public void SetPrice(int price)
        {

            _price = price;
        }
        public int GetCount() => _count;

    }
}
