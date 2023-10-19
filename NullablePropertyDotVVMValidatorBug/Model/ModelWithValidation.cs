using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NullablePropertyDotVVMValidatorBug.Model;

public class ModelWithValidation : IValidatableObject
{
    public string Name { get; set; }
    public RandomEnum? Enum { get; set; }
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (string.IsNullOrEmpty(Name))
        {
            yield return new ValidationResult($"The {nameof(Name)} field is required.",
                new[] { $"{nameof(Name)}" });
        }
    }
}