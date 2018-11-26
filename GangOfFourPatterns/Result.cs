using System;

namespace GangOfFourPatterns
{
    /// <summary>
    /// Based on Vladimir Khorikov's CSharpFunctionalExtensions. https://github.com/vkhorikov/CSharpFunctionalExtensions
    /// There were issues installing the CSharpFunctionalExtensions into the solution whilst using .net4.
    /// The below keeps the same interface as the above library, so when the .net framework is updated
    /// the library can be used.
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Indicates a successful or failure result
        /// </summary>
        public bool IsSuccess { get; private set; }

        /// <summary>
        /// The error message
        /// </summary>
        public string Error
        {
            get { return GetError(); }
        }

        private readonly string errorMessage;

        /// <summary>
        /// Create an instance of an unsuccessful <see cref="Result"/>
        /// </summary>
        /// <param name="message">The failure message</param>
        private Result(string message)
        {
            IsSuccess = false;
            errorMessage = message;
        }

        /// <summary>
        /// Create an instance of a successful <see cref="Result"/>
        /// </summary>
        private Result()
        {
            IsSuccess = true;
        }

        /// <summary>
        /// An unsuccessful result
        /// </summary>
        /// <param name="errorMessage">The failure message</param>
        /// <returns>An unsuccessful result</returns>
        public static Result Fail(string errorMessage)
        {
            return new Result(errorMessage);
        }

        /// <summary>
        /// An unsuccessful result
        /// </summary>
        /// <typeparam name="T">The type of result to return</typeparam>
        /// <param name="errorMessage">The failure message</param>
        /// <returns>An unsuccessful result</returns>
        public static Result<T> Fail<T>(string errorMessage)
        {
            return Result<T>.Fail(errorMessage);
        }

        /// <summary>
        /// A successful result with a value
        /// </summary>
        /// <typeparam name="T">The type for the value</typeparam>
        /// <param name="value">The value</param>
        /// <returns>A successful result</returns>
        public static Result<T> Ok<T>(T value)
        {
            return Result<T>.Ok(value);
        }

        /// <summary>
        /// A successful result
        /// </summary>
        /// <returns>A successful result</returns>
        public static Result Ok()
        {
            return new Result();
        }

        /// <summary>
        /// Get the error message. When the result is successful, throw the exception.
        /// </summary>
        /// <exception cref="InvalidOperationException">When the result is successful and there is no error message</exception>
        /// <returns>The error message</returns>
        private string GetError()
        {
            if (IsSuccess)
            {
                throw new InvalidOperationException("Ok has no error");
            }

            return errorMessage;
        }
    }

    public class Result<T>
    {
        /// <summary>
        /// Indicates a successful or failure result
        /// </summary>
        public bool IsSuccess { get; private set; }

        /// <summary>
        /// The value of the result
        /// </summary>
        public T Value
        {
            get { return GetValue(); }
        }

        /// <summary>
        /// The error message
        /// </summary>
        public string Error
        {
            get { return GetError(); }
        }

        private readonly T result;
        private readonly string errorMessage;

        /// <summary>
        /// Create an instance of an unsuccessful <see cref="Result"/>
        /// </summary>
        /// <param name="message">The failure message</param>
        private Result(string message)
        {
            IsSuccess = false;
            errorMessage = message;
        }

        /// <summary>
        /// Create an instance of a successful <see cref="Result"/> with a value
        /// </summary>
        /// <param name="value">The value</param>
        private Result(T value)
        {
            IsSuccess = true;
            result = value;
        }

        /// <summary>
        /// An unsuccessful <see cref="Result"/>
        /// </summary>
        /// <param name="message">The failure message</param>
        /// <returns>An unsuccessful result</returns>
        public static Result<T> Fail(string message)
        {
            return new Result<T>(message);
        }

        /// <summary>
        /// A successful <see cref="Result"/> with a value
        /// </summary>
        /// <param name="value">The value</param>
        /// <returns>A successful result</returns>
        public static Result<T> Ok(T value)
        {
            return new Result<T>(value);
        }

        /// <summary>
        /// Get the value from the <see cref="result"/>. When unsuccessful, throw an exception
        /// </summary>
        /// <exception cref="InvalidOperationException">When the result is unsuccessful and there is no value</exception>
        /// <returns>The value</returns>
        private T GetValue()
        {
            if (!IsSuccess)
            {
                throw new InvalidOperationException("Failure has no value");
            }
            return result;
        }

        /// <summary>
        /// Get the error message. When the result is successful, throw the exception.
        /// </summary>
        /// <exception cref="InvalidOperationException">When the result is successful and there is no error message</exception>
        /// <returns>The error message</returns>
        private string GetError()
        {
            if (IsSuccess)
            {
                throw new InvalidOperationException("Ok has no error");
            }

            return errorMessage;
        }

        public static implicit operator Result(Result<T> result)
        {
            return result.IsSuccess
                ? Result.Ok()
                : Result.Fail(result.Error);
        }
    }
}
