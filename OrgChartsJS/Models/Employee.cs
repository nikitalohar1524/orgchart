namespace OrgChartsJS.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int? Pid { get; set; }  // Parent ID (null = top level)
        public string Name { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
    }
}
