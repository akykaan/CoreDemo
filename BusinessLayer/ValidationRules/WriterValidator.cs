using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator: AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Boş geçilemez.");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail boş geçilemez.");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Sifre bos gecilemez");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Min 2 karakter girilebilir.");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Max 50 karakter girilebilir.");
			RuleFor(c => c.WriterPassword).Must(ValidationPassword)
				.WithMessage
				("Şifrede en az 1 büyük, " +
				"en az 1 küçük karakter , " +
				"en az 1 tane sayı olmalıdır ve " +
				"min 4 karakter olmalı ve" +
				"en fazla 10 karakter olmalıdır. ");
		}

		private bool ValidationPassword(string arg)
		{
			Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{4,10}$");
			
			if (regex.IsMatch(arg) )
			{
				return true;
			}
			return false;
		}
	}
}
