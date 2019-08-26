using RevisaoWebAPI.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace RevisaoWebAPI.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        ContextDB dB = new ContextDB();
        private ValidFields typeField;

        public CustomValidFields(ValidFields type)
        {
            typeField = type;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                switch (typeField)
                {
                    case ValidFields.ValidaLogin: { return ValidaLogin(value, validationContext.DisplayName); }
                    case ValidFields.ValidaEmail: { return ValidarEmail(value, validationContext.DisplayName); }
                    case ValidFields.ValidaSenha: { return ValidaSenha(value, validationContext.DisplayName); }
                    case ValidFields.ValidaNome:  { return ValidaNome(value, validationContext.DisplayName); }
                    default: { } break;
                }

            }

            return new ValidationResult($"O campo:{validationContext.DisplayName} é obrigatorio.");
        }

        private ValidationResult ValidarEmail(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é invalido.");
        }

        private ValidationResult ValidaSenha(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,16}$");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é invalido.");
        }

        private ValidationResult ValidaNome(object value, string displayField)
        {

            var result = Regex.IsMatch(value.ToString(), @"^[A-ZÀ-Ÿ][A-zÀ-ÿ']+\s([A-zÀ-ÿ']\s?)*[A-ZÀ-Ÿ][A-zÀ-ÿ']+$");


            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é invalido.");
        }

        private ValidationResult ValidaLogin(object value, string displayField)
        {

            var result = dB.usuarios.FirstOrDefault(x => x.Login == value.ToString()) ;

            if (result == null)
                return ValidationResult.Success;
            
            return new ValidationResult($"O campo {displayField} é invalido.");
        }
    }
}