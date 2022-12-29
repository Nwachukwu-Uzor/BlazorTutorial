namespace BlazorPractice.ServersideBlazorAuth.Configurations
{
    public class ColumnDefinition
    {
        public string Caption { get; set; }
        public string DataField { get; set; }
        public DataType DataType { get; set; }
        public string Format { get; set; }
        public Alignment Alignment { get; set; }

        public ColumnDefinition()
        {
            DataType = DataType.NotSet;
            Alignment = Alignment.NotSet;
        }
    }
}
