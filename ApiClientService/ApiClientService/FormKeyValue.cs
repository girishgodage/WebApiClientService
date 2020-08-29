namespace GGSoftware.ApiClientService
{
    public abstract class FormKeyValue
    {
        public string Key
        {
            get;
            set;
        }
        protected FormKeyValue(string key)
        {
            this.Key = key;
        }
    }
}
