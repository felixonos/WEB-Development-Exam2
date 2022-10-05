using WALLET_INC.Data.Entities;

namespace WALLET_INC.Data
{
    public static class SeedHelper
    {
        public static async Task InitializeData(ApplicationDbContext context
            )
        {
           
            if (!context.Customers.Any())
            {


                context.Customers.Add(new Customer
                {
                    FirstName = "Felix",
                    LastName = "Onomozor",
                    MiddleName= "Fintrak",
                    Gender = GenderEnum.Male,
                    MaritalStatus = MaritalStatusEnum.Single,
                    DateofBirth = DateTime.Now.AddYears(-20),
                    Country = "Nigeria",
                    State = "Lagos",
                    City = "Ikeja"
                });


                context.Customers.Add(new Customer
                {
                    FirstName = "Ishola",
                    LastName = "Abiola",
                    MiddleName = "Fintrak",
                    Gender = GenderEnum.Male,
                    MaritalStatus = MaritalStatusEnum.Married,
                    DateofBirth = DateTime.Now.AddYears(-10),
                    Country = "UK",
                    State = "London",
                    City = "London"
                });

                await context.SaveChangesAsync();
            }

            }
        }
    }

