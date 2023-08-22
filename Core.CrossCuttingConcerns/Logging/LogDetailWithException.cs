﻿namespace Core.CrossCuttingConcerns.Logging;

public class LogDetailWithException : LogDetail
{
    public string ExceptionMessage { get; set; }

    public LogDetailWithException()
    {
        ExceptionMessage = String.Empty;
    }

    public LogDetailWithException(string fullName, string methodName, string user, List<LogParameters> parameters, string exceptionMessage) : base(fullName, methodName, user, parameters)
    {
        ExceptionMessage = exceptionMessage;
    }
}