
using BookStore.Entity;

namespace BookStore.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Book, Application_Layer.BookViewModel>();
        }

        private object CreateMap<T1, T2>()
        {
            throw new NotImplementedException();
        }
    }

    public class Profile
    {
    }
}
