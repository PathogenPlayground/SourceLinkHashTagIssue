using Biohazrd;
using Biohazrd.Expressions;

// For `FromInt32`, SourceLink should find https://raw.githubusercontent.com/MochiLibraries/Biohazrd/9e11ce098fa067438d7fbd032fb9a9cebffaab19/Biohazrd/Expressions/IntegerConstant.cs
// Works as expected in all scenarios I tested, just including it to show that SourceLink works for this library in general.
IntegerConstant.FromInt32(42);

// For `Create`, SourceLink should find https://raw.githubusercontent.com/MochiLibraries/Biohazrd/main/Biohazrd/%23TypeReferences/TranslatedTypeReference.cs
// Source Link fails here in some scenarios because the `#` is (presumably) not properly escaped as `%23`
TranslatedTypeReference.Create(default(DeclarationId));
