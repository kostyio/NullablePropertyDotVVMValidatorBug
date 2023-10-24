The error occurs when the validation fails.
Leave the name field empty (this field is validated), select some value in Level combobox and press the save button.
The error only occurs, when there is a null value added to the "RandomEnumValues" collection, which is the source for
the Level FormControlComboBox component, located in the "DefaultViewModel.cs" .# NullablePropertyDotVVMValidatorBug
