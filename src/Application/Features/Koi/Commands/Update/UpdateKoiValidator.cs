﻿//using FluentValidation;

//namespace KoiAuction.Application.Features.Koi.Commands.Update
//{
//    public class UpdateKoiValidator : AbstractValidator<UpdateKoiCommand>
//    {
//        public UpdateKoiValidator()
//        {
//            ConfigureValidationRules();
//        }

//        private void ConfigureValidationRules()
//        {
//            RuleFor(x => x.Name)
//                .NotEmpty().WithMessage("The KoiEntity's name is required");

//            RuleFor(x => x.InitialPrice)
//                .GreaterThan(0).WithMessage("The initial price must be greater than 0");

//            RuleFor(x => x.Length)
//                .GreaterThan(0).WithMessage("The length must be greater than 0");

//            RuleFor(x => x.Age)
//                .GreaterThan(0).WithMessage("The age must be greater than 0");

//            RuleFor(x => x.AuctionID)
//                .NotEmpty().WithMessage("AuctionEntity ID is required");

//            RuleFor(x => x.BreederID)
//                .NotEmpty().WithMessage("Breeder ID is required");
//        }
//    }
//}
