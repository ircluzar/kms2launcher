namespace KMS2Launcher
{
    public static class Arguments
    {
        public static string GameId { get; internal set; } = "106498";
        public static string StartLocale { get; internal set; } = "KR";
        public static string LoginUrl { get; internal set; } = "https://clogin.nexon.com/common/clogin.aspx";

        public static string LoginRedirectUrl => $"{LoginUrl}?redirect=http://game.nexon.com/{GameId}";
    }
}
