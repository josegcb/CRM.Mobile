using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Mobile.Lib
{
    public class AutoMapperConfiguration {
        public static IMapper _Mapper;
        public static void Configure() {
            var thisAssembly = typeof(App).Assembly;
            var config = new MapperConfiguration(cfg => {
                cfg.AddMaps(thisAssembly);
            });
            _Mapper = config.CreateMapper();
            
        }
    }
}
