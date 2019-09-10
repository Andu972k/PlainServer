using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib.Model
{
    public class Car
    {
        #region InstanceFields

        private string _model;
        private string _colour;
        private string _registrationNumber;


        #endregion

        #region Properties

        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public string Colour
        {
            get => _colour;
            set => _colour = value;
        }

        public string RegistrationNumber
        {
            get => _registrationNumber;
            set => _registrationNumber = value;
        }

        #endregion

        #region Constructor

        public Car(string model, string colour, string registrationNumber)
        {
            _model = model;
            _colour = colour;
            _registrationNumber = registrationNumber;

        }

        public Car()
        {
            
        }


        #endregion


        #region Methods

        public override string ToString()
        {
            return $"{nameof(Model)}: {Model}, {nameof(Colour)}: {Colour}, {nameof(RegistrationNumber)}: {RegistrationNumber}";
        }

        #endregion


    }
}
