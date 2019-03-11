﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySite.Controllers;
using MySite.Domain.Contracts.Models;
using MySite.Domain.Infraestructure.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace MySite.WebUI.UnitTests
{
    [TestClass]
    public class AdminControllerTests
    {
        [TestMethod]
        public void CanChangeLoginName()
        {   
            // Arrange (set up a scenario)
            User user = new User() { LoginName = "Bob" };
            FakeRepository repositoryParam = new FakeRepository();
            repositoryParam.Add(user);
            AdminController target = new AdminController(repositoryParam);
            string oldLoginParam = user.LoginName;
            string newLoginParam = "Joe";

            // Act (attempt the operation)            
            target.ChangeLoginName(oldLoginParam, newLoginParam);

            // Assert (verify the result)
            Assert.AreEqual(newLoginParam, user.LoginName);
            Assert.IsTrue(repositoryParam.DidSubmitChanges);
        }

        class FakeRepository : IUserRepository
        {
            public List<User> Users = new List<User>();
            public bool DidSubmitChanges = false;
            public void Add(User user)
            {
                Users.Add(user);
            }
            public User FetchByLoginName(string loginName)
            {
                return Users.First(m => m.LoginName == loginName);
            }
            public void SubmitChanges()
            {
                DidSubmitChanges = true;
            }
        }

    }
}
