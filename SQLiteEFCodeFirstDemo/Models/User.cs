using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SQLiteEFCodeFirstDemo.Models
{
    public class User
    {
        public int ID { get; set; }

        [DisplayName("姓名"), StringLength(20)]
        public string Name { get; set; }

        [DisplayName("年龄")]
        public int Age { get; set; }

        [DisplayName("性别"), StringLength(3)]
        public string Gender { get; set; }

        [DisplayName("地区"), StringLength(30)]
        public string Location { get; set; }
    }
}