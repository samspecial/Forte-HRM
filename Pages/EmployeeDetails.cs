﻿using Forte_HRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forte_HRM.Pages
{
   public partial class EmployeeDetails
    {
		[Parameter]
		public string Id { get; set; }

		public Employee Employee { get; set; } = new Employee();
		protected override Task OnInitializedAsync()
		{
			InitializeCountries();
			InitializeEmployees();
			InitializeJobCategories();

			Employee = Employees.FirstOrDefault(e => e.Id == int.Parse(Id));
			return base.OnInitializedAsync();
		}
		public IEnumerable<Employee> Employees { get; set; }

		private List<Country> Countries { get; set; }

		private List<JobCategory> JobCategories { get; set; }

      
	
		private void InitializeJobCategories()
		{
			JobCategories = new List<JobCategory>()
			{
				new JobCategory{Id = 1, JobCategoryName = "Pie research"},
				new JobCategory{Id = 2, JobCategoryName = "Sales"},
				new JobCategory{Id = 3, JobCategoryName = "Management"},
				new JobCategory{Id = 4, JobCategoryName = "Store staff"},
				new JobCategory{Id = 5, JobCategoryName = "Finance"},
				new JobCategory{Id = 6, JobCategoryName = "QA"},
				new JobCategory{Id = 7, JobCategoryName = "IT"},
				new JobCategory{Id = 8, JobCategoryName = "Cleaning"},
				new JobCategory{Id = 9, JobCategoryName = "Bakery"},
				new JobCategory{Id = 9, JobCategoryName = "Bakery"}
			};
		}

		private void InitializeCountries()
		{
			Countries = new List<Country>
			{
				new Country {Id = 1, Name = "Belgium"},
				new Country {Id = 2, Name = "Netherlands"},
				new Country {Id = 3, Name = "USA"},
				new Country {Id = 4, Name = "Japan"},
				new Country {Id = 5, Name = "China"},
				new Country {Id = 6, Name = "UK"},
				new Country {Id = 7, Name = "France"},
				new Country {Id = 8, Name = "Brazil"}
			};
		}

		private void InitializeEmployees()
		{
			var e1 = new Employee
			{
				CountryId = 1,
				MaritalStatus = MaritalStatus.Single,
				BirthDate = new DateTime(1989, 3, 11),
				City = "Brussels",
				Email = "bethany@bethanyspieshop.com",
				Id = 1,
				FirstName = "Bethany",
				LastName = "Smith",
				Gender = Gender.Female,
				PhoneNumber = "324777888773",
				Smoker = false,
				Street = "Grote Markt 1",
				Zip = "1000",
				JobCategoryId = 1,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2015, 3, 1)
			};

			var e2 = new Employee
			{
				CountryId = 2,
				MaritalStatus = MaritalStatus.Married,
				BirthDate = new DateTime(1979, 1, 16),
				City = "Antwerp",
				Email = "gill@bethanyspieshop.com",
				Id = 2,
				FirstName = "Gill",
				LastName = "Cleeren",
				Gender = Gender.Female,
				PhoneNumber = "33999909923",
				Smoker = false,
				Street = "New Street",
				Zip = "2000",
				JobCategoryId = 1,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2017, 12, 24)
			};
			Employees = new List<Employee> { e1, e2 };
		}
	}
}
