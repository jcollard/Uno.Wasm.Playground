public static class WebThread {

    public static async Task Sleep(int millis)
    {
        await Task.Delay(millis);
    }

}