using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileLogger : ILogHandler {
    private FileStream fileStream;
    private StreamWriter streamWriter;
    private ILogHandler defaultLogHandler = Debug.unityLogger.logHandler;

    public FileLogger() {
        string filePath = Application.persistentDataPath + "/MyLogs.txt";
        fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        streamWriter = new StreamWriter(fileStream);
        ReplaceDefaultLogger();
        Debug.Log("Log file: " + filePath);
    }

    private void ReplaceDefaultLogger() {
        Debug.unityLogger.logHandler = this;
    }

    public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args) {
        streamWriter.WriteLine(String.Format(format, args));
        streamWriter.Flush();
        defaultLogHandler.LogFormat(logType, context, format, args);
    }

    public void LogException(Exception exception, UnityEngine.Object context) {
        defaultLogHandler.LogException(exception, context);
    }
}