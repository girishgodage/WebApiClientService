namespace GGSoftware.ApiClientService
{
    public class StringFormKeyValue : FormKeyValue
    {
        public string Value
        {
            get;
            set;
        }
        public StringFormKeyValue(string key, string value) : base(key)
        {
            this.Value = value;
        }
    }
}
