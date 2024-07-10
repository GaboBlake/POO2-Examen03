using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using POO_Examen3.Entities;

namespace POO_Examen3.Models
{
    public class ToyModel : BaseModel
    {

        public Guid CategoryId { get; set; }
        public CategoryModel? CategoryModel { get; set; }

        public List<SelectListItem> CategoryToys { get; set; }

        public Guid KindId { get; set; }
        public KindModel? KindModel{ get; set; }
        public List<SelectListItem> KindToys { get; set; }


    }
}