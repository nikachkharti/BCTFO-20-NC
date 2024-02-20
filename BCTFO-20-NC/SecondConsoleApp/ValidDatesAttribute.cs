using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace SecondConsoleApp
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class ValidDatesAttribute : ValidationAttribute
    {
        private readonly string _startDatePropertyName;
        public ValidDatesAttribute(string startDatePropertyName)
        {
            _startDatePropertyName = startDatePropertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            PropertyInfo propertyInfo = validationContext.ObjectType.GetProperty(_startDatePropertyName);

            if (propertyInfo == null)
            {
                return new ValidationResult($"Unknown property: {_startDatePropertyName}");
            }

            DateTime startDateValue = (DateTime)propertyInfo.GetValue(validationContext.ObjectInstance);
            DateTime endDateValue = (DateTime)value;

            if (endDateValue < startDateValue)
            {
                return new ValidationResult($"End date must be later then start date");
            }

            return ValidationResult.Success;
        }
    }
}
