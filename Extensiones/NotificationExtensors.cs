using Radzen;

namespace Registro_de_Tickets.Extensiones
{
    public static class NotificationExtensors
    {
        public static void ShowNotification(this NotificationService notifier, string mensaje, NotificationSeverity severity = NotificationSeverity.Success)
        {
            var message = new NotificationMessage
            {
                Severity = severity,
                Summary = mensaje
            };

            notifier.Notify(message);
        }
    }
}
