using Microsoft.EntityFrameworkCore.Diagnostics;
using OpenTracing;
using System.Data.Common;

namespace UNIVidaPortalWeb.Convocatorias.Utilities
{
    public class TracingDbCommandInterceptor : DbCommandInterceptor
    {
        private readonly ITracer _tracer;

        public TracingDbCommandInterceptor(ITracer tracer)
        {
            _tracer = tracer;
        }

        // Método sincrónico
        public override InterceptionResult<DbDataReader> ReaderExecuting(
            DbCommand command,
            CommandEventData eventData,
            InterceptionResult<DbDataReader> result)
        {
            TraceCommand(command); // Registrar los parámetros
            return base.ReaderExecuting(command, eventData, result);
        }

        // Método asincrónico
        public override ValueTask<InterceptionResult<DbDataReader>> ReaderExecutingAsync(
            DbCommand command,
            CommandEventData eventData,
            InterceptionResult<DbDataReader> result,
            CancellationToken cancellationToken = default)
        {
            TraceCommand(command); // Registrar los parámetros
            return base.ReaderExecutingAsync(command, eventData, result, cancellationToken);
        }

        // Método sincrónico para comandos no relacionados con lecturas
        public override InterceptionResult<int> NonQueryExecuting(
            DbCommand command,
            CommandEventData eventData,
            InterceptionResult<int> result)
        {
            TraceCommand(command); // Registrar los parámetros
            return base.NonQueryExecuting(command, eventData, result);
        }

        // Método asincrónico para comandos no relacionados con lecturas
        public override ValueTask<InterceptionResult<int>> NonQueryExecutingAsync(
            DbCommand command,
            CommandEventData eventData,
            InterceptionResult<int> result,
            CancellationToken cancellationToken = default)
        {
            TraceCommand(command); // Registrar los parámetros
            return base.NonQueryExecutingAsync(command, eventData, result, cancellationToken);
        }

        // Método sincrónico para obtener un escalar
        public override InterceptionResult<object> ScalarExecuting(
            DbCommand command,
            CommandEventData eventData,
            InterceptionResult<object> result)
        {
            TraceCommand(command); // Registrar los parámetros
            return base.ScalarExecuting(command, eventData, result);
        }

        // Método asincrónico para obtener un escalar
        public override ValueTask<InterceptionResult<object>> ScalarExecutingAsync(
            DbCommand command,
            CommandEventData eventData,
            InterceptionResult<object> result,
            CancellationToken cancellationToken = default)
        {
            TraceCommand(command); // Registrar los parámetros
            return base.ScalarExecutingAsync(command, eventData, result, cancellationToken);
        }

        // Método para registrar los parámetros y el comando SQL
        private void TraceCommand(DbCommand command)
        {
            var span = _tracer.ActiveSpan;
            if (span == null) return;

            // Registrar el comando SQL
            span.SetTag("db.statement", command.CommandText);

            // Registrar los parámetros
            foreach (DbParameter parameter in command.Parameters)
            {
                span.SetTag($"db.param.{parameter.ParameterName}", parameter.Value?.ToString());
            }
        }
    }
}
