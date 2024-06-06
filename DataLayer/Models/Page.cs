using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Page
    {
        [Key]
        public int PageID { get; set; }

        [Display(Name = "گروه صفحه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int GroupeID { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(250)]
        public string Title { get; set; }

        [Display(Name = "توضیح مختصر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(350)]
        public string ShortDescription { get; set; }

        [Display(Name = "متن")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Text { get; set; }

        [Display(Name = "بازدید")]
        public int Visit { get; set; }

        [Display(Name = "تصویر")]
        public string ImageName { get; set; }

        [Display(Name = "اسلایدر")]
        public bool ShowInSlider { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreateDate { get; set; }



        public virtual PageGroup PageGroup { get; set; }
        public virtual List<PageComment> PageComments { get; set; }

        public Page()
        {
            
        }
    }
}
