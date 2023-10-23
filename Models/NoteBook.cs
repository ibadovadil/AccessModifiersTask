namespace AccessModifiersTask.Models
{
    internal class NoteBook : Product
    {
        private string _brand;
        private string _model;
        private byte _ram;
        private ushort _storage;

        public string GetFullInfo()
        {
            return GetBrand() + " " + GetModel() + " " + GetRam() + " " + GetStorage() + " " + GetCount() + " " + GetPrice();
        }
        public string Brand
        {
            get
            {
                if (_brand == null)
                {
                    _brand = "Nothing entered";
                }
                return _brand;
            }
            set
            {
                if (value.Length < 3 && value.Length > 30)
                {
                    Console.WriteLine("The brand name you enter cannot be less than 3 characters and more than 30 characters");
                }
                else
                {
                    _brand = value;
                }
            }

        }
        public string GetBrand() => _brand;




        public string Model
        {
            get
            {
                if (_model == null)
                {
                    _model = "Nothing entered";
                }
                return _model;
            }
            set
            {
                if (value.Length < 3 && value.Length > 30)
                {
                    Console.WriteLine("The model name you enter cannot be less than 3 characters and more than 30 characters");
                }
                else
                {
                    _model = value;
                }
            }

        }
        public string GetModel() => _model;

        public byte Ram
        {
            get
            {
                if (_ram == null)
                {
                    Console.WriteLine("Ram value not initialized. Please set a value.");
                }
                return _ram;
            }
            set
            {
                if (value < 0 && value > 128)
                {
                    Console.WriteLine("Ram value must be greater than 0 and less than 128");
                }
                else
                {
                    _ram = value;
                }
            }

        }
        public ushort GetRam() => _ram;

        public ushort Storage
        {
            get
            {
                if (_storage == null)
                {
                    Console.WriteLine("Ram value not initialized. Please set a value.");
                }
                return _storage;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Storage value must be greater than 0");
                }
                else
                {
                    _storage = value;
                }
            }

        }

        public ushort GetStorage() => _storage;

        public void SetStorage(ushort storage)
        {

            if (storage < 0)
            {
                Console.WriteLine("Storage value must be greater than 0");
            }
            else
            {
                _storage = storage;
            }
        }

        public void SetRam(byte ram)
        {

            if (ram < 0 && ram > 128)
            {
                Console.WriteLine("Ram value must be greater than 0 and less than 128");
            }
            else
            {
                _ram = ram;
            }
        }

        public void SetModel(string model)
        {

            if (model.Length < 3 && model.Length > 30)
            {
                Console.WriteLine("The model name you enter cannot be less than 3 characters and more than 30 characters");
            }
            else
            {
                _model = model;
            }
        }



        public void SetBrand(string brand)
        {
            if (brand.Length < 3 && brand.Length > 30)
            {
                Console.WriteLine("The brand name you enter cannot be less than 3 characters and more than 30 characters");
            }
            else
            {
                _brand = brand;
            }
        }
    }
}
