using Vanguard.Abstraction.Contracts.Requests.Notification;
using Vanguard.Abstraction.Enums;
using Vanguard.Abstraction.Settings;
using Vanguard.Application.Integrations.Notification;
using Vanguard.Core.Extensions;
using Vanguard.Core.Helpers;
using Vanguard.Infrastructre.UnitOfWork;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Application.HealthChecks
{
    public class VanguardDbHealthCheck : IHealthCheck
    {
        private readonly VanguardHealthCheckUnitOfWork unitOfWork;
        private const string healthCheckKey = nameof(HealthChechKeys.DbHealthCheck);
        private HealthCheckNotificationSettings notificationSettings;
        private readonly INotificationServiceManager notificationServiceManager;

        public VanguardDbHealthCheck(VanguardHealthCheckUnitOfWork unitOfWork, INotificationServiceManager notificationServiceManager)
        {
            notificationSettings = AppSettingsHelper.GetData<HealthCheckNotificationSettings>();
            this.unitOfWork = unitOfWork;
            this.notificationServiceManager = notificationServiceManager;
        }

        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                await unitOfWork.TryConnectDbAsync();
                return HealthCheckResult.Healthy();
            }
            catch (Exception exp)
            {
                string expMsg = exp.GetAllInnerExceptionsAsJson();
                Console.WriteLine("DB ERROR!!!! Exception Message : {0}", expMsg);
                await SendAlertMessage(expMsg);
                return HealthCheckResult.Healthy();
            }
        }

        private async Task SendAlertMessage(string exceptionMessage)
        {
            HealthCheckDetailSettings dbSettings = notificationSettings.HealthChecksSettings.FirstOrDefault(w => w.Key == healthCheckKey);
            if (dbSettings is not null)
            {
                await notificationServiceManager.SendEmail(new NotificationSendMailRequest
                {
                    IsHtml = dbSettings.IsHtml,
                    Message = String.Format("{0} ExceptionMessage : {1}" , dbSettings.Message, exceptionMessage),
                    UniqueId = Guid.NewGuid().ToString(),
                    Recipient = dbSettings.Recipient,
                    Subject = dbSettings.Subject
                });
            }
        }
    }
}
