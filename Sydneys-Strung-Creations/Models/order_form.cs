namespace Sydneys_Strung_Creations.Models
{
    public class order_form
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string ProductName { get; set; }
        public string HardwareType { get; set; }
        public string FocalColor { get; set; }
        public string Length { get; set; }
        public string AdditionalNotes { get; set; }
        public DateTime OrderDate { get; set; }
    }

}
