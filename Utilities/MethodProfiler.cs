//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Web;

//namespace MemberSuite.SDK.Utilities
//{
//    public class MethodProfiler : IDisposable
//    {
//        private readonly string _fileName;

//        private Stopwatch _timer;
//        private StreamWriter _streamWriter;
       
//        public MethodProfiler(string fileName, string details)
//        {
//            _fileName = fileName;


//            _timer = new Stopwatch();
//            _timer.Start();
//            _streamWriter = File.AppendText(fileName);

//            _streamWriter.WriteLine(details);
            
//        }

//        public void Dispose()
//        {
//            _timer.Stop();
//            _streamWriter.WriteLine("Elapsed Time (ms): {0}", _timer.ElapsedMilliseconds);

//            long runningCount;

//            if (HttpContext.Current == null) return;

//            Dictionary<string, long> _methodHistory =
//                (Dictionary<string, long>) HttpContext.Current.Items["MethodHistory"];
//            if (_methodHistory == null)
//            {
//                _methodHistory = new Dictionary<string, long>();
//                HttpContext.Current.Items["MethodHistory"] = _methodHistory;

//                _streamWriter.WriteLine();
//                _streamWriter.WriteLine();
//                _streamWriter.WriteLine("---------- NEW REQUEST --------------------");
//                _streamWriter.WriteLine();
//                _streamWriter.WriteLine( "Request: {0}", HttpContext.Current.Request.RawUrl );

//            }

//            if (!_methodHistory.TryGetValue(_fileName, out runningCount))
//                _methodHistory.Add(_fileName, _timer.ElapsedMilliseconds);
//            else
//                _methodHistory[_fileName] = runningCount + _timer.ElapsedMilliseconds;

//            _streamWriter.WriteLine("Running Time (ms): {0}", runningCount + _timer.ElapsedMilliseconds);

//            _streamWriter.Close();
//        }
//    }
//}
