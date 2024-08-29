using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace ShopApp.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Введите имя")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина имени не менее 2 символов")]
        public string name { get; set; }
        [Display(Name = "Введите фамилию")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина имени не менее 2 символов")]
        public string surname { get; set; }
        [Display(Name = "Введите адрес")]
        [StringLength(35)]
        [Required(ErrorMessage = "Длина имени не менее 10 символов")]
        public string address { get; set; }
        [Display(Name = "Введите номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(13)]
        [Required(ErrorMessage = "Длина имени не менее 12 символов")]
        public string phone { get; set; }
        [Display(Name = "Введите электронную почту")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина имени не менее 8 символов")]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
