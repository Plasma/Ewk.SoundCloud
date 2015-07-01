using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ewk.SoundCloud.ApiLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests.Resources
{
    public abstract class SoundCloudResourcesTestBase<T> : SoundCloudTestBase
        where T: Entity, new()
    {
        protected void TestGetEntityList(string expectedPath, Func<IEnumerable<T>> function)
        {
            var task = new Task<IEnumerable<T>>(() => new List<T>());

            SoundCloudClient
                .Expect(client => client.GetPageAsync<T>(
                    Arg<string>.Is.Equal(expectedPath)))
                .WhenCalled(invocation => task.Start())
                .Return(task)
                .Repeat.Once();
            SoundCloudClient.Replay();

            function();

            SoundCloudClient.VerifyAllExpectations();
        }

        protected void TestGetEntityList(string expectedPath, Func<Task<IEnumerable<T>>> function)
        {
            TestGetEntityList(expectedPath, () => function().Result);
        }

        protected void TestGetEntity(string expectedPath, Func<T> function)
        {
            var entity = new T();
            var task = new Task<T>(() => entity);

            SoundCloudClient
                .Expect(client => client.GetAsync<T>(
                    Arg<string>.Is.Equal(expectedPath)))
                .WhenCalled(invocation => task.Start())
                .Return(task)
                .Repeat.Once();
            SoundCloudClient.Replay();

            var result = function();

            Assert.AreEqual(entity, result);
            SoundCloudClient.VerifyAllExpectations();
        }

        protected void TestGetEntity(string expectedPath, Func<Task<T>> function)
        {
            TestGetEntity(expectedPath, () => function().Result);
        }

        protected void TestPostEntity(string expectedPath, Func<T, T> function)
        {
            var entity = new T();
            var task = new Task<T>(() => entity);

            SoundCloudClient
                .Expect(client => client.PostAsync<T, T>(
                    Arg<string>.Is.Equal(expectedPath),
                    Arg<T>.Is.Equal(entity)))
                .WhenCalled(invocation => task.Start())
                .Return(task)
                .Repeat.Once();
            SoundCloudClient.Replay();

            var result = function(entity);

            Assert.AreEqual(entity, result);
            SoundCloudClient.VerifyAllExpectations();
        }

        protected void TestPostEntity(string expectedPath, Func<T, Task<T>> function)
        {
            TestPostEntity(expectedPath, entity => function(entity).Result);
        }

        protected void TestPutEntity(string expectedPath, Func<T, T> function)
        {
            var entity = new T();
            var task = new Task<T>(() => entity);

            SoundCloudClient
                .Expect(client => client.PutAsync<T, T>(
                    Arg<string>.Is.Equal(expectedPath),
                    Arg<T>.Is.Equal(entity)))
                .WhenCalled(invocation => task.Start())
                .Return(task)
                .Repeat.Once();
            SoundCloudClient.Replay();

            var result = function(entity);

            Assert.AreEqual(entity, result);
            SoundCloudClient.VerifyAllExpectations();
        }

        protected void TestPutEntity(string expectedPath, Func<T, Task<T>> function)
        {
            TestPutEntity(expectedPath, entity => function(entity).Result);
        }

        protected void TestDeleteEntity(string expectedPath, Action action)
        {
            var entity = new T();
            var task = new Task<T>(() => entity);

            SoundCloudClient
                .Expect(client => client.DeleteAsync<T>(
                    Arg<string>.Is.Equal(expectedPath)))
                .WhenCalled(invocation => task.Start())
                .Return(task)
                .Repeat.Once();
            SoundCloudClient.Replay();

            action();

            SoundCloudClient.VerifyAllExpectations();
        }
    }
}