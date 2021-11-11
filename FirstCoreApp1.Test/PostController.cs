using System;
using Xunit;
using FirstCoreApp1.Controllers;
using FirstCoreApp1.Models;
using FirstCoreApp1.Repository;
using FirstCoreApp1.Test;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstCoreApp1.Test
{
    public class PostTestController
    {
        private PostRepository repository;
        public PostTestController()
        {
            repository = new PostRepository();
        }
        [Fact]
        public void Test_Index_View_Result()
        {
            //Arrange
            var controller = new HomeController(this.repository);

            //Act
            var result = controller.Index();
            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            //var model = Assert.IsAssignableFrom > (viewResult.ViewData.Model); Assert.Equal(3, model.Count); Assert.Equal(101, model[0].PostId); Assert.Equal("DevOps Demo Title 1", model[0].Title);
        }
        [Fact]
        public void Test_Index_Return_Result()
        {
            //Arrange
            var controller = new HomeController(this.repository);
            //Act
            var result = controller.Index();
            //Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void Test_Index_GetPosts_MatchData()
        {
            //Arrange
            var controller = new HomeController(this.repository);
            //Act
            var result = controller.Index();
            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<PostViewModel>>(viewResult.ViewData.Model);
            Assert.Equal(3, model.Count);
            Assert.Equal(101, model[0].postId);
            Assert.Equal("DevOps", model[0].title);
        }
    }
}






