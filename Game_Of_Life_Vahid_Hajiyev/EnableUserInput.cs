public class EnableUserInput
{
    public int Starting(string value)
    {
        try
        {
            byte size = byte.Parse(value);
            return size;
        }
        catch (Exception)
        {
            var datasize = new DataSize();
            datasize.PleaseEnter();
            throw new Exception();
        }
    }
}