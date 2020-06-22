using AutoMapper;
using BusinessLayer.ModelDTO;
using DAL;
using DAL.Model;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class StoreManager
    {
        public readonly StoreRepository _storeRepository;
        public readonly Mapper _mapper;
        public StoreManager()
        {
            _storeRepository = new StoreRepository();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Book, BookDTO>();
                cfg.CreateMap<Category, CategoryDTO>();
                cfg.CreateMap<Author, AuthorDTO>();
                cfg.CreateMap<BookDTO, Book>();

            });
            _mapper = new Mapper(config);
        }
        public IList<BookDTO> GetAllBooks()
        {
            return _mapper.Map<IList<BookDTO>>(_storeRepository.GetAllBooks());
        }
        public void UpdateBook(BookDTO book)
        {
            _storeRepository.UpdateBook(_mapper.Map<Book>(book));
        }
        public void AddBook(BookDTO bookDTO)
        {
            _storeRepository.AddBook(_mapper.Map<Book>(bookDTO));
        }

        public void RemoveById(int id)
        {
            _storeRepository.RemoveBook(id);
        }

        public BookDTO GetBookID(int id)
        {
            return _mapper.Map<BookDTO>(_storeRepository.GetBookID(id));
        }

    }
}
