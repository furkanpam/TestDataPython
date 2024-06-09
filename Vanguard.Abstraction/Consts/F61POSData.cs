using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Abstraction.Consts
{
    public static class Sf1PosTerminalAttendance
    {
        public const string AttendedTerminal = "0";
        public const string UnattendedTerminal = "1";
        public const string NoTerminalUsed = "2";
    }

    public static class Sf3PosTerminalLocation
    {
        public const string OnPremises = "0";
        public const string OffPremisesMerchant = "1";
        public const string OffPremisesCardholderTerminal = "2";
        public const string NoTerminalUsed = "3";
        public const string OnPremisesCardholderTerminal = "4";
    }

    public static class Sf4PosCardholderPresence
    {
        public const string CardholderPresent = "0";
        public const string CardholderNotPresentUnspecified = "1";
        public const string MailOrFacsimileOrder = "2";
        public const string PhoneOrARUOrder = "3";
        public const string StandingOrderOrRecurringTransactions = "4";
        public const string ElectronicOrder = "5";
    }

    public static class Sf5PosCardPresence
    {
        public const string CardPresent = "0";
        public const string CardNotPresent = "1";
    }

    public static class Sf6PosCardCaptureCapabilities
    {
        public const string NoCaptureCapability = "0";
        public const string HasCaptureCapability = "1";
    }

    public static class Sf7PosTransactionStatus
    {
        public const string NormalRequest = "0";
        public const string SecureCodePhoneOrder = "2";
        public const string ATMInstallmentInquiry = "3";
        public const string PreauthorizedRequest = "4";
        public const string ATCUpdate = "6";
        public const string AccountStatusInquiryService = "8";
        public const string TokenizationRequestNotification = "9";
    }

    public static class Sf8PosTransactionSecurity
    {
        public const string NoSecurityConcern = "0";
        public const string SuspectedFraud = "1";
        public const string IDVerified = "2";
    }

    public static class Sf10CardholderActivatedTerminalLevel
    {
        public const int NotACATTransaction = 0;
        public const int AuthorizedLevel1CAT = 1;
        public const int AuthorizedLevel2CAT = 2;
        public const int AuthorizedLevel3CAT = 3;
        public const int AuthorizedLevel4CAT = 4;
        public const int Reserved1 = 5;
        public const int AuthorizedLevel6CAT = 6;
        public const int AuthorizedLevel7CAT = 7;
        public const int Reserved2 = 8;
        public const int MPOSAcceptanceDevice = 9;
    }

    public static class Sf11PosCardDataTerminalInputCapabilityIndicator
    {
        public const string UnknownOrUnspecified = "0";
        public const string NoTerminalUsed = "1";
        public const string MagneticStripeReaderOnly = "2";
        public const string ContactlessMChip = "3";
        public const string ContactlessMagneticStripeOnly = "4";
        public const string EMVSpecificationAndMagneticStripeReader = "5";
        public const string KeyEntryOnly = "6";
        public const string MagneticStripeReaderAndKeyEntry = "7";
        public const string EMVSpecificationMagneticStripeReaderAndKeyEntry = "8";
        public const string EMVSpecificationOnly = "9";
    }

    public static class Sf12PosAuthorizationLifeCycle
    {
        public const string ZeroFilled = "00";
    }
    public static class Sf13PosCountryCode
    {
        public const string Turkey = "792";
    }



}
