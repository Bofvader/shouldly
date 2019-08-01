using System;
using System.Diagnostics;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Shouldly
{
    [DebuggerStepThrough]
    [ShouldlyMethods]
    public static class ShouldThrowAsyncExtensions
    {
        /*** ShouldThrowAsync(Task) ***/
        public async static Task<TException> ShouldThrowAsync<TException>(this Task task) where TException : Exception
        {
            return await Should.ThrowAsync<TException>(task);
        }
        public async static Task<TException> ShouldThrowAsync<TException>(this Task task, string customMessage) where TException : Exception
        {
            return await Should.ThrowAsync<TException>(task, customMessage);
        }
        public async static Task<TException> ShouldThrowAsync<TException>(this Task task, [InstantHandle] Func<string> customMessage) where TException : Exception
        {
            return await Should.ThrowAsync<TException>(task, customMessage);
        }

        /*** ShouldThrowAsync(Task) ***/
        public async static Task<Exception> ShouldThrowAsync(this Task task, Type exceptionType)
        {
            return await Should.ThrowAsync(task, exceptionType);
        }
        public async static Task<Exception> ShouldThrowAsync(this Task task, string customMessage, Type exceptionType)
        {
            return await Should.ThrowAsync(task, customMessage, exceptionType);
        }
        public async static Task<Exception> ShouldThrowAsync(this Task task, [InstantHandle] Func<string> customMessage, Type exceptionType)
        {
            return await Should.ThrowAsync(task, customMessage, exceptionType);
        }

        /*** ShouldThrowAsync(Func<Task>) ***/
        public async static Task<TException> ShouldThrowAsync<TException>(this Func<Task> actual) where TException : Exception
        {
            return await Should.ThrowAsync<TException>(actual);
        }
        public async static Task<TException> ShouldThrowAsync<TException>(this Func<Task> actual, string customMessage) where TException : Exception
        {
            return await Should.ThrowAsync<TException>(actual, customMessage);
        }
        public async static Task<TException> ShouldThrowAsync<TException>(this Func<Task> actual, [InstantHandle] Func<string> customMessage) where TException : Exception
        {
            return await Should.ThrowAsync<TException>(actual, customMessage);
        }

        /*** ShouldThrowAsync(Func<Task>) ***/
        public async static Task<Exception> ShouldThrowAsync(this Func<Task> actual, Type exceptionType)
        {
            return await Should.ThrowAsync(actual, exceptionType);
        }
        public async static Task<Exception> ShouldThrowAsync(this Func<Task> actual, string customMessage, Type exceptionType)
        {
            return await Should.ThrowAsync(actual, customMessage, exceptionType);
        }
        public async static Task<Exception> ShouldThrowAsync(this Func<Task> actual, [InstantHandle] Func<string> customMessage, Type exceptionType)
        {
            return await Should.ThrowAsync(actual, customMessage, exceptionType);
        }
    }
}