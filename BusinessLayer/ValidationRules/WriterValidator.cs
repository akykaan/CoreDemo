using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
			RuleFor(x => x.WriterName).MinimumLength(50).WithMessage("Max 50 karakter girilebilir.");
		}
	}
}
