// See https://aka.ms/new-console-template for more information

Console.WriteLine(GetSinceTime());

Console.WriteLine(UnixTimeStampToDateTime(Convert.ToInt64(GetSinceTime())));

Console.ReadLine();

static string GetSinceTime()
{
    DateTime currentUtcTime = DateTime.UtcNow.ToUniversalTime().AddDays(-1);
    long unixTimestamp = new DateTimeOffset(currentUtcTime).ToUnixTimeSeconds();
    return unixTimestamp.ToString();
}

//convert unix timestamp to datetime
static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
{
    // Unix timestamp is seconds past epoch
    DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
    dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
    return dtDateTime;
}